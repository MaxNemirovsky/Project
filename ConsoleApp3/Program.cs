using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    internal class Program
    {
        /// <summary>
        /// величина а меняется значением с величиной b, а величина c — с величиной d.
        /// </summary>
        /// <param name="a">int</param>
        /// <param name="b">int</param>
        static void Swap(ref int a, ref int b)
        {
            int p= a;
            a=b;
            b=p;
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Out(int a)
        {

        Console.WriteLine($"вывод :{a}"); 
        }
        static void Main(string[] args)
        {
            int a = Input("a =");
            int b = Input("b =");
            int c = Input("c =");
            int d = Input("d =");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Out(a);
            Out(b);
            Out(c);
            Out(d);
            Console.ReadKey();
        }
    }
}
