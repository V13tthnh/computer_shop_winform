using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangMayTinh.MainForm
{
    public partial class QuanLySanPham : UserControl
    {
        SanPhamBLL spbll = new SanPhamBLL();
        LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();
        string imageUrl = null;
        public QuanLySanPham()
        {
            InitializeComponent();
            grv_DSSP.DataSource = spbll.LayDSSP();
        }

        private void btn_suaMT_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_DSSP.SelectedRows.Count > 0)
                {
                    if (txt_maSPMT.Text == "" || txt_tenSPMT.Text == "" || txt_donGiaMT.Text == "" || txt_moTaMT.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataGridViewRow selectedRow = grv_DSSP.SelectedRows[0];
                        SanPhamDTO sp = new SanPhamDTO(int.Parse(txtMaLoai.Text), txt_maNCC.Text, txt_tenSPMT.Text, int.Parse(nudSLTon.Text), float.Parse(txt_donGiaMT.Text), txt_moTaMT.Text, imageUrl, 1);
                        if (spbll.SuaSP(sp))
                        {
                            MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK);
                            grv_DSSP.DataSource = spbll.LayDSSP();
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công!!!", "Thông báo", MessageBoxButtons.OK);
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


        private void btn_xoaMT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenSPMT.Text == "" || nudSLTon.Value == 0 || txtMaLoai.Text == "" || txt_donGiaMT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataGridViewRow selectedRow = grv_DSSP.SelectedRows[0];
                    string MaSP = selectedRow.Cells[0].Value.ToString();
                    if (spbll.XoaSP(MaSP))
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK);
                        grv_DSSP.DataSource = spbll.LayDSSP();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!!!", "Thông báo", MessageBoxButtons.OK);
                        grv_DSSP.DataSource = spbll.LayDSSP();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_maSPMT.Text = "";
            txtMaLoai.Text = "";
            txt_maNCC.Text = "";
            txt_tenSPMT.Text = "";
            nudSLTon.Value = 0;
            txt_donGiaMT.Text = "";
            txt_moTaMT.Text = "";
            pb_AnhMT.Image = null;
        }

        private void btn_themMT_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenSPMT.Text == "" || nudSLTon.Value == 0 || txtMaLoai.Text == "" || txt_donGiaMT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SanPhamDTO sp = new SanPhamDTO(int.Parse(txtMaLoai.Text), txt_maNCC.Text, txt_tenSPMT.Text, int.Parse(nudSLTon.Value.ToString()), double.Parse(txt_donGiaMT.Text), txt_moTaMT.Text, imageUrl, 1);

                    if (spbll.ThemSP(sp))
                    {
                        MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_DSSP.DataSource = spbll.LayDSSP();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grv_DSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = grv_DSSP.SelectedRows[0];
                txt_maSPMT.Text = selectedRow.Cells["MaSP"].Value.ToString();
                txtMaLoai.Text = selectedRow.Cells["MaLoai"].Value.ToString();
                txt_maNCC.Text = selectedRow.Cells["MaNCC"].Value.ToString();
                //cbbTenLoaiSP.Text = selectedRow.Cells["TenLoaiSanPham"].Value.ToString();
                txt_tenSPMT.Text = selectedRow.Cells["TenSP"].Value.ToString();
                nudSLTon.Value = decimal.Parse(selectedRow.Cells["SLTon"].Value.ToString());
                txt_donGiaMT.Text = selectedRow.Cells["DonGia"].Value.ToString();
                txt_moTaMT.Text = selectedRow.Cells["MoTa"].Value.ToString();
                pb_AnhMT.Image = Image.FromFile(selectedRow.Cells["AnhSP"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_browseIMGMT_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Choose Image(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    pb_AnhMT.Image = Image.FromFile(of.FileName);
                    imageUrl = of.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_Click_1(object sender, EventArgs e)
        {
            txt_maSPMT.Text = "";
            txtMaLoai.Text = "";
            txt_maNCC.Text = "";
            //cbbTenLoaiSP.Text = selectedRow.Cells["TenLoaiSanPham"].Value.ToString();
            txt_tenSPMT.Text = "";
            nudSLTon.Value = 0;
            txt_donGiaMT.Text = "";
            txt_moTaMT.Text = "";
            pb_AnhMT.Image = null;
            grv_DSSP.DataSource = spbll.LayDSSP();
        }

        private void btn_xoaMT_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (grv_DSSP.SelectedRows.Count > 0)
                {
                   
                    DataGridViewRow selectedRow = grv_DSSP.SelectedRows[0];
                    string masp = selectedRow.Cells["MaSP"].Value.ToString();
                    
                    if (spbll.XoaSP(masp))
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grv_DSSP.DataSource = spbll.LayDSSP();
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

        private void btn_suaMT_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (grv_DSSP.SelectedRows.Count > 0)
                {
                    if (txt_tenSPMT.Text == "" || txt_moTaMT.Text == "" || txt_maNCC.Text == "" || txt_donGiaMT.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataGridViewRow selectedRow = grv_DSSP.SelectedRows[0];
                        SanPhamDTO sp = new SanPhamDTO(int.Parse(txtMaLoai.Text), txt_maNCC.Text, txt_tenSPMT.Text, int.Parse(nudSLTon.Value.ToString()), double.Parse(txt_donGiaMT.Text), txt_moTaMT.Text, imageUrl, 1);
                        if (spbll.SuaSP(sp))
                        {
                            MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grv_DSSP.DataSource = spbll.LayDSSP();
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

        private void pb_timKiemSP_Click(object sender, EventArgs e)
        {
            grv_DSSP.DataSource = spbll.TimKiemSP(txt_timKiemMT.Text);

        }

        private void txt_timKiemMT_TextChanged(object sender, EventArgs e)
        {
            if(txt_timKiemMT.Text == "")
            {
                grv_DSSP.DataSource = spbll.LayDSSP();
            }
        }

        private void txt_donGiaMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            cbbTenLoaiSP.DataSource = lspbll.LayDSLoaiSP();
            cbbTenLoaiSP.DisplayMember = "TenLoaiSanPham";
        }

        private void txtMaLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
