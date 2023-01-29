using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           for(int var=0;var<100;var++)
            {
                //instruction
            }
            */
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Hello" +i);
            }
            for (int i = 1; i <=9; i++)
            {

                for (int e = 1; e <= 12; e++)
                {
                    Console.WriteLine(i+"*"+e+"="+i*e);    
                }
                Console.WriteLine( );
              }
            Console.ReadKey();

        }
    }
}
