using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập ngày: ");
        int day = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập tháng");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập năm: ");
        int year = int.Parse(Console.ReadLine());
        try
        {
            DateTime date = new DateTime(year, month, day);
            string thu = GetDayOfWeek(date.DayOfWeek);
            Console.WriteLine($"Ngày {day}/{month}/{year} là {thu}");
        }
        catch
        {
            Console.WriteLine("Ngày tháng năm không hợp lệ!");
        }
    }
    // Chuyển thứ sang tiếng Việt
    static string GetDayOfWeek(DayOfWeek date)
    {
        switch(date)
        {
            case DayOfWeek.Monday:
                return "Thứ Hai";
                break;
            case DayOfWeek.Tuesday:
                return "Thứ Ba";
                break;
            case DayOfWeek.Wednesday:
                return "Thứ Tư";
                break;
            case DayOfWeek.Thursday:
                return "Thứ Năm";
                break;
            case DayOfWeek.Friday:
                return "Thứ Sáu";
                break;
            case DayOfWeek.Saturday:
                return "Thứ Bảy";
                break;
            case DayOfWeek.Sunday:
                return "Chủ Nhật";
                break;
            default:
                return "";

        }
    }
}