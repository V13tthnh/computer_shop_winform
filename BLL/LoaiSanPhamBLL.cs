using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamDAL connector = null;

        public LoaiSanPhamBLL()
        {
            connector = new LoaiSanPhamDAL();
        }

        public DataTable LayDSLoaiSP()
        {
            return connector.LayDSLoaiSP();
        }
    }
}
