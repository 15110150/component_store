using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using System.Windows.Forms;

namespace BALayer
{
    public class BAServer
    {
        DAl db = null;
        public BAServer()
        {
            db = new DAl();
        }
        public List<string> getDatabaseList(string server, string user, string pass)
        {
            return db.GetDatabaseList(server, user, pass);
        }
        public bool Authentication(string server, string User, string Pwd, string data, bool NTAuthentication)
        {
            if (NTAuthentication) // Nếu là đăng nhập với SQL Server Authentication 
            {
                if (User.Equals("")) // Nếu chưa đăng nhập user
                {
                    MessageBox.Show("Please enter user"); // báo là chưa nhập user
                }
                else // đã nhập user
                {
                    if (db.OpenConnection(User, Pwd, server, data)) // kiểm tra kết nối bằng hàm OpenConnection từ lớp DA
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo"); // kết nối được 
                        return true; // trả về trua
                    }
                    else// kết nối không được
                    {
                        MessageBox.Show("Không thể đăng nhập", "Thông báo");
                    }
                }
            }
            else //nếu là kết nối Window Authentication
            {
                if (!NTAuthentication)
                {
                    if (db.OpenConnection())
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        return true;
                    }
                    else
                        MessageBox.Show("Không thể đăng nhập", "Thông báo");
                }
            }
            return false;
        }
    }
}
