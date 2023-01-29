using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 89, b = 0; double div = a / b;
            }
            catch (DivideByZeroException ex)
            {
               Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
            //catch (ArithmeticException ar)
            //{

            //}
            //catch(IndexOutOfRangeException ou)
            //{

            //}
            finally
            {
                Console.WriteLine("Executed forever");
            }
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
