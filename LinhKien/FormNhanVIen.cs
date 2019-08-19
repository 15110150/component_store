using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BALayer;
using System.IO;
using DevExpress.XtraGrid.Views.Layout;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Repository;

namespace LinhKien
{
    public partial class FormNhanVIen : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BANhanVien balNhanVien;
        MemoryStream ms;
        byte[] arrImage;
        bool insert = false;
        bool update = false;
        public FormNhanVIen()
        {
            InitializeComponent();
            balNhanVien = new BANhanVien();
        }

        private void FormNhanVIen_Load(object sender, EventArgs e)
        {
            LoadNV();

        }
        private void HienThiChucNang(bool f)
        {
            btnThem.Enabled = f;
            btnSua.Enabled = f;
            btnXoa.Enabled = f;
        }
        private void HienThiHanhDong(bool f)
        {
            btnHuy.Enabled = f;
            btnLuu.Enabled = f;
        }
        private void HienThiThongTin(bool f)
        {
            txtDiaChi.Enabled = f;
            txtEmail.Enabled = f;
            txtLuong.Enabled = f;
            txtMaNV.Enabled = f;
            txtSDT.Enabled = f;
            txtTenNV.Enabled = f;
            dtNgaySinh.Enabled = f;
        }
        private void DonThongTin()
        {
            txtDiaChi.ResetText();
            txtEmail.ResetText();
            txtLuong.ResetText();
            txtMaNV.ResetText();
            txtSDT.ResetText();
            txtTenNV.ResetText();
        }
        private void loadTile()
        {
            int rowSelected = winExplorerView1.FocusedRowHandle;
            txtMaNV.Text = winExplorerView1.GetRowCellValue(winExplorerView1.FocusedRowHandle, "MaNV").ToString();
            txtTenNV.Text = winExplorerView1.GetRowCellValue(winExplorerView1.FocusedRowHandle, "TenNV").ToString();
            txtDiaChi.Text = winExplorerView1.GetRowCellValue(winExplorerView1.FocusedRowHandle, "DiaChi").ToString();
            txtSDT.Text = winExplorerView1.GetRowCellValue(winExplorerView1.FocusedRowHandle, "SDT").ToString();
            txtLuong.Text = winExplorerView1.GetRowCellValue(winExplorerView1.FocusedRowHandle, "Luong").ToString();
            txtEmail.Text = winExplorerView1.GetRowCellValue(winExplorerView1.FocusedRowHandle, "Email").ToString();
            dtNgaySinh.EditValue = (DateTime)winExplorerView1.GetRowCellValue(winExplorerView1.FocusedRowHandle, "NgaySinh");

            if (winExplorerView1.GetRowCellValue(winExplorerView1.FocusedRowHandle, "Photo") != System.DBNull.Value)
            {
                byte[] images = ((byte[])winExplorerView1.GetRowCellValue(winExplorerView1.FocusedRowHandle, "Photo"));
                MemoryStream meno = new MemoryStream(images);
                picNhanVien.Image = System.Drawing.Image.FromStream(meno);
                winExplorerView1.Columns["Photo"].ColumnEdit = new RepositoryItemPictureEdit();
            }
            else
                picNhanVien.Image = null;
        }
        private void loadLayout()
        {
            int rowSelected = layoutView1.FocusedRowHandle;
            txtMaNV.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "MaNV").ToString();
            txtTenNV.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "TenNV").ToString();
            txtDiaChi.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "DiaChi").ToString();
            txtSDT.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "SDT").ToString();
            txtLuong.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Luong").ToString();
            txtEmail.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Email").ToString();
            dtNgaySinh.EditValue = (DateTime)layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "NgaySinh");

            if (layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Photo") != System.DBNull.Value)
            {
                byte[] images = ((byte[])layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "Photo"));
                MemoryStream meno = new MemoryStream(images);
                picNhanVien.Image = System.Drawing.Image.FromStream(meno);
            }
            else
                picNhanVien.Image = null;
        }
        private void load()
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

        private void LoadNV()
        {
            try
            {
                if (balNhanVien.LayListNhanVien().Tables[0].Rows.Count != 0)
                {
                    this.gridControl1.DataSource = balNhanVien.LayListNhanVien().Tables[0];
                    load();
                } 
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnBrowse.Enabled = false;
            HienThiThongTin(false);

            HienThiChucNang(true);
            HienThiHanhDong(false);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.MainView = layoutView1;
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.MainView = winExplorerView1;
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            DonThongTin();
            btnBrowse.Enabled = true;
            HienThiThongTin(true);

            HienThiChucNang(false);
            HienThiHanhDong(true);
            picNhanVien.Image = null;
            insert = true;
        }
        private void hienthi()
        {
            if (gridControl1.MainView == winExplorerView1)
            {
                loadTile();
            }
            else if (gridControl1.MainView == layoutView1)
            {
                loadLayout();
            }
            else if (gridControl1.MainView == gridView1)
            {
                load();
            }
        }
        private void loadThongTin()
        {
            balNhanVien = new BANhanVien();
            try
            {
                if (balNhanVien.LayListNhanVien().Tables[0].Rows.Count != 0)
                {
                    this.gridControl1.DataSource = balNhanVien.LayListNhanVien().Tables[0];
                    hienthi();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            hienthi();
            btnBrowse.Enabled = true;
            HienThiThongTin(true);
            HienThiChucNang(false);
            HienThiHanhDong(true);
            update = true;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
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
                        if (balNhanVien.XoaNV(ref error, this.txtMaNV.Text))
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
                    hienthi();
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

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridControl1.MainView == winExplorerView1)
            {
                loadTile();
            }
            else if (gridControl1.MainView == layoutView1)
            {
                loadLayout();
            }
            else if (gridControl1.MainView == gridView1)
            {
                load();
            }
            insert = false;
            update = false;
            HienThiChucNang(true);
            HienThiHanhDong(false);
            HienThiThongTin(false);
        }

        private void btnReset_ItemClick(object sender, ItemClickEventArgs e)
        {
            HienThiChucNang(true);
            HienThiHanhDong(false);
            HienThiThongTin(false);
            loadThongTin();
            insert = false;
            update = false;
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (insert)
            {
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Mã nhân viên chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (labelTT.ForeColor == Color.Red)
                {
                    MessageBox.Show("Hãy nhập lương là số nguyên không âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (balNhanVien.KiemTraMaNV(this.txtMaNV.Text).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("mã nhân viên sản phẩm đã có", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (picNhanVien.Image != null)
                        {
                            string error = "";
                            try
                            {
                                if (balNhanVien.ThemNhanVienWithImage(ref error, this.txtMaNV.Text, this.txtTenNV.Text, this.dtNgaySinh.DateTime, this.txtDiaChi.Text, this.txtSDT.Text, arrImage, double.Parse(this.txtLuong.Text), this.txtEmail.Text)
                                   )
                                {
                                    MessageBox.Show("thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    picNhanVien.Image = null;
                                    arrImage = null;
                                    loadThongTin();
                                    insert = false;
                                }

                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            string error = "";
                            try
                            {
                                if (balNhanVien.ThemNhanVienNotImage(ref error, this.txtMaNV.Text, 
                                    this.txtTenNV.Text, this.dtNgaySinh.DateTime, this.txtDiaChi.Text, this.txtSDT.Text, double.Parse(this.txtLuong.Text), this.txtEmail.Text)
                                   )
                                {
                                    MessageBox.Show("thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    picNhanVien.Image = null;
                                    arrImage = null;
                                    loadThongTin();
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
            }
            else if (update)
            {
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Mã nhân viênchưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (balNhanVien.KiemTraMaNV(this.txtMaNV.Text).Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy mã nhân viên ", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (picNhanVien.Image != null)
                        {
                            string error = "";
                            try
                            {
                                if (balNhanVien.CapNhatNhanVienWithImage(ref error, this.txtMaNV.Text, this.txtTenNV.Text,
                                    this.dtNgaySinh.DateTime, this.txtDiaChi.Text, this.txtSDT.Text, arrImage, double.Parse(this.txtLuong.Text), this.txtEmail.Text)
                                   )
                                {
                                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    picNhanVien.Image = null;
                                    arrImage = null;
                                    loadThongTin();
                                    update = false;
                                }

                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            string error = "";
                            try
                            {
                                if (balNhanVien.CapNhatNhanVienNotImage(ref error, this.txtMaNV.Text, this.txtTenNV.Text,
                                    this.dtNgaySinh.DateTime, this.txtDiaChi.Text, this.txtSDT.Text, double.Parse(this.txtLuong.Text), this.txtEmail.Text)
                                      )
                                {
                                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    picNhanVien.Image = null;
                                    arrImage = null;
                                    loadThongTin();
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
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //chọn ảnh để đưa vào CSDL
            OpenFileDialog odlgOpenFile = new OpenFileDialog();
            odlgOpenFile.InitialDirectory = "C:\\";
            odlgOpenFile.Title = "Open File";
            odlgOpenFile.Filter = "Image files (*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*";
            if (odlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                this.picNhanVien.Image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                //
                ms = new MemoryStream();
                this.picNhanVien.Image.Save(ms, this.picNhanVien.Image.RawFormat);
                arrImage = ms.GetBuffer();
                ms.Close();
            }
        }

        private void txtLuong_EditValueChanged(object sender, EventArgs e)
        {
            int distance;
            // nếu text box số lượng khác null
            if (!string.IsNullOrEmpty(txtLuong.Text))
            {
                //nếu không phải là số
                if (!int.TryParse(txtLuong.Text, out distance))
                {

                    labelTT.Text = "Hãy nhập số nguyên";
                    // cho label trạng thái nằm dưới text box đó màu đỏ
                    labelTT.ForeColor = Color.Red;

                }
                //kiểm tra số âm
                else if ((double.Parse(txtLuong.Text) <= 0))
                {
                    labelTT.Text = "Hãy nhập số dương";
                    // cho label trạng thái nằm dưới text box đó màu đỏ
                    labelTT.ForeColor = Color.Red;
                }
                // nếu là số nguyên 
                else
                {
                    labelTT.ForeColor = Color.Green;
                }
            }
            else
            {
                //label trạng thái không hiện gì
                labelTT.Text = "";
                labelTT.ForeColor = Color.Green;


            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            hienthi();
            btnBrowse.Enabled = false;
            HienThiThongTin(false);

            HienThiChucNang(true);
            HienThiHanhDong(false);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.MainView = gridView1;
        }

        private void TimKiem_EditValueChanged(object sender, EventArgs e)
        {
            //this.gridControl1.DataSource = balNhanVien.DoNhanVienAll(timki.ToString()).Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = balNhanVien.DoNhanVienAll(textBox1.Text).Tables[0];
        }
    }
}