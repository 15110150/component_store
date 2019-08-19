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
    public partial class FromNhapHang : DevExpress.XtraEditors.XtraForm
    {
        int a ;
        BaNhaCungCap balNhaCC;
        BASanPham balSanPham;
        BAHoaDonNhapHang balHDNhapHang;
        BALChiTietNhap balChiTietNhap;
        //MemoryStream ms;
        // Biến đếm số lần click buttion thêm hàng, nếu là 0 (lần đầu click) thì tạo mới hóa đơn nhập
        int click_btn = 0;
        public FromNhapHang()
        {

            InitializeComponent();
            //balHDNhapHang = new BAHoaDonNhapHang();
            balChiTietNhap = new BALChiTietNhap();
           
        }
        private void LoadNhaCC()
        {
            balNhaCC = new BaNhaCungCap();
            try
            {
                if (balNhaCC.LayListNhaCungCap().Tables[0].Rows.Count != 0)
                {

                    //load nhà cung cấp vào combobox nhà cung cấp
                    DataTable dtNCC = balNhaCC.LayListNhaCungCap().Tables[0];
                    this.cbbNCC.DataSource = dtNCC;
                    this.cbbNCC.ValueMember = "MaNCC";
                    this.cbbNCC.DisplayMember = "TenNCC";
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
        private void LoadSanPham()
        {
            balSanPham = new BASanPham();
            try
            {
                //load danh sách sản phẩm lên gridcontrol
                this.gridSP.DataSource = balSanPham.LayListSPNCC(cbbNCC.SelectedValue.ToString()).Tables[0];
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
        private void loadCTHDNH()
        {
            balChiTietNhap = new BALChiTietNhap();
          try
            {
                if (balChiTietNhap.LayChiTietNhapTheoMaDon(gridView1.GetRowCellValue(a, "MaDonNhap").ToString()).Tables[0].Rows.Count != 0)
                {
                    this.gridCTHDNH.DataSource = balChiTietNhap.LayChiTietNhapTheoMaDon(gridView1.GetRowCellValue(a, "MaDonNhap").ToString()).Tables[0];
                    //int rowSelected2 = gridView2.FocusedRowHandle;
                    //txtSP.Text = gridView2.GetRowCellValue(rowSelected2, "MaSP").ToString();
                    //txtSL.Text = gridView2.GetRowCellValue(rowSelected2, "DonGia").ToString();
                    //txtSL.Text = gridView2.GetRowCellValue(rowSelected2, "SoLuong").ToString();
                    //txtTT.Text = gridView2.GetRowCellValue(rowSelected2, "ThanhTien").ToString();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu chi tiết hóa đơn nhập hàng được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu chi tiết hóa đơn nhập hàng được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //HienThiChucNangCTHD(true);
            //HienThiHanhDongCTHD(false);

        }
        private void loadHDNH()
        {
            a = gridView1.FocusedRowHandle;
            txtMaHD.Text = gridView1.GetRowCellValue(a, "MaDonNhap").ToString();
            txtNVGH.Text = gridView1.GetRowCellValue(a, "NguoiGiao").ToString();
            txtNVNH.Text = gridView1.GetRowCellValue(a, "NhanVienGiamSat").ToString();
            LoadNhaCC();
            DataRow dtr = this.gridView1.GetDataRow(a);
            if (dtr[2] != null)
                cbbNCC.SelectedValue = gridView1.GetRowCellValue(a, "NhaNCC").ToString();
            else
                cbbNCC.Text = "Select Nhà CC";
            txtTGT.Text = gridView1.GetRowCellValue(a, "TongTien").ToString();
        }
        private void LoadHoaDonNhapHang()
        {
            balHDNhapHang = new BAHoaDonNhapHang();
            try
            {
                if (balHDNhapHang.LayListHoaDonNhapHang().Tables[0].Rows.Count != 0)
                {
                    this.gridHDNH.DataSource = balHDNhapHang.LayListHoaDonNhapHang().Tables[0];
                    //loadHDNH();
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
            //HienThiChucNangHD(true);
            //HienThiHanhDongHD(false);
        }
        private void FromNhapHang_Load(object sender, EventArgs e)
        {
            groupSP.Enabled = false;
            LoadNhaCC();
            LoadSanPham();
            LoadHoaDonNhapHang();
            //HienThiChucNangCTHD(true);
            //HienThiChucNangHD(true);
            //HienThiHanhDongCTHD(false);
            //HienThiHanhDongHD(false);
            txtNVNH.Text = "1";
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            groupSP.Enabled = true;
            LoadSanPham();
        }
        private void gridSP_Click(object sender, EventArgs e)
        {
            int rowSelected1 = winExplorerView1.FocusedRowHandle;
            txtSP.Text = winExplorerView1.GetRowCellValue(rowSelected1, "MaSP").ToString(); 

        }
        private void gridHDNH_Click(object sender, EventArgs e)
        {
            loadHDNH();
            loadCTHDNH();
        }
        private void HienThiChucNangHD(bool f)
        {
            btnThemHD.Enabled = f;
            btnXoaHD.Enabled = f;
        }
        private void HienThiHanhDongHD(bool f)
        {
           btnHuyHd.Enabled = f;
           btnLuuHD.Enabled = f;
        }
        private void DonThongTinHD()
        {
            txtMaHD.ResetText();
            txtNVGH.ResetText();
            txtNVNH.ResetText();
            txtTGT.ResetText();
            txtThanhToan.ResetText();
            txtConThieu.ResetText();
            //txtConThieu.Text = "0";
            //txtThanhToan.Text = "0";
            //txtTGT.Text = "0";
            //txtSL.Text = "1";
        }
        private void HienThiChucNangCTHD(bool f)
        {
            btnXoaHang.Enabled = f;

        }
        private void HienThiHanhDongCTHD(bool f)
        {
            btnLuu.Enabled = f;
        }
        private void DonThongTinCTHD()
        {
            txtSP.ResetText();
            txtSL.ResetText();
            txtDG.ResetText();
            txtTT.ResetText();
        }
        private void HienThiThongTin(bool f)
        {
            txtMaHD.Enabled = f;
            cbbNCC.Enabled = f;
            txtNVGH.Enabled = f;
            txtThanhToan.Enabled = f;
        }
        private void HienThiThongTinCTHD(bool f)
        {
            txtSL.Enabled = f;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            this.gridSP.DataSource = balSanPham.DoSP(txtTimKiem.Text).Tables[0];
        }
        private void btnThemHang_Click(object sender, EventArgs e)
        {
           // DonThongTinCTHD();
        }
        public string GiaTriHoaDon()
        {
            try
            {
                DataTable dt = balHDNhapHang.GiaTriDonNhap(txtMaHD.Text).Tables[0];

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
        private void btnXoaHang_Click(object sender, EventArgs e)
        {

            DonThongTinCTHD();
            //string err = "";
            //try
            //{
            //    bool f = balChiTietNhap.XoaChiTietNhap(ref err, txtMaHD.Text, txtSP.Text);
            //    if (f == true)
            //        MessageBox.Show("Đã xóa...", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    else
            //        MessageBox.Show("Không xóa được..." + err, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    //
            //    txtTGT.Text = GiaTriHoaDon();
            //    txtTT.ResetText();
            //    txtSL.ResetText();
            //    txtDG.ResetText();

            //    // Load lại grid control
            //    loadCTHDNH();

            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show("Không thể xóa chi tiết đơn nhập!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void btnHoantat_Click(object sender, EventArgs e)
        {
            // Nếu click lần đầu thì tạo hóa đơn nhập mới
            // Tạo mã hóa đơn nhập
            if (click_btn == 0)
            {
                if (lbMaHD.ForeColor == Color.Red)
                {
                    MessageBox.Show("Mả hóa đơn này đã có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (labelTTSL.ForeColor == Color.Red)
                {
                    MessageBox.Show("Hãy nhập 1 số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (txtSL.Text == string.Empty || txtNVNH.Text == string.Empty)
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

                        string error = "";
                        try
                        {
                            // Tạo mới hóa đơn nhập hàng
                            if (balHDNhapHang.ThemHoaDonNhapHang(ref error, txtMaHD.Text, txtNVGH.Text, 0, 0, 0, DateTime.Now, "1", cbbNCC.SelectedValue.ToString()))
                            {
                                try
                                {
                                    double donGia = Double.Parse(txtDG.Text);
                                    int soLuong = int.Parse(txtSL.Text);
                                    // Tiến hành thêm
                                    bool f = balChiTietNhap.ThemChiTietNhap(ref error, txtMaHD.Text, txtSP.Text, soLuong, donGia, 0);
                                    if (f == true)
                                    {
                                        //MessageBox.Show("Đã thêm..." + err, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Sau khi thêm sẽ load chi tiết đơn nhập lên Gridcontrol để kiểm tra
                                        loadCTHDNH();
                                        txtTGT.Text = GiaTriHoaDon();


                                    }
                                    else
                                        MessageBox.Show("Không thể thêm chi tiết đơn nhập!\rLỗi:" + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                catch (Exception er)
                                {
                                    MessageBox.Show("Không thể thêm chi tiết đơn nhập!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Lỗi thêm đơn nhập hàng.\rLỗi: " + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            //
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Không thể thêm đơn nhập hàng mới.\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    double donGia = Double.Parse(txtDG.Text);
                    int soLuong = int.Parse(txtSL.Text);
                    // Tiến hành thêm
                    bool f = balChiTietNhap.ThemChiTietNhap(ref err, txtMaHD.Text, txtSP.Text, soLuong, donGia, 0);
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
            DonThongTinCTHD();
        }
        private void btnHuyHang_Click(object sender, EventArgs e)
        {

        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa hóa đơn này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    string error = "";
                    try
                    {
                        if (balHDNhapHang.XoaDonNhap(ref error, gridView1.GetRowCellValue(a, "MaDonNhap").ToString()))
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
                    LoadHoaDonNhapHang();
                    loadCTHDNH();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
        private void gridCTHDNH_Click(object sender, EventArgs e)
        {
            loadCTHDNH();
        }
        private void btnHuyHd_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                //xóa hết các chi tiết hóa đơn của hóa đơn đó
                if (balChiTietNhap.XoaChiTietNhapTheoMaDonNhap(ref err, txtMaHD.Text))
                {
                    //khi thành công thì xóa đơn nhập
                    try
                    {
                        // Xóa hóa đơn nhập
                        if (balHDNhapHang.XoaDonNhap(ref err, txtMaHD.Text))
                        {
                            //xóa thành công
                            DonThongTinCTHD();
                            DonThongTinHD();
                            groupSP.Enabled = false;
                            MessageBox.Show("Đã hủy đơn nhập...", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                            MessageBox.Show("Không thể xóa đơn nhập!!!! \rLỗi:" + err, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            string error = "";
            try
            {

                if (lbTTThanhToan.ForeColor == Color.Red)
                {
                    MessageBox.Show("Nhập lại số tiền thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               else  if (this.txtConThieu.Text != "0")
                    {
                        error = "";
                        try
                        {
                            double CongNo = double.Parse(balNhaCC.LayCongNoNCC(this.cbbNCC.SelectedValue.ToString()).Tables[0].Rows[0][0].ToString());
                            double NewCongNo = CongNo + double.Parse(this.txtConThieu.Text);

                            try
                            {
                                if (balNhaCC.CapNhatCongNoNCC(ref error, this.cbbNCC.SelectedValue.ToString(), NewCongNo, DateTime.Now.Date))
                                {
                  
                                    // Đặt lại biến bằng 0 để chuẩn bị tạo một hóa đơn nhập hàng mới 
                                    click_btn = 0;
                                    // Reset lại các textbox chuẩn bị nhập hóa đơn khác
                                    DonThongTinCTHD();
                                    DonThongTinHD();
                                    MessageBox.Show("Hoàn tất hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Lỗi cập nhật công nợ vào dữ liệu nhà cung cấp\rLỗi: " + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception er)
                            {
                                MessageBox.Show("Lỗi cập nhật công nợ vào dữ liệu nhà cung cấp.\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (SqlException err)
                        {
                            MessageBox.Show("Không lấy được số tiền công nợ của nhà cung cấp.\rLỗi: " + err, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                       
                        // Đặt lại biến bằng 0 để chuẩn bị tạo một hóa đơn nhập hàng mới 
                        click_btn = 0;
                        // Reset lại các textbox chuẩn bị nhập hóa đơn khác
                        DonThongTinCTHD();
                        DonThongTinHD();
                    groupSP.Enabled = false;
                        MessageBox.Show("Hoàn tất hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
           
                //else
                //{
                //    MessageBox.Show("Lỗi cập nhật tiền thanh toán hóa đơn nhập hàng vào dữ liệu.\rLỗi: " + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception er)
            {
                MessageBox.Show("Cập nhật tiền thanh toán hóa đơn nhập hàng vào dữ liệu không thành công.\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadHoaDonNhapHang();

        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            DonThongTinCTHD();
            DonThongTinHD();
        }
        private void txtSP_TextChanged(object sender, EventArgs e)
        {
            int rowSelected1 = winExplorerView1.FocusedRowHandle;
            if (txtSP.Text != "")
            {
               if(groupSP.Enabled==false)
                {
                   
                }
               else
                txtDG.Text = winExplorerView1.GetRowCellValue(rowSelected1, "GiaBanSP").ToString();
            }
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
                    if (groupSP.Enabled == true)
                    {
                        txtTT.Text = (double.Parse(txtSL.Text) * double.Parse(txtDG.Text)).ToString();
                        labelTTSL.ForeColor = Color.Green;
                    }
                }
            }
            else
            {
                //label trạng thái không hiện gì
                labelTTSL.Text = "";
                labelTTSL.ForeColor = Color.Green;


            }
        }
        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            int distance;
            // nếu text box số lượng khác null
            if (!string.IsNullOrEmpty(txtThanhToan.Text))
            {
                //nếu không phải là số
                if (!int.TryParse(txtThanhToan.Text, out distance))
                {

                    lbTTThanhToan.Text = "Hãy nhập số nguyên";
                    // cho label trạng thái nằm dưới text box đó màu đỏ
                    lbTTThanhToan.ForeColor = Color.Red;

                }
                //kiểm tra số âm
                else if ((double.Parse(txtThanhToan.Text) <= 0))
                {
                    lbTTThanhToan.Text = "Hãy nhập số dương";
                    // cho label trạng thái nằm dưới text box đó màu đỏ
                    lbTTThanhToan.ForeColor = Color.Red;
                }
                // nếu là số nguyên 
                else
                {
                    txtConThieu.Text = (double.Parse(txtTGT.Text) - double.Parse(txtThanhToan.Text)).ToString();
                    lbTTThanhToan.ForeColor = Color.Green;
                }
            }
            else
            {
                //label trạng thái không hiện gì
                lbTTThanhToan.Text = "";
                lbTTThanhToan.ForeColor = Color.Green;


            }
           // txtConThieu.Text= (double.Parse(txtTGT.Text) - double.Parse(txtThanhToan.Text)).ToString();
        }
        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //khi nhập mã đơn hàng vào ô mã đơn hàng mới thì cũng kiểm tra sự tồn tại của mã đơn hàng trong csdl
                if (string.IsNullOrEmpty(txtMaHD.Text))
                {
                    lbMaHD.Text = "";
                    lbMaHD.ForeColor = Color.Green;
                }
                else if (balHDNhapHang.KiemTraMaDH(this.txtMaHD.Text).Tables[0].Rows.Count != 0)
                {
                    //nếu mã hóa đơn đã có
                    this.lbMaHD.Text = "Ma hoa don da co";
                    // cho label trạng thái nằm dưới text box đó màu đỏ
                    this.lbMaHD.ForeColor = Color.Red;
                }
                else
                {
                    //nếu chưua bị trùng
                    this.lbMaHD.Text = "Mã hóa đơn sẵn sàng";
                    // cho label trạng thái nam29 dưới text box đó màu xanh
                    string d = txtMaHD.Text;
                    this.lbMaHD.ForeColor = Color.Green;
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu hóa dơn nhập hàng được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu hóa dơn nhập hàng được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void groupThongTinTT_Paint(object sender, PaintEventArgs e)
        {

        }
        private void gridHDNH_Click_1(object sender, EventArgs e)
        {
            a = gridView1.FocusedRowHandle;
            loadCTHDNH();
        }
        private void btnEditNCC_Click(object sender, EventArgs e)
        {
            FormNhaCungCap from = new FormNhaCungCap();
            from.Show();
        }
        private void btnEditSP_Click(object sender, EventArgs e)
        {
            FormSanPham form = new FormSanPham();
            form.Show();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadNhaCC();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }
    }
}