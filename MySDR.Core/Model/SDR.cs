using System;
using System.IO;
using System.Linq;

namespace MySDR.Model
{
    /// <summary>
    ///     寄件
    /// </summary>
    public class SDR
    {
        //每行代表一个SDR的一类物品. 每行包括SDR号、收件人、优先级、走货时间(日期) 、运费付费方、
        //是否延迟寄送、一个SDR物品总重量、物品类型、物品数量、物品单价(美元), 共10项.各项之间由单个竖线’|’来间隔. 
        //以由单个竖线’|’来间隔的10个数字0来表示输入的结束,其后的任何输入行都将被忽略

        /// <summary>
        ///     SDR号
        /// </summary>
        public string SDRNO { get; set; }

        public string Receiver { get; set; }
        public string Prior { get; set; }
        public DateTime SendDate { get; set; }
        public string Payway { get; set; }
        public bool IsDelay { get; set; }
        public decimal Weight { get; set; }
        public string SDRType { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        ///     包裹
        /// </summary>
        public Parcel Parcel { get; set; }

        /// <summary>
        ///     计费批量余数
        /// </summary>
        public decimal LotMod
        {
            get { return Weight%Parcel.Lot; }
        }

        /// <summary>
        ///     金额
        /// </summary>
        public decimal Amount
        {
            get { return Qty*Price; }
        }

        /// <summary>
        ///     序列化输出信息
        /// </summary>
        /// <returns></returns>
        public string InfoString()
        {
            var sp = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}"
                , SDRNO, Receiver, Prior, SendDate.ToString("yyyy/MM/dd"), Payway, (IsDelay ? "Y" : "N"), Weight,
                SDRType, Qty, Price);
            return sp;
        }

        /// <summary>
        ///     反序化对象
        /// </summary>
        /// <param name="SDRstr"></param>
        /// <returns></returns>
        public static SDR CreatSDR(string SDRstr)
        {
            var props = SDRstr.Split('|');
            if (!props.Any()) throw new InvalidDataException("传入数据不合法");
            if (props.Count() < 10) throw new InvalidDataException("传入数据必须有10项属性");
            if (props[0].Trim() == "0") return null;

            var entity = new SDR();
            entity.SDRNO = props[0].Trim();
            entity.Receiver = props[1].Trim();
            entity.Prior = props[2].Trim();
            entity.SendDate = DateTime.Parse(props[3].Trim());
            entity.Payway = props[4].Trim();
            entity.IsDelay = props[5].Trim() != "N";
            entity.Weight = decimal.Parse(props[6].Trim());
            entity.SDRType = props[7].Trim();
            entity.Qty = decimal.Parse(props[8].Trim());
            entity.Price = decimal.Parse(props[9].Trim());

            return entity;
        }
    }
}