using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySDR.Model;

namespace MySDR
{

    /// <summary>
    /// 主窗体呈现器
    /// </summary>
    public class MainFormPM : IMainFormPM
    {
        public MainFormPM()
        {
            init();
        }

        private void init()
        {
           plan = new ParcelPlan();
        }

        //包裹计划器
        private ParcelPlan plan ;
        
        public IMainForm Form { get; set; }


        /// <summary>
        /// 执行送货计划
        /// </summary>
        public void WorkPlan()
        {
            plan.InputStr  = Form.InputString;
            plan.WorkPlan();

            Form.SendPlanString = plan.ShowSdrPlan();
            Form.DelaySDRString = plan.ShowDelaySdrs();
        }

    }

    
    public interface IMainFormPM
    {
        /// <summary>
        /// 窗体
        /// </summary>
        IMainForm Form { get; set; }

        /// <summary>
        /// 生成送货计划
        /// </summary>
        void WorkPlan();
    }
}
