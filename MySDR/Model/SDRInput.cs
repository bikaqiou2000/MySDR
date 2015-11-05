using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MySDR.Model
{
    /// <summary>
    /// SDR输入生成器
    /// </summary>
    public class SDRInput
    {
        /// <summary>
        /// SDR生成
        /// </summary>
        /// <param name="str">输入</param>
        /// <returns>SDR集合</returns>
        public static List<SDR> GetSdrs (string str)
        {
            var sr = new StringReader(str);
            var sdrs = new List<SDR>();
            do
            {
                var lineStr = sr.ReadLine();
                if(string.IsNullOrEmpty(lineStr)) break;

                var sdrEnt = SDR.CreatSDR(lineStr);
                if (sdrEnt == null)
                {
                    break;
                }
                sdrs.Add(sdrEnt);

            } while (true);

            return sdrs;
        }
    }
}
