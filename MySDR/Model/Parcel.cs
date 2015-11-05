using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySDR.Model.ParcelRules;

namespace MySDR.Model
{
    /// <summary>
    ///     包裹
    /// </summary>
    public class Parcel
    {
        #region 构造函数

        /// <summary>
        ///     创建包裹
        /// </summary>
        /// <param name="lot">计费等级量</param>
        /// <param name="price">计费等级量</param>
        public Parcel(decimal lot, decimal price)
        {
            Sdrs = new List<SDR>();
            Lot = lot;
            Price = price;
            InitRule();
        }

        /// <summary>
        ///     初始化包裹规则
        /// </summary>
        private void InitRule()
        {
            ParcelRules = new List<ParcelRule>();
            ParcelRules.Add(new AmountRule(this));
            ParcelRules.Add(new FabricTotalRule(this));
            ParcelRules.Add(new GarmentTotalRule(this));
            ParcelRules.Add(new SameDateRule(this));
            ParcelRules.Add(new SamePayWayRule(this));
            ParcelRules.Add(new SamePriorTypeRule(this));
            ParcelRules.Add(new SameReceiverRule(this));
            ParcelRules.Add(new WeightRule(this));
        }

        /// <summary>
        ///     根据初始寄件创建包裹
        /// </summary>
        /// <param name="lot">计费等级量</param>
        /// <param name="firtSdr">第一个寄件</param>
        public Parcel(decimal lot, decimal price, SDR firtSdr)
            : this(lot, price)
        {
            Sdrs.Add(firtSdr);
            Receiver = firtSdr.Receiver;
            SendDate = firtSdr.SendDate;
            Prior = firtSdr.Prior;
            Payway = firtSdr.Payway;
            firtSdr.Parcel = this;
        }

        #endregion

        #region 属性

        /// <summary>
        ///     包裹名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     计费等级量0.5
        /// </summary>
        public decimal Lot { get; }


        /// <summary>
        ///     单价
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        ///     包裹重量
        /// </summary>
        public decimal Weight
        {
            get
            {
                var res = Sdrs.Select(x => x.Weight).Sum();
                return res;
            }
        }

        /// <summary>
        ///     包裹送货成本
        /// </summary>
        public decimal SendingCost
        {
            get { return Math.Ceiling(Weight/Lot)*Price; }
        }

        /// <summary>
        ///     包裹金额
        /// </summary>
        public decimal Amount
        {
            get
            {
                var res = Sdrs.Select(x => x.Amount).Sum();
                return res;
            }
        }

        /// <summary>
        ///     收件人
        /// </summary>
        public string Receiver { get; set; }

        /// <summary>
        ///     送货时间
        /// </summary>
        public DateTime SendDate { get; set; }

        /// <summary>
        ///     优先级别
        /// </summary>
        public string Prior { get; set; }

        public string Payway { get; set; }

        /// <summary>
        ///     包裹寄件
        /// </summary>
        public List<SDR> Sdrs { get; set; }

        /// <summary>
        ///     包裹规则
        /// </summary>
        public List<ParcelRule> ParcelRules { get; set; }

        /// <summary>
        ///     可调配的包裹集合
        /// </summary>
        public ParcelBatch Batch { get; set; }

        /// <summary>
        ///     包裹是否已满
        /// </summary>
        public bool IsFull
        {
            get
            {
                //检查金额是否超标
                var amountR = ParcelRules.FirstOrDefault(x => x.GetType() == typeof (AmountRule));
                if (amountR != null && !amountR.Check().IsPass) return true;

                //检查重量是否超标
                var weightR = ParcelRules.FirstOrDefault(x => x.GetType() == typeof (WeightRule));
                if (weightR != null && !weightR.Check().IsPass) return true;

                return false;
            }
        }

        /// <summary>
        ///     计费批量余数
        /// </summary>
        public decimal LotMod
        {
            get { return Weight%Lot; }
        }

        #endregion

        #region 方法

        /// <summary>
        ///     添加寄件
        /// </summary>
        /// <param name="sdr">寄件</param>
        /// <returns>成功：TRUE，失败：FALSE</returns>
        public bool AddSDR(SDR sdr)
        {
            var res = new CheckResult();
            foreach (var rule in ParcelRules)
            {
                res = rule.Check(sdr);
                if (!res.IsPass)
                {
                    return res.IsPass;
                }
            }
            Sdrs.Add(sdr);
            //设置寄件的包裹属性
            sdr.Parcel = this;
            return res.IsPass;
        }

        /// <summary>
        ///     移出寄件
        /// </summary>
        /// <param name="sdr"></param>
        /// <returns>成功：TRUE，失败：FALSE</returns>
        public bool Remove(SDR sdr)
        {
            return Sdrs.Remove(sdr);
        }

        /// <summary>
        ///     显示包裹信息
        /// </summary>
        /// <returns>结果字符串</returns>
        public string InfoString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("{0}  收件人:{1} 日期:{2} 重量:{3} 运费:{4} 优先级:{5}"
                , Name, Receiver, SendDate.ToString("yyyy-MM-dd"), Weight, SendingCost, Prior));
            foreach (var item in Sdrs)
            {
                sb.AppendLine(item.InfoString());
            }
            return sb.ToString();
        }

        #endregion
    }
}