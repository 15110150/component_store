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
    public class BAThongKeChiPhi
    {
        DAl db = null;

        public BAThongKeChiPhi()
        {
            db = new DAl();
        }


        public DataSet LayThongKeTheoThangNam(int Thang, int Nam)
        {
            return db.ExecuteQueryDataSetWithPra("spThongKeChiPhiBanTheoThangNam", CommandType.StoredProcedure,
                new SqlParameter("@Thang", Thang),
                 new SqlParameter("@Nam", Nam));
        }
        public DataSet LayThongKeTheoNam(int Nam)
        {
            return db.ExecuteQueryDataSetWithPra("spThongKeChiPhiBanTheoNam", CommandType.StoredProcedure, new SqlParameter("@Nam", Nam));
        }
        public DataSet LayThongKeNhapTheoThangNam(int Thang, int Nam)
        {
            return db.ExecuteQueryDataSetWithPra("spThongKeChiPhiNhapTheoThangNam", CommandType.StoredProcedure, 
                new SqlParameter("@Thang", Thang),
                 new SqlParameter("@Nam", Nam));
        }
        public DataSet LayThongKeNhapTheoNam(int Nam)
        {
            return db.ExecuteQueryDataSetWithPra("spThongKeChiPhiNhapTheoNam", CommandType.StoredProcedure, new SqlParameter("@Nam", Nam));
        }
    }
}
