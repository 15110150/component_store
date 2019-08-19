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
    public partial class FormThongKeHoaDon : DevExpress.XtraEditors.XtraForm
    {
        BALChiTietHDBanHang balChiTietBanHang;
        BALChiTietNhap balChiTietNhap;
        BAHoaDonBanHang balHoaDonBanHang;
        BAHoaDonNhapHang balHoaDonNhapHang;
        public FormThongKeHoaDon()
        {
            InitializeComponent();
          
        }
        private void loadHoaDonNhap()
        {
            balChiTietNhap = new BALChiTietNhap();
            balHoaDonNhapHang = new BAHoaDonNhapHang();
            try
            {
                if (balHoaDonNhapHang.LayListHoaDonNhapHang().Tables[0].Rows.Count != 0)
                {
                    this.gridHDNhapHang.DataSource = balHoaDonNhapHang.LayListHoaDonNhapHang().Tables[0];
                    int rowSelected2 = gridView3.FocusedRowHandle;
                    txtMaHDNhap.Text = gridView3.GetRowCellValue(rowSelected2, "MaDonNhap").ToString();
                    dtTGNhapHang.EditValue = (DateTime)gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "ThoiGianNhapHang");
                    txtNCC.Text = gridView3.GetRowCellValue(rowSelected2, "NhaNCC").ToString();
                    txtNguoiGiao.Text = gridView3.GetRowCellValue(rowSelected2, "NguoiGiao").ToString();
                    txtNVGS.Text = gridView3.GetRowCellValue(rowSelected2, "NhanVienGiamSat").ToString();
                    txtThanhTien.Text= gridView3.GetRowCellValue(rowSelected2, "TongTien").ToString();
                    this.gridcTHDNhapHang.DataSource = balChiTietNhap.LayChiTietNhapTheoMaDon(txtMaHDNhap.Text).Tables[0];
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu chi tiết hóa đơn bán hàng được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu chi tiết hóa đơn bán hàng được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //HienThiChucNangCTHD(true);
            //HienThiHanhDongCTHD(false);
        }
        private void loadHoaDonBan()
        {
            balChiTietBanHang = new BALChiTietHDBanHang();
            balHoaDonBanHang = new BAHoaDonBanHang();
            try
            {
                if (balHoaDonBanHang.LayListHoaDonBanHang().Tables[0].Rows.Count != 0)
                {
                    this.gridHdBanHang.DataSource = balHoaDonBanHang.LayListHoaDonBanHang().Tables[0];
                    int rowSelected2 = gridView1.FocusedRowHandle;
                    txtMaHDBan.Text = gridView1.GetRowCellValue(rowSelected2, "MaHD").ToString();
                    dtNgayLapHD.EditValue = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayLapHD");
                    txtMaNV.Text = gridView1.GetRowCellValue(rowSelected2, "MaNV").ToString();
                    txtMaKH.Text = gridView1.GetRowCellValue(rowSelected2, "MaKH").ToString();
                    txtThanhTienBAn.Text = gridView1.GetRowCellValue(rowSelected2, "ThanhTien").ToString();
                    this.gridChiTietHDBanHang.DataSource = balChiTietBanHang.LayChiTietHDBanHangTheoMaHD(txtMaHDBan.Text).Tables[0];

                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu chi tiết hóa đơn bán hàng được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu chi tiết hóa đơn bán hàng được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //HienThiChucNangCTHD(true);
            //HienThiHanhDongCTHD(false);
        }
        private void FormThongKeHoaDon_Load(object sender, EventArgs e)
        {
            loadHoaDonBan();
            loadHoaDonNhap();
        }
        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
            int rowSelected2 = gridView1.FocusedRowHandle;
          
            txtMaHDBan.Text = gridView1.GetRowCellValue(rowSelected2, "MaHD").ToString();
            dtNgayLapHD.EditValue = (DateTime)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayLapHD");
            txtMaNV.Text = gridView1.GetRowCellValue(rowSelected2, "MaNV").ToString();
            txtMaKH.Text = gridView1.GetRowCellValue(rowSelected2, "MaKH").ToString();
            txtThanhTienBAn.Text = gridView1.GetRowCellValue(rowSelected2, "ThanhTien").ToString();
            this.gridChiTietHDBanHang.DataSource = balChiTietBanHang.LayChiTietHDBanHangTheoMaHD(txtMaHDBan.Text).Tables[0];
        }
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void gridControl2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
                        if (balHoaDonBanHang.XoaHoaDonBanHang(ref error, txtMaHDNhap.Text))
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
                    loadHoaDonBan();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridHDNhapHang_Click(object sender, EventArgs e)
        {
            int rowSelected2 = gridView3.FocusedRowHandle;

            txtMaHDNhap.Text = gridView3.GetRowCellValue(rowSelected2, "MaDonNhap").ToString();
            dtTGNhapHang.EditValue = (DateTime)gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "ThoiGianNhapHang");
            txtNCC.Text = gridView3.GetRowCellValue(rowSelected2, "NhaNCC").ToString();
            txtNguoiGiao.Text = gridView3.GetRowCellValue(rowSelected2, "NguoiGiao").ToString();
            txtNVGS.Text = gridView3.GetRowCellValue(rowSelected2, "NhanVienGiamSat").ToString();
            txtThanhTien.Text = gridView3.GetRowCellValue(rowSelected2, "TongTien").ToString();
            this.gridcTHDNhapHang.DataSource = balChiTietNhap.LayChiTietNhapTheoMaDon(txtMaHDNhap.Text).Tables[0];
        }

        private void btnXoaHDNhap_Click(object sender, EventArgs e)
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
                        if (balHoaDonNhapHang.XoaDonNhap(ref error, txtMaHDNhap.Text))
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
                    loadHoaDonNhap();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}