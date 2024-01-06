using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Security.Cryptography;
using System.Runtime.ConstrainedExecution;

namespace DAL
{
    public class HoaDonDAL
    {
        SQLDataAccess connector = null;
        public HoaDonDAL()
        {
            connector = new SQLDataAccess();
        }

        public DataTable LayDSHD()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon", connector.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

            public int LayMaHDLonNhat()
            {
                try
                {
                    connector.Connect();
                    SqlCommand cmd = new SqlCommand("select max(MaHD) from HoaDon", connector.con);
                    cmd.CommandType = CommandType.Text;
                    Int32 MaHD = (Int32)cmd.ExecuteScalar();
                    return MaHD;
                }
                catch (Exception ex)
                {
                    return -1;
                }
                finally { connector.Disconnect(); }
            }

        public bool ThemHD(HoaDonDTO hoadon)
        {
            try
            {
                connector.Connect();
                string sql = "insert into HoaDon values ('"+hoadon.MaNV+"', '"+hoadon.MaKH+"', '"+hoadon.NgayLap+"', '"+hoadon.TongHD+"', '"+hoadon.MaKM+"')";
                SqlCommand cmd = new SqlCommand(sql, connector.con);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { connector.Disconnect(); }
            return false;
        }

        public bool XoaHD(string MaHD)
        {
            try
            {
                connector.Connect();
                string sql = string.Format("delete from HoaDon where MaHD = '" + MaHD + "'");
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
            finally
            {
                connector.Disconnect();
            }
            return false;
        }

        public bool SuaHD(HoaDonDTO hoadon)
        {
            try
            {
                connector.Connect();
                string sql = string.Format("update HoaDon set MaNV = N'" + hoadon.MaNV + "', MaKH = N'" + hoadon.MaKH + "', NgayLap = N'" + hoadon.NgayLap + "', TongHD = '" + hoadon.TongHD + "' where MaHD = '" + hoadon.MaHD + "'");
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
            finally
            {
                connector.Disconnect();
            }
            return false;
        }

        public DataTable TimKiemHD(string NgayLap)
        {
            try
            {
                connector.Connect();
                SqlDataAdapter da = new SqlDataAdapter("select * from HoaDon where NgayLap like '%" + NgayLap + "%'", connector.con);
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

        public bool ThongKeDoanhThu()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select sum(TongHD) from Hoadon", connector.con);
                cmd.ExecuteNonQuery();
                return true;

            }catch(Exception ex)
            {
                throw ex;
            }
            finally { connector.Disconnect(); }
            return false;
        }
    }
}
