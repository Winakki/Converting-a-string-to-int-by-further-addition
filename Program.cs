using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka;
            
            int a,b;

            Console.WriteLine("Введите первое число");


             stroka = Console.ReadLine();


            a = Convert.ToInt32(stroka);


            Console.WriteLine("Введите второе число");


            stroka = Console.ReadLine();


            b = Convert.ToInt32(stroka);


            Console.WriteLine(a + b);
        }
    }
}
