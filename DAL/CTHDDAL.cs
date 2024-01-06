using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Text.RegularExpressions;

namespace DAL
{
    public class CTHDDAL
    {
        SQLDataAccess connector = null;
        public CTHDDAL()
        {
            connector = new SQLDataAccess();
        }

        public DataTable LayDSCTHD()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CTHD", connector.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool ThemCTHD(CTHDDTO CTHD)
        {
            connector.con.Open();
            try
            {
                connector.Connect();
                string sql = "insert into CTHD values ('" + CTHD.MaHD + "', '" + CTHD.MaSP + "', '" + CTHD.SoLuong + "', '" + CTHD.DonGia + "')";
                SqlCommand cmd = new SqlCommand(sql, connector.con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { connector.Disconnect(); }
            return false;
        }

        public bool XoaCTHD(string mahd)
        {
            try
            {
                connector.Connect();
                SqlCommand cmd = new SqlCommand("delete from CTHD where MaHD = '" + mahd + "'", connector.con);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connector.Disconnect();
            }
            return false;
        }

        public DataTable SLBan()
        {
            try
            {
                connector.Connect();
                SqlDataAdapter da = new SqlDataAdapter("select sum(SoLuong) from CTHD", connector.con);
                DataTable dtNCC = new DataTable();
                da.Fill(dtNCC);
                return dtNCC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connector.Disconnect();
            }
        }

        public DataTable TongTienBan()
        {
            try
            {
                connector.Connect();
                SqlDataAdapter da = new SqlDataAdapter("select sum(SoLuong* dongia) from CTHD", connector.con);
                DataTable dtNCC = new DataTable();
                da.Fill(dtNCC);
                return dtNCC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connector.Disconnect();
            }
        }
    }
}
