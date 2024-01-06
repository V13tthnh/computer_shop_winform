namespace QuanLyCuaHangMayTinh.MainForm
{
    partial class QuanLyNhaCC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txt_timKiemNCC = new System.Windows.Forms.TextBox();
            this.grv_danhSachNCC = new Guna.UI.WinForms.GunaDataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTenNCC = new System.Windows.Forms.ComboBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.txt_lienHe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pb_logoNCC = new System.Windows.Forms.PictureBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_suaMT = new System.Windows.Forms.Button();
            this.btn_xoaMT = new System.Windows.Forms.Button();
            this.pb_timKiemNCC = new System.Windows.Forms.PictureBox();
            this.btn_themNCC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_danhSachNCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoNCC)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_timKiemNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 6;
            this.gunaElipse2.TargetControl = this;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 6;
            this.gunaElipse3.TargetControl = this;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 6;
            this.gunaElipse4.TargetControl = this;
            // 
            // txt_timKiemNCC
            // 
            this.txt_timKiemNCC.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_timKiemNCC.Location = new System.Drawing.Point(946, 340);
            this.txt_timKiemNCC.Name = "txt_timKiemNCC";
            this.txt_timKiemNCC.Size = new System.Drawing.Size(301, 26);
            this.txt_timKiemNCC.TabIndex = 91;
            this.txt_timKiemNCC.TextChanged += new System.EventHandler(this.txt_timKiemNCC_TextChanged);
            // 
            // grv_danhSachNCC
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_danhSachNCC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_danhSachNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_danhSachNCC.BackgroundColor = System.Drawing.Color.White;
            this.grv_danhSachNCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grv_danhSachNCC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_danhSachNCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_danhSachNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_danhSachNCC.ColumnHeadersHeight = 25;
            this.grv_danhSachNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.LienHe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_danhSachNCC.DefaultCellStyle = dataGridViewCellStyle3;
            this.grv_danhSachNCC.EnableHeadersVisualStyles = false;
            this.grv_danhSachNCC.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_danhSachNCC.Location = new System.Drawing.Point(3, 442);
            this.grv_danhSachNCC.Name = "grv_danhSachNCC";
            this.grv_danhSachNCC.RowHeadersVisible = false;
            this.grv_danhSachNCC.RowHeadersWidth = 51;
            this.grv_danhSachNCC.RowTemplate.Height = 24;
            this.grv_danhSachNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grv_danhSachNCC.Size = new System.Drawing.Size(1277, 301);
            this.grv_danhSachNCC.TabIndex = 88;
            this.grv_danhSachNCC.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grv_danhSachNCC.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_danhSachNCC.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_danhSachNCC.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_danhSachNCC.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_danhSachNCC.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_danhSachNCC.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_danhSachNCC.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_danhSachNCC.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.grv_danhSachNCC.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_danhSachNCC.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_danhSachNCC.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_danhSachNCC.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_danhSachNCC.ThemeStyle.HeaderStyle.Height = 25;
            this.grv_danhSachNCC.ThemeStyle.ReadOnly = false;
            this.grv_danhSachNCC.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_danhSachNCC.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_danhSachNCC.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_danhSachNCC.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_danhSachNCC.ThemeStyle.RowsStyle.Height = 24;
            this.grv_danhSachNCC.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_danhSachNCC.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_danhSachNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_danhSachNCC_CellClick);
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // LienHe
            // 
            this.LienHe.DataPropertyName = "LienHe";
            this.LienHe.HeaderText = "Liên hệ";
            this.LienHe.MinimumWidth = 6;
            this.LienHe.Name = "LienHe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTenNCC);
            this.groupBox1.Controls.Add(this.btn_upload);
            this.groupBox1.Controls.Add(this.txt_lienHe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pb_logoNCC);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_maNCC);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 365);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // cbbTenNCC
            // 
            this.cbbTenNCC.FormattingEnabled = true;
            this.cbbTenNCC.Location = new System.Drawing.Point(64, 138);
            this.cbbTenNCC.Name = "cbbTenNCC";
            this.cbbTenNCC.Size = new System.Drawing.Size(230, 26);
            this.cbbTenNCC.TabIndex = 59;
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(552, 275);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(117, 37);
            this.btn_upload.TabIndex = 58;
            this.btn_upload.Text = "Browser image";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // txt_lienHe
            // 
            this.txt_lienHe.Location = new System.Drawing.Point(64, 290);
            this.txt_lienHe.Name = "txt_lienHe";
            this.txt_lienHe.Size = new System.Drawing.Size(230, 26);
            this.txt_lienHe.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "Liên hệ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(572, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 55;
            this.label10.Text = "Logo NCC:";
            // 
            // pb_logoNCC
            // 
            this.pb_logoNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_logoNCC.Location = new System.Drawing.Point(520, 69);
            this.pb_logoNCC.Name = "pb_logoNCC";
            this.pb_logoNCC.Size = new System.Drawing.Size(188, 200);
            this.pb_logoNCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logoNCC.TabIndex = 54;
            this.pb_logoNCC.TabStop = false;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(64, 217);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(230, 26);
            this.txt_diachi.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tên nhà cung cấp:";
            // 
            // txt_maNCC
            // 
            this.txt_maNCC.Location = new System.Drawing.Point(64, 69);
            this.txt_maNCC.Name = "txt_maNCC";
            this.txt_maNCC.Size = new System.Drawing.Size(230, 26);
            this.txt_maNCC.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label5.Location = new System.Drawing.Point(943, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Tìm kiếm tên NCC:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 49);
            this.panel1.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(565, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 18);
            this.label6.TabIndex = 60;
            this.label6.Text = "Danh sách nhà cung cấp";
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
            this.btn_reset.Location = new System.Drawing.Point(1102, 47);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(178, 51);
            this.btn_reset.TabIndex = 96;
            this.btn_reset.Text = "     Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
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
            this.btn_suaMT.Location = new System.Drawing.Point(1102, 116);
            this.btn_suaMT.Name = "btn_suaMT";
            this.btn_suaMT.Size = new System.Drawing.Size(178, 48);
            this.btn_suaMT.TabIndex = 95;
            this.btn_suaMT.Text = "     Sửa";
            this.btn_suaMT.UseVisualStyleBackColor = false;
            this.btn_suaMT.Click += new System.EventHandler(this.btn_suaMT_Click);
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
            this.btn_xoaMT.Location = new System.Drawing.Point(920, 116);
            this.btn_xoaMT.Name = "btn_xoaMT";
            this.btn_xoaMT.Size = new System.Drawing.Size(178, 48);
            this.btn_xoaMT.TabIndex = 94;
            this.btn_xoaMT.Text = "     Xóa";
            this.btn_xoaMT.UseVisualStyleBackColor = false;
            this.btn_xoaMT.Click += new System.EventHandler(this.btn_xoaMT_Click);
            // 
            // pb_timKiemNCC
            // 
            this.pb_timKiemNCC.BackColor = System.Drawing.Color.White;
            this.pb_timKiemNCC.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.search;
            this.pb_timKiemNCC.Location = new System.Drawing.Point(1211, 340);
            this.pb_timKiemNCC.Name = "pb_timKiemNCC";
            this.pb_timKiemNCC.Size = new System.Drawing.Size(36, 18);
            this.pb_timKiemNCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_timKiemNCC.TabIndex = 92;
            this.pb_timKiemNCC.TabStop = false;
            this.pb_timKiemNCC.Click += new System.EventHandler(this.pb_timKiemNCC_Click);
            // 
            // btn_themNCC
            // 
            this.btn_themNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(151)))), ((int)(((byte)(196)))));
            this.btn_themNCC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_themNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themNCC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_themNCC.ForeColor = System.Drawing.Color.Black;
            this.btn_themNCC.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.add_friend1;
            this.btn_themNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themNCC.Location = new System.Drawing.Point(920, 47);
            this.btn_themNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_themNCC.Name = "btn_themNCC";
            this.btn_themNCC.Size = new System.Drawing.Size(178, 48);
            this.btn_themNCC.TabIndex = 84;
            this.btn_themNCC.Text = "     Thêm";
            this.btn_themNCC.UseVisualStyleBackColor = false;
            this.btn_themNCC.Click += new System.EventHandler(this.btn_themNCC_Click);
            // 
            // QuanLyNhaCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_suaMT);
            this.Controls.Add(this.btn_xoaMT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_timKiemNCC);
            this.Controls.Add(this.txt_timKiemNCC);
            this.Controls.Add(this.grv_danhSachNCC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_themNCC);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "QuanLyNhaCC";
            this.Size = new System.Drawing.Size(1283, 758);
            this.Load += new System.EventHandler(this.QuanLyNhaCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_danhSachNCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoNCC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_timKiemNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private System.Windows.Forms.PictureBox pb_timKiemNCC;
        private System.Windows.Forms.TextBox txt_timKiemNCC;
        private Guna.UI.WinForms.GunaDataGridView grv_danhSachNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.TextBox txt_lienHe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pb_logoNCC;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maNCC;
        private System.Windows.Forms.Button btn_themNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LienHe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_suaMT;
        private System.Windows.Forms.Button btn_xoaMT;
        private System.Windows.Forms.ComboBox cbbTenNCC;
    }
}
