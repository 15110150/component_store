using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;

namespace BALayer
{
    public class BALChiTietHDBanHang
    {
        DAl db = null;
        public BALChiTietHDBanHang()
        {
            db = new DAl();
        }

        // Thêm chi tiết hóa đơn bán hàng 
        public bool ThemChiTietHDBanHang(ref string erro, string maHoaDon, string maSanPham, double donGia, int soLuong)
        {
            return db.MyExecuteNonQuery("spThemChiTietHDBanHang", CommandType.StoredProcedure, ref erro,
                new SqlParameter("@MaHD", maHoaDon),
                 new SqlParameter("@MaSP", maSanPham),
                 new SqlParameter("@DonGia", donGia),
                 new SqlParameter("@SoLuong", soLuong)
                );
        }

        // Xóa chi tiết hóa đơn bán hàng 
        public bool XoaChiTietHDBanHang(ref string erro, string maHoaDon, string maSanPham)
        {
            return db.MyExecuteNonQuery("spXoaChiTietHDBanHang", CommandType.StoredProcedure, ref erro,
                new SqlParameter("@MaHD", maHoaDon),
                 new SqlParameter("@MaSP", maSanPham)
                );
        }

        // Xóa chi tiết hóa đơn bán hàng theo mã hóa đơn
        public bool XoaChiTietHDBanHangTheoMaHD(ref string erro, string maHoaDon)
        {
            return db.MyExecuteNonQuery("spXoaChiTietHDBanHangTheoMa", CommandType.StoredProcedure, ref erro,
                new SqlParameter("@MaHD", maHoaDon));
        }

        // lấy chi tiết hóa đơn theo mã hóa đơn
        public DataSet LayChiTietHDBanHangTheoMaHD(string maHoaDon)
        {
            return db.ExecuteQueryDataSetWithPra("spLayChiTietHDBanHangTheoMa", CommandType.StoredProcedure,
                new SqlParameter("@MaHD", maHoaDon));
        }

    }
}
