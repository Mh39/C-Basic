using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
//structure التراكيب
انشاء نوع بيانات خاص بنا
struct struct_name
{
public string var1;
public int  var2;
}
//Enumerations المعددات
Enum Enum_Name
{
Value1;
Value2;
}

 */
namespace enum__struct
{
    class Program
    {
        enum staus_Marital
        {
            single,maried
        }
        //struct person
        //{
        //    public string fullName;
        //    public int age;
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Are you Married ? ");
                string response = Console.ReadLine();
            switch(response)
            {
                case "yes":
                    Console.WriteLine("You Are " + staus_Marital.maried);
                    break;
                case "no": 
                    Console.WriteLine("You Are " + staus_Marital.single);
                    break;
            }
            //person p = new person();
            //Console.WriteLine("Enter your fullName");
            //p.fullName = Console.ReadLine();
            //Console.WriteLine("Enter your age");
            //p.age =int.Parse( Console.ReadLine());
            //Console.WriteLine("your fullName is"+p.fullName+" and you age is "+p.age);
       Console.ReadKey();

        }
    }
}
