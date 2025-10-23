using System;
using System.Net.Sockets;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Vui lòng nhập kích thước ma trận (số nguyên dương)!");
            int m = GetInt("Nhập số dòng: ");
            int n = GetInt("Nhập số cột: ");

            int[,] matrix = Input(m, n);

            Console.WriteLine("\n--- Ma trận bạn đã nhập ---");
            PrintMatrix(matrix);

            while (true)
            {
                Console.WriteLine("\n--- MENU CHỨC NĂNG ---");
                Console.WriteLine("1. Tìm kiếm phần tử trong ma trận");
                Console.WriteLine("2. Xuất số nguyên tố trong ma trận");
                Console.WriteLine("3. Tìm dòng có nhiều số nguyên tố nhất");
                Console.WriteLine("0. Thoát chương trình");

                int choice = GetInt("Nhập lựa chọn của bạn: ");

                switch (choice)
                {
                    case 1:
                        int number = GetInt("Nhập số cần tìm: ");
                        Search(matrix, number);
                        break;
                    case 2:
                        PrintPrimeNum(matrix);
                        break;
                    case 3:
                        CountPrimeNum(matrix);
                        break;
                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        return; 
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập lại.");
                        break;
                }
            }
        }

        static int GetInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ.");
            }
        }
        static int[,] Input(int soDong, int soCot)
        {
            Console.WriteLine("--- Bắt đầu nhập ma trận ---");
            int[,] matrix = new int[soDong, soCot];
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    int value;
                    matrix[i, j] = GetInt($"Nhập phần tử [{i}, {j}]: ");
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int soDong = matrix.GetLength(0);
            int soCot = matrix.GetLength(1);

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine(); 
            }
        }
        static void Search(int[,] matrix,int number)
        {
            bool found = false;
            int soDong = matrix.GetLength(0);
            int soCot = matrix.GetLength (1);

            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot;j++)
                {
                    if (matrix[i, j] == number)
                    {
                        found = true;
                        Console.WriteLine($"Tìm thấy {number} ở dòng {i} cột {j}");
                    }
                }
            }
            if (!found)
                Console.WriteLine($"Không tìm thấy giá trị {number} trong ma trận!");
        }
        
        static void PrintPrimeNum(int[,] matrix)
        {
            bool found = false;
            int soDong = matrix.GetLength(0);
            int soCot = matrix.GetLength(1);
            Console.WriteLine("Danh sách các số nguyên tố của ma trận:");
            for (int i = 0; i < soDong; i++)
            {
                for (int j = 0; j < soCot; j++)
                {
                    if (IsPrime(matrix[i, j]))
                    {
                        found = true;
                        Console.WriteLine($"{matrix[i, j]}: dòng {i} cột {j}");
                    }
                }
            }
            if (!found)
                Console.WriteLine("Không có số nguyen tố trong ma trận!");
        }

        static void CountPrimeNum(int[,] matrix)
        {
            int max = 0;
            int maxRow = 0; 

            int soDong = matrix.GetLength(0);
            int soCot = matrix.GetLength(1);

            for (int i = 0; i < soDong; i++)
            {
                int currentRowCount = 0;

                for (int j = 0; j < soCot; j++)
                {
                    if (IsPrime(matrix[i, j]))
                    {
                        currentRowCount++; 
                    }
                }

                if (currentRowCount > max)
                {
                    max = currentRowCount;
                    maxRow = i; 
                }
            }

            if (max == 0)
            {
                Console.WriteLine("Ma trận không có số nguyên tố nào.");
            }
            else
            {
                Console.WriteLine($"Dòng {maxRow} có nhiều số nguyên tố nhất với {max} số nguyên tố");
            }
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
    }
}