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
    public partial class FormBaoHanh : DevExpress.XtraEditors.XtraForm
    {
        BAKhachHang balKhachHang;
        BABaoHanh balBaoHanh;
        BAHoaDonBanHang balHDBH;
        public FormBaoHanh()
        { 
            InitializeComponent();
            balBaoHanh = new BABaoHanh();
            balHDBH = new BAHoaDonBanHang();
        }
        private void LoadDanhSachSanPhamKHMua()
        {
            balKhachHang = new BAKhachHang();
            try
            {
                if (balKhachHang.LayDSSPKHDaMua().Tables[0].Rows.Count != 0)
                {
                    this.dgvDsSpKhMua.DataSource = balKhachHang.LayDSSPKHDaMua().Tables[0];
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadDanhSachBaoHanh()
        {
            balBaoHanh = new BABaoHanh();
            try
            {
                if (balBaoHanh.LayListBaoHanh().Tables[0].Rows.Count != 0)
                {
                    this.dgvBaoHanh.DataSource = balBaoHanh.LayListBaoHanh().Tables[0];
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void DonThongTin()
        {
            txtMaPhieu.ResetText();
            txtGhiChu.ResetText();
            txtCachBH.ResetText();
            txtTinhTrang.ResetText();
            txtSP.ResetText();
            txtKH.ResetText();
        }
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormBaoHanh_Load(object sender, EventArgs e)
        {
            dtTGTK.EditValue = DateTime.Now;
            LoadDanhSachSanPhamKHMua();
            LoadDanhSachBaoHanh();
        }

        private void dgvDsSpKhMua_Click(object sender, EventArgs e)
        {
            int rowSelected = gridView1.FocusedRowHandle;
            txtKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
            txtSP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSP").ToString();

            string TGBaoHanh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BaoHanh").ToString();
            int month = int.Parse(TGBaoHanh.Remove(2));
            //lấy thơi gian bắt đầu bảo hành từ ngày bán
            dateBatDau.Value = DateTime.Now;
            DateTime batDau = DateTime.Now;
            //thời gian kết thúc = tháng bán cộng với sô tháng bảo hành
            DateTime ketThuc = batDau.AddMonths(month);
            dateKetThuc.Value = ketThuc;
        }

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                //khi nhập mã đơn hàng vào ô mã đơn hàng mới thì cũng kiểm tra sự tồn tại của mã đơn hàng trong csdl

                if (string.IsNullOrEmpty(txtMaPhieu.Text))
                {
                    lbTTMaBH.Text = "";
                    lbTTMaBH.ForeColor = Color.Green;
                }
                else if (balBaoHanh.DoMaBH(this.txtMaPhieu.Text).Tables[0].Rows.Count != 0)
                {
                    //nếu mã hóa đơn đã có
                    this.lbTTMaBH.Text = "Ma hoa don da co";
                    // cho label trạng thái nằm dưới text box đó màu đỏ
                    this.lbTTMaBH.ForeColor = Color.Red;
                }
                else
                {
                    //nếu chưua bị trùng
                    this.lbTTMaBH.Text = "Mã hóa đơn sẵn sàng";
                    // cho label trạng thái nam29 dưới text box đó màu xanh
                    this.lbTTMaBH.ForeColor = Color.Green;
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu phiếu bảo hành được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu phiếu bảo hành được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHủy_Click(object sender, EventArgs e)
        {
            DonThongTin();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieu.Text))
            {
                MessageBox.Show("Mã bảo hành chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (balBaoHanh.DoMaBH(this.txtMaPhieu.Text).Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Mã bảo hành đã có", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string error = "";
                    string TGBaoHanh = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "BaoHanh").ToString();
                    int month = int.Parse(TGBaoHanh.Remove(2));
                    //lấy thơi gian bắt đầu bảo hành từ ngày bán
                    DateTime batDau = DateTime.Now;
                    //thời gian kết thúc = tháng bán cộng với sô tháng bảo hành
                    DateTime ketThuc = batDau.AddMonths(month);
                    try
                    {
                        if (balBaoHanh.ThemBaoHanh(ref error,txtMaPhieu.Text, txtKH.Text, txtSP.Text,batDau, ketThuc,
                                       txtTinhTrang.Text,txtCachBH.Text, 0, txtGhiChu.Text))
                        {
                            MessageBox.Show("thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DonThongTin();
                            LoadDanhSachBaoHanh();
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin bảo hành này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tl == DialogResult.OK)
            {
                string MaBaoHanh = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "SoPhieu").ToString();
                string error = "";
                try
                {
                    //Xoa record khoi CSDL
                    if (balBaoHanh.XoaBaoHanh(ref error, MaBaoHanh))
                    {
                        //khi thành công
                        MessageBox.Show("Xóa thông tin Bảo hành khỏi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachBaoHanh();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: " + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Xóa thông tin Bảo hành khỏi dữ liệu không thành công!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTKMKH_TextChanged(object sender, EventArgs e)
        {
           // this.dgvDsSpKhMua.DataSource = balHDBH.LayHoaDonViewTheoDatetimevaMaKH(dtTGTK.DateTime, txtTKMKH.Text).Tables[0];
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTKMKH.Text))
                this.dgvDsSpKhMua.DataSource = balHDBH.LayHoaDonViewTheoDatetimevaMaKH(dtTGTK.DateTime, txtTKMKH.Text).Tables[0];
            else
                this.dgvDsSpKhMua.DataSource = balHDBH.LayHoaDonViewTheoDatetime(dtTGTK.DateTime).Tables[0];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDanhSachSanPhamKHMua();
        }
    }
}