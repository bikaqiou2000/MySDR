using MySDR.Presenter;

namespace MySDR.View
{
    /// <summary>
    ///     主视图
    /// </summary>
    public interface IMainForm
    {
        /// <summary>
        ///     呈现器
        /// </summary>
        IMainFormPM PM { get; set; }

        /// <summary>
        ///     延迟送货文本
        /// </summary>
        string DelaySDRString { set; }

        /// <summary>
        ///     送货计划文本
        /// </summary>
        string SendPlanString { set; }
    }
}