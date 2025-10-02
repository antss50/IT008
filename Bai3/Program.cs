using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập ngày:");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập tháng: ");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập năm: ");
        int year = int.Parse(Console.ReadLine());
        if (CheckDate(day, month, year))
            Console.WriteLine($"Ngày {day}/{month}/{year} là ngày hợp lệ");
        else
            Console.WriteLine($"Ngày {day}/{month}/{year} là ngày không hợp lệ");
    }
    // Kiểm tra ngày hợp lệ
    static bool CheckDate(int day, int month, int year)
    {
        if (day < 1 || month < 1 || month > 12 || year <= 0) 
            return false;
        int daysOfMonth;
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                daysOfMonth = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                daysOfMonth = 30;
                break;
            case 2:
                daysOfMonth = IsLeapYear(year) ? 29 : 28;
                break;
            default:
                return false;
        }
        return day <= daysOfMonth;
    }
    // Kiểm tra năm nhuận
    static bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }
}