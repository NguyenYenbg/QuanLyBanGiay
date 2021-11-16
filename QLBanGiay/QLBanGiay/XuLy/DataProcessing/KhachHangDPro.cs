using QLBanGiay.Databases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanGiay.XuLy.DataProcessing
{
    class KhachHangDPro
    {
        DBConnection dataConn = new DBConnection();
        int maKH;
        public DataTable showKhachHang()
        {
            String sql = "Select *from KhachHang";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }

        public void InsertKhachHang(string TenKH, Int64 SDT,string DiaChi)
        {
            string sql = "insert into KhachHang(TenKH,SDT,DiaChi) values(N'" + TenKH + "','" + SDT + "',N'" + DiaChi + "')";
            dataConn.ExecuteNonQuery(sql);
        }
        public void UpdateKhachHang(Int32 MaKH, string TenKH, Int64 SDT, string DiaChi)
        {
            string sql="update KhachHang set TenKH=N'"+TenKH+"',SDT='"+SDT+"',DiaChi=N'"+DiaChi+"' where MaKH='"+MaKH+"'";
            dataConn.ExecuteNonQuery(sql);
        }
        public void DeleteKhachHang(Int32 MaKH)
        {
            string sql = "delete KhachHang where MaKH='" + MaKH + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable Search(string tenKH)
        {
            String sql = "select *from KhachHang where TenKH like N'%" + tenKH + "%'";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public DataTable SearchSDT(Int64 soDT)
        {
            String sql = "select *from KhachHang where SDT=" + soDT;
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }

        public DataTable searchMa(int maKH)
        {
            String sql = "select TenKH, SDT, DiaChi from KhachHang where MaKH='" + maKH + "'";
            DataTable dt = dataConn.GetTable(sql);
            return dt;
        }
        
        public bool getSDT(Int64 sdt)
        {
            string sql = "select *from KhachHang where SDT=" + sdt;
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            foreach(DataRow row in dt.Rows)
            {
                try
                {
                    this.maKH = int.Parse(row["MaKH"].ToString());
                }
                catch (Exception)
                {

                    throw;
                }
                break;
            }
            return dt.Rows.Count == 0 ? false : true;
        }
        public int maKhachHang()
        {
            return this.maKH;
        }
    }
}
