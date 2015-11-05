using System.Collections.Generic;

namespace MySDR.Model
{
    /// <summary>
    ///     检验结果
    /// </summary>
    public class CheckResult
    {
        public CheckResult()
        {
            IsPass = true;
            Messages = new List<string>();
        }

        /// <summary>
        ///     是否通过
        /// </summary>
        public bool IsPass { get; set; }

        /// <summary>
        ///     错误信息
        /// </summary>
        public List<string> Messages { get; set; }
    }
}