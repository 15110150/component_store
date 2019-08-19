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
    public partial class FormLoaiSP : DevExpress.XtraEditors.XtraForm
    {
        BALoaiSP balLoaiSp;
        bool insert = false;
        bool update = false;
        public FormLoaiSP()
        {
            InitializeComponent();
            balLoaiSp = new BALoaiSP();
        }
        private void HienThiChucNang(bool f)
        {
            tlThem.Enabled = f;
            tlSua.Enabled = f;
            tlXoa.Enabled = f;
        }
        private void HienThiHanhDong(bool f)
        {
            tlLuu.Enabled = f;
            tlHuy.Enabled = f;
        }
        private void HienThiThongTin(bool f)
        {
            txtMaLoai.Enabled = f;
            txtTenLoai.Enabled = f;
        }
        private void DonThongTin()
        {
            txtTenLoai.ResetText();
            txtMaLoai.ResetText();
        }
        private void LoadLoaiSp()
        {
            int rowSelected1 = gridView1.FocusedRowHandle;
            txtMaLoai.Text = gridView1.GetRowCellValue(rowSelected1, "MaLoai").ToString();
            txtTenLoai.Text = gridView1.GetRowCellValue(rowSelected1, "TenLoai").ToString();
        }
        private void Loadfirst()
        {
            balLoaiSp = new BALoaiSP();
            try
            {
                if (balLoaiSp.LayListLoaiSanPham().Tables[0].Rows.Count != 0)
                {
                    this.gridControl1.DataSource = balLoaiSp.LayListLoaiSanPham().Tables[0];
                    LoadLoaiSp();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu Loại sản phẩm được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu Loại sản phẩm được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThiThongTin(false);
            HienThiChucNang(true);
            HienThiHanhDong(false);
        }
        private void FormLoaiSP_Load(object sender, EventArgs e)
        {
            try
            {
                if (balLoaiSp.LayListLoaiSanPham().Tables[0].Rows.Count != 0)
                {
                    this.gridControl1.DataSource = balLoaiSp.LayListLoaiSanPham().Tables[0];
                    LoadLoaiSp();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu Loại sản phẩm được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu Loại sản phẩm được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HienThiThongTin(false);
            HienThiChucNang(true);
            HienThiHanhDong(false);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            LoadLoaiSp();
        }

        private void tlThem_ItemClick(object sender, TileItemEventArgs e)
        {
            DonThongTin();
            HienThiThongTin(true);
            HienThiChucNang(false);
            HienThiHanhDong(true);
            insert = true;
        }

        private void tlSua_ItemClick(object sender, TileItemEventArgs e)
        {
            HienThiThongTin(true);
            HienThiChucNang(false);
            HienThiHanhDong(true);
            update = true;
        }

        private void tlXoa_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa nhân viên này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    string error = "";
                    try
                    {
                        if (balLoaiSp.XoaLoaiSP(ref error, this.txtMaLoai.Text))
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
                    Loadfirst();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tlHuy_ItemClick(object sender, TileItemEventArgs e)
        {
            Loadfirst();
            update = false;
            insert = false;
        }

        private void tlLuu_ItemClick(object sender, TileItemEventArgs e)
        {
            if (insert)
            {
                if (string.IsNullOrEmpty(txtMaLoai.Text))
                {
                    MessageBox.Show("Mã sản phẩm chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (balLoaiSp.DoMaLoaiSP(this.txtMaLoai.Text).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("mã loại sản phẩm đã có", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string error = "";
                        try
                        {
                            if (balLoaiSp.ThemLoaiSp(ref error, this.txtMaLoai.Text, this.txtTenLoai.Text))
                            {
                                MessageBox.Show("thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Loadfirst();
                                insert = false;
                            }

                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (update)
            {
                try
                {

                    if (string.IsNullOrEmpty(txtMaLoai.Text))
                    {
                        MessageBox.Show("Mã Loại sản phẩm chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (balLoaiSp.DoMaLoaiSP(this.txtMaLoai.Text).Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("không tồn tại mã loại sản phẩm này", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string error = "";
                            try
                            {
                                if (balLoaiSp.CapNhatLoaiSp(ref error, this.txtMaLoai.Text, this.txtTenLoai.Text))
                                {
                                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Loadfirst();
                                    update = false;
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
    }
}