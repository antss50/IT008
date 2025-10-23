using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Mảng gồm {n} số nguyên:");
        int[] a = CreateRandomArray(n, 0, 100);
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
        Console.WriteLine($"Tổng các số lẻ trong mảng: {SumOdd(a)}");
        Console.WriteLine($"Mảng có {CountPrime(a)} số nguyên tố");
        Console.WriteLine($"Số chính phương nhỏ nhất mảng là: {SmallestPerfectSquare(a)}");

    }
    // Tạo mảng số nguyên ngẫu nhiên
    static int[] CreateRandomArray(int n, int min, int max)
    {
        var rnd = new Random();
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = rnd.Next(min, max + 1);
        }
        return a;
    }
    // Tính tổng số lẻ
    static int SumOdd(int[] a)
    {
        int sum = 0;
        foreach (var tmp in a)
        {
            if (tmp % 2 != 0)
                sum += tmp;
        }
        return sum;
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
        for (int i = 3; i <= Math.Sqrt(a); i+=2)
        {
            if ((a % i) == 0)
                return false;
        }
        return true;
    }
    // Đếm số nguyên tố
    static int CountPrime(int[] a)
    {
        int count = 0;
        foreach(var tmp in a)
        {
            if (IsPrime(tmp))
                count++;
        }
        return count;
    }
    // Kiểm tra số chính phương
    static bool IsPerfectSquare(int a)
    {
        if (a < 0)
            return false;
        int r = (int)Math.Sqrt(a);
        return r * r == a;
    }
    // Tìm số chính phương bé nhất
    static int SmallestPerfectSquare(int[] a)
    {
        int smallest = int.MaxValue;
        foreach (var tmp in a)
        {
            if (IsPerfectSquare(tmp) && tmp < smallest)
                smallest = tmp;
        }
        if (smallest == 1)
            return -1;
        else
            return smallest;
    }
}