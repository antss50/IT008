using System;
using System.Linq; // Cần cho hàm .Max()

namespace PhanSoDemo
{
    public class PhanSo : IComparable<PhanSo>
    {
        public int TuSo { get; private set; }
        public int MauSo { get; private set; }

        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }

        public PhanSo(int tu, int mau)
        {
            if (mau == 0)
            {
                throw new ArgumentException("Mẫu số không được bằng 0.");
            }
            TuSo = tu;
            MauSo = mau;
            RutGon();
        }

        private int TimUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private void RutGon()
        {
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }

            if (TuSo == 0)
            {
                MauSo = 1; 
                return;
            }

            int ucln = TimUCLN(TuSo, MauSo);
            TuSo /= ucln;
            MauSo /= ucln;
        }

        // Nạp chồng toán tử
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            int tuMoi = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int mauMoi = a.MauSo * b.MauSo;
            return new PhanSo(tuMoi, mauMoi); 
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            int tuMoi = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            int mauMoi = a.MauSo * b.MauSo;
            return new PhanSo(tuMoi, mauMoi);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int tuMoi = a.TuSo * b.TuSo;
            int mauMoi = a.MauSo * b.MauSo;
            return new PhanSo(tuMoi, mauMoi);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.TuSo == 0)
            {
                throw new DivideByZeroException("Không thể chia cho phân số 0.");
            }
            int tuMoi = a.TuSo * b.MauSo;
            int mauMoi = a.MauSo * b.TuSo;
            return new PhanSo(tuMoi, mauMoi);
        }

        public int CompareTo(PhanSo other)
        {
            long val1 = (long)this.TuSo * other.MauSo;
            long val2 = (long)other.TuSo * this.MauSo;
            return val1.CompareTo(val2);
        }

        public override string ToString()
        {
            if (MauSo == 1)
            {
                return TuSo.ToString(); 
            }
            return $"{TuSo}/{MauSo}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestHaiPhanSo();
            Console.WriteLine("\n========================================\n");
            TestDayPhanSo();
            Console.ReadKey();
        }

        static void TestHaiPhanSo()
        {
            Console.WriteLine("===== Tính toán phân số ======");
            try
            {
                PhanSo a = NhapPhanSo("Nhập phân số thứ nhất:");
                PhanSo b = NhapPhanSo("Nhập phân số thứ hai:");


                Console.WriteLine($"Tổng:     a + b = {a + b}");
                Console.WriteLine($"Hiệu:     a - b = {a - b}");
                Console.WriteLine($"Tích:     a * b = {a * b}");

                try
                {
                    Console.WriteLine($"Thương:   a / b = {a / b}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Thương:   a / b = Lỗi: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi nghiêm trọng: {ex.Message}");
            }
        }

        /// <summary>
        /// Chương trình con 2: Nhập dãy phân số, tìm max, sắp xếp
        /// </summary>
        static void TestDayPhanSo()
        {
            Console.WriteLine("===== Xử lý dãy phân số =====");
            try
            {
                Console.Write("Nhập số lượng phân số trong dãy: ");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Dãy phải có ít nhất 1 phân số.");
                    return;
                }

                PhanSo[] dayPhanSo = new PhanSo[n];
                for (int i = 0; i < n; i++)
                {
                    dayPhanSo[i] = NhapPhanSo($"Nhập phân số thứ {i + 1}:");
                }

                Console.WriteLine("\nDãy phân số đã nhập:");
                Console.WriteLine("[ " + string.Join(", ", (object[])dayPhanSo) + " ]");

                // Tìm phân số lớn nhất 
                PhanSo max = dayPhanSo.Max();
                Console.WriteLine($"Phân số lớn nhất: {max}");

                // Sắp xếp các phân số tăng dần
                Array.Sort(dayPhanSo);
                Console.WriteLine("Dãy phân số sau khi sắp xếp tăng dần:");
                Console.WriteLine("[ " + string.Join(", ", (object[])dayPhanSo) + " ]");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Số lượng không hợp lệ.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi nghiêm trọng: {ex.Message}");
            }
        }

        static PhanSo NhapPhanSo(string prompt)
        {
            Console.WriteLine(prompt);
            while (true) 
            {
                try
                {
                    Console.Write("  Nhập tử số: ");
                    int tu = int.Parse(Console.ReadLine());
                    Console.Write("  Nhập mẫu số: ");
                    int mau = int.Parse(Console.ReadLine());

                    return new PhanSo(tu, mau);
                }
                catch (FormatException)
                {
                    Console.WriteLine("  Lỗi: Vui lòng nhập số nguyên.");
                }
                catch (ArgumentException ex) 
                {
                    Console.WriteLine($"  Lỗi: {ex.Message} Vui lòng nhập lại.");
                }
            }
        }
    }
}