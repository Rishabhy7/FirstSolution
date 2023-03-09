using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
   class SvsNS
    {
        static int y;
        int x;
        static SvsNS()
        {
            
            Console.WriteLine("Static constructor "+y);
            
        }
        SvsNS(int x)
        {
           this.x = x;
            Console.WriteLine("Non-Static constructor "+x);
        }
        static void Main()
        {
           SvsNS p = new SvsNS(10);
            Console.WriteLine("Main constructor " + p.x);
        }
    }    
}
