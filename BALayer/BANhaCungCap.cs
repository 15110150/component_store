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
    public class BaNhaCungCap
    {
        DAl db = null;
        public BaNhaCungCap()
        {
            db = new DAl();
        }
        public DataSet LayListNhaCungCap()
        {
            return db.ExecuteQueryDataSet("spLayListNhaCC", CommandType.StoredProcedure, null);
        }
        public bool XoaNCC(ref string error, string MaNCC)
        {
            return db.MyExecuteNonQuery("spXoaNCC", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaNCC", MaNCC));
        }
        public bool ThemNhaCungCap(ref string error, string MaNCC, string TenNCC, string Phone, string DiaChi, string Email, bool TrangThaiHopTac, string GhiChu)
        {
            return db.MyExecuteNonQuery("spThemNhaCC", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@TenNCC", TenNCC),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email),
                new SqlParameter("@TinhTrangHopTac", TrangThaiHopTac),
                new SqlParameter("@GhiChu", GhiChu)
                );
        }
        public bool CapNhatNhaCungCap(ref string error, string MaNCC, string TenNCC, string Phone, string DiaChi, string Email, bool TinhTrangHopTac, string GhiChu)
        {
            return db.MyExecuteNonQuery("spCapNhatNhaCC", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@TenNCC", TenNCC),
                new SqlParameter("@Phone", Phone),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email),
                new SqlParameter("@TinhTrangHopTac", TinhTrangHopTac),
                new SqlParameter("@GhiChu", GhiChu)
                );
        }
        public DataSet KiemTraMaNCC(string MaNCC)
        {
            return db.ExecuteQueryDataSetWithPra("spKiemTraMaNCC", CommandType.StoredProcedure,
               new SqlParameter("@MaNCC", MaNCC));
        }
        public DataSet DoNCC(string ThongTin)
        {
            return db.ExecuteQueryDataSetWithPra("spDoNCC", CommandType.StoredProcedure,
                  new SqlParameter("@ThongTin", ThongTin));
        }
        public DataSet DoSDT(string SDT)
        {
            return db.ExecuteQueryDataSetWithPra("spDoSDT_NCC", CommandType.StoredProcedure,
                  new SqlParameter("@SDT", SDT));
        }
        public DataSet DoEmail(string Email)
        {
            return db.ExecuteQueryDataSetWithPra("spDoEmail_NCC", CommandType.StoredProcedure,
                  new SqlParameter("@Email", Email));
        }
        public DataSet DoTenNCC(string TenNCC)
        {
            return db.ExecuteQueryDataSetWithPra("spDoTen_NCC", CommandType.StoredProcedure,
                  new SqlParameter("@TenNCC", TenNCC));
        }
        public bool CapNhatCongNoNCC(ref string error, string MaNCC, double CongNo, DateTime ThoiGianCapNhat)
        {
            return db.MyExecuteNonQuery("spCapNhatCongNoNCC", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@CongNo", CongNo),
                new SqlParameter("@ThoiGianCapNhat", ThoiGianCapNhat));
        }
        public DataSet LayCongNoNCC(string MaNCC)
        {
            return db.ExecuteQueryDataSetWithPra("spLayCongNoNCC", CommandType.StoredProcedure, new SqlParameter("@MaNCC", MaNCC));
        }

    }
}
