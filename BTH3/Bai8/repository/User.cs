using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Bai8.repository
{
    public class User
    {
        private string _stk;
        private string _hoten;
        private string _diachi;
        private double _sotien;
        public User() { }
        public User(string hoten, string diachi, string stk)
        {
            _stk = stk;
            _hoten = hoten;
            _diachi = diachi;
            _sotien = 0;
        }
        public User(string hoten, string diachi, string stk, double sotien)
        {
            _stk = stk;
            _hoten = hoten;
            _diachi = diachi;
            _sotien = sotien;
        }
        public void set(User user) 
        { 
            _diachi = user.get_diachi();
            _hoten = user.get_hoten();
            _sotien = user.get_sotien();
        }
        public void set(string stk, string hoten,  string diachi, double sotien)
        {
            _stk = stk;
            _hoten = hoten;
            _diachi = diachi;
            _sotien = sotien;
        }
        public void setSotien(double sotien)
        {
            _sotien = sotien;
        }
        public string get_stk()
        {
            return _stk;
        }
        public string get_hoten()
        {
            return _hoten;
        }
        public double get_sotien()
        {
            return _sotien;
        }
        public string get_diachi()
        {
            return _diachi;
        }

        public static bool operator ==(User a, User b)
        {
            if (ReferenceEquals(a, b)) return true;        // cùng tham chiếu
            if (a is null || b is null) return false;      // 1 trong 2 null

            return a.get_stk() == b.get_stk();
        }
        public static bool operator !=(User a, User b) => !(a == b);
    }
}
