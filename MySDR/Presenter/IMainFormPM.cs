using MySDR.View;

namespace MySDR.Presenter
{
    /// <summary>
    ///     主窗口呈现器
    /// </summary>
    public interface IMainFormPM
    {
        /// <summary>
        ///     窗体
        /// </summary>
        IMainForm Form { get; set; }

        /// <summary>
        ///     生成送货计划
        /// </summary>
        void WorkPlan(string inputstr);
    }
}