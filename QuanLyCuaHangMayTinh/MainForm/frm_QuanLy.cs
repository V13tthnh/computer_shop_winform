using QuanLyCuaHangMayTinh.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace QuanLyCuaHangMayTinh.ChucNang
{
    public partial class frm_QuanLy : Form
    {
        private TaiKhoanDTO tkdto;
        public string manv = null;
        BaoCaoThongKe baoCaoThongKe = new BaoCaoThongKe();
        QuanLyHoaDon quanLyHoaDon = new QuanLyHoaDon();
        QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
        QuanLyKhuyenMai quanLyKhuyenMai = new QuanLyKhuyenMai();
        QuanLyNhaCC quanLyNhaCC = new QuanLyNhaCC();
        QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
        QuanLySanPham quanLySanPham = new QuanLySanPham();
        BanHang banHang;
        public frm_QuanLy(TaiKhoanDTO tkdto)
        {
            InitializeComponent();
            this.tkdto = tkdto;
            banHang = new BanHang(this.tkdto);
            pnlContainer.Controls.Add(banHang);
            pnlContainer.Controls.Add(baoCaoThongKe);
            pnlContainer.Controls.Add(quanLyHoaDon);
            pnlContainer.Controls.Add(quanLyKhachHang);
            pnlContainer.Controls.Add(quanLyKhuyenMai);
            pnlContainer.Controls.Add(quanLyNhaCC);
            pnlContainer.Controls.Add(quanLyNhanVien);
            pnlContainer.Controls.Add(quanLySanPham);
            banHang.Dock = DockStyle.Fill;
            baoCaoThongKe.Dock = DockStyle.Fill;
            quanLyHoaDon.Dock = DockStyle.Fill;
            quanLyKhachHang.Dock = DockStyle.Fill;
            quanLyKhuyenMai.Dock = DockStyle.Fill;
            quanLyNhaCC.Dock = DockStyle.Fill;
            quanLyNhanVien.Dock = DockStyle.Fill;
            quanLySanPham.Dock = DockStyle.Fill;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void movepanel(Control btn)
        {
            panel_move.Top = btn.Top;
            panel_move.Height = btn.Height;

        }

        private void frm_QuanLy_Load(object sender, EventArgs e)
        {

            timerDateTime.Start();
            lbl_tenTK.Text = tkdto.TaiKhoan.ToString();
            lbl_quyen.Text = tkdto.Quyen.ToString();
            manv = tkdto.MaNV.ToString();
            if (tkdto.Quyen.ToString() == "Nhân viên")
            {
                btn_baoCaoThongKe.Enabled = false;
                btn_khuyenMai.Enabled = false;
                btn_khachHang.Enabled = false;
                btn_nhaCungCap.Enabled = false;
                btn_sanPham.Enabled = false;
                btn_nhanVien.Enabled = false;
            }

            this.btn_nhanVien.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_khachHang.FlatAppearance.BorderSize = 0;
            this.btn_sanPham.FlatAppearance.BorderSize = 0;
            this.btn_banHang.FlatAppearance.BorderSize = 0;
            this.btn_bill.FlatAppearance.BorderSize = 0;
            this.btn_nhaCungCap.FlatAppearance.BorderSize = 0;
            this.btn_khuyenMai.FlatAppearance.BorderSize = 0;
            this.btn_baoCaoThongKe.FlatAppearance.BorderSize = 0;

            banHang.Visible = true;
            quanLyKhachHang.Visible = false;
            quanLyNhaCC.Visible = false;
            quanLyNhanVien.Visible = false;
            quanLySanPham.Visible = false;
            quanLyKhuyenMai.Visible = false;
            quanLyHoaDon.Visible = false;
            baoCaoThongKe.Visible = false;

        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thống?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                movepanel(btn_quit);
                timerDateTime.Stop();
                this.Close();
            }
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lbl_dataTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void btn_nhanVien_Click(object sender, EventArgs e)
        {
            movepanel(btn_nhanVien);
            quanLyNhanVien.Visible = true;
            quanLyNhaCC.Visible = false;
            banHang.Visible = false;
            quanLyKhachHang.Visible = false;
            quanLySanPham.Visible = false;
            quanLyKhuyenMai.Visible = false;
            quanLyHoaDon.Visible = false;
            baoCaoThongKe.Visible = false;
        }

        private void btn_nhaCungCap_Click(object sender, EventArgs e)
        {
            movepanel(btn_nhaCungCap);
            quanLyNhaCC.Visible = true;
            quanLyKhachHang.Visible = false;
            banHang.Visible = false;
            quanLyNhanVien.Visible = false;
            quanLySanPham.Visible = false;
            quanLyKhuyenMai.Visible = false;
            quanLyHoaDon.Visible = false;
            baoCaoThongKe.Visible = false;
        }

        private void btn_khachHang_Click(object sender, EventArgs e)
        {
            movepanel(btn_khachHang);
            quanLyKhachHang.Visible = true;
            quanLyNhaCC.Visible = false;
            banHang.Visible = false;
            quanLyNhanVien.Visible = false;
            quanLySanPham.Visible = false;
            quanLyKhuyenMai.Visible = false;
            quanLyHoaDon.Visible = false;
            baoCaoThongKe.Visible = false;
        }

        private void btn_mayTinh_Click(object sender, EventArgs e)
        {
            movepanel(btn_sanPham);
            quanLySanPham.Visible = true;
            quanLyKhachHang.Visible = false;
            quanLyNhaCC.Visible = false;
            banHang.Visible = false;
            quanLyNhanVien.Visible = false;
            quanLyKhuyenMai.Visible = false;
            quanLyHoaDon.Visible = false;
            baoCaoThongKe.Visible = false;
        }

        private void btn_linhKienDienTu_Click(object sender, EventArgs e)
        {
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
            movepanel(btn_bill);
            quanLyHoaDon.Visible = true;
            quanLySanPham.Visible = false;
            quanLyKhachHang.Visible = false;
            quanLyNhaCC.Visible = false;
            banHang.Visible = false;
            quanLyNhanVien.Visible = false;
            quanLyKhuyenMai.Visible = false;
            baoCaoThongKe.Visible = false;
        }

        private void btn_khuyenMai_Click(object sender, EventArgs e)
        {
            movepanel(btn_khuyenMai);
            quanLyKhuyenMai.Visible = true;
            quanLySanPham.Visible = false;
            quanLyKhachHang.Visible = false;
            quanLyNhaCC.Visible = false;
            banHang.Visible = false;
            quanLyNhanVien.Visible = false;
            quanLyHoaDon.Visible = false;
            baoCaoThongKe.Visible = false;
        }

        private void btn_Kho_Click(object sender, EventArgs e)
        {
        }

        private void btn_baoCaoThongKe_Click(object sender, EventArgs e)
        {
            movepanel(btn_baoCaoThongKe);
            baoCaoThongKe.Visible = true;
            banHang.Visible = false;
            quanLyKhachHang.Visible = false;
            quanLyNhaCC.Visible = false;
            quanLyNhanVien.Visible = false;
            quanLySanPham.Visible = false;
            quanLyKhuyenMai.Visible = false;
            quanLyHoaDon.Visible = false;
        }

        private void btn_banHang_Click(object sender, EventArgs e)
        {
            movepanel(btn_banHang);
            banHang.Visible = true;
            baoCaoThongKe.Visible = false;
            quanLyKhachHang.Visible = false;
            quanLyNhaCC.Visible = false;
            quanLyNhanVien.Visible = false;
            quanLySanPham.Visible = false;
            quanLyKhuyenMai.Visible = false;
            quanLyHoaDon.Visible = false;
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void baoCaoThongKe_Load(object sender, EventArgs e)
        {
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
