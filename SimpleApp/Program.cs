using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp
{
    public class Program
    {
        public static int Sum(int a, int b) => a + b;
        public static int Sum((int a, int b) v) => v.a + v.b;
        static void Main(string[] args)
        {
            var a = (3, 6);
#if NET45
            Console.WriteLine("net45: " + a);
#elif NET452
            Console.WriteLine("net452: " + a);
#else
            Console.WriteLine("other: " + a);
#endif
            Console.ReadKey();
        }
    }
}
