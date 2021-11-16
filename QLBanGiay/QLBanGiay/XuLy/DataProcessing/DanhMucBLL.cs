using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanGiay.DTO;
using System.Data;
using QLBanGiay.Databases;
namespace QLBanGiay.XuLy.DataProcessing
{
    class DanhMucBLL
    {
        DBConnection dataConn = new DBConnection();

        public DataTable ShowDanhMuc()
        {
            string sql = "Select * from DanhMuc";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public List<DanhMucsDTO> danhMuc()
        {
            List<DanhMucsDTO> a = new List<DanhMucsDTO>();
            string sql = "Select * from DanhMuc";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                var danhmuc = new DanhMucsDTO();
                danhmuc.maDM = int.Parse(table.Rows[i].ItemArray[0].ToString());
                danhmuc.tenDM = table.Rows[i].ItemArray[1].ToString();
                a.Add(danhmuc);


            }
            return a;
        }

        public void InsertDanhMuc(string tenDM, string moTa)
        {
            string sql = "Insert into DanhMuc(TenDM,MoTa)values (N'"+tenDM+"',N'"+moTa+"')";
            dataConn.ExecuteNonQuery(sql);
        
        }
        public void UpdateDanhMuc(Int32 ma, string tenDM,string moTa)
        {
            string sql = "update DanhMuc set TenDM=N'" + tenDM + "',MoTa=N'" + moTa + "',NgaySua='" + DateTime.UtcNow.Date.ToString("MM/dd/yyyy") + "'where MaDM='" + ma + "'";
            dataConn.ExecuteNonQuery(sql);
        }

        //Truy xuat vào MaDM TRONG sql để tìm ra tên dm
        public int getID(string ten)
        {
            string sql = "select MaDM from DanhMuc where TenDM=N'" + ten + "'";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
        }
        //Kiểm tra xem trong sql có tên danh mục đó chưa để báo trùng tendm hay k
        public int getitem(string name)
        {
            string sql = "select * from DanhMuc where TenDM=N'" + name + "'";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt.Rows.Count;
        }

        public DataTable search(string TenDM)
        {
            string sql = "select *from DanhMuc where TenDM like N'%" + TenDM + "%'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public void DeleteDanhMuc(Int32 ma)
        {
            string sql = "delete DanhMuc where MaDM='" + ma + "'";
            dataConn.ExecuteNonQuery(sql);
        }

     
    }
}
