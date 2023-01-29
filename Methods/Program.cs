using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /*
     //Function
     Type FunctionName(Parameters)
     {
     //الاوامر المراد تنقيذها
     return value;
        }
        //Procedures
     Type FunctionName(Parameters)
     {
     //الاوامر المراد تنقيذها
        }
      
     */
    class Program
    {
        static int sum(int x,int y)
        {
            return x + y;

        }
        static void showmassage(string param)
        {
            Console.WriteLine("Welcome MR : " + param);
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter Your Name : ");
            //string name = Console.ReadLine();
            // showmassage(name);
            Console.WriteLine("Enter 2 number ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
             Console.WriteLine("The sum is "+sum(a,b));
             Console.ReadKey();

         }
    }
}
 