using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySDR.Model;

namespace MySDR.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //SDRTest.SDRDeSerializ_Test();
            //Console.WriteLine("-------------------------------------------");
            //SDRTest.SDRsInput_Test();
            //Console.WriteLine("-------------------------------------------");
            //CollectionTest.CollectionMath_Test();
            //CollectionTest.CollectionCopy_Test();
            //MathTest.Mod_Test();

            ParcelPlanTest.Plan_Test();
            Console.ReadLine();
        }

    }
}
