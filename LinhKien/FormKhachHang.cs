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
    public partial class FormKhachHang : DevExpress.XtraEditors.XtraForm
    {
        bool insertKH = false;
        bool updateKH = false;
        BAKhachHang balKhachHang;
        public FormKhachHang()
        {
            InitializeComponent();
            balKhachHang = new BAKhachHang();
        }
        private void load()
        {
           
                int rowSelected = cardKhachHang.FocusedRowHandle;
              
                txtMaKH.Text = cardKhachHang.GetRowCellValue(cardKhachHang.FocusedRowHandle, "MaKH").ToString();
                txtTenKH.Text = cardKhachHang.GetRowCellValue(cardKhachHang.FocusedRowHandle, "TenKH").ToString();
                txtGhiChu.Text = cardKhachHang.GetRowCellValue(cardKhachHang.FocusedRowHandle, "GhiChu").ToString();
                txtDiaChi.Text = cardKhachHang.GetRowCellValue(cardKhachHang.FocusedRowHandle, "DiaChi").ToString();
                txtPhone.Text = cardKhachHang.GetRowCellValue(cardKhachHang.FocusedRowHandle, "Phone").ToString();

                if (balKhachHang.LayHoaDonDaMua(txtMaKH.Text).Tables[0].Rows.Count != 0)
                    this.gridControl2.DataSource = balKhachHang.LayHoaDonDaMua(txtMaKH.Text).Tables[0];
                else
                    this.gridControl2.DataSource = null;
           
        }
        private void loadThongTin()
        { 
            balKhachHang = new BAKhachHang();
            try
            {
                if (balKhachHang.LayListKhachHang().Tables[0].Rows.Count != 0)
                {
                    this.gridControl1.DataSource = balKhachHang.LayListKhachHang().Tables[0];
                    load();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
                    loadThongTin();
                    HienThiThongTin(false);
                    HienThiChucNang(true);
                    HienThiHanhDong(false);
       }
        private void HienThiChucNang(bool f)
        {
            tlThem.Enabled = f;
            tlSua.Enabled = f;
            tlXoa.Enabled = f;
        }
        private void HienThiHanhDong(bool f)
        {
            tlHuy.Enabled = f;
            tlLuu.Enabled = f;
        }
        private void HienThiThongTin(bool f)
        {
            txtDiaChi.Enabled = f;
            txtGhiChu.Enabled = f;
            txtMaKH.Enabled = f;
            txtPhone.Enabled = f;
            txtTenKH.Enabled = f;
        }
        private void DonThongTin()
        {
            txtDiaChi.ResetText();
            txtMaKH.ResetText();
            txtPhone.ResetText();
            txtGhiChu.ResetText();
            txtTenKH.ResetText();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void tlThem_ItemClick(object sender, TileItemEventArgs e)
        {
            DonThongTin();
            HienThiThongTin(true);

            HienThiChucNang(false);
            HienThiHanhDong(true);
            insertKH = true;
        }

        private void tlSua_ItemClick(object sender, TileItemEventArgs e)
        {
            load();
            HienThiThongTin(true);
            HienThiChucNang(false);
            HienThiHanhDong(true);
            updateKH = true;
        }

        private void tlXoa_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa khách hàng này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    string error = "";
                    try
                    {
                        if (balKhachHang.XoaKhachHang(ref error, this.txtMaKH.Text))
                        {
                            MessageBox.Show("xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi: " + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    catch (SqlException)
                    {
                        MessageBox.Show("Không sửa được. Lỗi rồi!");
                    }
                    loadThongTin();
                    HienThiThongTin(false);
                    HienThiChucNang(true);
                    HienThiHanhDong(false);

                }
                else
                {

                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tlHuy_ItemClick(object sender, TileItemEventArgs e)
        {
            insertKH = false;
            updateKH = false;
            load();
            HienThiThongTin(false);
            HienThiChucNang(true);
            HienThiHanhDong(false);
        }

        private void tileBarItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            insertKH = false;
            updateKH = false;
            load();
            HienThiThongTin(false);
            HienThiChucNang(true);
            HienThiHanhDong(false);
        }

        private void tlThoat_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void tlLuu_ItemClick(object sender, TileItemEventArgs e)
        {
            if (insertKH)
            {
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Mã khach hang chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (balKhachHang.KiemTraMaKH(this.txtMaKH.Text).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Mã khách hàng đã có", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string error = "";
                        try
                        {
                            if (balKhachHang.ThemKhachHang(ref error, this.txtMaKH.Text, this.txtTenKH.Text, this.txtPhone.Text,
                                 this.txtDiaChi.Text, this.txtGhiChu.Text))
                            {
                                MessageBox.Show("thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadThongTin();
                                HienThiThongTin(false);
                                HienThiChucNang(true);
                                HienThiHanhDong(false);
                                insertKH = false;
                            }

                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (updateKH)
            {
                try
                {

                    if (string.IsNullOrEmpty(txtMaKH.Text))
                    {
                        MessageBox.Show("Mã khách hàng chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (balKhachHang.KiemTraMaKH(this.txtMaKH.Text).Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy mã khách hàng", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string error = "";
                            try
                            {
                                if (balKhachHang.CapNhatKhachHang(ref error, this.txtMaKH.Text, this.txtTenKH.Text, this.txtPhone.Text,
                                    this.txtGhiChu.Text, this.txtDiaChi.Text))
                                {
                                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadThongTin();
                                    HienThiThongTin(false);
                                    HienThiChucNang(true);
                                    HienThiHanhDong(false);
                                    updateKH = false;
                                }


                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = balKhachHang.DoKH(textBox6.Text).Tables[0];
        }
    }
}