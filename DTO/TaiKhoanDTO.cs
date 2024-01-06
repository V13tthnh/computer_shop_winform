using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public int MaTK { get; set; }
        public int MaNV { get; set; }

        public string TaiKhoan { get; set; }

        public string MatKhau { get; set; }

        public string Quyen { get; set; }

        public TaiKhoanDTO()
        {
        }

        public TaiKhoanDTO(int MaNV,string TaiKhoan, string MatKhau, string Quyen) {
            this.MaNV = MaNV;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
        }
    }
}
