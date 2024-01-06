using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
        public string MaLoai { get; set; }
        public string TenLoaiSanPham { get; set; }

        public LoaiSanPhamDTO(string TenLoaiSanPham) {
            this.TenLoaiSanPham = TenLoaiSanPham;
        }
    }
}
