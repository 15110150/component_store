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
using System.IO;
using System.Data.SqlClient;

namespace LinhKien
{
    public partial class FormQuanLyTKNV : DevExpress.XtraEditors.XtraForm
    {
        BANhanVien balNhanVien;
        BATaiKhoan balTaiKhoan;
        public FormQuanLyTKNV()
        {
            InitializeComponent();
            balNhanVien = new BANhanVien();
            balTaiKhoan = new BATaiKhoan();
        }
        private void loadNV()
        {
            //   try
            {
                if (balNhanVien.LayListNhanVienKhongTK().Tables[0].Rows.Count != 0)
                {
                    this.gridControl1.DataSource = balNhanVien.LayListNhanVienKhongTK().Tables[0];

                    int rowSelected = gridView1.FocusedRowHandle;
                    txtMaNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
                    txtTenNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
                    txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
                    txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
                    txtLuong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Luong").ToString();
                    txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
                    dtNgaySinh.EditValue = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh");

                    if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Photo") != System.DBNull.Value)
                    {
                        byte[] images = ((byte[])gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Photo"));
                        MemoryStream meno = new MemoryStream(images);
                        picNhanVien.Image = System.Drawing.Image.FromStream(meno);
                    }
                    else
                        picNhanVien.Image = null;
                }
            }
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtLuong.Enabled = false;
            txtMaNV.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNV.Enabled = false;
            dtNgaySinh.Enabled = false;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                if (balNhanVien.LayListNhanVienKhongTK().Tables[0].Rows.Count != 0)
                {

                    int rowSelected = gridView1.FocusedRowHandle;
                    txtMaNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
                    txtTenNV.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
                    txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
                    txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
                    txtLuong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Luong").ToString();
                    txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
                    dtNgaySinh.EditValue = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh");

                    if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Photo") != System.DBNull.Value)
                    {
                        byte[] images = ((byte[])gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Photo"));
                        MemoryStream meno = new MemoryStream(images);
                        picNhanVien.Image = System.Drawing.Image.FromStream(meno);
                    }
                    else
                        picNhanVien.Image = null;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtLuong.Enabled = false;
            txtMaNV.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNV.Enabled = false;
            dtNgaySinh.Enabled = false;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            gbDSNV.Enabled = true;
            loadNV();
        }

        private void txtTK_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //khi nhập tài khoản vào ô tài khoản mới thì cũng kiểm tra sự tồn tại của tài khoản trong csdl
                if (string.IsNullOrEmpty(txtTK.Text))
                {
                    lbTT.Text = "";
                    this.lbTT.ForeColor = Color.Green;
                }
                else if (balTaiKhoan.KiemTraTaiKhoan(this.txtTK.Text).Tables[0].Rows.Count != 0)
                {
                    //nếu đã có tài khoản
                    this.lbTT.Text = "Tài khoản đã có người dùng";
                    this.lbTT.ForeColor = Color.Red;
                }
                else
                {
                    //nếu chưua bị trùng
                    this.lbTT.Text = "Tài khoản sẵn sàng";
                    this.lbTT.ForeColor = Color.Green;
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu Tài khoản được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu Tài khoản được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaNV_EditValueChanged(object sender, EventArgs e)
        {
            txtMaNVCapTK.Text = txtMaNV.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (this.txtTK == null || this.txtMK == null || this.txtNLMK == null ||
               this.txtMaNVCapTK == null)
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin !", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //nếu có tài khoản trùng thì không cho tạo tài khoản
                if (lbTT.ForeColor == Color.Red)
                {
                    MessageBox.Show("Tài khoản đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (lbTT.ForeColor == Color.Red)
                {
                    MessageBox.Show("Mã nhân viên đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    //kiểm tra 2 ô mật khẩu mới phải trùng nhau
                    if (this.txtMK.Text != this.txtNLMK.Text)
                    {
                        MessageBox.Show("Hãy nhập ô Mật khẩu và Nhập lại mật khẩu giống nhau!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string Quyen = "";
                        if (rbCHC.Checked == true)
                            Quyen = "CCH";
                        if (rbNVBH.Checked == true)
                        {
                            Quyen = "NVBH";
                        }
                        if (rbNVK.Checked == true)
                        {
                            Quyen = "NVK";
                        }
                        if (rbQLBH.Checked == true)
                        {
                            Quyen = "QLBH";
                        }
                        string error = "";
                        try
                        {
                            //thêm tài khoản
                            if (balTaiKhoan.ThemTaiKhoan(ref error, this.txtTK.Text, this.txtMK.Text, this.txtNLMK.Text, Quyen))
                            {
                                MessageBox.Show("Tạo tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.txtTK.ResetText();
                                this.txtMK.ResetText();
                                this.txtNLMK.ResetText();
                                this.txtMaNV.ResetText();
                                loadNV();
                                groupControl2.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Lỗi: " + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Tạo tài khoản không thành công!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.txtTK.ResetText();
            this.txtMK.ResetText();
            this.txtNLMK.ResetText();
            this.txtMaNV.ResetText();
        }

        private void FormQuanLyTKNV_Load(object sender, EventArgs e)
        {
            gbDSNV.Enabled = false;
        }
    }
}