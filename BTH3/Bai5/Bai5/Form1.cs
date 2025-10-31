using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                double numA = double.Parse(textBox1.Text);
                double numB = double.Parse(textBox2.Text);

                double res = 0;
                res = numA + numB;
                textBox3.Text = res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double numA = double.Parse(textBox1.Text);
                double numB = double.Parse(textBox2.Text);

                double res = 0;
                res = numA - numB;
                textBox3.Text = res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double numA = double.Parse(textBox1.Text);
                double numB = double.Parse(textBox2.Text);

                double res = 0;
                res = numA * numB;
                textBox3.Text = res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double numA = double.Parse(textBox1.Text);
                double numB = double.Parse(textBox2.Text);

                double res = 0;
                if (numB == 0)
                {
                    MessageBox.Show("Mẫu số phải khác 0");
                    return;
                }
                res = numA / numB;
                textBox3.Text = res.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
