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

namespace LinhKien
{
    public partial class FormDoiMK : DevExpress.XtraEditors.XtraForm
    {
        BATaiKhoan balTaiKhoan;
        public FormDoiMK()
        {
            InitializeComponent();
            balTaiKhoan = new BATaiKhoan();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (this.txtTK == null || this.txtMKC == null || this.txtMKM == null || this.txtNhapLaiMKM == null)
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (this.txtMKM.Text != this.txtNhapLaiMKM.Text)
                {
                    MessageBox.Show("Xin nhap mat khau moi khong trung mat khau moi", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    if (balTaiKhoan.DoTaiKhoan2(this.txtTK.Text, this.txtMKC.Text).Tables[0].Rows.Count != 1)
                    {
                        MessageBox.Show("Không tồn tại tài khoản này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtTK.ResetText();
                        this.txtMKC.ResetText();
                        this.txtMKM.ResetText();
                        this.txtNhapLaiMKM.ResetText();
                        this.txtTK.Focus();
                    }
                    else
                    {
                        string error = "";
                        try
                        {
                            if (balTaiKhoan.CapNhatMatKhau(ref error, this.txtTK.Text, this.txtMKM.Text))
                            {
                                MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.txtTK.ResetText();
                                this.txtMKC.ResetText();
                                this.txtMKM.ResetText();
                                this.txtNhapLaiMKM.ResetText();
                                this.txtTK.Focus();
                            }
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Cập nhật mật khẩu không thành công!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        

        private void tctHuy_Click(object sender, EventArgs e)
        {
             this.txtTK.ResetText();
                                this.txtMKC.ResetText();
                                this.txtMKM.ResetText();
                                this.txtNhapLaiMKM.ResetText();
                                this.txtTK.Focus();
        }
    }
}