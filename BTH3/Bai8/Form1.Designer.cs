using Bai8.repository;
using System.Data;

namespace Bai8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtStk = new TextBox();
            txtSoTienTK = new TextBox();
            txtDChiKH = new TextBox();
            txtTenKH = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 39);
            label1.Name = "label1";
            label1.Size = new Size(324, 20);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN NGÂN HÀNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 94);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Số tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 140);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 180);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 219);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 4;
            label5.Text = "Số tiền trong tài khoản";
            // 
            // txtStk
            // 
            txtStk.Location = new Point(305, 91);
            txtStk.Name = "txtStk";
            txtStk.Size = new Size(535, 27);
            txtStk.TabIndex = 5;
            // 
            // txtSoTienTK
            // 
            txtSoTienTK.Location = new Point(305, 219);
            txtSoTienTK.Name = "txtSoTienTK";
            txtSoTienTK.Size = new Size(535, 27);
            txtSoTienTK.TabIndex = 6;
            // 
            // txtDChiKH
            // 
            txtDChiKH.Location = new Point(305, 180);
            txtDChiKH.Name = "txtDChiKH";
            txtDChiKH.Size = new Size(535, 27);
            txtDChiKH.TabIndex = 7;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(305, 137);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(535, 27);
            txtTenKH.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(447, 277);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 29);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm / Cập nhật";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(626, 277);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(746, 277);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(97, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(743, 303);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 661);
            Controls.Add(dataGridView1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtTenKH);
            Controls.Add(txtDChiKH);
            Controls.Add(txtSoTienTK);
            Controls.Add(txtStk);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtStk;
        private TextBox txtSoTienTK;
        private TextBox txtDChiKH;
        private TextBox txtTenKH;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridView dataGridView1;
        ListUser listUser = new ListUser();
        private DataTable dataTable = new DataTable();
    }
}
