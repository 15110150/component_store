using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DALayer
{
    public class DAl
    {
        static string ConnStr = @"Data Source= HAVY\SQLSERVER;Initial catalog=LinhKien3;Integrated Security=true";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DAl()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public bool OpenConnection(string user, string pass, string server, string data)
        {
            ConnStr = @"Data Source=" + server + ";Initial catalog=" + data +
                ";Integrated Security=false;User Id=" + user + ";Password=" + pass;
            conn = new SqlConnection(ConnStr);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return false;
            }
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
            return true;
        }
        public bool OpenConnection()
        {
            System.Console.WriteLine(ConnStr);
            conn.ConnectionString = ConnStr;
            try
            {
                conn.Open();
            }
            catch (Exception Ex)
            {
                return false;
            }
            return true;
        }

        public List<string> GetDatabaseList(string server, string user, string pass)
        {
            List<string> list = new List<string>();
            string Conn = @"Data Source=" + server + ";Initial catalog=HondaStoreADO" +
                ";Integrated Security=false;User Id=" + user + ";Password=" + pass;
            using (SqlConnection con = new SqlConnection(Conn))
            {
                con.Open();
                // Set up a command with the given query and associate
                // this with the current connection.
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }
            }
            return list;

        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL; // chuẩn bị đối tượng command
            comm.CommandType = ct; //
            comm.Parameters.Clear();
            da = new SqlDataAdapter(comm); // sử dụng cmd để khởi tạo đối tượng adapter
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet ExecuteQueryDataSetWithPra(string strSQL, CommandType ct, params SqlParameter[] param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            comm.Parameters.Clear();
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false; //
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();// dọn sạch bộ parameter của command đi
            comm.CommandText = strSQL;////Đưa nội dung command vào
            comm.CommandType = ct;// chuyển loại command
            comm.Parameters.Clear();
            foreach (SqlParameter p in param) //add các bộ tham số vào command
                comm.Parameters.Add(p);
            try
            {
                comm.ExecuteNonQuery();
                f = true; // nếu thực thi được cờ sẽ true, còn không được cờ vẫn là flase
            }
            catch (SqlException ex)
            {
                error = ex.Message; //lưu lỗi
            }
            finally
            {
                conn.Close();//đóng connection
            }
            return f; //trả  cờ (nhận biết được thực thi được hay không)
        }
        public bool MyExecuteNonQueryNotPra(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            comm.Parameters.Clear();
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

    }
}
