using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        private BindingList<SinhVien> dsSinhVien = new BindingList<SinhVien>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dsSinhVien;
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string hoTen = txtHoTen.Text;
            string chuyenNganh = comboChuyenNganh.Text;
            string gioiTinh = "";
            if (checkNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (checkNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            int soMon = listMonChuaChon.Items.Count;

            SinhVien sinhVien = new SinhVien {
                maSV = mssv,
                hoTen = hoTen,
                chuyenNganh = chuyenNganh,
                gioiTinh = gioiTinh,
                soMon = soMon
            };
            // Thêm sinh viên vào danh sách
            dsSinhVien.Add(sinhVien);
               
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMSSV.Text = "";
            txtHoTen.Text = "";
            comboChuyenNganh.SelectedIndex = 0;
            checkNam.Checked = false;
            checkNu.Checked = false;

            foreach (var item in listMonDaChon.Items)
            {
                listMonChuaChon.Items.Add(item);
            }
            listMonDaChon.Items.Clear();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (listMonChuaChon.SelectedItem != null)
            {
                listMonDaChon.Items.Add(listMonChuaChon.SelectedItem);
                listMonChuaChon.Items.Remove(listMonChuaChon.SelectedItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listMonDaChon.SelectedItem != null)
            {
                listMonChuaChon.Items.Add(listMonDaChon.SelectedItem);
                listMonDaChon.Items.Remove(listMonDaChon.SelectedItem);
            }
        }
    }
}
