using MySDR.Model;
using MySDR.View;

namespace MySDR.Presenter
{
    /// <summary>
    ///     主窗体呈现器
    /// </summary>
    public class MainFormPM : IMainFormPM
    {
        //包裹计划
        private ParcelPlan plan;

        public MainFormPM()
        {
            init();
        }

        public IMainForm Form { get; set; }

        /// <summary>
        ///     执行送货计划
        /// </summary>
        /// <param name="inputstr">输入数据</param>
        public void WorkPlan(string inputstr)
        {
            plan.WorkPlan(inputstr);
            Form.SendPlanString = plan.ShowSdrPlan();
            Form.DelaySDRString = plan.ShowDelaySdrs();
        }

        /// <summary>
        ///     初始化
        /// </summary>
        private void init()
        {
            plan = new ParcelPlan();
        }
    }
}