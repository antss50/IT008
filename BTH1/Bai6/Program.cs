using System;
using System.Text;

namespace MaTran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số dòng n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột m: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = InitializeMatrix(n, m, -50, 50);

            int choice;
            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Xuất ma trận");
                Console.WriteLine("2. Tìm phần tử lớn nhất / nhỏ nhất");
                Console.WriteLine("3. Tìm dòng có tổng lớn nhất");
                Console.WriteLine("4. Tính tổng các số không phải số nguyên tố");
                Console.WriteLine("5. Xóa dòng thứ k");
                Console.WriteLine("6. Xóa cột chứa phần tử lớn nhất");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        PrintMatrix(matrix);
                        break;
                    case 2:
                        FindMaxMin(matrix);
                        break;
                    case 3:
                        FindMaxSumRow(matrix);
                        break;
                    case 4:
                        Console.WriteLine("Tổng các số không phải số nguyên tố: " + SumNonPrimes(matrix));
                        break;
                    case 5:
                        Console.Write("Nhập dòng k muốn xóa: ");
                        int k = int.Parse(Console.ReadLine());
                        matrix = RemoveRow(matrix, k);
                        break;
                    case 6:
                        matrix = RemoveColWithMax(matrix);
                        break;
                    case 0:
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (choice != 0);
        }
        // Tạo ma trận
        static int[,] InitializeMatrix(int n, int m, int min, int max)
        {
            Random random = new Random();
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = random.Next(min, max + 1);
                }
            }
            return a;
        }

        // Xuất ma trận 
        static void PrintMatrix(int[,] a)
        {
            // Kích thước ma trận
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            Console.WriteLine("Ma trận: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        // Tìm phần tử lớn nhất/nhỏ nhất
        static void FindMaxMin(int[,] a)
        {
            int n = a.GetLength(0);
            int m = a.GetLength(1);

            int min = a[0, 0];
            int max = a[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < min)
                        min = a[i, j];
                    if (a[i, j] > max)
                        max = a[i, j];
                }
            }
            Console.WriteLine($"Phần tử nhỏ nhất: {min}, lớn nhất: {max}");
        }

        // Tìm dòng có tổng lớn nhất
        static void FindMaxSumRow(int[,] a)
        {
            int n = a.GetLength(0), m = a.GetLength(1);
            int bestRow = 0, maxSum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                    sum += a[i, j];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestRow = i;
                }
            }
            Console.WriteLine($"Dòng có tổng lớn nhất là dòng {bestRow + 1} với tổng = {maxSum}");
        }

        // Tổng các số không phải số nguyên tố
        static int SumNonPrimes(int[,] a)
        {
            int n = a.GetLength(0), m = a.GetLength(1);
            int sum = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (!IsPrime(a[i, j])) sum += a[i, j];
            return sum;
        }
        static bool IsPrime(int x)
        {
            if (x < 2) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            int limit = (int)Math.Sqrt(x);
            for (int i = 3; i <= limit; i += 2)
                if (x % i == 0) return false;
            return true;
        }

        // Xóa dòng thứ k
        static int[,] RemoveRow(int[,] a, int k)
        {
            int n = a.GetLength(0), m = a.GetLength(1);
            if (k < 0 || k >= n)
            {
                Console.WriteLine($"Dòng {k} không hợp lệ!");
                return a;
            }

            int[,] b = new int[n - 1, m];
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == k) continue;
                for (int j = 0; j < m; j++)
                    b[r, j] = a[i, j];
                r++;
            }
            Console.WriteLine($"Đã xóa dòng {k}.");
            return b;
        }

        // Xóa cột chứa phần tử lớn nhất
        static int[,] RemoveColWithMax(int[,] a)
        {
            int n = a.GetLength(0), m = a.GetLength(1);

            // Tìm giá trị max và cột chứa nó
            int maxVal = a[0, 0], colIndex = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (a[i, j] > maxVal)
                    {
                        maxVal = a[i, j];
                        colIndex = j;
                    }

            // Xóa cột colIndex
            int[,] b = new int[n, m - 1];
            for (int i = 0; i < n; i++)
            {
                int c = 0;
                for (int j = 0; j < m; j++)
                {
                    if (j == colIndex) continue;
                    b[i, c++] = a[i, j];
                }
            }
            Console.WriteLine($"Đã xóa cột {colIndex} (chứa giá trị lớn nhất {maxVal}).");
            return b;
        }
    }
}

