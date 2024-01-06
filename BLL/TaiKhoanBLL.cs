using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL tkdal = null;
        public TaiKhoanBLL() {
            tkdal = new TaiKhoanDAL();
        }
       
        public TaiKhoanDTO DangNhap(string taikhoan, string matkhau)
        {
            return tkdal.DangNhap(taikhoan, matkhau);
        }

        public bool XoaTK(string manv)
        {
            return tkdal.XoaTK(manv);
        }

        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            return tkdal.ThemTaiKhoan(tk);
        }

        public bool SuaTaiKhoan(TaiKhoanDTO tk)
        {
            return tkdal.SuaTaiKhoan(tk);
        }
    }
}
