using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL:SQLDataAccess
    {
        SQLDataAccess connector;
        public SanPhamDAL() {
            connector = new SQLDataAccess();
        }

        public DataTable LayDSSP()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SanPham", connector.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable LayTenAnhDSSP()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MaSP, TenSP, AnhSP from SanPham", connector.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public bool ThemSP(SanPhamDTO sp)
        {
            try
            {
                connector.Connect();
                string sql = string.Format("insert into SanPham values('"+sp.MaLoai+"', '" + sp.MaNCC + "', N'" + sp.TenSP + "', '" + sp.SLTon + "', '" + sp.DonGia + "', N'" + sp.MoTa + "', '" + sp.AnhSP +"', '"+sp.TrangThai+"')");
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

        public bool XoaSP(string MaSP)
        {
            try
            {
                connector.Connect();
                string sql = string.Format("delete from SanPham where MaSP = '" + MaSP + "'");

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

        public bool SuaSP(SanPhamDTO sp)
        {
            try
            {
                connector.Connect();
                string sql = string.Format("update SanPham set TenSP=N'" + sp.TenSP + "', MaNCC=N'" + sp.MaNCC + "', SLTon='" + sp.SLTon + "', DonGia='" + sp.DonGia + "', MoTa=N'" + sp.MoTa + "', AnhSP=N'" + sp.AnhSP + "', MaLoai='"+sp.MaLoai+"' where MaSP = '"+sp.MaSP+"'");
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

        public bool CapNhatSoLuongSanPham(int masp, int sl)
        {
            try
            {
                connector.Connect();
                string sql = string.Format("update sanpham set SlTon= SlTon - '"+sl+"' where masp = '"+masp+"'");
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

        public DataTable TimKiemSP(string TenSP)
        {
            try
            {
                connector.Connect();
                SqlDataAdapter da = new SqlDataAdapter("select * from SanPham where TenSP like '%" + TenSP + "%'", connector.con);
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

        public DataTable TongTienNhap()
        {
            try
            {
                connector.Connect();
                SqlDataAdapter da = new SqlDataAdapter("select sum(SlTon * DonGia) from SanPham", connector.con);
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

        public DataTable TongSLSanPham()
        {
            try
            {
                connector.Connect();
                SqlDataAdapter da = new SqlDataAdapter("select sum(SlTon) from SanPham", connector.con);
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
