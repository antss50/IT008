namespace Bai9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listMonDaChon = new System.Windows.Forms.ListBox();
            this.listMonChuaChon = new System.Windows.Forms.ListBox();
            this.checkNu = new System.Windows.Forms.RadioButton();
            this.checkNam = new System.Windows.Forms.RadioButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.comboChuyenNganh = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongSoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 1112);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listMonDaChon);
            this.groupBox1.Controls.Add(this.listMonChuaChon);
            this.groupBox1.Controls.Add(this.checkNu);
            this.groupBox1.Controls.Add(this.checkNam);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnLuuThongTin);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnThemMon);
            this.groupBox1.Controls.Add(this.comboChuyenNganh);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(81, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 543);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // listMonDaChon
            // 
            this.listMonDaChon.FormattingEnabled = true;
            this.listMonDaChon.ItemHeight = 20;
            this.listMonDaChon.Location = new System.Drawing.Point(611, 314);
            this.listMonDaChon.Name = "listMonDaChon";
            this.listMonDaChon.Size = new System.Drawing.Size(333, 124);
            this.listMonDaChon.TabIndex = 33;
            // 
            // listMonChuaChon
            // 
            this.listMonChuaChon.FormattingEnabled = true;
            this.listMonChuaChon.ItemHeight = 20;
            this.listMonChuaChon.Items.AddRange(new object[] {
            "Lập trình trực quan",
            "Nhập môn Công nghệ phần mềm",
            "Công nghệ web và ứng dụng",
            "Kỹ thuật phân tích yêu cầu",
            "Kiểm chứng phần mềm",
            "Đại số tuyến tính",
            "Giải tích",
            "Giáo dục thể chất",
            "Kinh tế chính trị Mác-Lênin",
            "Chủ nghĩa xã hội khoa học",
            "Tư tường Hồ Chí Minh"});
            this.listMonChuaChon.Location = new System.Drawing.Point(177, 314);
            this.listMonChuaChon.Name = "listMonChuaChon";
            this.listMonChuaChon.Size = new System.Drawing.Size(333, 124);
            this.listMonChuaChon.TabIndex = 32;
            // 
            // checkNu
            // 
            this.checkNu.AutoSize = true;
            this.checkNu.Location = new System.Drawing.Point(454, 203);
            this.checkNu.Name = "checkNu";
            this.checkNu.Size = new System.Drawing.Size(54, 24);
            this.checkNu.TabIndex = 31;
            this.checkNu.TabStop = true;
            this.checkNu.Text = "Nữ";
            this.checkNu.UseVisualStyleBackColor = true;
            // 
            // checkNam
            // 
            this.checkNam.AutoSize = true;
            this.checkNam.Location = new System.Drawing.Point(360, 203);
            this.checkNam.Name = "checkNam";
            this.checkNam.Size = new System.Drawing.Size(67, 24);
            this.checkNam.TabIndex = 30;
            this.checkNam.TabStop = true;
            this.checkNam.Text = "Nam";
            this.checkNam.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(611, 473);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(135, 30);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xoá Chọn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Location = new System.Drawing.Point(381, 473);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(224, 30);
            this.btnLuuThongTin.TabIndex = 28;
            this.btnLuuThongTin.Text = "Lưu Thông Tin";
            this.btnLuuThongTin.UseVisualStyleBackColor = true;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(534, 330);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(55, 36);
            this.btnThemMon.TabIndex = 25;
            this.btnThemMon.Text = ">";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // comboChuyenNganh
            // 
            this.comboChuyenNganh.FormattingEnabled = true;
            this.comboChuyenNganh.Items.AddRange(new object[] {
            "Kỹ thuật Phần mềm",
            "Truyền thông Đa phương tiện",
            "Kỹ thuật Máy tính",
            "Khoa học Dữ liệu",
            "Thương mại Điện tử",
            "Công nghệ Thông tin",
            "An toàn Thông tin",
            "Trí tuệ Nhân tạo"});
            this.comboChuyenNganh.Location = new System.Drawing.Point(360, 150);
            this.comboChuyenNganh.Name = "comboChuyenNganh";
            this.comboChuyenNganh.Size = new System.Drawing.Size(270, 28);
            this.comboChuyenNganh.TabIndex = 21;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(360, 100);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(270, 26);
            this.txtHoTen.TabIndex = 20;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(360, 51);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(150, 26);
            this.txtMSSV.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chuyên Ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.hoTen,
            this.chuyenNganh,
            this.gioiTinh,
            this.tongSoMon});
            this.dataGridView1.Location = new System.Drawing.Point(81, 674);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(944, 312);
            this.dataGridView1.TabIndex = 34;
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "maSV";
            this.maSV.HeaderText = "Mã Sinh Viên";
            this.maSV.MinimumWidth = 8;
            this.maSV.Name = "maSV";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ Tên";
            this.hoTen.MinimumWidth = 8;
            this.hoTen.Name = "hoTen";
            // 
            // chuyenNganh
            // 
            this.chuyenNganh.DataPropertyName = "chuyenNganh";
            this.chuyenNganh.HeaderText = "Chuyên Ngành";
            this.chuyenNganh.MinimumWidth = 8;
            this.chuyenNganh.Name = "chuyenNganh";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "gioiTinh";
            this.gioiTinh.HeaderText = "Giới Tính";
            this.gioiTinh.MinimumWidth = 8;
            this.gioiTinh.Name = "gioiTinh";
            // 
            // tongSoMon
            // 
            this.tongSoMon.DataPropertyName = "soMon";
            this.tongSoMon.HeaderText = "Số Môn";
            this.tongSoMon.MinimumWidth = 8;
            this.tongSoMon.Name = "tongSoMon";
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2041, 1112);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checkNu;
        private System.Windows.Forms.RadioButton checkNam;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuuThongTin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox comboChuyenNganh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listMonDaChon;
        private System.Windows.Forms.ListBox listMonChuaChon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyenNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongSoMon;
    }
}

