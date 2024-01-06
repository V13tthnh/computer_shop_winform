using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyCuaHangMayTinh.MainForm
{
    
    public partial class QuanLyHoaDon : UserControl
    {
        HoaDonBLL hdbll = null;
        CTHDBLL cthdbll = null;
        public QuanLyHoaDon()
        {
            hdbll = new HoaDonBLL();
            cthdbll = new CTHDBLL();
            InitializeComponent();
            grv_danhSachHoaDon.DataSource = hdbll.LayDSHD();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void tbCTHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbQuanLyHoaDon.SelectedIndex == 0)
            {
                grv_danhSachHoaDon.DataSource = hdbll.LayDSHD();
            }
            else
            {
               grv_DSCTHD.DataSource = cthdbll.LayDSCTHD();
            }
        }

        private void tpQuanLyCTHD_Click(object sender, EventArgs e)
        {

        }

        private void grv_danhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = grv_danhSachHoaDon.SelectedRows[0];
                txt_maHD.Text = selectedRow.Cells[0].Value.ToString();
                txt_maNV.Text = selectedRow.Cells[1].Value.ToString();
                txt_makH.Text = selectedRow.Cells[2].Value.ToString();
                dtp_ngayLap.Text = selectedRow.Cells[3].Value.ToString();
                txt_tongTien.Text = selectedRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grv_DSCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = grv_DSCTHD.SelectedRows[0];
                txtMaCTHD.Text = selectedRow.Cells["MaCTHD"].Value.ToString();
                txtMaHD.Text = selectedRow.Cells["MaHoaDon"].Value.ToString();
                txtMaSP.Text = selectedRow.Cells["MaSP"].Value.ToString();
                txtSoLuong.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                txtDonGia.Text = selectedRow.Cells["DonGia"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   

   

        private void btn_themHD_Click_1(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    HoaDonDTO hoadon = new HoaDonDTO(int.Parse(txt_maNV.Text), int.Parse(txt_makH.Text), dtp_ngayLap.Value.ToString("yy-MM-dd"), float.Parse(txt_tongTien.Text), 0);
                    if (hdbll.ThemHD(hoadon))
                    {
                        MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_danhSachHoaDon.DataSource = hdbll.LayDSHD();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoaHD_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_danhSachHoaDon.SelectedRows.Count > 0)
                {
                    //Lấy row hiện tại
                    DataGridViewRow selectedRow = grv_danhSachHoaDon.SelectedRows[0];
                    string mahd = selectedRow.Cells[0].Value.ToString();
                    //Xóa CTHD trước vì có khóa ngoại
                    cthdbll.XoaCTHD(mahd);
                    //Sau đó xóa hóa đơn
                    if (hdbll.XoaHD(mahd))
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_danhSachHoaDon.DataSource = hdbll.LayDSHD();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chọn vào dòng muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_suaHD_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (grv_danhSachHoaDon.SelectedRows.Count > 0)
                {
                    if (txt_maNV.Text == "" || txt_makH.Text == "" || txt_tongTien.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataGridViewRow selectedRow = grv_danhSachHoaDon.SelectedRows[0];
                        HoaDonDTO hd = new HoaDonDTO(int.Parse(txt_maNV.Text), int.Parse(txt_makH.Text), dtp_ngayLap.Text, double.Parse(txt_tongTien.Text), 0);
                        if (hdbll.SuaHD(hd))
                        {
                            MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grv_danhSachHoaDon.DataSource = hdbll.LayDSHD();
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Chọn vào dòng muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txt_maNV.Text = "";
            txt_makH.Text = "";
            txt_tongTien.Text = "";
            grv_danhSachHoaDon.DataSource = hdbll.LayDSHD();
        }

        private void txtTimKiemTheoTen_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiemTheoTen.Text == "")
            {
                grv_danhSachHoaDon.DataSource = hdbll.LayDSHD();
            }
        }

        private void pb_timKiemCTHD_Click(object sender, EventArgs e)
        {

        }
    }
}
