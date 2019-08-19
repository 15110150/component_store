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
    public class BALoaiSP
    {
        DAl db = null;
        public BALoaiSP()
        {
            db = new DAl();
        }
        public DataSet LayListLoaiSanPham()
        {
            return db.ExecuteQueryDataSet("spLayListLoaiSanPham", CommandType.StoredProcedure, null);
        }
        public bool XoaLoaiSP(ref string error, string MaLoaiSp)
        {
            return db.MyExecuteNonQuery("spXoaLoaiSP", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaLoaiSp", MaLoaiSp));
        }
        public DataSet DoMaLoaiSP(string MaLoaiSp)
        {
            return db.ExecuteQueryDataSetWithPra("spDoMaLoaiSp", CommandType.StoredProcedure,
                new SqlParameter("@MaLoaiSp", MaLoaiSp));
        }
        public bool ThemLoaiSp(ref string error, string MaLoaiSp, string TenLoai)
        {
            return db.MyExecuteNonQuery("spThemLoaiSp", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaLoai", MaLoaiSp),
                new SqlParameter("@TenLoaiSP", TenLoai));
        }
        public bool CapNhatLoaiSp(ref string error, string MaLoaiSp, string TenLoai)
        {
            return db.MyExecuteNonQuery("spCapNhatLoaiSp", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaLoaiSp", MaLoaiSp),
                new SqlParameter("@TenLoai", TenLoai));
        }
    }
}
