using System;
using System.Collections.Generic;
using System.Linq;

namespace MySDR.Test
{
    /// <summary>
    /// 集合运算测试
    /// </summary>
    public class CollectionTest
    {
        public static void CollectionMath_Test()
        {
            var arr1 = new[] {1, 2, 3, 4, 5, 6};
            var arr2 = new[] {2, 9};
            var test1 = arr1.Intersect(arr2);
            var test2 = arr1.Union(arr2);
            var test3 = arr1.Except(arr2);

            Console.WriteLine(arr1.Select(x => x.ToString()).Aggregate((x, y) => x + "," + y));
            Console.WriteLine(arr2.Select(x => x.ToString()).Aggregate((x, y) => x + "," + y));
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(test1.Select(x => x.ToString()).Aggregate((x, y) => x + "," + y));
            Console.WriteLine(test2.Select(x => x.ToString()).Aggregate((x, y) => x + "," + y));
            Console.WriteLine(test3.Select(x => x.ToString()).Aggregate((x, y) => x + "," + y));
        }

        public static void CollectionCopy_Test()
        {
            var ls1 = new List<int> {1, 2, 3};
            var ls2 = ls1.ToList();
            Console.WriteLine(ls1 == ls2);

            ls2.Add(5);
            Console.WriteLine(ls1.Select(x => x.ToString()).Aggregate((x, y) => x + "," + y));
            Console.WriteLine(ls2.Select(x => x.ToString()).Aggregate((x, y) => x + "," + y));
        }
    }
}