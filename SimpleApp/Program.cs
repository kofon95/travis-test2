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
        static void Main(string[] args)
        {
#if NET45
            Console.WriteLine("net45");
#elif NET452
            Console.WriteLine("net452");
#else
            Console.WriteLine("other");
#endif
        }
    }
}
