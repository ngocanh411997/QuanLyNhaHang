using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.model
{
    class ConnectString
    {
        

            public static SqlConnection conn;

            public SqlConnection Connection { get; internal set; }

            public static SqlConnection Ketnoi()
            {
                try
                {

                    string str_conn = @"Data Source=NGOCANH\NGOCANH;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(str_conn);
                    conn.Open();
                    return conn;
                }
                catch
                {
                    return null;
                }
            }

            public static DataTable GetData(string proc)
            {
                try
                {
                    conn = Ketnoi();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                     da.Fill(dt);
                    conn.Close();
                    return dt;
                }
                catch (SqlException)
                {
                    conn.Close();
                    return null;
                }
            }

            public static int ExecuteNonQuery(string proc, SqlParameter[] para)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                        conn = Ketnoi();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = proc;
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (para != null)
                        cmd.Parameters.AddRange(para);

                    int val = cmd.ExecuteNonQuery();
                    conn.Close();
                    return val;
                }
                catch (SqlException)
                {
                    return 0;
                }
            }
        }

}
