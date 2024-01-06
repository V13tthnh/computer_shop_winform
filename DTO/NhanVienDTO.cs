using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string GT { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public float Luong { get; set; }
        public string Anh { get; set; }
        public int TrangThai { get; set; }

        public NhanVienDTO(string TenNV, string GT, string DiaChi, string SDT, float Luong, string Anh, int TrangThai) {
            this.TenNV = TenNV;
            this.GT = GT;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
            this.Luong = Luong;
            this.Anh = Anh;
            this.TrangThai = TrangThai;
        }

        public NhanVienDTO(int MaNV, string TenNV, string GT, string DiaChi, string SDT, float Luong, string Anh, int TrangThai)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.GT = GT;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
            this.Luong = Luong;
            this.Anh = Anh;
            this.TrangThai = TrangThai;
        }

    }
}
