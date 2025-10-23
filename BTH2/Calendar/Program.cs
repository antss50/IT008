using System;
using System.Globalization;
using System.Text;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int month = GetInput("Nhập tháng (1-12): ", 1, 12);
            int year = GetInput("Nhập năm: ", 1, 9999);

            DateTime firstDayOfMonth = new DateTime(year, month, 1);

            // Lấy số ngày trong tháng 
            int daysInMonth = DateTime.DaysInMonth(year, month);

            // Lấy ngày trong tuần của ngày 1. 
            int startingOffset = (int)firstDayOfMonth.DayOfWeek;

            Console.WriteLine();
            Console.WriteLine($"Month: {month:D2}/{year}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" Sun Mon Tue Wed Thu Fri Sat");
            Console.WriteLine("-----------------------------");

            // In các ô trống ban đầu (offset)
            for (int i = 0; i < startingOffset; i++)
            {
                Console.Write("    ");
            }

            // In các ngày trong tháng
            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,3} ");

                // Xuống dòng
                if ((startingOffset + day) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
        }
        private static int GetInput(string prompt, int min, int max)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                {
                    return value;
                }
                Console.WriteLine($"Lỗi: Vui lòng nhập một số hợp lệ từ {min} đến {max}.");
            }
        }
    }
}