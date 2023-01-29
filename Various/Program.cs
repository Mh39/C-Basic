using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Various
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="C#";
            // Console.BackgroundColor = ConsoleColor.Blue;
            // Console.ForegroundColor = ConsoleColor.Cyan;
            // Console.Beep();
            //Console.Clear();
            Console.WriteLine("Kha\"lid ");
            Console.WriteLine("Hello \t\t\t\t world");
            Console.WriteLine("Hello \n world");
            Console.WriteLine("\a");
            //break //Continue
            for(int i=0;i<20;i++)
            {
                Console.WriteLine(i);
                // if(i<10)
                //{
                //    continue;
                //}
                //else
                //{
                //    break;
                //}
                if (i < 10) continue;break;
                     }
            string name = "Mohamed",country = "Egypt";int age = 22;
            Console.WriteLine("My Name is : {0} ,My Country is : {1},My age is: {2}",name,country,age);
            Console.WriteLine(" My Name is : {0} \n My Country is : {1} \n My age is: {2}", name, country, age);

            Console.Read();

            Console.ReadKey();

        }
    }
}
