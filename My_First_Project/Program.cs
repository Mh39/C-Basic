//variable decleration
/*
int number;
string text;
bool test;
DateTime Mydate;
double number2;
number = 8;
text = "Mohamed";
test = false;
Mydate = DateTime.Now;
    number2 = 5.84;
const int mynumber = 3;
const string name = "karim";
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //تغير شاشه ال console
            Console.Title = "My first Project";
            Console.WriteLine("Enter your first Name ");
            //الادخال النصى
            string name = Console.ReadLine();
            //Console.Write("Hello Mr:"+name);
            /***********/
            Console.WriteLine("Enter Your Age ");
            //الادخال الرقمى
            //First Way
            int age = int.Parse(Console.ReadLine());
            //Second Way
            //int age2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hello Mr:" + name+" Your age is:"+age);



            Console.ReadKey();

        }
    }
}
