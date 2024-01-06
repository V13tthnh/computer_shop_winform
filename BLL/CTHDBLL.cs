using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CTHDBLL
    {
        CTHDDAL cthddal = null;
        public CTHDBLL() {
            cthddal = new CTHDDAL();
        }

        public DataTable LayDSCTHD()
        {
            return cthddal.LayDSCTHD();
        }

        public DataTable TongSLBan()
        {
            return cthddal.SLBan();
        }

        public DataTable TongTienBan()
        {
            return cthddal.TongTienBan();
        }

        public bool ThemCTHD(CTHDDTO cthd)
        {
            return cthddal.ThemCTHD(cthd);
        }

        public bool XoaCTHD(string mahd)
        {
            return cthddal.XoaCTHD(mahd);
        }
    }
}
