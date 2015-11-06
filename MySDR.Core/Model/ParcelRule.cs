namespace MySDR.Model
{
    /// <summary>
    ///     包裹规则
    /// </summary>
    public abstract class ParcelRule
    {
        public ParcelRule(Parcel parcel)
        {
            Parcel = parcel;
        }

        public string Name { get; set; }
        public Parcel Parcel { get; private set; }

        /// <summary>
        ///     检查包裹
        /// </summary>
        /// <returns></returns>
        public abstract CheckResult Check();

        /// <summary>
        ///     检查寄件
        /// </summary>
        /// <param name="sdr"></param>
        /// <returns></returns>
        public abstract CheckResult Check(SDR sdr);
    }
}