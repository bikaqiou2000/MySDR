using  System;
using  System.Linq;

namespace MySDR.Model.PlanRules
{
    /// <summary>
    /// 包裹规则
    /// </summary>
    public  class SameReceiveTotalRule : PlanRule
    {
        private const int Max_Num = 2;

        public SameReceiveTotalRule(ParcelPlan plan):base(plan)
        {
            Name = string.Format("同一收件人一天最多{0}个包裹",Max_Num);
        }

        /// <summary>
        /// 检查包裹
        /// </summary>
        /// <param name="parcel"></param>
        /// <returns></returns>
        public override CheckResult Check(Parcel parcel)
        {
            var copySdr = Plan.Parcels.ToList();
            copySdr.Add(parcel);
            var res = new CheckResult();
            if (copySdr.Count(x => x.Receiver == parcel.Receiver) > Max_Num)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }
    }
    
}
