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
    public class BACongNo
    {
        DAl db = null;
        public BACongNo()
        {
            db = new DAl();
        }
        public DataSet LayListThanhToanCN()
        {
            return db.ExecuteQueryDataSet("spLayListThanhToanCongNo", CommandType.StoredProcedure, null);
        }
        public DataSet KiemTraMaThahHToan(string MaThanhToan)
        {
            return db.ExecuteQueryDataSetWithPra("spKiemTraMaThanhToan", CommandType.StoredProcedure, new SqlParameter("@MaThanhToan", MaThanhToan));
        }
        public bool ThemThanhToan(ref string error, string MaThanhToan, string MaNCC, DateTime ThoiGian, string NguoiNhan, string MaNV, double CongNo, double TienThanhToan)
        {
            return db.MyExecuteNonQuery("spThemThanhToan", CommandType.StoredProcedure, ref error,
                new SqlParameter("MaThanhToan", MaThanhToan),
                new SqlParameter("MaNCC", MaNCC),
                new SqlParameter("ThoiGian", ThoiGian),
                new SqlParameter("NguoiNhan", NguoiNhan),
                new SqlParameter("MaNV", MaNV),
                new SqlParameter("CongNo", CongNo),
                new SqlParameter("TienThanhToan", TienThanhToan)
                );
        }
      
        public bool XoaThanhToan(ref string error, string MaThanhToan)
        {
            return db.MyExecuteNonQuery("spXoaThanhToan", CommandType.StoredProcedure, ref error, new SqlParameter("MaThanhToan", MaThanhToan));
        }
    }
}
