namespace QuanLyCuaHangMayTinh.MainForm
{
    partial class QuanLySanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_timKiemMT = new System.Windows.Forms.TextBox();
            this.grv_DSSP = new Guna.UI.WinForms.GunaDataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSLTon = new System.Windows.Forms.NumericUpDown();
            this.cbbTenLoaiSP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_maNCC = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_moTaMT = new System.Windows.Forms.TextBox();
            this.txt_donGiaMT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_browseIMGMT = new System.Windows.Forms.Button();
            this.txt_tenSPMT = new System.Windows.Forms.TextBox();
            this.txt_maSPMT = new System.Windows.Forms.TextBox();
            this.lbl_gia = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_soLuong = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_doHoa = new System.Windows.Forms.Label();
            this.lbl_SSD = new System.Windows.Forms.Label();
            this.lbl_RAM = new System.Windows.Forms.Label();
            this.lbl_CPU = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_AnhMT = new System.Windows.Forms.PictureBox();
            this.pb_timKiemSP = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_suaMT = new System.Windows.Forms.Button();
            this.btn_themSP = new System.Windows.Forms.Button();
            this.btn_xoaMT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DSSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_timKiemSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_timKiemMT
            // 
            this.txt_timKiemMT.Location = new System.Drawing.Point(1000, 325);
            this.txt_timKiemMT.Name = "txt_timKiemMT";
            this.txt_timKiemMT.Size = new System.Drawing.Size(280, 26);
            this.txt_timKiemMT.TabIndex = 60;
            this.txt_timKiemMT.TextChanged += new System.EventHandler(this.txt_timKiemMT_TextChanged);
            // 
            // grv_DSSP
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_DSSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_DSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_DSSP.BackgroundColor = System.Drawing.Color.White;
            this.grv_DSSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_DSSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_DSSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_DSSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_DSSP.ColumnHeadersHeight = 25;
            this.grv_DSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.MaLoai,
            this.MaNCC,
            this.TenSP,
            this.SLTon,
            this.DonGia,
            this.MoTa,
            this.AnhSP,
            this.TrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_DSSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.grv_DSSP.EnableHeadersVisualStyles = false;
            this.grv_DSSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DSSP.Location = new System.Drawing.Point(0, 402);
            this.grv_DSSP.Name = "grv_DSSP";
            this.grv_DSSP.RowHeadersVisible = false;
            this.grv_DSSP.RowHeadersWidth = 51;
            this.grv_DSSP.RowTemplate.Height = 24;
            this.grv_DSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_DSSP.Size = new System.Drawing.Size(1280, 353);
            this.grv_DSSP.TabIndex = 54;
            this.grv_DSSP.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grv_DSSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DSSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_DSSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_DSSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_DSSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_DSSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_DSSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DSSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.grv_DSSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_DSSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grv_DSSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_DSSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_DSSP.ThemeStyle.HeaderStyle.Height = 25;
            this.grv_DSSP.ThemeStyle.ReadOnly = false;
            this.grv_DSSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DSSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_DSSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grv_DSSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DSSP.ThemeStyle.RowsStyle.Height = 24;
            this.grv_DSSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DSSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_DSSP_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã loại";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // SLTon
            // 
            this.SLTon.DataPropertyName = "SLTon";
            this.SLTon.HeaderText = "Số lượng tồn";
            this.SLTon.MinimumWidth = 6;
            this.SLTon.Name = "SLTon";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            // 
            // AnhSP
            // 
            this.AnhSP.DataPropertyName = "AnhSP";
            this.AnhSP.HeaderText = "Ảnh";
            this.AnhSP.MinimumWidth = 6;
            this.AnhSP.Name = "AnhSP";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(1000, 304);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(179, 18);
            this.label19.TabIndex = 61;
            this.label19.Text = "Tìm theo tên sản phẩm:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 40);
            this.panel2.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(534, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Danh Sách Sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.groupBox2.Controls.Add(this.nudSLTon);
            this.groupBox2.Controls.Add(this.cbbTenLoaiSP);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMaLoai);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txt_maNCC);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txt_moTaMT);
            this.groupBox2.Controls.Add(this.txt_donGiaMT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btn_browseIMGMT);
            this.groupBox2.Controls.Add(this.txt_tenSPMT);
            this.groupBox2.Controls.Add(this.txt_maSPMT);
            this.groupBox2.Controls.Add(this.lbl_gia);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lbl_soLuong);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lbl_doHoa);
            this.groupBox2.Controls.Add(this.lbl_SSD);
            this.groupBox2.Controls.Add(this.lbl_RAM);
            this.groupBox2.Controls.Add(this.lbl_CPU);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pb_AnhMT);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 348);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // nudSLTon
            // 
            this.nudSLTon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nudSLTon.Location = new System.Drawing.Point(475, 102);
            this.nudSLTon.Name = "nudSLTon";
            this.nudSLTon.Size = new System.Drawing.Size(242, 26);
            this.nudSLTon.TabIndex = 49;
            // 
            // cbbTenLoaiSP
            // 
            this.cbbTenLoaiSP.FormattingEnabled = true;
            this.cbbTenLoaiSP.Location = new System.Drawing.Point(475, 212);
            this.cbbTenLoaiSP.Name = "cbbTenLoaiSP";
            this.cbbTenLoaiSP.Size = new System.Drawing.Size(242, 26);
            this.cbbTenLoaiSP.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tên loại:";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(475, 153);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(242, 26);
            this.txtMaLoai.TabIndex = 46;
            this.txtMaLoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaLoai_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(400, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 18);
            this.label21.TabIndex = 45;
            this.label21.Text = "Mã loại:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(404, 103);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 18);
            this.label24.TabIndex = 41;
            this.label24.Text = "SL tồn:";
            // 
            // txt_maNCC
            // 
            this.txt_maNCC.Location = new System.Drawing.Point(475, 45);
            this.txt_maNCC.Name = "txt_maNCC";
            this.txt_maNCC.Size = new System.Drawing.Size(242, 26);
            this.txt_maNCC.TabIndex = 37;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(393, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 18);
            this.label22.TabIndex = 35;
            this.label22.Text = "Mã NCC:";
            // 
            // txt_moTaMT
            // 
            this.txt_moTaMT.Location = new System.Drawing.Point(90, 213);
            this.txt_moTaMT.Multiline = true;
            this.txt_moTaMT.Name = "txt_moTaMT";
            this.txt_moTaMT.Size = new System.Drawing.Size(268, 121);
            this.txt_moTaMT.TabIndex = 34;
            // 
            // txt_donGiaMT
            // 
            this.txt_donGiaMT.Location = new System.Drawing.Point(90, 158);
            this.txt_donGiaMT.Name = "txt_donGiaMT";
            this.txt_donGiaMT.Size = new System.Drawing.Size(268, 26);
            this.txt_donGiaMT.TabIndex = 33;
            this.txt_donGiaMT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_donGiaMT_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Mô tả:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Đơn giá:";
            // 
            // btn_browseIMGMT
            // 
            this.btn_browseIMGMT.Location = new System.Drawing.Point(788, 256);
            this.btn_browseIMGMT.Name = "btn_browseIMGMT";
            this.btn_browseIMGMT.Size = new System.Drawing.Size(133, 46);
            this.btn_browseIMGMT.TabIndex = 30;
            this.btn_browseIMGMT.Text = "Browse image";
            this.btn_browseIMGMT.UseVisualStyleBackColor = true;
            this.btn_browseIMGMT.Click += new System.EventHandler(this.btn_browseIMGMT_Click_1);
            // 
            // txt_tenSPMT
            // 
            this.txt_tenSPMT.Location = new System.Drawing.Point(89, 104);
            this.txt_tenSPMT.Name = "txt_tenSPMT";
            this.txt_tenSPMT.Size = new System.Drawing.Size(269, 26);
            this.txt_tenSPMT.TabIndex = 29;
            // 
            // txt_maSPMT
            // 
            this.txt_maSPMT.Location = new System.Drawing.Point(89, 46);
            this.txt_maSPMT.Name = "txt_maSPMT";
            this.txt_maSPMT.ReadOnly = true;
            this.txt_maSPMT.Size = new System.Drawing.Size(269, 26);
            this.txt_maSPMT.TabIndex = 28;
            // 
            // lbl_gia
            // 
            this.lbl_gia.AutoSize = true;
            this.lbl_gia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gia.Location = new System.Drawing.Point(109, 578);
            this.lbl_gia.Name = "lbl_gia";
            this.lbl_gia.Size = new System.Drawing.Size(52, 18);
            this.lbl_gia.TabIndex = 19;
            this.lbl_gia.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(56, 578);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 18);
            this.label18.TabIndex = 18;
            this.label18.Text = "Giá:";
            // 
            // lbl_soLuong
            // 
            this.lbl_soLuong.AutoSize = true;
            this.lbl_soLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soLuong.Location = new System.Drawing.Point(109, 543);
            this.lbl_soLuong.Name = "lbl_soLuong";
            this.lbl_soLuong.Size = new System.Drawing.Size(52, 18);
            this.lbl_soLuong.TabIndex = 17;
            this.lbl_soLuong.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 543);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 18);
            this.label16.TabIndex = 16;
            this.label16.Text = "Số lượng:";
            // 
            // lbl_doHoa
            // 
            this.lbl_doHoa.AutoSize = true;
            this.lbl_doHoa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doHoa.Location = new System.Drawing.Point(109, 502);
            this.lbl_doHoa.Name = "lbl_doHoa";
            this.lbl_doHoa.Size = new System.Drawing.Size(52, 18);
            this.lbl_doHoa.TabIndex = 15;
            this.lbl_doHoa.Text = "label14";
            // 
            // lbl_SSD
            // 
            this.lbl_SSD.AutoSize = true;
            this.lbl_SSD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SSD.Location = new System.Drawing.Point(109, 461);
            this.lbl_SSD.Name = "lbl_SSD";
            this.lbl_SSD.Size = new System.Drawing.Size(52, 18);
            this.lbl_SSD.TabIndex = 13;
            this.lbl_SSD.Text = "label12";
            // 
            // lbl_RAM
            // 
            this.lbl_RAM.AutoSize = true;
            this.lbl_RAM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RAM.Location = new System.Drawing.Point(109, 420);
            this.lbl_RAM.Name = "lbl_RAM";
            this.lbl_RAM.Size = new System.Drawing.Size(52, 18);
            this.lbl_RAM.TabIndex = 12;
            this.lbl_RAM.Text = "label13";
            // 
            // lbl_CPU
            // 
            this.lbl_CPU.AutoSize = true;
            this.lbl_CPU.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPU.Location = new System.Drawing.Point(109, 386);
            this.lbl_CPU.Name = "lbl_CPU";
            this.lbl_CPU.Size = new System.Drawing.Size(52, 18);
            this.lbl_CPU.TabIndex = 11;
            this.lbl_CPU.Text = "label10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đồ họa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "SSD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "RAM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SP:";
            // 
            // pb_AnhMT
            // 
            this.pb_AnhMT.Location = new System.Drawing.Point(760, 45);
            this.pb_AnhMT.Name = "pb_AnhMT";
            this.pb_AnhMT.Size = new System.Drawing.Size(186, 205);
            this.pb_AnhMT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_AnhMT.TabIndex = 0;
            this.pb_AnhMT.TabStop = false;
            // 
            // pb_timKiemSP
            // 
            this.pb_timKiemSP.BackColor = System.Drawing.Color.White;
            this.pb_timKiemSP.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.search;
            this.pb_timKiemSP.Location = new System.Drawing.Point(1237, 325);
            this.pb_timKiemSP.Name = "pb_timKiemSP";
            this.pb_timKiemSP.Size = new System.Drawing.Size(43, 20);
            this.pb_timKiemSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_timKiemSP.TabIndex = 62;
            this.pb_timKiemSP.TabStop = false;
            this.pb_timKiemSP.Click += new System.EventHandler(this.pb_timKiemSP_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.circle_of_two_clockwise_arrows_rotation1;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(1000, 177);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(280, 51);
            this.btn_reset.TabIndex = 59;
            this.btn_reset.Text = "     Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click_1);
            // 
            // btn_suaMT
            // 
            this.btn_suaMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_suaMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_suaMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaMT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_suaMT.ForeColor = System.Drawing.Color.Black;
            this.btn_suaMT.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.repair2;
            this.btn_suaMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suaMT.Location = new System.Drawing.Point(1000, 119);
            this.btn_suaMT.Name = "btn_suaMT";
            this.btn_suaMT.Size = new System.Drawing.Size(280, 51);
            this.btn_suaMT.TabIndex = 58;
            this.btn_suaMT.Text = "     Sửa";
            this.btn_suaMT.UseVisualStyleBackColor = false;
            this.btn_suaMT.Click += new System.EventHandler(this.btn_suaMT_Click_1);
            // 
            // btn_themSP
            // 
            this.btn_themSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_themSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_themSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themSP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_themSP.ForeColor = System.Drawing.Color.Black;
            this.btn_themSP.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.icons8_add_641;
            this.btn_themSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themSP.Location = new System.Drawing.Point(1000, 7);
            this.btn_themSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_themSP.Name = "btn_themSP";
            this.btn_themSP.Size = new System.Drawing.Size(280, 48);
            this.btn_themSP.TabIndex = 56;
            this.btn_themSP.Text = "     Thêm";
            this.btn_themSP.UseVisualStyleBackColor = false;
            this.btn_themSP.Click += new System.EventHandler(this.btn_themMT_Click_1);
            // 
            // btn_xoaMT
            // 
            this.btn_xoaMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_xoaMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_xoaMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaMT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_xoaMT.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaMT.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.bin3;
            this.btn_xoaMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaMT.Location = new System.Drawing.Point(1000, 64);
            this.btn_xoaMT.Name = "btn_xoaMT";
            this.btn_xoaMT.Size = new System.Drawing.Size(280, 48);
            this.btn_xoaMT.TabIndex = 57;
            this.btn_xoaMT.Text = "     Xóa";
            this.btn_xoaMT.UseVisualStyleBackColor = false;
            this.btn_xoaMT.Click += new System.EventHandler(this.btn_xoaMT_Click_1);
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_timKiemSP);
            this.Controls.Add(this.txt_timKiemMT);
            this.Controls.Add(this.grv_DSSP);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_suaMT);
            this.Controls.Add(this.btn_themSP);
            this.Controls.Add(this.btn_xoaMT);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "QuanLySanPham";
            this.Size = new System.Drawing.Size(1283, 758);
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_DSSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSLTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AnhMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_timKiemSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_timKiemSP;
        private System.Windows.Forms.TextBox txt_timKiemMT;
        private Guna.UI.WinForms.GunaDataGridView grv_DSSP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbTenLoaiSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_maNCC;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_moTaMT;
        private System.Windows.Forms.TextBox txt_donGiaMT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_browseIMGMT;
        private System.Windows.Forms.TextBox txt_tenSPMT;
        private System.Windows.Forms.TextBox txt_maSPMT;
        private System.Windows.Forms.Label lbl_gia;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_soLuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_doHoa;
        private System.Windows.Forms.Label lbl_SSD;
        private System.Windows.Forms.Label lbl_RAM;
        private System.Windows.Forms.Label lbl_CPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_AnhMT;
        private System.Windows.Forms.Button btn_suaMT;
        private System.Windows.Forms.Button btn_themSP;
        private System.Windows.Forms.Button btn_xoaMT;
        private System.Windows.Forms.NumericUpDown nudSLTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
