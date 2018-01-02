using System;

namespace SimpleApp
{
    public class Program
    {
        public static int Sum(int a, int b) => a + b;
        public static int Sum((int a, int b) v) => v.a + v.b;
        public static string Run()
        {
            var a = (1, 6);
            string result;
#if NET35
            result = "net35";
#elif NET40
            result = "net40";
#elif NET45
            result = "net45";
#elif NET452
            result = "net452";
#elif NET46
            result = "net46";
#elif NET461
            result = "net461";
#else
            result = "other";
#endif
            return $"{result}: {a}";
        }
    }
}
