using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            
            // Cho phép sử dụng custom color
            dlg.AllowFullOpen = true;

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color selectedColor = dlg.Color;
                this.BackColor = selectedColor;
            }
        }
    }
}
