using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string LienHe { get; set; }
        public string TenAnh { get; set; }

        public NhaCungCapDTO(string MaNCC, string TenNCC, string DiaChi, string LienHe, string TenAnh)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.DiaChi = DiaChi;
            this.LienHe = LienHe;
            this.TenAnh = TenAnh;
        }

    }   
}
