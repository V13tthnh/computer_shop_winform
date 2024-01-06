namespace QuanLyCuaHangMayTinh.MainForm
{
    partial class QuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_timKiemKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_nu = new System.Windows.Forms.CheckBox();
            this.cb_nam = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pb_timKiem = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btnSuaMT = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_danhSachKH = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_themKH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_timKiem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_danhSachKH)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_timKiemKH
            // 
            this.txt_timKiemKH.Location = new System.Drawing.Point(792, 302);
            this.txt_timKiemKH.Name = "txt_timKiemKH";
            this.txt_timKiemKH.Size = new System.Drawing.Size(488, 26);
            this.txt_timKiemKH.TabIndex = 36;
            this.txt_timKiemKH.TextChanged += new System.EventHandler(this.txt_timKiemKH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(788, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tìm theo tên:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cb_nu);
            this.groupBox1.Controls.Add(this.cb_nam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_tenKH);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.txt_maKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1265, 244);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cb_nu
            // 
            this.cb_nu.AutoSize = true;
            this.cb_nu.Location = new System.Drawing.Point(1033, 47);
            this.cb_nu.Name = "cb_nu";
            this.cb_nu.Size = new System.Drawing.Size(49, 22);
            this.cb_nu.TabIndex = 96;
            this.cb_nu.Text = "Nữ";
            this.cb_nu.UseVisualStyleBackColor = true;
            this.cb_nu.CheckedChanged += new System.EventHandler(this.cb_nu_CheckedChanged);
            // 
            // cb_nam
            // 
            this.cb_nam.AutoSize = true;
            this.cb_nam.Location = new System.Drawing.Point(881, 46);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(61, 22);
            this.cb_nam.TabIndex = 95;
            this.cb_nam.Text = "Nam";
            this.cb_nam.UseVisualStyleBackColor = true;
            this.cb_nam.CheckedChanged += new System.EventHandler(this.cb_nam_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 94;
            this.label2.Text = "Giới tính:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(123, 152);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(324, 26);
            this.txt_sdt.TabIndex = 93;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Location = new System.Drawing.Point(123, 99);
            this.txt_tenKH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(324, 26);
            this.txt_tenKH.TabIndex = 91;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(127, 201);
            this.txt_diaChi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(324, 26);
            this.txt_diaChi.TabIndex = 90;
            // 
            // txt_maKH
            // 
            this.txt_maKH.Location = new System.Drawing.Point(123, 42);
            this.txt_maKH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.ReadOnly = true;
            this.txt_maKH.Size = new System.Drawing.Size(324, 26);
            this.txt_maKH.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 87;
            this.label8.Text = "Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 18);
            this.label9.TabIndex = 86;
            this.label9.Text = "SĐT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 85;
            this.label10.Text = "Tên KH:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 46);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 84;
            this.label11.Text = "Mã KH:";
            // 
            // pb_timKiem
            // 
            this.pb_timKiem.BackColor = System.Drawing.Color.White;
            this.pb_timKiem.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.search;
            this.pb_timKiem.Location = new System.Drawing.Point(1239, 302);
            this.pb_timKiem.Name = "pb_timKiem";
            this.pb_timKiem.Size = new System.Drawing.Size(41, 21);
            this.pb_timKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_timKiem.TabIndex = 39;
            this.pb_timKiem.TabStop = false;
            this.pb_timKiem.Click += new System.EventHandler(this.pb_timKiem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 45);
            this.panel1.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(562, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 18);
            this.label3.TabIndex = 95;
            this.label3.Text = "Danh sách khách hàng";
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
            this.btn_reset.Location = new System.Drawing.Point(604, 281);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(178, 53);
            this.btn_reset.TabIndex = 100;
            this.btn_reset.Text = "     Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btnSuaMT
            // 
            this.btnSuaMT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btnSuaMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuaMT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaMT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaMT.ForeColor = System.Drawing.Color.Black;
            this.btnSuaMT.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.repair2;
            this.btnSuaMT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaMT.Location = new System.Drawing.Point(408, 283);
            this.btnSuaMT.Name = "btnSuaMT";
            this.btnSuaMT.Size = new System.Drawing.Size(178, 50);
            this.btnSuaMT.TabIndex = 99;
            this.btnSuaMT.Text = "     Sửa";
            this.btnSuaMT.UseVisualStyleBackColor = false;
            this.btnSuaMT.Click += new System.EventHandler(this.btnSuaMT_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btnXoaKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaKH.ForeColor = System.Drawing.Color.Black;
            this.btnXoaKH.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.bin3;
            this.btnXoaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaKH.Location = new System.Drawing.Point(210, 281);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(178, 51);
            this.btnXoaKH.TabIndex = 98;
            this.btnXoaKH.Text = "     Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GT";
            this.GT.HeaderText = "Giới tính";
            this.GT.MinimumWidth = 6;
            this.GT.Name = "GT";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            // 
            // grv_danhSachKH
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.grv_danhSachKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grv_danhSachKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_danhSachKH.BackgroundColor = System.Drawing.Color.White;
            this.grv_danhSachKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_danhSachKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_danhSachKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_danhSachKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grv_danhSachKH.ColumnHeadersHeight = 25;
            this.grv_danhSachKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.GT,
            this.DiaChi,
            this.SDT,
            this.TrangThai});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_danhSachKH.DefaultCellStyle = dataGridViewCellStyle12;
            this.grv_danhSachKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grv_danhSachKH.EnableHeadersVisualStyles = false;
            this.grv_danhSachKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_danhSachKH.Location = new System.Drawing.Point(0, 407);
            this.grv_danhSachKH.Name = "grv_danhSachKH";
            this.grv_danhSachKH.RowHeadersVisible = false;
            this.grv_danhSachKH.RowHeadersWidth = 51;
            this.grv_danhSachKH.RowTemplate.Height = 24;
            this.grv_danhSachKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_danhSachKH.Size = new System.Drawing.Size(1283, 351);
            this.grv_danhSachKH.TabIndex = 85;
            this.grv_danhSachKH.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grv_danhSachKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_danhSachKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_danhSachKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_danhSachKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_danhSachKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_danhSachKH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_danhSachKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_danhSachKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.grv_danhSachKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_danhSachKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grv_danhSachKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_danhSachKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_danhSachKH.ThemeStyle.HeaderStyle.Height = 25;
            this.grv_danhSachKH.ThemeStyle.ReadOnly = false;
            this.grv_danhSachKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_danhSachKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_danhSachKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grv_danhSachKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_danhSachKH.ThemeStyle.RowsStyle.Height = 24;
            this.grv_danhSachKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_danhSachKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_danhSachKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_danhSachKH_CellClick_1);
            // 
            // btn_themKH
            // 
            this.btn_themKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_themKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_themKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_themKH.ForeColor = System.Drawing.Color.Black;
            this.btn_themKH.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.add_friend1;
            this.btn_themKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themKH.Location = new System.Drawing.Point(15, 281);
            this.btn_themKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_themKH.Name = "btn_themKH";
            this.btn_themKH.Size = new System.Drawing.Size(178, 52);
            this.btn_themKH.TabIndex = 101;
            this.btn_themKH.Text = "     Thêm";
            this.btn_themKH.UseVisualStyleBackColor = false;
            this.btn_themKH.Click += new System.EventHandler(this.btn_themKH_Click);
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_themKH);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btnSuaMT);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grv_danhSachKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb_timKiem);
            this.Controls.Add(this.txt_timKiemKH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "QuanLyKhachHang";
            this.Size = new System.Drawing.Size(1283, 758);
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_timKiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_danhSachKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_timKiemKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_timKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_nu;
        private System.Windows.Forms.CheckBox cb_nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btnSuaMT;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private Guna.UI.WinForms.GunaDataGridView grv_danhSachKH;
        private System.Windows.Forms.Button btn_themKH;
    }
}
