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
    class NhaCCDPro
    {
        DBConnection dataconn = new DBConnection();
        public List<NhaCCsDTO> nhaCC()
        {
            List<NhaCCsDTO> listNcc = new List<NhaCCsDTO>();
            string sql = "select *from NhaCC";
            DataTable dt = new DataTable();
            dt = dataconn.GetTable(sql);
            for(int i=0; i<dt.Rows.Count; i++)
            {
                var nhacc = new NhaCCsDTO();
                nhacc.MaNCC = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                nhacc.TenNCC = dt.Rows[i].ItemArray[1].ToString();
                listNcc.Add(nhacc);
            }
            return listNcc;
        }
        public DataTable showNhaCC()
        {
            String sql = "select *from NhaCC";
            DataTable dt = new DataTable();
            dt = dataconn.GetTable(sql);
            return dt;
        }
        public void InsertNhaCC(string TenNCC, Int64 SDT, string DiaChi)
        {
            string sql = "insert into NhaCC(TenNCC, SDT, DiaChi) values(N'" + TenNCC + "','" + SDT + "',N'" + DiaChi + "')";
            dataconn.ExecuteNonQuery(sql);
        }

        public void UpdateNhaCC(Int32 MaNCC,string TenNCC, Int64 SDT, string DiaChi)
        {
            string sql="update NhaCC set TenNCC=N'"+TenNCC+"',SDT="+SDT+",DiaChi=N'"+DiaChi+"'where MaNCC='" + MaNCC + "'";
            dataconn.ExecuteNonQuery(sql);
        }
        public void DeleteNhaCC(Int32 MaNCC)
        {
            string sql="delete NhaCC where MaNCC='"+MaNCC+"'";
            dataconn.ExecuteNonQuery(sql);
        }
        public DataTable Search(string tenNCC)
        {
            string sql = "select *from NhaCC where TenNCC like N'%" + tenNCC + "%'";
            DataTable dt = new DataTable();
            dt = dataconn.GetTable(sql);
            return dt;
        }

        //truy xuat mã ncc trong sql để tìm tên ncc
        public int getmaNCC(string ten)
        {
            string sql = "select MaNCC from NhaCC where TenNCC=N'" + ten + "'";
            DataTable dt = new DataTable();
            dt = dataconn.GetTable(sql);
            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
        }

        public int getitemNCC(string name)
        {
            string sql = "select * from NhaCC where TenNCC=N'" + name + "'";
            DataTable dt = new DataTable();
            dt = dataconn.GetTable(sql);
            return dt.Rows.Count;
        }
    }
}
