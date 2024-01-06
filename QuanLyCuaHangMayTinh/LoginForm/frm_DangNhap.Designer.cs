namespace QuanLyCuaHangMayTinh
{
    partial class frm_DangNhap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.llbl_forgetpassword = new System.Windows.Forms.LinkLabel();
            this.cb_remindme = new System.Windows.Forms.CheckBox();
            this.lbl_validateUsername = new System.Windows.Forms.Label();
            this.lbl_validatePassword = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_show = new System.Windows.Forms.PictureBox();
            this.pic_hidden = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Location = new System.Drawing.Point(145, 365);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(306, 34);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Location = new System.Drawing.Point(145, 449);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(306, 34);
            this.txt_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng nhập hệ thống quản lý cửa hàng máy tính";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Black;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(73, 566);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(387, 49);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // llbl_forgetpassword
            // 
            this.llbl_forgetpassword.AutoSize = true;
            this.llbl_forgetpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbl_forgetpassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_forgetpassword.Location = new System.Drawing.Point(353, 528);
            this.llbl_forgetpassword.Name = "llbl_forgetpassword";
            this.llbl_forgetpassword.Size = new System.Drawing.Size(115, 21);
            this.llbl_forgetpassword.TabIndex = 0;
            this.llbl_forgetpassword.TabStop = true;
            this.llbl_forgetpassword.Text = "Đổi mật khẩu!";
            this.llbl_forgetpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_forgetpassword_LinkClicked);
            // 
            // cb_remindme
            // 
            this.cb_remindme.AutoSize = true;
            this.cb_remindme.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_remindme.Location = new System.Drawing.Point(73, 527);
            this.cb_remindme.Name = "cb_remindme";
            this.cb_remindme.Size = new System.Drawing.Size(141, 25);
            this.cb_remindme.TabIndex = 8;
            this.cb_remindme.Text = "Lưu mật khẩu?";
            this.cb_remindme.UseVisualStyleBackColor = true;
            this.cb_remindme.CheckedChanged += new System.EventHandler(this.cb_remindme_CheckedChanged);
            // 
            // lbl_validateUsername
            // 
            this.lbl_validateUsername.AutoSize = true;
            this.lbl_validateUsername.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_validateUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_validateUsername.Location = new System.Drawing.Point(144, 402);
            this.lbl_validateUsername.Name = "lbl_validateUsername";
            this.lbl_validateUsername.Size = new System.Drawing.Size(0, 21);
            this.lbl_validateUsername.TabIndex = 9;
            // 
            // lbl_validatePassword
            // 
            this.lbl_validatePassword.AutoSize = true;
            this.lbl_validatePassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_validatePassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_validatePassword.Location = new System.Drawing.Point(144, 503);
            this.lbl_validatePassword.Name = "lbl_validatePassword";
            this.lbl_validatePassword.Size = new System.Drawing.Size(0, 21);
            this.lbl_validatePassword.TabIndex = 10;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.btn_login;
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Blue;
            this.pic_close.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.close;
            this.pic_close.Location = new System.Drawing.Point(495, 12);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(24, 25);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_close.TabIndex = 15;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_show
            // 
            this.pic_show.BackColor = System.Drawing.Color.White;
            this.pic_show.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_show.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.eye;
            this.pic_show.Location = new System.Drawing.Point(422, 449);
            this.pic_show.Name = "pic_show";
            this.pic_show.Size = new System.Drawing.Size(29, 29);
            this.pic_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_show.TabIndex = 14;
            this.pic_show.TabStop = false;
            this.pic_show.Visible = false;
            this.pic_show.Click += new System.EventHandler(this.pic_show_Click);
            // 
            // pic_hidden
            // 
            this.pic_hidden.BackColor = System.Drawing.Color.White;
            this.pic_hidden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_hidden.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.hidden;
            this.pic_hidden.Location = new System.Drawing.Point(422, 449);
            this.pic_hidden.Name = "pic_hidden";
            this.pic_hidden.Size = new System.Drawing.Size(29, 29);
            this.pic_hidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_hidden.TabIndex = 13;
            this.pic_hidden.TabStop = false;
            this.pic_hidden.Click += new System.EventHandler(this.pic_hidden_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.user;
            this.pictureBox3.Location = new System.Drawing.Point(73, 338);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyCuaHangMayTinh.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(73, 417);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCuaHangMayTinh.Properties.Resources.computer;
            this.pictureBox1.Location = new System.Drawing.Point(147, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this;
            // 
            // frm_DangNhap
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(531, 649);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.pic_show);
            this.Controls.Add(this.pic_hidden);
            this.Controls.Add(this.lbl_validatePassword);
            this.Controls.Add(this.lbl_validateUsername);
            this.Controls.Add(this.cb_remindme);
            this.Controls.Add(this.llbl_forgetpassword);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.x_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel llbl_forgetpassword;
        private System.Windows.Forms.CheckBox cb_remindme;
        private System.Windows.Forms.Label lbl_validateUsername;
        private System.Windows.Forms.Label lbl_validatePassword;
        private System.Windows.Forms.PictureBox pic_hidden;
        private System.Windows.Forms.PictureBox pic_show;
        private System.Windows.Forms.PictureBox pic_close;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}

