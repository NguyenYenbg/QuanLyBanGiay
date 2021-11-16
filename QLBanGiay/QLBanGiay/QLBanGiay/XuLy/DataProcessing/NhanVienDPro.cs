using QLBanGiay.Databases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanGiay.XuLy.DataProcessing
{
    class NhanVienDPro
    {
        DBConnection dataconn = new DBConnection();
        int ma;
        public bool getUsernamePassword(String username, string password)
        {
            string sql="select *from NhanVien where UserName='"+username+"'and PassWord='"+password+"'";
            DataTable dt = new DataTable();
            dt = dataconn.GetTable(sql);
            foreach(DataRow row in dt.Rows)
            {
                try
                {
                    this.ma = int.Parse(row["MaNV"].ToString());
                }
                catch (Exception)
                {

                    throw;
                }
                break;
            }
            return dt.Rows.Count == 0 ? false : true;
        }
        public int maNhanVien()
        {
            return this.ma;
        }
        public DataTable searchMa(int maNV)
        {
            String sql = "select HoTenNV from NhanVien where MaNV='"+maNV+"'";
            DataTable dt = new DataTable();
            dt = dataconn.GetTable(sql);
            return dt;
        }
        public int getViTri(int ma)
        {
            string sql = "select ViTri from NhanVien where MaNV=" + ma;
            DataTable dt = dataconn.GetTable(sql);
            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
        }
        
    }
}
