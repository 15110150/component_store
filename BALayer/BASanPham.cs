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
    public class BASanPham
    {
        DAl db = null;
        public BASanPham()
        {
            db = new DAl();
        }
        public DataSet LayListSanPham()
        {
            return db.ExecuteQueryDataSet("spLayListSanPham", CommandType.StoredProcedure, null);
        }
        public DataSet LayListSanPhamTheoLoai(string MaLoai)
        {
            return db.ExecuteQueryDataSetWithPra("spLayListSanPhamTheoLoai", CommandType.StoredProcedure, new SqlParameter("@MaLoai", MaLoai));
        }
        public bool XoaSP(ref string error, string MaSP)
        {
            return db.MyExecuteNonQuery("spXoaSP", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaSP", MaSP));
        }
        public DataSet LayListSPNCC(string MaNCC)
        {
            return db.ExecuteQueryDataSetWithPra("spLayListSPNCC", CommandType.StoredProcedure,
                new SqlParameter("@MaNCC", MaNCC));
        }
        public DataSet DoMaSP(string MaSP)
        {
            return db.ExecuteQueryDataSetWithPra("spDoMaSP", CommandType.StoredProcedure,
                new SqlParameter("@MaSP", MaSP));
        }
        public bool ThemSanPhamWithImage(ref string error, string MaSP, string TenSP, string ThoiGianBaoHanh, double GiaMua, double GiaBan, string MoTa
         , byte[] Photo, string MaNCC, string MaLoaiSp)
        {
            return db.MyExecuteNonQuery("spThemSanPham", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaSP", MaSP),
                new SqlParameter("@TenSP", TenSP),
                 new SqlParameter("@NhaCC", MaNCC),
                new SqlParameter("@LoaiSP", MaLoaiSp),
                new SqlParameter("@BaoHanh", ThoiGianBaoHanh),
                new SqlParameter("@GiaMua", GiaMua),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@MoTa", MoTa),
                new SqlParameter("@HinhAnh", Photo) );
        }
        public bool ThemSanPhamNotImage(ref string error, string MaSP, string TenSP, string ThoiGianBaoHanh, double GiaMua, double GiaBan, string MoTa
        , string MaNCC, string MaLoaiSp)
        {
            return db.MyExecuteNonQuery("spThemSanPhamNotImage", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaSP", MaSP),
                new SqlParameter("@TenSP", TenSP),
                 new SqlParameter("@NhaCC", MaNCC),
                new SqlParameter("@LoaiSP", MaLoaiSp),
                new SqlParameter("@BaoHanh", ThoiGianBaoHanh),
                new SqlParameter("@GiaMua", GiaMua),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@MoTa", MoTa)
              );
        }
        public bool CapNhatSanPhamNotImage(ref string error, string MaSP, string TenSP, string ThoiGianBaoHanh, double GiaMua, double GiaBan, string MoTa
       , string MaNCC, string MaLoaiSp)
        {
            return db.MyExecuteNonQuery("spCapNhatSanPhamNotImage", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaSP", MaSP),
                new SqlParameter("@TenSP", TenSP),
                new SqlParameter("@NhaCC", MaNCC),
                new SqlParameter("@LoaiSP", MaLoaiSp),
                new SqlParameter("@BaoHanh", ThoiGianBaoHanh),
                new SqlParameter("@GiaMua", GiaMua),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@MoTa", MoTa));
        }
        public bool CapNhatSanPhamWithImage(ref string error, string MaSP, string TenSP, string ThoiGianBaoHanh, double GiaMua, double GiaBan, string MoTa
       , byte[] Photo, string MaNCC, string MaLoaiSp)
        {
            return db.MyExecuteNonQuery("spCapNhatSanPhamWithImage", CommandType.StoredProcedure, ref error,
                new SqlParameter("@MaSP", MaSP),
                new SqlParameter("@TenSP", TenSP),
                new SqlParameter("@NhaCC", MaNCC),
                new SqlParameter("@LoaiSP", MaLoaiSp),
                new SqlParameter("@BaoHanh", ThoiGianBaoHanh),
                new SqlParameter("@GiaMua", GiaMua),
                new SqlParameter("@GiaBan", GiaBan),
                new SqlParameter("@MoTa", MoTa),
                new SqlParameter("@HinhAnh", Photo));
        }
        public DataSet DoSP(string ThongTin)
        {
            return db.ExecuteQueryDataSetWithPra("spDoSP", CommandType.StoredProcedure,
               new SqlParameter("@ThongTin", ThongTin));
        }
        public DataSet DoNCC(string MaNCC)
        {
            return db.ExecuteQueryDataSetWithPra("spDoMaCC_SP", CommandType.StoredProcedure,
               new SqlParameter("@MaNCC", MaNCC));
        }
        public DataSet DoLoaiSp(string MaLoaiSp)
        {
            return db.ExecuteQueryDataSetWithPra("spDoMaLoaiSp_SP", CommandType.StoredProcedure,
               new SqlParameter("@MaLoaiSp", MaLoaiSp));
        }
        public DataSet DoSPAll(string MaSP, string TenSP, string MaNCC, string MaLoaiSp)
        {
            return db.ExecuteQueryDataSetWithPra("spDoAll_SP", CommandType.StoredProcedure,
               new SqlParameter("@MaSP", MaLoaiSp),
                 new SqlParameter("@TenSP", TenSP),
                  new SqlParameter("@MaNCC", MaNCC),
                   new SqlParameter("@MaLoaiSp", MaLoaiSp));
        }


    }
}
