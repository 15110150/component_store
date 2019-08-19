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
    public class BAInHoaDon
    {
        DAl db = null;
        public BAInHoaDon()
        {
            db = new DAl();
        }
        public DataSet InHoaDon(string MaDH)
        {
            return db.ExecuteQueryDataSetWithPra("spInHoaDonBanHang", CommandType.StoredProcedure,
               new SqlParameter("@MaHD", MaDH));
        }
        public DataSet LayHoaDonView(string TenKH)
        {
            return db.ExecuteQueryDataSetWithPra("spLayHoaDonKH", CommandType.StoredProcedure,
               new SqlParameter("@TenKH", TenKH));
        }
       

    }
}
