using DALayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
    public class BABaoHanh
    {
        DAl db = null;
        public BABaoHanh()
        {
            db = new DAl();
        }
        public bool ThemBaoHanh(ref string error, string SoPhieu, string MaKH, string MaSP, DateTime BatDau, DateTime KetThuc, string TinhTrang, string CachBH, int SoLanBH, string GhiChu)
        {
            return db.MyExecuteNonQuery("spThemBaoHanh", CommandType.StoredProcedure, ref error,
                new SqlParameter("@SoPhieu", SoPhieu),
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@MaSP", MaSP),
                new SqlParameter("@BatDau", BatDau),
                new SqlParameter("@KetThuc", KetThuc),
                new SqlParameter("@TinhTrang", TinhTrang),
                new SqlParameter("@CachBH", CachBH),
                new SqlParameter("@SoLanBH", SoLanBH),
                new SqlParameter("@GhiChu", GhiChu));
        }
        public DataSet DoMaBH(string MaBH)
        {
            return db.ExecuteQueryDataSetWithPra("spDoMaBH", CommandType.StoredProcedure,
                new SqlParameter("@MaBH", MaBH));

        }
        public DataSet LayListBaoHanh()
        {
            return db.ExecuteQueryDataSet("spLayListBaoHanh", CommandType.StoredProcedure, null);
        }
        public bool XoaBaoHanh(ref string error, string SoPhieu)
        {
            return db.MyExecuteNonQuery("spXoaBaoHanh", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaBH", SoPhieu));
        }
    }
}
