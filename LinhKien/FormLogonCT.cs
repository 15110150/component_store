using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BALayer;
using System.Data.SqlClient;

namespace LinhKien
{
    public partial class FormLogonCT : DevExpress.XtraEditors.XtraForm
    {
        BATaiKhoan balTaiKhoan;
        public FormLogonCT()
        {
            InitializeComponent();
            balTaiKhoan = new BATaiKhoan();
        }
        public static string MaNV { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DN();
        }
        private void DN()
        {
           
            // nếu check vào radio buton nào thì gắn quyen tuong ung
            string Quyen = "";
            if (rdCHC.Checked == true)
                Quyen = "CCH";
            if (rdNVBH.Checked == true)
            {
                Quyen = "NVBH";
            }
            if (rdNVK.Checked == true)
            {
                Quyen = "NVK";
            }
            if (rdQLCH.Checked == true)
            {
                Quyen = "QLBH";
            }
            try
            {
               
                // kiem tra tai khoan theo ten tai khoan, mat khau, quyen
                DataTable dtTaiKhoan = balTaiKhoan.DoTaiKhoan1(this.txtUser.Text, this.txtPass.Text, Quyen).Tables[0];
                if (dtTaiKhoan.Rows.Count == 1)//neu ton tai tai khoan
                {
                    MaNV = dtTaiKhoan.Rows[0][2].ToString();
                    //ẩn form đang nhập
                    this.Hide();
                    //load form với quyền tương ứng
                    if (Quyen == "CCH")
                    {
                        Form frm = new FormChuCuaHang();
                        frm.ShowDialog();

                    }
                    if (Quyen == "NVBH")
                    {
                        // FormNhanVienBanHang.NVBanHang = true;
                        //Form frm = new FormNhanVienBanHang();
                        //frm.ShowDialog();
                    }
                    if (Quyen == "NVK")
                    {
                       // Form frm = new FormNhanVienKho();
                        //frm.ShowDialog();
                    }
                    if (Quyen == "QLBH")
                    {
                    //    Form frm = new FormQuanLyBanHang();
                      //  frm.ShowDialog();
                    }
                }
                else
                {
                    //nếu không đúng tài khoản thì thông báo
                    MessageBox.Show("Nhập sai Tài khoản, Mật khẩu hoặc Quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtUser.ResetText();
                    this.txtPass.ResetText();

                    this.txtUser.Focus();
                }
            }
            catch (SqlException error)//bắt lỗi sql server
            {
                MessageBox.Show("Không truy cập dữ liệu Tài khoản được!\rLỗi:" + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu Tài khoản được!\rLỗi:" + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}