using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiSanPhamDAL
    {
        SQLDataAccess connector = null;
        public LoaiSanPhamDAL()
        {
            connector = new SQLDataAccess();
        }

        public DataTable LayDSLoaiSP()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from LoaiSanPham", connector.con);
            DataTable dtNCC = new DataTable();
            da.Fill(dtNCC);
            return dtNCC;
        }
    }
}
