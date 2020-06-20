using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyM;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
                Console.WriteLine("a=");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("b=");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("c=");
                double c = double.Parse(Console.ReadLine());
                KVADR kv2 = new KVADR(a, b, c);
            kv2.Decision();
                Console.WriteLine(kv2.ToString());
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error.Message);
            //}
        }
    }
}
