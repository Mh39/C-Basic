using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
  
    class Program
    {
        //ref // out

        static void myproc(ref int Number)
        {
            Number = 10;
            Console.WriteLine("The Value During passing is " + Number);

        }
        static void Main(string[] args)
        {
            int num = 20;
            Console.WriteLine("The Value before passing is "+ num);
            //myproc(num);
            //Console.WriteLine("The Value after passing is " + num);
            myproc(ref num);
            Console.WriteLine("The Value after passing is " + num);
            // Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
