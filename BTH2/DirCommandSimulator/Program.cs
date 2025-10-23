using System;
using System.IO;
using System.Globalization;

namespace DirCommandSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập đường dẫn
            Console.Write("Vui lòng nhập đường dẫn thư mục: ");
            string path = Console.ReadLine();

            try
            {
                // Kiểm tra xem đường dẫn có tồn tại không
                if (!Directory.Exists(path))
                {
                    Console.WriteLine("Lỗi: Không tìm thấy đường dẫn.");
                    Console.ReadKey();
                    return;
                }

                DirectoryInfo dirInfo = new DirectoryInfo(path);

                Console.WriteLine($"\n Directory of {dirInfo.FullName}\n");

                // Liệt kê các thư mục con ---
                DirectoryInfo[] subDirs = dirInfo.GetDirectories();

                foreach (DirectoryInfo subDir in subDirs)
                {
                    // Định dạng ngày giờ
                    string lastModified = subDir.LastWriteTime.ToString("MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);

                    // In thông tin:
                    Console.WriteLine($"{lastModified}    <DIR>          {subDir.Name}");
                }

                // Liệt kê các tệp tin ---
                FileInfo[] files = dirInfo.GetFiles();

                foreach (FileInfo file in files)
                {
                    // Định dạng ngày giờ
                    string lastModified = file.LastWriteTime.ToString("MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);

                    // Định dạng kích thước tệp 
                    string fileSize = string.Format("{0,14:N0}", file.Length); // N0 để thêm dấu phẩy

                    // In thông tin
                    Console.WriteLine($"{lastModified} {fileSize} {file.Name}");
                }

                // In thống kê ---
                Console.WriteLine($"\n{files.Length,16} File(s)");
                Console.WriteLine($"{subDirs.Length,16} Dir(s)");

            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Lỗi: Không có quyền truy cập vào thư mục này.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}