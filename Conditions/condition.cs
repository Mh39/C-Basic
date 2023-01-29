using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class condition
    {
        static void Main(string[] args)
        {
            int number1, number2;
          
            double div;
            Console.Title = "DIV";  
            Console.WriteLine("Enter First number");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine(" Invalid number");
                Console.ReadKey();
                return;

            }
            // number1 =Convert.ToInt32(  Console.ReadLine());
            //number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            // number2 = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine(" Invalid number");
                Console.ReadKey();
                return;

            }
            if (number2==0)
            {
                Console.WriteLine("Connot devided by zero !");
            }
            else
            {
                div = Convert.ToDouble ( number1 / number2);
                Console.WriteLine("div=" + div);
            }


        Console.ReadKey();
        }
    }
}
