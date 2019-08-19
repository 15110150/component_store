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
    public class BAThongKeSanPham
    {
        DAl db = null;
        public BAThongKeSanPham()
        {
            db = new DAl();
        }
        public DataSet ThongKeSLToanBo()
        {
            return db.ExecuteQueryDataSet("spThongKeSoLuongSPBanRaToanBo", CommandType.StoredProcedure, null);
        }
        public DataSet ThongKeSLTheoLoai(string MaLoai)
        {
            return db.ExecuteQueryDataSetWithPra("spThongKeSoLuongSPBanRaTheoLoai", CommandType.StoredProcedure,
                new SqlParameter("@MaLoai", MaLoai));
        }
    }
    }
