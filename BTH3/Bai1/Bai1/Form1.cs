using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogEvent(string eventName)
        {
            // Thêm tên sự kiện vào đầu danh sách để dễ thấy nhất
            listLog.Items.Insert(0, $"{DateTime.Now:HH:mm:ss.fff} - {eventName}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogEvent("Form_Load (Đang tải...)");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LogEvent("Form_Shown (Đã hiển thị xong)");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LogEvent("Form_Activated (Đã được focus)");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            LogEvent("Form_Deactivate (Đã mất focus)");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogEvent("Form_FormClosing (Đang chuẩn bị đóng...)");

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát?","Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                LogEvent("   -> Đã huỷ việc đóng Form!");
                e.Cancel = true; 
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form_FormClosed (Form đã được đóng)");
        }
    }
}
