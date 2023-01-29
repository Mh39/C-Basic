using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grademark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "grade Scalling";

            Console.WriteLine("enter your grade");
           // int grade = int.Parse(Console.ReadLine());

            int grade ;
         //  if (int.TryParse(Console.ReadLine(), out grade = false))

                if (!int.TryParse(Console.ReadLine(), out grade))
            {
                Console.WriteLine(" Invalid number");
                Console.ReadKey();
                return;

            }

            if (grade<0 ||grade>100)
            {
                Console.WriteLine(" Invalid grade");
                Console.ReadKey();
                return;

            }


            if (grade>=95 && grade<100)
            {
                Console.WriteLine("A");

            }
           else if (grade >=85  && grade < 95)
            {
                Console.WriteLine("B");

            }
            else if (grade >= 75 && grade < 85)
            {
                Console.WriteLine("c");

            }
            else if (grade >= 65 && grade < 75)
            {
                Console.WriteLine("D");

            }
            else if (grade >= 50 && grade <65 )
            {
                Console.WriteLine("E");

            }
            else
            {
                Console.WriteLine("you are failed");

            }

            Console.ReadKey();

        }
    }
}
