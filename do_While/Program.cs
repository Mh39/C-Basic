using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //do و while و goto
            /*
            do
            {
                //  instructions
            }
            while (condition);
            */
            /*
            while (condition)
            {
                //  instructions

            }
            */
            /*
            Label:
                goto Label;
                */
            //do..while
            /*  int number = 0;
             do
             {
                 Console.WriteLine("Hello");
                 number++;
             }
             while (number > 0 && number < 5);
             */
           ask: Console.WriteLine("Who is the first Khalifa");
            String name = Console.ReadLine();
            while (name!="abu bakr")
            {
                Console.WriteLine("False");
                goto ask;
            }
            Console.WriteLine("True");
            Console.ReadKey();

        }
    }
}
