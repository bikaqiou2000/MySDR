using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySDR.Model
{
    /// <summary>
    /// 检验结果
    /// </summary>
    public class CheckResult
    {
        public CheckResult()
        {
            IsPass = true;
            Messages = new List<string>();
        }

        public bool IsPass { get; set; }
        public List<string> Messages { get; set; }
    }
}
