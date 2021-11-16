using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanGiay.DTO
{
    class NhanViensDTO
    {
        public int MaNV { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string HoTenNV { get; set; }
        public string AnhNV { get; set; }
        public string GioiTinh { get; set; }
        public Int64 SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int ViTri { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgaySua { get; set; }
    }
}
