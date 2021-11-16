using QLBanGiay.Databases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBanGiay.DTO;
using QLBanGiay.XuLy.DataProcessing;
using System.Drawing;
namespace QLBanGiay.XuLy.DataProcessing
{
    class NhanVienDPro
    {
        DBConnection dataconn = new DBConnection();
        int ma;

        public List<NhanViensDTO> ShowNhanVien()
        {
            string sql = "select * from NhanVien";
            DataTable dt = new DataTable();
            dt = dataconn.GetTable(sql);
            List<NhanViensDTO> listuser = new List<NhanViensDTO>();
            foreach(DataRow row in dt.Rows)
            {
                NhanViensDTO user = new NhanViensDTO();
                user.maNV = int.Parse(row["manv"].ToString());
                user.userName = row["username"].ToString();
                user.passWord = row["password"].ToString();
                user.hoTenNV = row["hotennv"].ToString();
                user.gioiTinh = row["gioitinh"].ToString();
                user.soDT = row["sodt"].ToString();
                user.diaChi = row["diachi"].ToString();
                user.email = row["email"].ToString();
                user.viTri = row["vitri"].ToString() == "1" ? "Admin" : "Employee";
                user.ngayTao = DateTime.Parse(row["NgayTao"].ToString()).ToString("MM/dd/yyyy");
                string anhNV = row["anhNV"].ToString();
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
                    img = new Bitmap(@"C:\Users\NGUYENYEN\Pictures\Dog\ab.jpg");
                }


                user.anhNV = img;
                if (row["Ngaysua"].ToString().Trim() == null)
                {
                    user.ngaySua = "";
                }
                else
                {
                    user.ngaySua = row["ngaysua"].ToString().Replace(" 12:00:00 AM", "");
                }

                listuser.Add(user);
            }
            return listuser;
        }
        public void InsertNhanVien(string UserName, string PassWord, string HoTenNV,string AnhNV, string GioiTinh, int SoDT, string DiaChi, string Email, int ViTri, string NgayTao)
        {
            string sql = "Insert into NhanVien values(N'" + UserName + "',N'" + PassWord + "',N'" + HoTenNV + "','" + AnhNV + "',N'" + GioiTinh + "','" + SoDT + "',N'" + DiaChi + "',N'" + Email + "','" + ViTri + "','" + NgayTao + "',null)";
            dataconn.ExecuteNonQuery(sql);
        }

        public void UpdateNhanVien(int MaNV, string UserName, 
            string HoTenNV,string AnhNV, string GioiTinh, int SoDT,
            string DiaChi, string Email, int ViTri)
        {
            string sql = "update NhanVien set UserName=N'" + UserName + "',HoTenNV=N'" + HoTenNV + "',AnhNV=N'" + AnhNV + "',GioiTinh=N'" + GioiTinh + "',SoDT='" + SoDT + "',DiaChi=N'" + DiaChi + "',Email=N'" + Email + "',ViTri='" + ViTri + "',NgaySua='" + DateTime.UtcNow.Date.ToString("MM/dd/yyyy") + "'where MaNV='" + MaNV + "'";
            dataconn.ExecuteNonQuery(sql);
        }
        public void DeleteNhanVien(Int32 ma)
        {
            string sql = "delete NhanVien where MaNV= '" + ma + "'";
            dataconn.ExecuteNonQuery(sql);
        }

        public List<NhanViensDTO> search(string HoTenNV)
        {
            string sql = "select *from NhanVien where HoTenNV like N'%" + HoTenNV + "%'";
            DataTable table = new DataTable();
            table = dataconn.GetTable(sql);

            List<NhanViensDTO> listuser = new List<NhanViensDTO>();
            foreach (DataRow row in table.Rows)
            {
                NhanViensDTO user = new NhanViensDTO();
                user.maNV = int.Parse(row["manv"].ToString());
                user.userName = row["username"].ToString();
                user.passWord = row["password"].ToString();
                user.hoTenNV = row["hotennv"].ToString();
                user.gioiTinh = row["gioitinh"].ToString();
                user.soDT = row["sodt"].ToString();
                user.diaChi = row["diachi"].ToString();
                user.email = row["email"].ToString();
                user.viTri = row["vitri"].ToString() == "1" ? "Admin" : "Employee";
                string anhNV = row["anhNV"].ToString();
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
                    img = new Bitmap(@"C:\Users\NGUYENYEN\Pictures\Dog\ab.jpg");
                }


                user.anhNV = img;
                if (row["Ngaysua"].ToString().Trim() == null)
                {
                    user.ngaySua = "";
                }
                else
                {
                    user.ngaySua = row["ngaysua"].ToString().Replace(" 12:00:00 AM", "");
                }

                listuser.Add(user);
            }
            return listuser;

        }
        public bool getUsernamePassword(String username, string password)
        {
            string sql="select *from NhanVien where UserName=N'"+username+"'and PassWord=N'"+password+"'";
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

        //Lay ra nhan vien co manv trong sql
        public DataTable getNhanVienByMaNV(int MaNV)
        {
            string sql = "select * from NhanVien where MaNV='" + MaNV + "'";
            DataTable dt = dataconn.GetTable(sql);
            return dt;
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
        public string imageLink(int id)
        {
            string sql = "select AnhNV from NhanVien where MaNV='" + id + "'";
            DataTable dt = dataconn.GetTable(sql);//loi ko select dc cai gi ca
            return dt.Rows[0].ItemArray[0].ToString();
        }

        //Lấy ra mã nv có mk thích hợp trong sql để đổi
        public void UpdatePassByMaNV(int MaNV, string Pass)
        {
            string sql = "update NhanVien set PassWord=N'" + Pass + "' where MaNV='" + MaNV + "'";
            dataconn.ExecuteNonQuery(sql);
        }
    }
}
