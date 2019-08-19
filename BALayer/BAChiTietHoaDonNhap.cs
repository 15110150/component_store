using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
using System.Data.SqlClient;
using System.Data;

namespace BALayer
{
    public class BALChiTietNhap
    {
        DAl db = null;
        public BALChiTietNhap()
        {
            db = new DAl();
        }

        // Thêm chi tiết đơn nhập
        public bool ThemChiTietNhap(ref string error, string MaDonNhap, string MaSP, int SoLuong, double DonGia, double TongTien)
        {
            return db.MyExecuteNonQuery("spTaoChiTietNhap", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaDonNhap", MaDonNhap),
                new SqlParameter("@MaSP", MaSP),
                new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@ThanhTien", TongTien)
                );
        }

        // Xóa chi tiết đơn nhập
        public bool XoaChiTietNhap(ref string error, string MaDonNhap, string MaSP)
        {
            return db.MyExecuteNonQuery("spXoaChiTietNhap", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaDonNhap", MaDonNhap),
                new SqlParameter("@MaSP", MaSP)
                );
        }

        // Lấy chi tiết nhập theo mã đơn nhập
        public DataSet LayChiTietNhapTheoMaDon(string MaDonNhap)
        {
            return db.ExecuteQueryDataSetWithPra("spLayChiTietNhapTheoMaHD", CommandType.StoredProcedure, new SqlParameter("@MaDonNhap", MaDonNhap));
        }

        // Lấy tất cả chi tiết nhập 
        public DataSet LayTatCaChiTietNhap()
        {
            return db.ExecuteQueryDataSet("spLayChiTietDonNhap", CommandType.StoredProcedure);
        }
        ///
        public bool XoaChiTietNhapTheoMaDonNhap(ref string error, string MaHD)
        {
            return db.MyExecuteNonQuery("spXoaChiTietDonNhapTheoMaDonNhap", CommandType.StoredProcedure, ref error, new SqlParameter("@MaHD", MaHD));
        }
    }
}
