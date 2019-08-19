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
    public class BAKhachHang
    {

        DAl db = null;
        public BAKhachHang()
        {
            db = new DAl();
        }
        public DataSet KiemTraMaKH(string MaKH)
        {
            return db.ExecuteQueryDataSetWithPra("spKiemTraMaKH", CommandType.StoredProcedure,
               new SqlParameter("@MaKH", MaKH));
        }
        public DataSet LayListKhachHang()
        {
            return db.ExecuteQueryDataSet("spLayListKhachHang", CommandType.StoredProcedure, null);
        }
        public DataSet LayHoaDonDaMua(string MaKH)
        {
            return db.ExecuteQueryDataSetWithPra("spLayListHoaDonKhachHang", CommandType.StoredProcedure,
                 new SqlParameter("@MaKH", MaKH));
        }
        public bool XoaKhachHang(ref string error, string MaKH)
        {
            return db.MyExecuteNonQuery("spXoaKhachHang", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaKH", MaKH));
        }
        public bool ThemKhachHang(ref string error, string MaKH, string TenKH, string SDT, string GhiChu, string DiaChi)
        {
            return db.MyExecuteNonQuery("spThemKhachHang", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaKH", MaKH),
                 new SqlParameter("@TenKH", TenKH),
                  new SqlParameter("@Sdt", SDT),
                     new SqlParameter("@DiaChi", DiaChi),
                         new SqlParameter("@GhiChu", GhiChu));
        }
      
        public bool CapNhatKhachHang(ref string error, string MaKH, string TenKH, string SDT, string GhiChu, string DiaChi)
        {
            return db.MyExecuteNonQuery("spCapNhatKhachHang", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaKH", MaKH),
                 new SqlParameter("@TenKH", TenKH),
                  new SqlParameter("@SDT", SDT),
                   new SqlParameter("@GhiChu", GhiChu),
                     new SqlParameter("@DiaChi", DiaChi));
        }
      
        public DataSet DoKH(string ThongTin)
        {
            return db.ExecuteQueryDataSetWithPra("spDoKH", CommandType.StoredProcedure,
                  new SqlParameter("@ThongTin", ThongTin));
        }
        public DataSet LayDSSPKHDaMua()
        {
            return db.ExecuteQueryDataSet("spLayListSPKHDaMua", CommandType.StoredProcedure,null);
        }

    }
    }
