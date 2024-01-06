using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL: SQLDataAccess
    {
        SQLDataAccess conn = null;
        public TaiKhoanDAL() { 
            conn = new SQLDataAccess();
        }

        public TaiKhoanDTO DangNhap(string taiKhoan, string matKhau)
        {
            TaiKhoanDTO taiKhoanDTO = null;
            conn.Connect();
            {
                SqlCommand command = new SqlCommand("SELECT * FROM TAIKHOAN WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau", conn.con);
                command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                command.Parameters.AddWithValue("@MatKhau", matKhau);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    taiKhoanDTO = new TaiKhoanDTO();
                    taiKhoanDTO.MaTK = reader.GetInt32(0);
                    taiKhoanDTO.MaNV = reader.GetInt32(1);
                    taiKhoanDTO.TaiKhoan = reader.GetString(2);
                    taiKhoanDTO.MatKhau = reader.GetString(3);
                    taiKhoanDTO.Quyen = reader.GetString(4);
                }
                reader.Close();
                conn.Disconnect();
            }
            return taiKhoanDTO;
        }

        public bool XoaTK(string manv)
        {
            try
            {
                conn.Connect();
                SqlCommand cmd = new SqlCommand("delete from TaiKhoan where MaNV = '" + manv + "'", conn.con);
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
                conn.Disconnect();
            }
            return false;
        }
        
        
        public bool SuaTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                conn.Connect();
                string sql = string.Format("update TaiKhoan set TaiKhoan = '" + tk.TaiKhoan + "', matkhau = '" + tk.MatKhau + "', quyen = '"+ tk.Quyen + "' where manv = '"+tk.MaNV+"'");
                SqlCommand cmd = new SqlCommand(sql, conn.con);
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
                conn.Disconnect();
            }
            return false;
        }
        public bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                conn.Connect();
                string sql = string.Format("insert into TaiKhoan values(N'" + tk.MaNV + "',N'" + tk.TaiKhoan + "', N'" + tk.MatKhau + "', N'" + tk.Quyen + "')");
                SqlCommand cmd = new SqlCommand(sql, conn.con);
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
                conn.Disconnect();
            }
            return false;
        }
    }
}
