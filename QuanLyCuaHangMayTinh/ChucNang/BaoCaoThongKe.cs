using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangMayTinh.ChucNang
{
    public partial class BaoCaoThongKe : UserControl
    {
        HoaDonBLL hdbll = new HoaDonBLL();
        SanPhamBLL spbll = new SanPhamBLL();
        CTHDBLL cthdbll = new CTHDBLL();
        LoaiSanPhamBLL loaispbll = new LoaiSanPhamBLL();

        
        public BaoCaoThongKe()
        {
            InitializeComponent();
        }

        public void TongTienTonKho()
        {

            DataTable dt = spbll.TongTienNhap();
            DataRow row = dt.Rows[0];
            lbl_tongTienTon.Text = string.Format("{0:n}", double.Parse(row[0].ToString())) + " vnđ";
        }

        public void TongSlTon()
        {
            DataTable dt = spbll.TongSLTon();
            DataRow row = dt.Rows[0];
            lbl_sLTon.Text = row[0].ToString();
        }

        public void TongSlBan()
        {
            DataTable dt = cthdbll.TongSLBan();
            DataRow row = dt.Rows[0];
            lbl_SLBan.Text = row[0].ToString();
        }

        public void TongTienBan()
        {
            DataTable dt = cthdbll.TongTienBan();
            DataRow row = dt.Rows[0];
            lbl_tongTienBan.Text = string.Format("{0:n}", double.Parse(row[0].ToString())) + " vnđ";
        }


        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            TongTienTonKho();
            TongSlTon();
            TongSlBan();
            TongTienBan();
            cbb_DanhMucSanPham.DataSource = loaispbll.LayDSLoaiSP();
            cbb_DanhMucSanPham.DisplayMember = "TenLoaiSanPham";
            
        }
    }
}
