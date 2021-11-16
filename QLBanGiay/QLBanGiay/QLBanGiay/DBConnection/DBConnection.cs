using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanGiay.Databases
{
    class DBConnection
    {
        private SqlConnection GetConnection()
        {
            String connString = @"Data Source=DESKTOP-IOHI6L2\SQLEXPRESS;Initial Catalog=QuanLyBanGiay;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        //load data
        public DataTable GetTable(String sql)
        {
            try
            {
                SqlConnection conn = GetConnection();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
                return null;
            }
        }

        //thực hiện thêm, sửa, xóa
        public void ExecuteNonQuery(String sql)
        {
            try
            {
                SqlConnection conn = GetConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
