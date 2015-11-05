using System.Linq;

namespace MySDR.Model.ParcelRules
{
    /// <summary>
    ///     必须相同的走货时间
    /// </summary>
    public class SamePayWayRule : ParcelRule
    {
        public SamePayWayRule(Parcel parcel)
            : base(parcel)
        {
            Name = "必须相同的付费人";
        }

        public override CheckResult Check(SDR sdr)
        {
            var res = new CheckResult();
            if (Parcel.Payway != sdr.Payway)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }

        public override CheckResult Check()
        {
            var res = new CheckResult();
            if (Parcel.Sdrs.Select(x => x.Payway).Distinct().Count() > 1)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }
    }
}