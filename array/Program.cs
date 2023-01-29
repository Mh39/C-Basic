using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type[] Array = new Type[N];  
            int[] array = new int[5];
            array[0] = 3;
            array[3] = 85;
            Console.WriteLine(array[3]);
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
            string[] name = new string[4];
            name[0] = "ahmed";
            name[1] = "akram";
            name[2] = "Karim ";
            name[3] = "mohamed";
            for(int i=0;i<name.Length;i++)
            {
                Console.WriteLine("Hello:"+name[i]);
            }
            foreach(string n in name)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();

        }
    }
}
