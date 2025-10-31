using System.Collections.Generic;
using System.Security.AccessControl;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                if (i < 5)
                {
                    listSeat.Add(new Seat(5000, $"Seat {i + 1}", buttonList[i]));
                }
                else if (i < 10)
                {
                    listSeat.Add(new Seat(6500, $"Seat {i + 1}", buttonList[i]));
                }
                else
                {
                    listSeat.Add(new Seat(8000, $"Seat {i + 1}", buttonList[i]));
                }
            }

            for (int i = 0; i < 15; i++)
            {
                if (listSeat[i].isbought)
                {
                    listSeat[i].button.BackColor = Color.Yellow;
                }
                else
                {
                    listSeat[i].button.BackColor = Color.White;
                }
            }
            foreach (var item in seats)
            {
                item.button.BackColor = Color.Blue;
            }
            ClickSeats();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void SeatClick(Seat seat)
        {
            if (seat.isbought)
            {
                MessageBox.Show("Ghế đã được bán");
                return;
            }
            else
            {
                if (seats.Contains(seat))
                {
                    seats.Remove(seat);
                }
                else
                {
                    seats.Add(seat);
                }
                UpdateAllSeatColors();

            }
        }


        private void UpdateSeatColor(Seat seat)
        {
            if (seat.isbought)
                seat.button.BackColor = Color.Yellow;   // đã bán
            else if (seats.Contains(seat))
                seat.button.BackColor = Color.SkyBlue;  // đang chọn
            else
                seat.button.BackColor = Color.White;    // còn trống
        }
        private void UpdateAllSeatColors()
        {
            foreach (var s in listSeat) UpdateSeatColor(s);
        }
        private void ClickSeats()
        {
            foreach (var seat in listSeat)
            {
                var s = seat; // đóng biến
                s.button.Click += (sender, e) => SeatClick(s);
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var seat = (Seat)btn.Tag;                   // lấy đúng Seat tương ứng
            SeatClick(seat);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double thanhtien = 0;
            foreach (var seat in seats)
            {
                seat.setBought();
                thanhtien += seat.price;
            }
            seats.Clear();
            textBoxTotal.Text = thanhtien.ToString();
            UpdateAllSeatColors();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            seats.Clear();
            UpdateAllSeatColors();
        }
    }
}
