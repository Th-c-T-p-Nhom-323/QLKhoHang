namespace QuanLyKhoHang
{
    partial class DangNhapHeThong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.chb_showpass = new System.Windows.Forms.CheckBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đăng Nhập";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu";
            this.label3.UseMnemonic = false;
            // 
            // tbx_username
            // 
            this.tbx_username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_username.Location = new System.Drawing.Point(245, 106);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(178, 30);
            this.tbx_username.TabIndex = 1;
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(245, 148);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(178, 30);
            this.tbx_password.TabIndex = 2;
            this.tbx_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_password_KeyDown);
            // 
            // chb_showpass
            // 
            this.chb_showpass.AutoSize = true;
            this.chb_showpass.Location = new System.Drawing.Point(245, 184);
            this.chb_showpass.Name = "chb_showpass";
            this.chb_showpass.Size = new System.Drawing.Size(123, 21);
            this.chb_showpass.TabIndex = 3;
            this.chb_showpass.Text = "Hiện mật khẩu";
            this.chb_showpass.UseVisualStyleBackColor = true;
            this.chb_showpass.CheckedChanged += new System.EventHandler(this.chb_showpass_CheckedChanged);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.btn_dangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangnhap.Location = new System.Drawing.Point(114, 226);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(114, 34);
            this.btn_dangnhap.TabIndex = 4;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.btn_thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(283, 227);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(114, 33);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // DangNhapHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 299);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.chb_showpass);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DangNhapHeThong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.CheckBox chb_showpass;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_dangnhap;
    }
}

