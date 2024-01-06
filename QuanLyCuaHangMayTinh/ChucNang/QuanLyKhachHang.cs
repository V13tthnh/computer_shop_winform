using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using DTO;

namespace QuanLyCuaHangMayTinh.MainForm
{
    public partial class QuanLyKhachHang : UserControl
    {
        KhachHangBLL khbll = null;
        int tt = 1;
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            khbll = new KhachHangBLL();
            grv_danhSachKH.DataSource = khbll.LayDSKH();
        }

        private void pb_timKiem_Click(object sender, EventArgs e)
        {
            if (txt_timKiemKH.Text == "")
            {
                grv_danhSachKH.DataSource = khbll.LayDSKH();
            }
            grv_danhSachKH.DataSource = khbll.TimKH(txt_timKiemKH.Text);
        }

        private void grv_danhSachKH_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = grv_danhSachKH.SelectedRows[0];
                txt_maKH.Text = selectedRow.Cells[0].Value.ToString();
                txt_tenKH.Text = selectedRow.Cells[1].Value.ToString();
                if (selectedRow.Cells[2].Value.ToString() == cb_nam.Text)
                {
                    cb_nam.Checked = true;
                    cb_nu.Checked = false;
                }
                else
                {
                    cb_nu.Checked = true;
                    cb_nam.Checked = false;
                }
                txt_diaChi.Text = selectedRow.Cells[3].Value.ToString();
                txt_sdt.Text = selectedRow.Cells[4].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void txt_timKiemKH_TextChanged(object sender, EventArgs e)
        {
            if(txt_timKiemKH.Text == "")
            {
                grv_danhSachKH.DataSource = khbll.LayDSKH();
            }
        }

     
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_maKH.Text = "";
            txt_tenKH.Text = "";
            txt_diaChi.Text = "";
            txt_sdt.Text = "";
            txt_timKiemKH.Text = "";
            cb_nam.Checked = false;
            cb_nu.Checked = false;
            grv_danhSachKH.DataSource = khbll.LayDSKH();
        }

        private void btnSuaMT_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_danhSachKH.SelectedRows.Count > 0)
                {
                    if (txt_tenKH.Text == "" || txt_diaChi.Text == "" || txt_sdt.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataGridViewRow selectedRow = grv_danhSachKH.SelectedRows[0];
                        string gt = cb_nam.Checked ? gt = "Nam" : gt = "Nữ";
                        KhachHangDTO kh = new KhachHangDTO(int.Parse(txt_maKH.Text), txt_tenKH.Text, gt, txt_diaChi.Text, txt_sdt.Text, 1);
                        if (khbll.SuaKH(kh))
                        {
                            MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grv_danhSachKH.DataSource = khbll.LayDSKH();
                            btn_reset.PerformClick();
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

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_danhSachKH.SelectedRows.Count > 0)
                {
                    //Lấy row hiện tại
                    DataGridViewRow selectedRow = grv_danhSachKH.SelectedRows[0];
                    string makh = selectedRow.Cells[0].Value.ToString();
                    //Xóa
                    if (khbll.XoaKH(makh))
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_danhSachKH.DataSource = khbll.LayDSKH();
                        btn_reset.PerformClick();
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

        private void cb_nam_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_nam.Checked)
            {
                cb_nu.Checked = false;
            }
            else
            {
                cb_nam.Checked = false;
            }
        }

        private void cb_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nu.Checked)
            {
                cb_nam.Checked = false;
            }
            else
            {
                cb_nu.Checked = false;
            }
        }

        private void btn_themKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenKH.Text == "" || txt_sdt.Text == "" || txt_diaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string gt = cb_nam.Checked == true ? gt = cb_nam.Text : gt = cb_nu.Text;
                    KhachHangDTO khachhang = new KhachHangDTO(txt_tenKH.Text, gt, txt_diaChi.Text, txt_sdt.Text, 1);
                    if (khbll.ThemKH(khachhang))
                    {
                        MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_danhSachKH.DataSource = khbll.LayDSKH();
                        btn_reset.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
