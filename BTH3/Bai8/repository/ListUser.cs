using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8.repository
{
    public class ListUser
    {
        private List<User> _users = new List<User> { };
        public ListUser() { }
        public void addOrUpdateUser(User user)
        {
            for (int i=0; i<_users.Count; i++)
            {
                if (_users[i] == user)
                {
                    _users[i].set(user);
                    return;
                }
            }
            _users.Add(user);
        }
        public bool removeUser(User user)
        {
            if (user == null) return false;
            return _users.RemoveAll(u => u.get_stk() == user.get_stk()) > 0;
        }

        // Xóa theo mã tài khoản (dễ dùng nhất từ DataGridView)
        public bool removeUser(string stk)
        {
            if (string.IsNullOrWhiteSpace(stk)) return false;
            return _users.RemoveAll(u => u.get_stk() == stk) > 0;
        }
        public List<User> getUsers()
        {
            return _users;
        }
    }
}
