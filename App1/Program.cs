using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num;

            Console.WriteLine("Enter number of array");
            //int num = int.Parse(Console.ReadLine());
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine(" Invalid number");
                Console.ReadKey();
                return;

            }

            if (num < 0 )
            {
                Console.WriteLine(" Invalid number");
                Console.ReadKey();
                return;

            }
            int[] array = new int[num];
            
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter number" + (i + 1));
                
                array[i] = int.Parse(Console.ReadLine());
               
                //sum++;
                
            }
            sum = array.Sum();
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("avarage = " + (sum/num));
           int mx = array[0];
            int mn = array[0];

            for (int z = 1; z < num; z++)
            {
                if (array[z] > mx)
                {
                    mx = array[z];
                }


                if (array[z] < mn)
                {
                    mn = array[z];
                }
            }
            Console.Write("Maximum element is : "+ mx );
            Console.WriteLine();
            Console.Write("Minimum element is : "+ mn);
                          Console.ReadKey();

        }
    }
}
