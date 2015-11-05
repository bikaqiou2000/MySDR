using System;
using System.Linq;

namespace MySDR.Test
{

    /// <summary>
    /// 数学运算测试
    /// </summary>
    public class MathTest
    {
        public static void Mod_Test()
        {
            var num1 = new[] {23.4m, 45, 0.96m, 31.2m, 0.87m, 0.8m};
            var num2 = 0.5m;

            Console.WriteLine(num1.Select(x => x.ToString()).Aggregate((x, y) => x + "," + y));
            num1.ToList().ForEach(x => Console.WriteLine("{0} 对 {1} 的余数: {2}", x, num2, x%num2));
            Console.WriteLine("-----------------------------------------------------------------");
            num1.ToList().ForEach(x => Console.WriteLine("{0} 项上取整 {1} 数", x, Math.Ceiling(x)));
            Console.WriteLine("-----------------------------------------------------------------");
            num1.ToList().ForEach(x => Console.WriteLine("{0}/0.5 项上取整 {1} 数", x, Math.Ceiling(x/0.5m)));
        }
    }
}