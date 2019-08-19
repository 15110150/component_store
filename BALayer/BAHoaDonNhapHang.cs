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
    public class BAHoaDonNhapHang
    {
        DAl db = null;
        public BAHoaDonNhapHang()
        {
            db = new DAl();
        }
        public DataSet KiemTraMaDH(string MaDH)
        {
            return db.ExecuteQueryDataSetWithPra("spKiemTraMaHDNH", CommandType.StoredProcedure,
               new SqlParameter("@MaDH", MaDH));
        }
        public DataSet LayListHoaDonNhapHang()
        {
            return db.ExecuteQueryDataSet("spLayListHDNhapHang", CommandType.StoredProcedure, null);
        }


        public bool ThemHoaDonNhapHang(ref string error, string MaHD, string NguoiGiao, double TongTien, double DaTra, double ConNo, DateTime ThoiGian, string NhanVienId, string MaNCC)
        {
            return db.MyExecuteNonQuery("spTaoHoaDonNhap", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaDonNhap", MaHD),
                new SqlParameter("@ThoiGian", ThoiGian),
                new SqlParameter("@NhaCC", MaNCC),
                new SqlParameter("@NguoiGiao", NguoiGiao),
                 new SqlParameter("@NhanVienGiamSat", NhanVienId),
                new SqlParameter("@TongTien", TongTien)
                );
        }
        public bool XoaDonNhap(ref string error, string MaDonNhap)
        {
            return db.MyExecuteNonQuery("spXoaHoaDonNhap", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaDonNhap", MaDonNhap));
        }

        // Lấy giá trị HĐ nhập hàng
        public DataSet GiaTriDonNhap(string MaDonNhap)
        {
            return db.ExecuteQueryDataSetWithPra("spLayGiaTriHDNhap", CommandType.StoredProcedure, new SqlParameter("@MaDonNhap", MaDonNhap));

        }
        public bool CapNhatThanhToanHDNhap(ref string error, string MaHD, double DaThanhToan, double ChuaThanhToan)
        {
            return db.MyExecuteNonQuery("spCapNhatThanhToanHDNhap", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaHD", MaHD),
                new SqlParameter("@DaThanhToan", DaThanhToan),
                new SqlParameter("@ChuaThanhToan", ChuaThanhToan));
        }
        public DataSet KiemTraMaHDNhap(string MaHD)
        {
            return db.ExecuteQueryDataSetWithPra("spKiemTraMaHDNhap", CommandType.StoredProcedure, new SqlParameter("@MaHD", MaHD));
        }


    }

}
