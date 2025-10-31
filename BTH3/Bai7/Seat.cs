using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    public class Seat
    {
        public double price {  get; set; }
        public bool isbought { get; set; }
        public string name { get; set; }
        public Button button { get; set; }
        public Seat(double price, string name, Button btn)
        {
            this.name = name;
            this.price = price;
            this.isbought = false;
            this.button = btn;
        }
        public override string ToString()
        {
            return name;
        }

        public void setBought()
        {
            isbought = true;
        }
    }
}
