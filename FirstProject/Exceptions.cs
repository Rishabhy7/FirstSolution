using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Exceptions : ApplicationException
    {
        public override string Message
        {
            get { return "Attempted to divide by odd number"; }
        }
    }

    class ThrowDemo
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter number 1: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter nymber 2: ");
                int y = int.Parse(Console.ReadLine());
                if (y % 2 > 0)
                {
                    throw new Exception("odd number se divide mat kar");
                }
                int z = x / y;
                Console.WriteLine("The result is: " + z);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex1) 
            {
                Console.WriteLine("Dang se daal le input type");
            }
            catch(Exception ex2)
            {
                Console.WriteLine(ex2.Message);
            }
            finally
            {
                Console.WriteLine("End of the Program.");
            }
        }
    }
}