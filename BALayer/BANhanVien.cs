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
    public class BANhanVien
    {

        DAl db = null;
        public BANhanVien()
        {
            db = new DAl();
        }
        public DataSet KiemTraMaNV(string MaNV)
        {
            return db.ExecuteQueryDataSetWithPra("spKiemTraMaNV", CommandType.StoredProcedure,
               new SqlParameter("@MaNV", MaNV));
        }
        public DataSet LayListNhanVien()
        {
            return db.ExecuteQueryDataSet("spLayListNhanVien", CommandType.StoredProcedure, null);
        }
        public bool ThemNhanVienWithImage(ref string error, string NhanVienId, string TenNV, DateTime Birthday, string Address, string SDT
            , byte[] photo, double luong, string email)
        {
            return db.MyExecuteNonQuery("spThemNhanVienWithImage", CommandType.StoredProcedure, ref error,
                new SqlParameter("@NhanVienId", NhanVienId),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@Birthday", Birthday),
                new SqlParameter("@Address", Address),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@photo", photo),
                new SqlParameter("@luong", luong),
                new SqlParameter("@email", email));
        }
        public bool ThemNhanVienNotImage(ref string error, string NhanVienId, string TenNV, DateTime Birthday, string Address, string SDT
            , double luong, string email)
        {
            return db.MyExecuteNonQuery("spThemNhanVienNotImage", CommandType.StoredProcedure, ref error,
                 new SqlParameter("@NhanVienId", NhanVienId),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@Birthday", Birthday),
                new SqlParameter("@Address", Address),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@luong", luong),
                new SqlParameter("@email", email));
        }
        public bool CapNhatNhanVienWithImage(ref string error, string NhanVienId, string TenNV,DateTime Birthday, string Address, string SDT
            , byte[] photo, double luong, string email)
        {
            return db.MyExecuteNonQuery("spCapNhatNhanVienWithImage", CommandType.StoredProcedure, ref error,
                 new SqlParameter("@NhanVienId", NhanVienId),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@Birthday", Birthday),
                new SqlParameter("@Address", Address),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@photo", photo),
                new SqlParameter("@luong", luong),
                new SqlParameter("@email", email));
        }
        public bool CapNhatNhanVienNotImage(ref string error, string NhanVienId, string TenNV, DateTime Birthday, string Address, string SDT
              , double luong, string email)
        {
            return db.MyExecuteNonQuery("spCapNhatNhanVienNotImage", CommandType.StoredProcedure, ref error,
             new SqlParameter("@NhanVienId", NhanVienId),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@Birthday", Birthday),
                new SqlParameter("@Address", Address),
                new SqlParameter("@SDT", SDT),
                new SqlParameter("@luong", luong),
                new SqlParameter("@email", email));
        }
        public DataSet DoNhanVienAll(string ThongTin)
        {
            return db.ExecuteQueryDataSetWithPra("spDoNhanVien", CommandType.StoredProcedure,
                  new SqlParameter("@ThongTin",ThongTin));
        }
        
        public bool XoaNV(ref string error, string MaNV)
        {
            return db.MyExecuteNonQuery("spXoaNV", CommandType.StoredProcedure, ref error,
                new SqlParameter("@NhanVienId", MaNV));
        }
        public DataSet LayListNhanVienKhongTK()
        {
            return db.ExecuteQueryDataSet("spLayListNhanVienKhongTK", CommandType.StoredProcedure, null);
        }
    }
}
