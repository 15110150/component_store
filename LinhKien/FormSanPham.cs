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
    public partial class FormSanPham : DevExpress.XtraEditors.XtraForm
    {
        BASanPham balSanPham;
        BaNhaCungCap balNhaCC;
        BALoaiSP balLoaiSP;
        MemoryStream ms;
        byte[] arrImage;

        bool insertSP = false;
        bool updateSP = false;
        public FormSanPham()
        {
            InitializeComponent();
            balSanPham = new BASanPham();
            balNhaCC = new BaNhaCungCap();
            balLoaiSP = new BALoaiSP();
        }
        public static Image ChuyenByteSangImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            MemoryStream ms = new MemoryStream(byteArrayIn);
            returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void LoadSanPham()
        {
            balSanPham = new BASanPham();
             try
            {
                //load danh sách sản phẩm lên gridcontrol
                this.gridControl1.DataSource = balSanPham.LayListSanPham().Tables[0];
               loadFirst();
                HienThiChucNang(true);
                HienThiHanhDong(false);
                HienThiThongTin(false);
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu Sản phẩm được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu Sản phẩm được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiChucNang(bool f)
        {
            btnThem.Enabled = f;
            btnSua.Enabled = f;
            btnXoa.Enabled = f;
        }
        private void HienThiHanhDong(bool f)
        {
            btnLuu.Enabled = f;
            btnHuy.Enabled = f;
        }
        private void HienThiThongTin(bool f)
        {
            txtMaSP.Enabled = f;
            txtTenSP.Enabled = f;
            txtBaoHanh.Enabled = f;
            txtGiaBan.Enabled = f;
            txtGiaMua.Enabled = f;
            cbbLoaiSP.Enabled = f;
            cbbNhaCC.Enabled = f;
            txtMoTa.Enabled = f;
        }
        private void DonThongTin()
        {
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtBaoHanh.ResetText();
            txtGiaBan.ResetText();
            txtGiaMua.ResetText();
            picSP.Image = null;
            txtMoTa.ResetText();
        }
        private void LoadNhaCC()
        {
            try
            {
                if (balNhaCC.LayListNhaCungCap().Tables[0].Rows.Count != 0)
                {

                    //load nhà cung cấp vào combobox nhà cung cấp
                    DataTable dtNCC = balNhaCC.LayListNhaCungCap().Tables[0];
                    this.cbbNhaCC.DataSource = dtNCC;

                    this.cbbNhaCC.ValueMember = "MaNCC";
                    this.cbbNhaCC.DisplayMember = "TenNCC";
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu Nhà cung cấp được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu Nhà cung cấp được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadLoaiSP()
        {
            try
            {
                if (balLoaiSP.LayListLoaiSanPham().Tables[0].Rows.Count != 0)
                {
                    //load danh sách loại sản phẩm lên gridcontrol loại sản phẩm

                    DataTable dtLoaiSP = balLoaiSP.LayListLoaiSanPham().Tables[0];
                    //load lên combobox loại sản phẩm
                    this.cbbLoaiSP.DataSource = dtLoaiSP;
                    this.cbbLoaiSP.ValueMember = "MaLoai";
                    this.cbbLoaiSP.DisplayMember = "TenLoai";

                   
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
        }
        private void load()
        {
            int rowSelected1 = winExplorerView1.FocusedRowHandle;
            txtMaSP.Text = winExplorerView1.GetRowCellValue(rowSelected1, "MaSP").ToString();
            txtTenSP.Text = winExplorerView1.GetRowCellValue(rowSelected1, "TenSP").ToString();
            txtBaoHanh.Text = winExplorerView1.GetRowCellValue(rowSelected1, "BaoHanh").ToString();

            DataRow dtr = this.winExplorerView1.GetDataRow(rowSelected1);

            if (dtr[8].ToString() != null)
                cbbLoaiSP.SelectedValue = winExplorerView1.GetRowCellValue(rowSelected1, "LoaiSP").ToString();
            else
                cbbLoaiSP.SelectedValue = "Select LoaiSP";
            if (dtr[7] != null)
                cbbNhaCC.SelectedValue = winExplorerView1.GetRowCellValue(rowSelected1, "NhaCC").ToString();
            else
                cbbLoaiSP.Text = "Select Nhà CC";
            txtGiaMua.Text = winExplorerView1.GetRowCellValue(rowSelected1, "GiaMuaSP").ToString();
            txtGiaBan.Text = winExplorerView1.GetRowCellValue(rowSelected1, "GiaBanSP").ToString();
            txtMoTa.Text = winExplorerView1.GetRowCellValue(rowSelected1, "MoTa").ToString();
            if (winExplorerView1.GetRowCellValue(rowSelected1, "HinhAnh") != System.DBNull.Value)
            {
                arrImage = (System.Byte[])winExplorerView1.GetRowCellValue(rowSelected1, "HinhAnh");
                this.picSP.Image = ChuyenByteSangImage(arrImage);
            }

            else
                picSP.Image = null;
        }
        private void loadFirst()
        {
            //bên grid SanPham
            int rowSelected1 = winExplorerView1.FocusedRowHandle;
            txtMaSP.Text = winExplorerView1.GetRowCellValue(0, "MaSP").ToString();
            txtTenSP.Text = winExplorerView1.GetRowCellValue(0, "TenSP").ToString();
            txtBaoHanh.Text = winExplorerView1.GetRowCellValue(0, "BaoHanh").ToString();

            DataRow dtr = this.winExplorerView1.GetDataRow(0);

            if (dtr[8].ToString() != null)
                cbbLoaiSP.SelectedValue = winExplorerView1.GetRowCellValue(0, "LoaiSP").ToString();
            else
                cbbLoaiSP.SelectedValue = "Select LoaiSP";
            if (dtr[7] != null)
                cbbNhaCC.SelectedValue = winExplorerView1.GetRowCellValue(0, "NhaCC").ToString();
            else
                cbbLoaiSP.Text = "Select Nhà CC";
            txtGiaMua.Text = winExplorerView1.GetRowCellValue(0, "GiaMuaSP").ToString();
            txtGiaBan.Text = winExplorerView1.GetRowCellValue(0, "GiaBanSP").ToString();
            txtMoTa.Text = winExplorerView1.GetRowCellValue(0, "MoTa").ToString();
            if (winExplorerView1.GetRowCellValue(0, "HinhAnh") != System.DBNull.Value)
            {
                arrImage = (System.Byte[])winExplorerView1.GetRowCellValue(0, "HinhAnh");
                this.picSP.Image = ChuyenByteSangImage(arrImage);
            }

            else
                picSP.Image = null;
        }
        private void FormSanPham_Load(object sender, EventArgs e)
        {
   
            LoadLoaiSP();
            LoadNhaCC();
            LoadSanPham();
            HienThiThongTin(false);

            HienThiChucNang(true);
            HienThiHanhDong(false);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DonThongTin();
            HienThiThongTin(true);
            insertSP = true;
            HienThiChucNang(false);
            HienThiHanhDong(true);
        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            HienThiThongTin(true);
            HienThiChucNang(false);
            HienThiHanhDong(true);
            updateSP = true;
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa sản phẩm này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    string error = "";
                    try
                    {
                        if (balSanPham.XoaSP(ref error, this.txtMaSP.Text))
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
                    load();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            insertSP = false;
            updateSP = false;
            HienThiChucNang(true);
            HienThiHanhDong(false);
            HienThiThongTin(false);
            loadFirst();
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            insertSP = false;
            updateSP = false;
            HienThiChucNang(true);
            HienThiHanhDong(false);
            HienThiThongTin(false);
            loadFirst();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (insertSP)
            {
                if (string.IsNullOrEmpty(txtMaSP.Text))
                {
                    MessageBox.Show("Mã sản phẩm chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (balSanPham.DoMaSP(this.txtMaSP.Text).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("mã sản phẩm đã có", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (picSP.Image != null)
                        {
                            string error = "";
                            try
                            {
                                if (balSanPham.ThemSanPhamWithImage(ref error, this.txtMaSP.Text, this.txtTenSP.Text, this.txtBaoHanh.Text
                                    , double.Parse(this.txtGiaMua.Text), double.Parse(this.txtGiaBan.Text), this.txtMoTa.Text,arrImage,
                                    this.cbbNhaCC.SelectedValue.ToString(), this.cbbLoaiSP.SelectedValue.ToString()))
                                {
                                    MessageBox.Show("thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    picSP.Image = null;
                                    arrImage = null;
                                    LoadSanPham();
                                    insertSP = false;
                                }
                                else
                                    MessageBox.Show(error, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                if (balSanPham.ThemSanPhamNotImage(ref error, this.txtMaSP.Text, this.txtTenSP.Text, this.txtBaoHanh.Text
                                    , double.Parse(this.txtGiaMua.Text), double.Parse(this.txtGiaBan.Text), this.txtMoTa.Text,
                                    this.cbbNhaCC.SelectedValue.ToString(), this.cbbLoaiSP.SelectedValue.ToString()))
                                {
                                    MessageBox.Show("thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    picSP.Image = null;
                                    arrImage = null;
                                    LoadSanPham();
                                    insertSP = false;
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
            else if (updateSP)
            {
                if (string.IsNullOrEmpty(txtMaSP.Text))
                {
                    MessageBox.Show("Mã sản phẩm chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (balSanPham.DoMaSP(this.txtMaSP.Text).Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy mã sản phẩm", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (picSP.Image != null)
                        {
                            string error = "";
                            try
                            {
                                if (balSanPham.CapNhatSanPhamWithImage(ref error, this.txtMaSP.Text, this.txtTenSP.Text, this.txtBaoHanh.Text
                                    , double.Parse(this.txtGiaMua.Text), double.Parse(this.txtGiaBan.Text), this.txtMoTa.Text, arrImage,
                                    this.cbbNhaCC.SelectedValue.ToString(), this.cbbLoaiSP.SelectedValue.ToString()))
                                {
                                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    picSP.Image = null;
                                    arrImage = null;
                                    LoadSanPham();
                                    updateSP = false;
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
                                if (balSanPham.CapNhatSanPhamNotImage(ref error, this.txtMaSP.Text, this.txtTenSP.Text, this.txtBaoHanh.Text
                                    , double.Parse(this.txtGiaMua.Text), double.Parse(this.txtGiaBan.Text), this.txtMoTa.Text,
                                    this.cbbNhaCC.SelectedValue.ToString(), this.cbbLoaiSP.SelectedValue.ToString()))
                                {
                                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    picSP.Image = null;
                                    arrImage = null;
                                    LoadSanPham();
                                    updateSP = false;
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
                this.picSP.Image = System.Drawing.Image.FromFile(odlgOpenFile.FileName);
                //
                ms = new MemoryStream();
                this.picSP.Image.Save(ms, this.picSP.Image.RawFormat);
                arrImage = ms.GetBuffer();
                ms.Close();
            }
        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = balSanPham.DoSP(textBox1.Text).Tables[0];
        }

        private void btnEditLoaiSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLoaiSP form = new FormLoaiSP();
            form.Show();
        }
    }
}