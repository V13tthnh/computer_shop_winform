using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMaiDTO
    {
        public int MaKM { get; set; }
        public string TenKM { get; set; }
        public int GiaTriGiam { get; set; }
        public string NgayBatDau {  get; set; }
        public string NgayKetThuc {  get; set; }
        public int TrangThai { get; set; }

        public KhuyenMaiDTO(string TenKM, int GiaTriGiam, string NgayBatDau, string NgayKetThuc, int TrangThai) { 
            this.TenKM = TenKM;
            this.GiaTriGiam = GiaTriGiam;
            this.NgayBatDau = NgayBatDau;
            this.NgayKetThuc = NgayKetThuc;
            this.TrangThai = TrangThai;
        }

        public KhuyenMaiDTO(int MaKM, string TenKM, int GiaTriGiam, string NgayBatDau, string NgayKetThuc, int TrangThai)
        {
            this.MaKM = MaKM;
            this.TenKM = TenKM;
            this.GiaTriGiam = GiaTriGiam;
            this.NgayBatDau = NgayBatDau;
            this.NgayKetThuc = NgayKetThuc;
            this.TrangThai = TrangThai;
        }
    }
}
