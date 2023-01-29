using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //arithemetic operation
            int x, y, sum;
            x = 5;y = 8;sum = x + y;
            Console.WriteLine("The sum is " + sum);
            //test operations
            bool test = 5 > 6;
            Console.WriteLine("bool test equal "+test);
             //logic operations
            bool test2 = 5 < 6 && 7 < 9;
           Console.WriteLine("bool test2 equal " + test2);
            bool test3 = 5 < 6 || 78 < 9;
            Console.WriteLine("bool test3 equal " + test3);

            Console.ReadKey();

        }
    }
}
