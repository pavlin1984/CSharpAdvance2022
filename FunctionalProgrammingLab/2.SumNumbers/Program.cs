using System;

namespace T02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> multiplier = Multiply;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
