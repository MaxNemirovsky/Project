using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {//Поменять местами содержимое двух строковых переменных
        static void Swap(ref string x, ref string y)
        {
            string p = x;
            x = y;
            y = p;
        }
        static void Main(string[] args)
        {
            string st1 = "это первая строка";
            string st2 = "это вторая строка";
            Console.WriteLine($"вывод до обмена:{st1}\t{st2}");
            Swap(ref st1, ref st2);
            Console.WriteLine($"вывод после обмена:{st1}\t{st2}");
            Console.ReadKey();
        }
    }
}