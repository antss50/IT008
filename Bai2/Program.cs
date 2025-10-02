using System;
using System.Text;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập n:");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Các số nguyên tố bé hơn {n}: ");
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Tổng các số nguyên tố bé hơn n: {SumPrime(n)}");
        }
        // Kiểm tra số nguyên tố
        static bool IsPrime(int a)
        {
            if (a < 2)
                return false;
            if (a == 2)
                return true;
            if (a % 2 == 0)
                return false;
            for (int i = 3; i <= Math.Sqrt(a); i += 2)
            {
                if ((a % i) == 0)
                    return false;
            }
            return true;
        }
        // Tính tổng các số nguyên tố bé hơn n
        static int SumPrime(int n)
        {
            var sum = 0;
            for (int i = 1; i < n; i++)
                if (IsPrime(i))
                    sum += i;
            return sum;
        }
    }
}
