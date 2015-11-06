using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MySDR.Model.PlanRules;

namespace MySDR.Model
{
    /// <summary>
    ///     送货计划
    /// </summary>
    public class ParcelPlan
    {
        private const decimal Lot_Num = 0.5m; //批量
        private const string Prior_Name = "优先";
        private const string Common_Name = "经济";

        #region 构造函数

        public ParcelPlan()
        {
            Parcels = new List<Parcel>();
            Batchs = new List<ParcelBatch>();
            inputSdrs = new List<SDR>();
            InitRule();
            IntiPrice();
            DelaySdrs = new DelaySdrPack(Lot_Num, Prices[Common_Name]);
        }

        /// <summary>
        ///     初始化送货计划规则
        /// </summary>
        private void InitRule()
        {
            Rules = new List<PlanRule>();
            Rules.Add(new SameReceiverTotalRule(this)); //同一收件人只不能超过两个包裹
        }

        /// <summary>
        ///     初始送货单价
        /// </summary>
        private void IntiPrice()
        {
            Prices = new Dictionary<string, decimal>();
            Prices[Prior_Name] = 30;
            Prices[Common_Name] = 20;
        }

        #endregion

        #region 属性

        /// <summary>
        ///     单价表
        /// </summary>
        private Dictionary<string, decimal> Prices { get; set; }

        /// <summary>
        ///     输入数据
        /// </summary>
        public string InputStr { get; set; }

        /// <summary>
        ///     延时件集合
        /// </summary>
        public DelaySdrPack DelaySdrs { get; private set; }

        /// <summary>
        ///     包裹集合
        /// </summary>
        public List<Parcel> Parcels { get; set; }

        /// <summary>
        ///     批次集合
        /// </summary>
        public List<ParcelBatch> Batchs { get; set; }

        /// <summary>
        ///     输入包裹
        /// </summary>
        private List<SDR> inputSdrs { get; set; }

        /// <summary>
        ///     计划规则表
        /// </summary>
        public List<PlanRule> Rules { get; set; }

        /// <summary>
        ///     包裹总价值
        /// </summary>
        public decimal SendingCost
        {
            get { return Parcels.Sum(x => x.SendingCost) + DelaySdrs.SendingCost; }
        }

        #endregion

        #region 方法

        /// <summary>
        ///     创建包裹计划
        /// </summary>
        /// <param name="inputstr">输入数据</param>
        public void WorkPlan(string inputstr)
        {
            InputStr = inputstr;
            WorkPlan();
        }

        /// <summary>
        ///     创建包裹计划
        /// </summary>
        public void WorkPlan()
        {
            //校验
            if (string.IsNullOrEmpty(InputStr)) throw new InvalidDataException("没有输入数据");

            //生成SDR输入
            var sdrs = SDRInput.GetSdrs(InputStr);
            inputSdrs = SortSdr(sdrs); //排列
            var idx = 1;
            foreach (var sdr in inputSdrs)
            {
                //查找符合条件的包裹
                var maybeParcels = FindParcel(sdr);
                var suc = false;
                foreach (var maybeparcel in maybeParcels)
                {
                    //逐个包裹尝试添加
                    suc = maybeparcel.AddSDR(sdr);
                    if (suc) break;
                }
                if (!suc)
                {
                    //尝试创建包裹
                    var price = Prices[sdr.Prior];
                    var parc = new Parcel(Lot_Num, price, sdr);
                    parc.Name = string.Format("Pack{0}", idx++);
                    var res = AddParcel(parc);
                    if (!res)
                    {
                        //否则放入延时件
                        //sdr.IsDelay = true; //设置成延时件
                        DelaySdrs.Add(sdr);
                    }
                }
            }
        }


        /// <summary>
        ///     条件一个包裹
        /// </summary>
        /// <param name="parcel">包裹</param>
        /// <returns>成功：True,失败：false</returns>
        private bool AddParcel(Parcel parcel)
        {
            var suc = true;
            foreach (var rule in Rules)
            {
                suc = rule.Check(parcel).IsPass;
                if (!suc) return false;
            }
            Parcels.Add(parcel);
            return suc;
        }


        /// <summary>
        ///     根据寄件查找适合的包裹
        /// </summary>
        /// <param name="sdr">寄件</param>
        /// <returns>包裹集合</returns>
        private List<Parcel> FindParcel(SDR sdr)
        {
            //必须是相同收件人，相同日期，相同优先级，相同付费方，包裹未满
            var ents = Parcels.Where(x =>
                x.Receiver == sdr.Receiver
                && x.SendDate == sdr.SendDate
                && x.Prior == sdr.Prior
                && x.Payway == sdr.Payway
                && !x.IsFull
                ).ToList();
            return ents;
        }

        /// <summary>
        ///     对SDR重新排序
        ///     规则 优先 => 延时 => 普通
        /// </summary>
        /// <param name="sdrs">输入SDR</param>
        /// <returns></returns>
        private List<SDR> SortSdr(List<SDR> sdrs)
        {
            var res = new List<SDR>();
            //先添加优先型几件
            res.AddRange(sdrs.Where(x => x.Prior == Prior_Name));
            //再添加延时寄件
            res.AddRange(sdrs.Where(x => x.IsDelay));

            //在添加剩余的普通寄件
            var exp = sdrs.Except(res);
            res.AddRange(exp);

            return res;
        }

        /// <summary>
        ///     输出送货计划
        /// </summary>
        /// <returns>结果字符</returns>
        public string ShowSdrPlan()
        {
            var sb = new StringBuilder();
            foreach (var item in Parcels)
            {
                sb.AppendLine(item.InfoString());
            }
            return sb.ToString();
        }

        /// <summary>
        ///     输出延时件
        /// </summary>
        /// <returns>结果字符</returns>
        public string ShowDelaySdrs()
        {
            return DelaySdrs.InfoString();
        }

        #endregion
    }
}