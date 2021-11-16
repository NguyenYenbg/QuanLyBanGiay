using QLBanGiay.Databases;
using QLBanGiay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace QLBanGiay.XuLy.DataProcessing
{
    class SanPhamDPro
    {
        DBConnection dataConn = new DBConnection();
        
        public List<SanPhamsDTO> ShowSanPham()
        {
            string sql = "select * from SanPham";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            List<SanPhamsDTO> listsanpham = new List<SanPhamsDTO>();

            foreach (DataRow row in table.Rows)
            {
                SanPhamsDTO sanPham = new SanPhamsDTO();
                sanPham.MaSP = int.Parse(row["masp"].ToString());
                //category.ID = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                sanPham.TenSP = row["tensp"].ToString();
                string AnhSP = row["anhsp"].ToString();
                sanPham.GiaSP = int.Parse(row["giasp"].ToString());
                sanPham.KichCo = int.Parse(row["kichco"].ToString());

                sanPham.MauSac = row["mausac"].ToString();
                sanPham.LoaiGiay = row["loaigiay"].ToString();
                //  string[] MauSac = row["color"].ToString().Split(',').ToArray();
                //product.color = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]), int.Parse(color[3]));
                //product.color.BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]), int.Parse(color[3]));

                sanPham.SoLuong = int.Parse(row["soluong"].ToString());
                sanPham.MoTa = row["mota"].ToString();
                sanPham.NgayTao = DateTime.Parse(row["ngaytao"].ToString()).ToString("MM/dd/yyyy");
                //ảnh
                Bitmap img;


                try
                {
                    img = (Bitmap)Image.FromFile(row["anhsp"].ToString());
                    //img = new Bitmap(@"" + linkAvatar + "");
                }
                catch (Exception)
                {
                    //img = new Bitmap(linkAvatar);
                    //img = (Bitmap)Image.FromFile(row["avatar"].ToString().Replace("\\", "\\\\"));
                    img = new Bitmap(@"D:\HaUI\he\window\BTL\BTL_QLBanGiay\Giay.jpg");
                }


                sanPham.AnhSP = img;
                if (row["Ngaysua"].ToString().Trim() == null)
                {
                    sanPham.NgaySua = "";
                }
                else
                {
                    sanPham.NgaySua = row["ngaysua"].ToString().Replace(" 12:00:00 AM", "");
                }
                sanPham.MaDM = int.Parse(row["madm"].ToString());
                sanPham.MaNCC = int.Parse(row["mancc"].ToString());
                listsanpham.Add(sanPham);
            }
            return listsanpham;
        }

        public void InsertSanPham(string TenSP, string AnhSP, Int32 GiaSP,
            Int32 KichCo, string MauSac, string LoaiGiay,
            Int32 SoLuong, string MoTa, string NgayTao, int MaDM, int MaNCC)
        {
            string sql = "Insert into SanPham values(N'" + TenSP+"','"+AnhSP+ "','" + GiaSP + "','" + KichCo + "','" + MauSac + "',N'" + LoaiGiay + "','" + SoLuong + "',N'" + MoTa + "','" + NgayTao + "',null,'" + MaDM + "','" + MaNCC + "') ";
            dataConn.ExecuteNonQuery(sql);
        }

        public void UpdateSanPham(int MaSP, string TenSP, string AnhSP, Int32 GiaSP,
          Int32 KichCo, string MauSac, string LoaiGiay,
          Int32 SoLuong, string MoTa, int MaDM, int MaNCC)
        {
            string sql = "update SanPham set TenSP=N'" + TenSP + "',AnhSP=N'" + AnhSP + "',GiaSP='" + GiaSP + "',KichCo='" + KichCo + "',MauSac=N'" + MauSac + "',LoaiGiay=N'" + LoaiGiay + "',SoLuong='" + SoLuong + "',MoTa=N'" + MoTa + "',NgaySua='" + DateTime.UtcNow.Date.ToString("MM/dd/yyyy") + "',MaDM='" + MaDM + "',MaNCC='" + MaNCC + "'where MaSP='" + MaSP + "'";
            dataConn.ExecuteNonQuery(sql);
        }

        public void DeleteSanPham(int MaSP)
        {
            string sql = "delete SanPham where MaSP= '" + MaSP + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        //Kiểm tra tên sản phẩm có trong SANPHAM k
        public int getcountitem(string TenSP)
        {
            string sql = "select * from SanPham where TenSP='" + TenSP + "'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table.Rows.Count;
        }

        public string getavalink(int MaSP)
        {
            string sql = "select AnhSP from SanPham where MaSP='" + MaSP + "'";
            DataTable table = dataConn.GetTable(sql);//loi ko select dc cai gi ca
            return table.Rows[0].ItemArray[0].ToString();
        }

        public List<SanPhamsDTO> search(string TenSP)
        {
            string sql = "select *from SanPham where TenSP like '%" + TenSP + "%'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);

            List<SanPhamsDTO> listsanpham = new List<SanPhamsDTO>();

            foreach (DataRow row in table.Rows)
            {
                SanPhamsDTO sanPham = new SanPhamsDTO();
                sanPham.MaSP = int.Parse(row["masp"].ToString());
                //category.ID = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                sanPham.TenSP = row["tensp"].ToString();
                string AnhSP = row["anhsp"].ToString();
                sanPham.GiaSP = int.Parse(row["giasp"].ToString());
                sanPham.KichCo = int.Parse(row["kichco"].ToString());

                sanPham.MauSac = row["mausac"].ToString();
                sanPham.LoaiGiay = row["loaigiay"].ToString();
                //  string[] MauSac = row["color"].ToString().Split(',').ToArray();
                //product.color = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]), int.Parse(color[3]));
                //product.color.BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]), int.Parse(color[3]));

                sanPham.SoLuong = int.Parse(row["soluong"].ToString());
                sanPham.MoTa = row["mota"].ToString();
                sanPham.NgayTao = DateTime.Parse(row["ngaytao"].ToString()).ToString("yyyy-MM-dd");
                //ảnh
                Bitmap img;


                try
                {
                    img = (Bitmap)Image.FromFile(row["avatar"].ToString());
                    //img = new Bitmap(@"" + linkAvatar + "");
                }
                catch (Exception)
                {
                    //img = new Bitmap(linkAvatar);
                    //img = (Bitmap)Image.FromFile(row["avatar"].ToString().Replace("\\", "\\\\"));
                    img = new Bitmap(@"E:\giay.jpg");
                }


                sanPham.AnhSP = img;
                if (row["Ngaysua"].ToString().Trim() == null)
                {
                    sanPham.NgaySua = "";
                }
                else
                {
                    sanPham.NgaySua = row["ngaysua"].ToString().Replace(" 12:00:00 AM", "");
                }
                sanPham.MaDM = int.Parse(row["madm"].ToString());
                // sanPham.MaNCC= int.Parse(row["mancc"].ToString());
                listsanpham.Add(sanPham);
            }
            return listsanpham;
        }

        public void ChangeDanhMuc(int DMmoi, int DMCu)
        {
            string sql = "update SanPham set MaDM= '" + DMmoi + "' where MaDM='" + DMCu + "'";
            dataConn.ExecuteNonQuery(sql);
        }
        public int getSanPhamDanhMuc(int DM)
        {
            string sql = "select * from SanPham where MaDM = '" + DM + "'";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table.Rows.Count;
        }


        public void ChangeSP_toNCC(int newNcc, int oldNcc)
        {
            string sql= "update SanPham set MaNCC=" + newNcc + " where MaNCC=" + oldNcc;
            dataConn.ExecuteNonQuery(sql);
        }
        
        public DataTable getSanPhamByMa(int maSP)
        {
            string sql = "select *from SanPham where MaSP='" + maSP + "'";
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt;
        }
        public int getSanPham_maNhaCC(int maNcc)
        {
            string sql = "select *from SanPham where MaNCC=" + maNcc;
            DataTable dt = new DataTable();
            dt = dataConn.GetTable(sql);
            return dt.Rows.Count;
        }


    }
}
