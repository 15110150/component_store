using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALayer;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class BAHoaDonBanHang
    {
        DAl db = null;
        public BAHoaDonBanHang()
        {
            db = new DAl();
        }

        // Thêm một hóa đơn bán hàng
        public bool ThemHoaDonBanHang(ref string erro, string maHoaDon, DateTime ngayLapHD, string maKhachHang, string maNhanVien)
        {
            return db.MyExecuteNonQuery("spThemHoaDonBanHang", CommandType.StoredProcedure, ref erro,
                 new SqlParameter("@MaHD", maHoaDon),
                  new SqlParameter("@NgayLapHD", ngayLapHD),
                  new SqlParameter("@MaKH", maKhachHang),
                   new SqlParameter("@MaNV", maNhanVien)
                 );
        }
        // Xóa hóa đơn bán hàng
        public bool XoaHoaDonBanHang(ref string erro, string maHoaDon)
        {
            return db.MyExecuteNonQuery("spXoaHoaDonBanHang", CommandType.StoredProcedure, ref erro,
                new SqlParameter("@MaHD", maHoaDon));
        }

        // Lấy giá trị HĐ bán hàng
        public DataSet GiaTriDonBan(string maHoaDon)
        {

            return db.ExecuteQueryDataSetWithPra("spLayGiaTriHDBan", CommandType.StoredProcedure, new SqlParameter("@MaDon", maHoaDon));

        }
        ///
        public DataSet LayListHoaDonBanHang()
        {
            return db.ExecuteQueryDataSet("spLayListHoaDonBanHang", CommandType.StoredProcedure, null);
        }

        public DataSet KiemTraMaHDBan(string MaHD)
        {
            return db.ExecuteQueryDataSetWithPra("spKiemTraMaHDBan", CommandType.StoredProcedure, new SqlParameter("@MaHD", MaHD));
        }
        public DataSet LayHoaDonViewTheoDatetime(DateTime ThoiGian)
        {
            return db.ExecuteQueryDataSetWithPra("spLayHoaDonDateTime", CommandType.StoredProcedure,
               new SqlParameter("@ThoiGian", ThoiGian));
        }
        public DataSet LayHoaDonViewTheoDatetimevaMaKH(DateTime ThoiGian, string MaKH)
        {
            return db.ExecuteQueryDataSetWithPra("spLayHoaDonDateTimevaMaKH", CommandType.StoredProcedure,
               new SqlParameter("@ThoiGian", ThoiGian),
               new SqlParameter("@MaKH", MaKH));
        }
    }
}
