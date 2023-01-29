using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2D array
            //   Type[,] array=new Type[nعدد الصفوف,mعدد الاعمدة]
            //int[,] array=new int[4,8]
            //   array[0, 0] = 57;
            //array[0, 1] = 45;
            string [,]names = new string[2, 3];
            names[0,0] = "wxewc ";
            names[0,1] = "cer ";
            names[0,2] = " xecr";
            names[1,0] = " rct";
            names[1,1] = " ecxrc";
            names[1,2] = " xecr";
            
            foreach (string n in names)
            {
                Console.WriteLine("Hello : "+n);
                 }
            Console.WriteLine();

            foreach (string n in names)
            {
                Console.WriteLine("Hello : " + n.ToUpper());
            }
            Console.WriteLine();

            foreach (string n in names)
            {
                                Console.WriteLine("Hello : " + n.ToLower());

            }

            //3D array
            //   Type[,,] array=new Type[n,m,s]
            Console.ReadKey();

        }
    }
}
