using QLBanGiay.Databases;
using QLBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanGiay.XuLy.DataProcessing
{
    class SanPhamDPro
    {
        DBConnection dataConn = new DBConnection();
        
        public List<SanPhamsDTO> ShowSanPham()
        {
            string sql = "select *from SanPham";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            List<SanPhamsDTO> listSanPham = new List<SanPhamsDTO>();
            foreach(DataRow row in dt.Rows)
            {
                SanPhamsDTO sanPham = new SanPhamsDTO();
                sanPham.MaSP = int.Parse(row["MaSP"].ToString());
                sanPham.TenSP = row["TenSP"].ToString();
                sanPham.GiaSP = int.Parse(row["GiaSP"].ToString());
                sanPham.SoLuong = int.Parse(row["SoLuong"].ToString());
                listSanPham.Add(sanPham);
            }
            return listSanPham;
        }
        

        public DataTable getSanPhamByMa(int maSP)
        {
            string sql = "select *from SanPham where MaSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
    }
}
