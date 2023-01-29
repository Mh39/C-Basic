using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            //Multidimential//dinamic//add//delete
            //  List<Type> ListName = new List<type>();
            List<int> mylist = new List<int>();
            mylist.Add(2);
            mylist.Add(6);
            mylist.Add(8);
            mylist.Add(15);
           // mylist.Remove(8);
            mylist.RemoveAt(1);
            foreach(int n in mylist)
            {
                if (n > 7) 
                {
                    Console.WriteLine(n);
                }
            }
          //  Console.WriteLine(mylist.Count); 
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
