using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace QLBanGiay.DTO
{
    class NhanViensDTO
    {
        public int maNV { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string hoTenNV { get; set; }
        public Bitmap anhNV { get; set; }
        public string gioiTinh { get; set; }
        public string soDT { get; set; }
        public string diaChi { get; set; }
        public string email { get; set; }
        public string  viTri { get; set; }
        public string ngayTao { get; set; }
        public string ngaySua { get; set; }
    }
}
