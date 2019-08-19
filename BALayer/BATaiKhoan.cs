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
    public class BATaiKhoan
    {

        DAl db = null;
        public BATaiKhoan()
        {
            db = new DAl();
        }
        public DataSet DoTaiKhoan1(string user, string pass, string Quyen)
        {
            return db.ExecuteQueryDataSetWithPra("dbo.spDoTkQuyen", CommandType.StoredProcedure,
                new SqlParameter("@user", user),
                new SqlParameter("@pass", pass),
                new SqlParameter("@Quyen", Quyen));
        }
        public DataSet DoTaiKhoan2(string user, string pass)
        {
            return db.ExecuteQueryDataSetWithPra("spDoTK", CommandType.StoredProcedure,
                new SqlParameter("@user", user),
                new SqlParameter("@pass", pass));
        }
        public bool CapNhatMatKhau(ref string error, string user, string pass)
        {
            return db.MyExecuteNonQuery("spCapNhatMatKhau", CommandType.StoredProcedure, ref error,
                new SqlParameter("@user", user),
                new SqlParameter("@pass", pass));
        }
        public DataSet KiemTraTaiKhoan(string TaiKhoan)
        {
            return db.ExecuteQueryDataSetWithPra("spKiemTraTaiKhoan", CommandType.StoredProcedure,
               new SqlParameter("@TaiKhoan", TaiKhoan));
        }
        public bool ThemTaiKhoan(ref string error, string NhanVienId, string user, string pass, string Quyen)
        {
            return db.MyExecuteNonQuery("spThemTaiKhoan", CommandType.StoredProcedure, ref error,
                new SqlParameter("@TaiKhoan", NhanVienId),
                new SqlParameter("@MatKhau", user),
                new SqlParameter("@NhanVien", pass),
                new SqlParameter("@Quyen", Quyen));
        }

        public DataSet KiemTraTaiKhoanNV(string MaNV)
        {
            return db.ExecuteQueryDataSetWithPra("spKiemTraTaiKhoanNV", CommandType.StoredProcedure,
               new SqlParameter("@NhanVienId", MaNV));
        }
    }
}
