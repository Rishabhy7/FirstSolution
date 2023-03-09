using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class MethodOverload
    {
        public void Test()
        {
            Console.WriteLine("Method 1 is called");
        }
        public void Test(int i)
        {
            Console.WriteLine("Method 2 is called");
        }
        public void Test(string s)
        {
            Console.WriteLine("Method 3 is called");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("Method 4 is called");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("Method 5 is called");
        }
        static void Main(string[] args)
        {
            MethodOverload p = new MethodOverload();
            p.Test(9);
            Console.ReadLine();
        }
    }
}
