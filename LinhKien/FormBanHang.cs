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
    public partial class FormBanHang : DevExpress.XtraEditors.XtraForm
    {
        BASanPham balSanPham = null;
       // BANhanVien dbNhanVien = null;
        BAKhachHang balKH = null;
        BAHoaDonBanHang balHoaDon = null;
        BALChiTietHDBanHang balChiTietHD = null;
        BALoaiSP balLoaiSP = null;
        int click_btn = 0;
        //BABaoHanh dbBaoHanh = null;
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void btnEditKH_Click(object sender, EventArgs e)
        {
            FormKhachHang form = new FormKhachHang();
            form.Show();
        }
        private void LoadSanPham()
        {
            balSanPham = new BASanPham();
            try
            {
                //load danh sách sản phẩm lên gridcontrol
                this.gridSP.DataSource = balSanPham.LayListSanPhamTheoLoai(cbbLoaiHang.SelectedValue.ToString()).Tables[0];
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
        private void LoadKhachHang()
        {
            balKH = new BAKhachHang();
            try
            {
                //load danh sách sản phẩm lên gridcontrol
                this.gridKH.DataSource = balKH.LayListKhachHang().Tables[0];
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu khách hàng được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu khách hàng được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadLoaiSP()
        {
            balLoaiSP = new BALoaiSP();
            try
            {
                if (balLoaiSP.LayListLoaiSanPham().Tables[0].Rows.Count != 0)
                {

                    //load nhà cung cấp vào combobox nhà cung cấp
                    DataTable dtNCC = balLoaiSP.LayListLoaiSanPham().Tables[0];
                    this.cbbLoaiHang.DataSource = dtNCC;
                    this.cbbLoaiHang.ValueMember = "MaLoai";
                    this.cbbLoaiHang.DisplayMember = "TenLoai";
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
        private void loadCTHDNH()
        {
            balChiTietHD = new BALChiTietHDBanHang();
            try
            {
                if (balChiTietHD.LayChiTietHDBanHangTheoMaHD(txtMaHD.Text).Tables[0].Rows.Count != 0)
                {
                    this.gridDSKH.DataSource = balChiTietHD.LayChiTietHDBanHangTheoMaHD(txtMaHD.Text).Tables[0];
                    //int rowSelected2 = gridView2.FocusedRowHandle;
                    //txtSP.Text = gridView2.GetRowCellValue(rowSelected2, "MaSP").ToString();
                    //txtSL.Text = gridView2.GetRowCellValue(rowSelected2, "DonGia").ToString();
                    //txtSL.Text = gridView2.GetRowCellValue(rowSelected2, "SoLuong").ToString();
                    //txtTT.Text = gridView2.GetRowCellValue(rowSelected2, "ThanhTien").ToString();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu hóa đơn nhập hàng được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu hóa đơn nhập hàng được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //HienThiChucNangCTHD(true);
            //HienThiHanhDongCTHD(false);

        }
        private void DonThongTinCTHD()
        {
            txtSanPham.ResetText();
            txtSL.ResetText();
            txtSLTK.ResetText();
            txtDonGia.ResetText();
            txtThanhTien.ResetText();
        }
        private void DonThongTinHD()
        {
            txtMaHD.ResetText();
            txtKH.ResetText();
            txtNhanVien.ResetText();
            txtTGT.ResetText();
            txtKhachTra.ResetText();
            txtTienThua.ResetText();
            //txtConThieu.Text = "0";
            //txtThanhToan.Text = "0";
            //txtTGT.Text = "0";
            //txtSL.Text = "1";
        }
        private void LoadChiTietHD()
        {
            try
            {
                gridDSKH.DataSource = balChiTietHD.LayChiTietHDBanHangTheoMaHD(txtMaHD.Text).Tables[0];
            }
            catch (SqlException err)
            {
                MessageBox.Show("Không lấy được dữ liệu!\rLỗi: " + err.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            DonThongTinCTHD();
            DonThongTinHD();
        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
            gbThongTin.Enabled = true;
            tabKhachHang.PageEnabled = true;
            tabSP.PageEnabled = false;
        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            LoadSanPham();
            gbThongTin.Enabled = true;
            tabKhachHang.PageEnabled = false;
            tabSP.PageEnabled = true;
        }

        private void btnTruHang_Click(object sender, EventArgs e)
        {
            DonThongTinCTHD();
        }

        private void btnHuyHd_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                //xóa hết các chi tiết hóa đơn của hóa đơn đó
                if (balChiTietHD.XoaChiTietHDBanHangTheoMaHD(ref err, txtMaHD.Text))
                {
                    //khi thành công thì xóa đơn nhập
                    try
                    {
                        // Xóa hóa đơn nhập
                        if (balHoaDon.XoaHoaDonBanHang(ref err, txtMaHD.Text))
                        {
                            //xóa thành công
                            DonThongTinCTHD();
                            DonThongTinHD();
                            gbThongTin.Enabled = false;
                            gridDSKH.DataSource = null;
                            MessageBox.Show("Đã hủy đơn bán...", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                            MessageBox.Show("Không thể xóa đơn bán hàng !!!! \rLỗi:" + err, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Xóa đơn nhập không thành công\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa chi tiết đơn nhập!!!!\r Lỗi:" + err, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Xóa chi tiết đơn nhập không thành công\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string GiaTriHoaDon()
        {
            try
            {
                DataTable dt = balHoaDon.GiaTriDonBan(txtMaHD.Text).Tables[0];

                // Nếu bảng trả về trống tức là hóa đơn có giá trị bằng 0
                if (dt.Rows.Count == 0)
                {
                    return "0";
                }
                else
                {
                    return dt.Rows[0][0].ToString();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show("Không thể tính giá trị hóa đơn.\rLỗi: " + err.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không thể tính giá trị hóa đơn.\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            // Nếu click lần đầu thì tạo hóa đơn nhập mới
            // Tạo mã hóa đơn nhập
            if (click_btn == 0)
            {
                if (lbMAHD.ForeColor == Color.Red)
                {
                    MessageBox.Show("Mả hóa đơn này đã có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (labelTTSL.ForeColor == Color.Red)
                {
                    MessageBox.Show("Hãy nhập 1 số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if(double.Parse(txtSL.Text)>double.Parse(txtSLTK.Text))
                {
                    MessageBox.Show("Hãy nhập 1 số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txtSL.Text == string.Empty || txtNhanVien.Text == string.Empty)
                {
                    MessageBox.Show("Không được bỏ trống số lượng hoặc nhân viên nhập hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    click_btn = 1;
                    //3 cbbNCC.Enabled = false;
                  try
                    {
                        // kiểm tra lỗi trùng mã đơn nhập
                        double donGia = Double.Parse(txtDonGia.Text);
                        int soLuong = int.Parse(txtSL.Text);
                        string error = "";
                        try
                        {
                            // Tạo mới hóa đơn nhập hàng
                            if (balHoaDon.ThemHoaDonBanHang(ref error, txtMaHD.Text,  DateTime.Now, txtKH.Text,txtNhanVien.Text))
                            {
                              
                                 if(balChiTietHD.ThemChiTietHDBanHang(ref error, txtMaHD.Text, txtSanPham.Text, donGia, soLuong))
                                {
                                    loadCTHDNH();
                                    txtTGT.Text = GiaTriHoaDon();

                                }

                            }
                            else
                            {
                                MessageBox.Show("Lỗi thêm đơn bán hàng.\rLỗi: " + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            //
                        }
                        catch (Exception er)
                    {
                        MessageBox.Show("Không thể thêm đơn bán hàng mới.\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                    catch (SqlException err)
                    {
                        MessageBox.Show("Không thể kiểm tra mã hóa đơn nhập.\rLỗi: " + err.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Không thể kiểm tra mã hóa đơn nhập.\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Thêm các chi tiết đơn nhập vào hóa đơn nhập có mã là MaHD
                string err = "";
                try
                {
                    double donGia = Double.Parse(txtDonGia.Text);
                    int soLuong = int.Parse(txtSL.Text);
                    // Tiến hành thêm
                    bool f = balChiTietHD.ThemChiTietHDBanHang(ref err, txtMaHD.Text, txtSanPham.Text, donGia,soLuong);
                    if (f == true)
                    {
                        //MessageBox.Show("Đã thêm..." + err, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Sau khi thêm sẽ load chi tiết đơn nhập lên Gridcontrol để kiểm tra
                        loadCTHDNH();
                        txtTGT.Text = GiaTriHoaDon();


                    }
                    else
                        MessageBox.Show("Không thể thêm chi tiết đơn nhập!\rLỗi:" + err, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Không thể thêm chi tiết đơn nhập!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadChiTietHD();
            DonThongTinCTHD();
            gbThongTin.Enabled = false;
        }

        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            // Đặt lại biến bằng 0 để chuẩn bị tạo một hóa đơn nhập hàng mới 
            click_btn = 0;
            // Reset lại các textbox chuẩn bị nhập hóa đơn khác
            DonThongTinCTHD();
            DonThongTinHD();
            gridDSKH.DataSource = null;    
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            int distance;
            // nếu text box số lượng khác null
            if (!string.IsNullOrEmpty(txtSL.Text))
            {
                //nếu không phải là số
                if (!int.TryParse(txtSL.Text, out distance))
                {

                    labelTTSL.Text = "Hãy nhập số nguyên";
                    // cho label trạng thái nằm dưới text box đó màu đỏ
                    labelTTSL.ForeColor = Color.Red;

                }
                //kiểm tra số âm
                else if ((double.Parse(txtSL.Text) <= 0))
                {
                    labelTTSL.Text = "Hãy nhập số dương";
                    // cho label trạng thái nằm dưới text box đó màu đỏ
                    labelTTSL.ForeColor = Color.Red;
                }
                // nếu là số nguyên 
                else
                {
                    txtThanhTien.Text = (double.Parse(txtSL.Text) * double.Parse(txtDonGia.Text)).ToString();
                    labelTTSL.ForeColor = Color.Green;
               
                }
            }
            else
            {
                //label trạng thái không hiện gì
                labelTTSL.Text = "";
                labelTTSL.ForeColor = Color.Green;


            }
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            balHoaDon = new BAHoaDonBanHang();
            balChiTietHD = new BALChiTietHDBanHang();
            LoadLoaiSP();
            gbThongTin.Enabled = false;
            txtNhanVien.Text = "1";
        }

        private void gridSP_Click(object sender, EventArgs e)
        {
            int rowSelected1 = winExplorerView1.FocusedRowHandle;
            txtSanPham.Text = winExplorerView1.GetRowCellValue(rowSelected1, "MaSP").ToString();
            txtDonGia.Text = winExplorerView1.GetRowCellValue(rowSelected1, "GiaBanSP").ToString();
            txtSLTK.Text= winExplorerView1.GetRowCellValue(rowSelected1, "SoLuongTrongKho").ToString();
   
        }

        private void gridKH_Click(object sender, EventArgs e)
        {
            int rowSelected1 = gridView1.FocusedRowHandle;
            txtKH.Text = gridView1.GetRowCellValue(rowSelected1, "MaKH").ToString();
        }

        private void txtSanPham_TextChanged(object sender, EventArgs e)
        {
            //int rowSelected1 = winExplorerView1.FocusedRowHandle;
            //if (txtSanPham.Text != "")
            //{
            //    if (tabSP.Enabled == false)
            //    {

            //    }
            //    else
                  
            //}
        }
    }
}