using System.Linq;

namespace MySDR.Model.ParcelRules
{
    public class AmountRule : ParcelRule
    {
        private const decimal Max_Num = 600;

        public AmountRule(Parcel parcel) : base(parcel)
        {
            Name = string.Format("包裹价值必须不超过{0}USD", Max_Num);
        }

        public override CheckResult Check(SDR sdr)
        {
            var copySdr = Parcel.Sdrs.ToList();
            copySdr.Add(sdr);
            var res = new CheckResult();
            if (copySdr.Select(x => x.Amount).Sum() > Max_Num)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }

        public override CheckResult Check()
        {
            var res = new CheckResult();
            if (Parcel.Sdrs.Select(x => x.Amount).Sum() >= Max_Num)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }
    }
}