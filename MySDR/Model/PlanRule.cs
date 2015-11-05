using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySDR.Model
{
    /// <summary>
    /// 包裹规则
    /// </summary>
    public abstract class PlanRule
    {
        public PlanRule(ParcelPlan plan)
        {
            Plan = plan;
        }
        public string Name { get; set; }
        public ParcelPlan Plan{ get; private set; }


        /// <summary>
        /// 检查寄件
        /// </summary>
        /// <param name="sdr"></param>
        /// <returns></returns>
        public abstract CheckResult Check(Parcel parcel);
    }
    
}
