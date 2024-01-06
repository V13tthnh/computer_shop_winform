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

namespace QuanLyCuaHangMayTinh.MainForm
{
    public partial class QuanLyKhuyenMai : UserControl
    {
        KhuyenMaiBLL khuyenmai;
        public QuanLyKhuyenMai()
        {
            InitializeComponent();
            khuyenmai = new KhuyenMaiBLL();

        }

        private void grv_DSKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = grv_DSKM.SelectedRows[0];
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                txtMaKM.Text = selectedRow.Cells[1].Value.ToString();
                txtGiaTriGiam.Text = selectedRow.Cells[2].Value.ToString();
                dtpNgayBatDau.Value = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
                dtpNgayKetThuc.Value = Convert.ToDateTime(selectedRow.Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            grv_DSKM.DataSource = khuyenmai.LayDSKM();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKM.Text == "" || txtGiaTriGiam.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(dtpNgayBatDau.Value >= dtpNgayKetThuc.Value)
                    {
                        MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        KhuyenMaiDTO km = new KhuyenMaiDTO(txtMaKM.Text, int.Parse(txtGiaTriGiam.Text), dtpNgayBatDau.Value.ToString(), dtpNgayKetThuc.Value.ToString(), 1);
                        if (khuyenmai.ThemKM(km))
                        {
                            MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grv_DSKM.DataSource = khuyenmai.LayDSKM();
                            btnReset.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGiaTriGiam.Text = "";
            txtMaKM.Text = "";
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_DSKM.SelectedRows.Count > 0)
                {
                    if (txtMaKM.Text == "" || txtGiaTriGiam.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (dtpNgayBatDau.Value >= dtpNgayKetThuc.Value)
                        {
                            MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DataGridViewRow selectedRow = grv_DSKM.SelectedRows[0];
                            KhuyenMaiDTO km = new KhuyenMaiDTO(int.Parse(txtID.Text), txtMaKM.Text, int.Parse(txtGiaTriGiam.Text), dtpNgayBatDau.Value.ToString(), dtpNgayKetThuc.Value.ToString(), 1);
                            if (khuyenmai.SuaKM(km))
                            {
                                MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                grv_DSKM.DataSource = khuyenmai.LayDSKM();
                                btnReset.PerformClick();
                            }
                            else
                            {
                                MessageBox.Show("Sửa không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_DSKM.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = grv_DSKM.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();

                    if (khuyenmai.XoaKM(id))
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_DSKM.DataSource = khuyenmai.LayDSKM();
                        btnReset.PerformClick();
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

        private void pb_timKiemSP_Click(object sender, EventArgs e)
        {
            grv_DSKM.DataSource = khuyenmai.TimKiemKM(txt_timKiemKM.Text);
        }

        private void txt_timKiemKM_TextChanged(object sender, EventArgs e)
        {
            if(txt_timKiemKM.Text == "")
            {
                grv_DSKM.DataSource = khuyenmai.LayDSKM();
            }
        }
    }
}
