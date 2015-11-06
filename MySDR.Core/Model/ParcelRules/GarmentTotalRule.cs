using System.Linq;

namespace MySDR.Model.ParcelRules
{
    public class GarmentTotalRule : ParcelRule
    {
        private const string Garment_Type = "garment";
        private const int Max_Num = 49;

        public GarmentTotalRule(Parcel parcel) : base(parcel)
        {
            Name = string.Format("{0}件必须不超过{1}件", Garment_Type, Max_Num);
        }

        public override CheckResult Check(SDR sdr)
        {
            var copySdr = Parcel.Sdrs.ToList();
            copySdr.Add(sdr);
            var res = new CheckResult();
            if (copySdr.Count(x => x.SDRType.ToLower() == Garment_Type) > Max_Num)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }

        public override CheckResult Check()
        {
            var res = new CheckResult();
            if (Parcel.Sdrs.Count(x => x.SDRType.ToLower() == Garment_Type) >= Max_Num)
            {
                res.IsPass = false;
                res.Messages.Add(Name);
            }
            return res;
        }
    }
}