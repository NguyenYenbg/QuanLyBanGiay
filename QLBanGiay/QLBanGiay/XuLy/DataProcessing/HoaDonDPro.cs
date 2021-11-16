using QLBanGiay.Databases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanGiay.XuLy.DataProcessing
{
    class HoaDonDPro
    {
        DBConnection dataConn = new DBConnection();

        public void InsertHoaDon(int maKH, int maNV)
        {
            string sql = "insert into HoaDon(MaKH,MaNV) values(" + maKH + "," + maNV + ")";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable showHoaDon()
        {
            String sql = "Select *from HoaDon";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public void DeleteHoaDon(Int32 maHD)
        {
            string sql = "delete HoaDon where MaHD='" + maHD + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable locHD(DateTime ngayTu, DateTime ngayDen)
        {
            string sql="select *from HoaDon where NgayLap between'"+ngayTu+"' and '"+ngayDen+"'";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public int getMaHD()
        {
            string sql = "select max(MaHD) from HoaDon";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
        }
    }
}
