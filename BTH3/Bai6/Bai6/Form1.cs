using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        // Lưu toán hạng đầu tiên 
        double operand1 = 0;

        // Lưu phép toán đang chờ xử lý 
        string currentOperation = "";

        bool isNewEntry = true;

        double memoryValue = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // Lấy nút đã được nhấn
            Button btn = (Button)sender;
            // Reset lại ô kết quả sau khi ấn phép tính
            if (isNewEntry)
            {
                txtDisplay.Text = btn.Text;
                isNewEntry = false;
            }
            else
            {
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = btn.Text;
                }
                else
                {
                    txtDisplay.Text += btn.Text;
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                txtDisplay.Text = "0.";
                isNewEntry = false;
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Nếu người dùng vừa nhập một số (isNewEntry = false)
            if (!isNewEntry && currentOperation != "")
            {
                btnEqual_Click(sender, e);
            }

            // Lưu số hiện tại trên màn hình 
            operand1 = double.Parse(txtDisplay.Text);

            currentOperation = btn.Text;

            isNewEntry = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (currentOperation == "")
            {
                return;
            }

            // Lấy toán hạng thứ hai 
            double operand2 = double.Parse(txtDisplay.Text);
            double result = 0;

            // Thực hiện phép tính 
            switch (currentOperation)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        txtDisplay.Text = "Error: Cannot divide by zero";
                        // Đặt lại về trạng thái ban đầu
                        operand1 = 0;
                        currentOperation = "";
                        isNewEntry = true;
                        return;
                    }
                    result = operand1 / operand2;
                    break;
            }

            // Hiển thị kết quả và đặt lại trạng thái
            txtDisplay.Text = result.ToString();
            operand1 = 0; 
            currentOperation = ""; 
            isNewEntry = true; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            operand1 = 0;
            currentOperation = "";
            isNewEntry = true;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            isNewEntry = true;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (!isNewEntry && txtDisplay.Text.Length > 0)
            {
                // Xóa 1 ký tự cuối
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);

                if (txtDisplay.Text == "")
                {
                    txtDisplay.Text = "0";
                    isNewEntry = true;
                }
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double currentNumber = double.Parse(txtDisplay.Text);
            if (currentNumber < 0)
                MessageBox.Show("Vui lòng nhập số không âm!");
            else
                txtDisplay.Text = Math.Sqrt(currentNumber).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double currentNumber = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (currentNumber * -1).ToString();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            double currentNumber = double.Parse(txtDisplay.Text);
            if (currentNumber == 0)
                MessageBox.Show("Vui lòng nhập số khác 0!");
            else 
                txtDisplay.Text = (1/currentNumber).ToString();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (currentOperation == "")
            {
                txtDisplay.Text = "0";
                isNewEntry = true;
                return;
            }

            double currentDisplayValue = double.Parse(txtDisplay.Text);
            double percentResult = 0;

            if (currentOperation == "+" || currentOperation == "-")
            {
                percentResult = operand1 * (currentDisplayValue / 100.0);
            }
            else if (currentOperation == "*" || currentOperation == "/")
            {
                percentResult = currentDisplayValue / 100.0;
            }

            txtDisplay.Text = percentResult.ToString();

            isNewEntry = true;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoryValue.ToString();
            isNewEntry = true;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memoryValue = double.Parse(txtDisplay.Text);
            isNewEntry = true;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memoryValue += double.Parse(txtDisplay.Text);
            isNewEntry = true;
        }
    }
}
