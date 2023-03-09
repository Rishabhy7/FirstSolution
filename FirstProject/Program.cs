// See https://aka.ms/new-console-template for more information
using System;

namespace FirstProject{
    class Program
    {
        int x;
        public Program(int i)
        {
           x = i;      //Copy constructor
          Console.WriteLine(i);
        }
        public Program(Program obj)
        {
           x=obj.x;
        }
        public void Display() //Copy constructor Method
        {

            Console.WriteLine(x);
        }
        static void Main(String[] args)
        {
         
            Program p = new Program(10);
            Program p1 = new Program(p);
            p1.Display(); 
        }
       }
    }