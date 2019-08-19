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

namespace LinhKien
{
    public partial class FormChuCuaHang : DevExpress.XtraEditors.XtraForm
    {
        public FormChuCuaHang()
        {
            InitializeComponent();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            FormQuanLyTKNV form = new FormQuanLyTKNV();
            form.Show();
        }

        private void tlDoiMK_ItemClick(object sender, TileItemEventArgs e)
        {
            FormDoiMK form = new FormDoiMK();
            form.Show();
        }

        private void tlThoat_ItemClick(object sender, TileItemEventArgs e)
        {
            Application.Exit();
        }

        private void tlNhaCC_ItemClick(object sender, TileItemEventArgs e)
        {
            FormNhaCungCap form = new FormNhaCungCap();
            form.Show();
        }

        private void tlSP_ItemClick(object sender, TileItemEventArgs e)
        {
            FormLoaiSP form = new FormLoaiSP();
            form.Show();
        }

        private void tlKH_ItemClick(object sender, TileItemEventArgs e)
        {
            FormKhachHang form = new FormKhachHang();
            form.Show();
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            FormNhanVIen form = new FormNhanVIen();
            form.Show();
        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            FormThongKeHoaDon frm = new FormThongKeHoaDon();
            frm.Show();
        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {
            FormThongKeDanhThuvaChiPhi frm = new FormThongKeDanhThuvaChiPhi();
            frm.Show();
        }

        private void tileItem12_ItemClick(object sender, TileItemEventArgs e)
        {
            FormBanHang form = new FormBanHang();
            form.Show();
        }

        private void tlLoaiSP_ItemClick(object sender, TileItemEventArgs e)
        {
            FormSanPham frm = new FormSanPham();
            frm.Show();
        }

        private void tlNhanVien_ItemClick(object sender, TileItemEventArgs e)
        {
            FormNhanVIen form = new FormNhanVIen();
            form.Show();
        }

        private void tlNhapHang_ItemClick(object sender, TileItemEventArgs e)
        {
            FromNhapHang form = new FromNhapHang();
            form.Show();
        }

        private void tlCongNo_ItemClick(object sender, TileItemEventArgs e)
        {
            FormThanhToanCongNo frm = new FormThanhToanCongNo();
            frm.Show();
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            FormThongKeSoLuongSpBanRa frm = new FormThongKeSoLuongSpBanRa();
            frm.Show();
        }

        private void tileItem11_ItemClick(object sender, TileItemEventArgs e)
        {
            FormBaoHanh frm = new FormBaoHanh();
            frm.Show();
        }
    }
}