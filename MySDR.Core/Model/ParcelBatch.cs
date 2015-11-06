using System.Collections.Generic;
using System.Linq;

namespace MySDR.Model
{
    /// <summary>
    ///     可相互调配的包裹集合
    ///     主要用于包裹优化分析
    /// </summary>
    public class ParcelBatch : List<Parcel>
    {
        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="lot"></param>
        public ParcelBatch(decimal lot)
        {
            Lot = lot;
        }

        /// <summary>
        ///     重量
        /// </summary>
        public decimal Lot { get; private set; }

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
            get { return this.Select(x => x.SendingCost).Sum(); }
        }
    }
}