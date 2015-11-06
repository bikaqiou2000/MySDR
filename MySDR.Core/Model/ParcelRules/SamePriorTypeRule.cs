using System.Linq;

namespace MySDR.Model.ParcelRules
{
    /// <summary>
    ///     必须相同的经济型和优先型
    /// </summary>
    public class SamePriorTypeRule : ParcelRule
    {
        public SamePriorTypeRule(Parcel parcel)
            : base(parcel)
        {
            Name = "必须相同的优先型";
        }

        public override CheckResult Check(SDR sdr)
        {
            var res = new CheckResult();
            if (Parcel.Prior != sdr.Prior)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }

        public override CheckResult Check()
        {
            var res = new CheckResult();
            if (Parcel.Sdrs.Select(x => x.Prior).Distinct().Count() > 1)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }
    }
}