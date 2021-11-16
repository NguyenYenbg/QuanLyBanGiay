using QLBanGiay.Databases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanGiay.XuLy.DataProcessing
{
    class ChiTietHoaDonDPro
    {
        DBConnection dataConn = new DBConnection();

        public void InsertCTHoaDon(int mahd, int masp, int slban)
        {
            string sql = "insert into CTHoaDon(MaHD,MaSP, SLBan) values(" + mahd + "," + masp + "," + slban + ")";
            dataConn.ExecuteNonQuery(sql);
        }
        public DataTable getCTHoaDonByMa(int maHD)
        {
            string sql = "select *from CTHoaDon where maHD='" + maHD + "'";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        
        public void deleteCTHoaDon(int mahd)
        {
            string sql = "delete from CTHoaDon where MaHD=" + mahd;
            dataConn.ExecuteNonQuery(sql);
        }
    }
}
