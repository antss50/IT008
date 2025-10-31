using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = random.Next(50, ClientSize.Width - 150);
            int y = random.Next(70, ClientSize.Height - 50);
            using (Font f = new Font("Segoe UI", 20, FontStyle.Bold))
            using (Brush b = new SolidBrush(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256))))
            {
                g.DrawString("Paint Event", f, b, x, y);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
