using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //public delegate double Delegate1(int x, float y, double z);
    //public delegate void Delegate2(int x, float y, double z);
    //public delegate bool Delegate3(string str);
    class GenericDelegates
    {
        //public static double AddNums1(int x, float y, double z)
        //{
        //    return x + y + z;
        //}
        //public static void AddNums2(int x, float y, double z)
        //{
        //    Console.WriteLine(x + y + z);
        //}
        //public static bool CheckLength(string str)
        //{
        //   if (str.Length > 5)
        //        return true;
        //   return false;
        // }
        static void Main()
        {
        Func<int, float, double, double> p1 = (x, y, z) =>
        {
            return x+ y + z;
        };
            double x = p1.Invoke(21,3.02f,3);
            Console.WriteLine(x);

        Action<int, float, double> p2 = (x, y, z) =>
        {
            Console.WriteLine(x + y + z);
        };
            p2.Invoke(21, 32.4f, 3);

            Predicate<string> p3 = (str) => 
           {
            if (str.Length > 5)
                return true;
            return false;
        };
            bool x3 = p3.Invoke("apples");
            Console.WriteLine(x3);
        }
    }
}
