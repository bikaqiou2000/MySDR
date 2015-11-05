using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MySDR.Model;

namespace MySDR.Test
{
    public class ParcelPlanTest
    {
        

        public static void Plan_Test()
        {
            var ipstr = @"SDR001|Jarod|经济|2015/10/12|3rd Party|N|0.3|Document|2|2
SDR001|Jarod|经济|2015/10/12|3rd Party|N|0.3|Garment|3|16
SDR002|Joey|经济|2015/10/12|3rd Party|N|0.8|Document|1|1
SDR002|Joey|经济|2015/10/12|3rd Party|N|0.8|Garment|5|15
SDR003|Keith|经济|2015/10/12|3rd Party|N|0.8|Fabric|10|2
SDR003|Keith|经济|2015/10/12|3rd Party|N|0.8|Document|1|1
SDR003|Keith|经济|2015/10/12|3rd Party|N|0.8|Garment|6|15
SDR004|Jarod|优先|2015/10/12|3rd Party|N|0.2|Garment|2|25
SDR004|Jarod|优先|2015/10/12|3rd Party|N|0.2|Document|1|1
SDR005|Vincent|经济|2015/10/12|3rd Party|N|7.2|Document|1|1
SDR005|Vincent|经济|2015/10/12|3rd Party|N|7.2|Sub-Material|150|0.5
SDR006|Keith|经济|2015/10/12|3rd Party|N|0.8|Document|1|1
SDR006|Keith|经济|2015/10/12|3rd Party|N|0.8|Garment|46|12
SDR007|Jarod|经济|2015/10/12|3rd Party|N|5|Sub-Material|135|0.7
SDR007|Jarod|经济|2015/10/12|3rd Party|N|5|Document|1|1
SDR008|Joey|经济|2015/10/12|3rd Party|N|7.2|Document|1|1
SDR008|Joey|经济|2015/10/12|3rd Party|N|7.2|Garment|5|15
SDR008|Joey|经济|2015/10/12|3rd Party|N|7.2|Fabric|12|1.2
SDR009|Tommy|经济|2015/10/12|3rd Party|N|0.8|Garment|5|15
SDR010|Jarod|经济|2015/10/12|3rd Party|N|5|Fabric|8|1.5
SDR010|Jarod|经济|2015/10/12|3rd Party|N|5|Document|1|1
SDR011|Jarod|经济|2015/10/12|3rd Party|Y|12|Garment|12|49
SDR011|Jarod|经济|2015/10/12|3rd Party|Y|12|Document|1|1
0|0|0|0|0|0|0|0|0|0";

            var plan = new ParcelPlan();
            plan.InputStr = ipstr;
            var t1 = DateTime.Now;
            plan.WorkPlan();
            var t2 = DateTime.Now;
            Console.WriteLine("--------------------------原输入-----------------------------");
            Console.WriteLine(ipstr);
            Console.WriteLine("--------------------------送计划----------------------------");
            Console.WriteLine(plan.ShowSdrPlan());
            Console.WriteLine("---------------------------延迟件---------------------------");
            Console.WriteLine(plan.ShowDelaySdrs());
            Console.WriteLine("---------------------------总预估成本---------------------------");
            Console.WriteLine("总耗费(USD)：{0}", plan.SendingCost);
            var timespend = (t2 - t1).Milliseconds;
            Console.WriteLine("总耗时：{0} 毫秒",timespend);
        }
        
      
    }
}
