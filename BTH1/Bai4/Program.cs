using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập tháng: ");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập năm: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tháng {month}/{year} có {DaysOfMonth(month, year)} ngày");


    }
    // Lấy số ngày của tháng
    static int DaysOfMonth(int month, int year)
    {
        if (year <= 0 || month > 12 || month < 1)
            return -1;
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
                daysOfMonth = IsLeapYear(year)? 29 : 28;
                break;
            default:
                return -1;
        }
        return daysOfMonth;
    }
    // Kiểm tra năm nhuận
    static bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }
}