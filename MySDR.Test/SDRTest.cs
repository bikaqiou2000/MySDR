using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MySDR.Model;

namespace MySDR.Test
{
    public class SDRTest
    {
        public static void SDRDeSerializ_Test()
        {
            var st = "SDR001|Jarod|经济|2015/10/12|3rd Party|N|0.3|Document|2|2";
            var st2 = "0|0|0|0|0|0|0|0|0|0";
            var ent = SDR.CreatSDR(st);
            var ent2 = SDR.CreatSDR(st2);
            Console.WriteLine(ent.SDRNO);
            Console.WriteLine(st);
            Console.WriteLine(ent.InfoString());
            Console.WriteLine(ent2);
        }
        
        public static void SDRsInput_Test()
        {
            var str = @"SDR010|Jarod|经济|2015/10/12|3rd Party|N|5|Fabric|8|1.5
 SDR010 | Jarod | 经济 | 2015 / 10 / 12 | 3rd Party| N | 5 | Document | 1 | 1
 SDR011 | Jarod | 经济 | 2015 / 10 / 12 | 3rd Party| Y | 12 | Garment | 12 | 49
 SDR011 | Jarod | 经济 | 2015 / 10 / 12 | 3rd Party| Y | 12 | Document | 1 | 1
 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0 | 0";

            Console.WriteLine(str);
            var ents = SDRInput.GetSdrs(str);
            foreach (var item in ents)
            {
                Console.WriteLine(item.InfoString());
            }
        }
    }
}
