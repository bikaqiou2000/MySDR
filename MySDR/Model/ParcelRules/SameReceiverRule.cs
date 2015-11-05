using System.Linq;

namespace MySDR.Model.ParcelRules
{
    /// <summary>
    ///     必须相同的走货时间
    /// </summary>
    public class SameReceiverRule : ParcelRule
    {
        public SameReceiverRule(Parcel parcel)
            : base(parcel)
        {
            Name = "必须相同的收货人时间";
        }

        public override CheckResult Check(SDR sdr)
        {
            var res = new CheckResult();
            if (Parcel.Receiver != sdr.Receiver)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }

        public override CheckResult Check()
        {
            var res = new CheckResult();
            if (Parcel.Sdrs.Select(x => x.Receiver).Distinct().Count() > 1)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }
    }
}