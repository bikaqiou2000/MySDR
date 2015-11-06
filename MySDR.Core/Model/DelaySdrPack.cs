using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySDR.Model
{
    public class DelaySdrPack : List<SDR>
    {
        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="lot"></param>
        public DelaySdrPack(decimal lot, decimal price)
        {
            Lot = lot;
            Price = price;
        }

        /// <summary>
        ///     重量
        /// </summary>
        public decimal Lot { get; private set; }

        /// <summary>
        ///     单价
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        ///     重量
        /// </summary>
        public decimal Weight
        {
            get { return this.Select(x => x.Weight).Sum(); }
        }

        /// <summary>
        ///     批量余数
        /// </summary>
        public decimal LotMod
        {
            get { return Weight%Lot; }
        }

        /// <summary>
        ///     送货成本
        /// </summary>
        public decimal SendingCost
        {
            get { return Math.Ceiling(Weight/Lot)*Price; }
        }

        /// <summary>
        ///     显示包裹信息
        /// </summary>
        /// <returns>结果字符串</returns>
        public string InfoString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("延迟件 重量:{0} 运费:{1}", Weight, SendingCost));
            foreach (var item in this)
            {
                sb.AppendLine(item.InfoString());
            }
            return sb.ToString();
        }
    }
}