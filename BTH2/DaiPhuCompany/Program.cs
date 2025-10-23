using System;
using System.Collections.Generic;
using System.Globalization;

namespace DaiPhuRealEstate
{
    public class KhuDat
    {
        public string DiaDiem { get; set; }
        public decimal GiaBan { get; set; }
        public double DienTich { get; set; }

        public KhuDat() { }

        public KhuDat(string diaDiem, decimal giaBan, double dienTich)
        {
            DiaDiem = diaDiem;
            GiaBan = giaBan;
            DienTich = dienTich;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhập địa điểm: ");
            DiaDiem = Console.ReadLine();
            GiaBan = GetInputDecimal("Nhập giá bán (VND): ");
            DienTich = GetInputDouble("Nhập diện tích (m2): ");
        }
        public virtual void Xuat()
        {
            string prefix = "[Khu Đất]";
            Console.WriteLine($" {prefix,-10} | {DiaDiem,-20} | {GiaBan,15:N0} VND | {DienTich,7} m2");
        }

        protected static int GetInputInt(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out value) && value > 0)
                    return value;
                Console.WriteLine("  Lỗi: Vui lòng nhập một số nguyên dương hợp lệ.");
            }
        }

        internal static decimal GetInputDecimal(string prompt)
        {
            decimal value;
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out value) && value >= 0)
                    return value;
                Console.WriteLine("  Lỗi: Vui lòng nhập một số hợp lệ (ví dụ: 5000000).");
            }
        }

        internal static double GetInputDouble(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out value) && value > 0)
                    return value;
                Console.WriteLine("  Lỗi: Vui lòng nhập một số hợp lệ (ví dụ: 85.5).");
            }
        }
    }
    public class NhaPho : KhuDat
    {
        public int NamXayDung { get; set; }
        public int SoTang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            NamXayDung = GetInputInt("  - Nhập năm xây dựng: ");
            SoTang = GetInputInt("  - Nhập số tầng: ");
        }

        public override void Xuat()
        {
            string prefix = "[Nhà Phố]";
            Console.WriteLine($" {prefix,-10} | {DiaDiem,-20} | {GiaBan,15:N0} VND | {DienTich,7} m2");
            Console.WriteLine($" {"",-10} | {' ',20} | {' ',15}     | {' ',7}    | (Năm XD: {NamXayDung}, Số tầng: {SoTang})");
        }
    }

    public class ChungCu : KhuDat
    {
        public int Tang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Tang = GetInputInt("Nhập tầng: ");
        }

        public override void Xuat()
        {
            string prefix = "[Chung Cư]";
            Console.WriteLine($" {prefix,-10} | {DiaDiem,-20} | {GiaBan,15:N0} VND | {DienTich,7} m2");
            Console.WriteLine($" {"",-10} | {' ',20} | {' ',15}     | {' ',7}    | (Tầng số: {Tang})");
        }
    }

    class Program
    {
        // Danh sách chính quản lý tất cả bất động sản (BDS)
        static List<KhuDat> danhSachBDS = new List<KhuDat>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            ThemDuLieuTest();

            Console.WriteLine("CHÀO MỪNG ĐẾN VỚI HỆ THỐNG QUẢN LÝ ĐỊA ỐC ĐẠI PHÚ");

            while (true)
            {
                Console.WriteLine("\n========================= MENU =========================");
                Console.WriteLine("1. Nhập danh sách Bất Động Sản (Khu Đất, Nhà Phố, Chung Cư)");
                Console.WriteLine("2. Xuất danh sách Bất Động Sản");
                Console.WriteLine("3. Xem tổng giá bán theo từng loại");
                Console.WriteLine("4. Tìm kiếm BĐS theo yêu cầu (Khu đất > 100m2 HOẶC Nhà phố > 60m2 & XD >= 2019)");
                Console.WriteLine("5. Tìm kiếm Nhà Phố / Chung Cư (theo Địa điểm, Giá, Diện tích)");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("----------------------------------------------------\nNhập lựa chọn của bạn: ");

                string choice = Console.ReadLine();
                Console.Clear(); 

                switch (choice)
                {
                    case "1":
                        NhapDanhSach();
                        break;
                    case "2":
                        XuatDanhSach();
                        break;
                    case "3":
                        XuatTongGiaBan();
                        break;
                    case "4":
                        TimKiemNangCao1();
                        break;
                    case "5":
                        TimKiemNangCao2();
                        break;
                    case "0":
                        Console.WriteLine("Đã thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                        break;
                }
            }
        }

        // Nhập / Xuất Danh Sách 
        static void NhapDanhSach()
        {
            Console.WriteLine("--- 1. NHẬP DANH SÁCH BẤT ĐỘNG SẢN ---");
            while (true)
            {
                Console.WriteLine("\nChọn loại BĐS:");
                Console.WriteLine("  1: Khu Đất");
                Console.WriteLine("  2: Nhà Phố");
                Console.WriteLine("  3: Chung Cư");
                Console.WriteLine("  Thoát (0)");
                Console.Write("Lựa chọn của bạn: ");
                string loai = Console.ReadLine();

                KhuDat bdsMoi;

                switch (loai)
                {
                    case "1":
                        Console.WriteLine("Nhập thông tin Khu Đất:");
                        bdsMoi = new KhuDat();
                        break;
                    case "2":
                        Console.WriteLine("Nhập thông tin Nhà Phố:");
                        bdsMoi = new NhaPho();
                        break;
                    case "3":
                        Console.WriteLine("Nhập thông tin Chung Cư:");
                        bdsMoi = new ChungCu();
                        break;
                    case "0":
                        return; 
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        continue; 
                }

                bdsMoi.Nhap(); 
                danhSachBDS.Add(bdsMoi);
                Console.WriteLine("=> Đã thêm thành công!");
            }
        }

        static void XuatDanhSach()
        {
            Console.WriteLine("--- 2. XUẤT DANH SÁCH BẤT ĐỘNG SẢN ---");
            if (danhSachBDS.Count == 0)
            {
                Console.WriteLine("Chưa có Bất Động Sản nào trong danh sách.");
                return;
            }

            Console.WriteLine($"\nTổng cộng có {danhSachBDS.Count} BĐS:");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine($" {"Loại",-10} | {"Địa Điểm",-20} | {"Giá Bán",15}     | {"Diện Tích",7}    | Ghi Chú");
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            foreach (KhuDat bds in danhSachBDS)
            {
                bds.Xuat(); 
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }

        // Xuất Tổng Giá Bán 
        static void XuatTongGiaBan()
        {
            Console.WriteLine("--- 3. TỔNG GIÁ BÁN THEO LOẠI ---");
            decimal tongGiaKhuDat = 0;
            decimal tongGiaNhaPho = 0;
            decimal tongGiaChungCu = 0;

            foreach (KhuDat bds in danhSachBDS)
            {
                if (bds is NhaPho)
                {
                    tongGiaNhaPho += bds.GiaBan;
                }
                else if (bds is ChungCu)
                {
                    tongGiaChungCu += bds.GiaBan;
                }
                else
                {
                    tongGiaKhuDat += bds.GiaBan;
                }
            }

            Console.WriteLine($"Tổng giá bán Khu Đất:  {tongGiaKhuDat,20:N0} VND");
            Console.WriteLine($"Tổng giá bán Nhà Phố:  {tongGiaNhaPho,20:N0} VND");
            Console.WriteLine($"Tổng giá bán Chung Cư: {tongGiaChungCu,20:N0} VND");
        }

        // Tìm kiếm Nâng cao 1
        static void TimKiemNangCao1()
        {
            Console.WriteLine("--- 4. TÌM KIẾM (Khu đất > 100m2 HOẶC Nhà phố > 60m2 & XD >= 2019) ---");
            bool timThay = false;

            foreach (KhuDat bds in danhSachBDS)
            {
                if (bds is NhaPho np)
                {
                    if (np.DienTich > 60 && np.NamXayDung >= 2019)
                    {
                        if (!timThay) 
                        {
                            Console.WriteLine("Kết quả tìm thấy:");
                            timThay = true;
                        }
                        np.Xuat();
                    }
                }
                else if (bds.GetType() == typeof(KhuDat))
                {
                    if (bds.DienTich > 100)
                    {
                        if (!timThay)
                        {
                            Console.WriteLine("Kết quả tìm thấy:");
                            timThay = true;
                        }
                        bds.Xuat();
                    }
                }
            }

            if (!timThay)
            {
                Console.WriteLine("Không tìm thấy BĐS nào phù hợp với yêu cầu.");
            }
        }

        // Tìm kiếm Nâng cao 2 
        static void TimKiemNangCao2()
        {
            Console.WriteLine("--- 5. TÌM KIẾM NHÀ PHỐ / CHUNG CƯ ---");
            Console.WriteLine("Nhập thông tin cần tìm (bỏ trống nếu không muốn lọc):");

            Console.Write("  - Địa điểm (chứa): ");
            string timDiaDiem = Console.ReadLine();

            decimal timGia = KhuDat.GetInputDecimal("Giá TỐI ĐA: ");
            double timDienTich = KhuDat.GetInputDouble("Diện tích TỐI THIỂU: ");

            bool timThay = false;

            foreach (KhuDat bds in danhSachBDS)
            {
                if (bds is NhaPho || bds is ChungCu)
                {
                    // Kiểm tra điều kiện
                    bool matchDiaDiem = string.IsNullOrEmpty(timDiaDiem) ||
                                        bds.DiaDiem.IndexOf(timDiaDiem, StringComparison.OrdinalIgnoreCase) >= 0;

                    bool matchGia = (timGia == 0) || (bds.GiaBan <= timGia);

                    bool matchDienTich = (timDienTich == 0) || (bds.DienTich >= timDienTich);

                    if (matchDiaDiem && matchGia && matchDienTich)
                    {
                        if (!timThay)
                        {
                            Console.WriteLine("\nKết quả tìm thấy:");
                            timThay = true;
                        }
                        bds.Xuat();
                    }
                }
            }

            if (!timThay)
            {
                Console.WriteLine("\nKhông tìm thấy Nhà Phố/Chung Cư nào phù hợp.");
            }
        }

        // Thêm dữ liệu mẫu 
        static void ThemDuLieuTest()
        {
            danhSachBDS.Add(new KhuDat("Quận 9, TPHCM", 5000000000m, 120));
            danhSachBDS.Add(new KhuDat("Củ Chi, TPHCM", 1500000000m, 80));

            danhSachBDS.Add(new NhaPho
            {
                DiaDiem = "Quận 1, TPHCM",
                GiaBan = 25000000000m,
                DienTich = 70,
                NamXayDung = 2020,
                SoTang = 5
            });
            danhSachBDS.Add(new NhaPho
            {
                DiaDiem = "Quận Gò Vấp, TPHCM",
                GiaBan = 7000000000m,
                DienTich = 50,
                NamXayDung = 2015,
                SoTang = 3
            });
            danhSachBDS.Add(new NhaPho
            {
                DiaDiem = "Quận 2, TPHCM",
                GiaBan = 12000000000m,
                DienTich = 65,
                NamXayDung = 2019,
                SoTang = 4
            });

            danhSachBDS.Add(new ChungCu
            {
                DiaDiem = "Vinhomes, TPHCM",
                GiaBan = 3000000000m,
                DienTich = 75,
                Tang = 15
            });
            danhSachBDS.Add(new ChungCu
            {
                DiaDiem = "Sunwah Pearl, TPHCM",
                GiaBan = 6000000000m,
                DienTich = 90,
                Tang = 22
            });
        }
    }
}