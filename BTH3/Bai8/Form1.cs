using Bai8.repository;
using System.Data;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Mã tài khoản", typeof(string));
            dataTable.Columns.Add("Tên khách hàng", typeof(string));
            dataTable.Columns.Add("Địa chỉ", typeof(string));
            dataTable.Columns.Add("Số tiền", typeof(double));

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string stk = (string)txtStk.Text;
            string hoten = (string)txtTenKH.Text;
            string diachi = (string)txtDChiKH.Text;
            double sotien = double.Parse(txtSoTienTK.Text);
            User user = new User(hoten, diachi, stk, sotien);
            listUser.addOrUpdateUser(user);
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            // Xóa tất cả dòng nhưng KHÔNG xóa header
            dataTable.Rows.Clear();
            foreach (var u in listUser.getUsers())
            {
                dataTable.Rows.Add(u.get_stk(), u.get_hoten(), u.get_diachi(), u.get_sotien());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Click Xoa");
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa {dataGridView1.SelectedRows.Count} dòng?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            // Danh sách mã tài khoản (khóa)
            var keys = new List<string>();

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                // Bỏ qua hàng trống cuối cùng của DataGridView
                if (row.IsNewRow) continue;

                // Lấy giá trị từ cột "Mã tài khoản"
                string maTk = Convert.ToString(row.Cells["Mã tài khoản"].Value);
                if (!string.IsNullOrWhiteSpace(maTk))
                    keys.Add(maTk);
            }

            // Xóa user trong listUser
            foreach (var stk in keys)
            {
                listUser.removeUser(stk);
            }

            // Cập nhật lại DataGridView
            UpdateGridView();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
