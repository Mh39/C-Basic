using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            
            //double div;
           string msg;
            Console.Title = "DIV";
            Console.WriteLine("Enter First number");
            // number1 =Convert.ToInt32(  Console.ReadLine());
            //number1 = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine(" Invalid number");
                Console.ReadKey();
                return;

            }
            Console.WriteLine("Enter Second number");
            //number2 = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine(" Invalid number");
                Console.ReadKey();
                return;

            }
            /*
            switch (number2)
            {
                case 0:
                    Console.WriteLine("Connot devided by zero !");

                    break;
                default:
                    div = number1 / number2;
                    
                    Console.WriteLine("div=" + div);
                    break;
            }
              */
            
            
            msg = number2 == 0 ? "Connot devided by zero !" : "div=" + number1 / number2;
            Console.WriteLine(msg);
            
            Console.ReadKey();

            
            /*
                switch (Excpression)//المتغير الذى سيجرى عليه التحقيق
                {
                  case1:
                //instructions;
                break;
            case2:
                //instructions;
                break;
                  default://العوامل الافتراضيه فى حالة عدم تحقق اى شرط
                 break;
                         }*/
            //  Condition ? instruction1: instruction2;

        
    


}
    }
}
