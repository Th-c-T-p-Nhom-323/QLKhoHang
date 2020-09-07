namespace QuanLyKhoHang
{
    partial class DanhMucSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMucSP));
            this.tbx_makho = new System.Windows.Forms.ComboBox();
            this.tbx_ghichu = new System.Windows.Forms.TextBox();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_tendm = new System.Windows.Forms.TextBox();
            this.tbx_madm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDANHMUC = new System.Windows.Forms.DataGridView();
            this.group_dmsp = new System.Windows.Forms.GroupBox();
            this.lb_thongbao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.group_qldmsp = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button_lammoi = new System.Windows.Forms.Button();
            this.btn_ghinhan = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_chophepsua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).BeginInit();
            this.group_dmsp.SuspendLayout();
            this.group_qldmsp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_makho
            // 
            this.tbx_makho.FormattingEnabled = true;
            this.tbx_makho.Location = new System.Drawing.Point(640, 53);
            this.tbx_makho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_makho.Name = "tbx_makho";
            this.tbx_makho.Size = new System.Drawing.Size(253, 31);
            this.tbx_makho.TabIndex = 63;
            // 
            // tbx_ghichu
            // 
            this.tbx_ghichu.Location = new System.Drawing.Point(640, 101);
            this.tbx_ghichu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_ghichu.Multiline = true;
            this.tbx_ghichu.Name = "tbx_ghichu";
            this.tbx_ghichu.Size = new System.Drawing.Size(253, 48);
            this.tbx_ghichu.TabIndex = 5;
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.Location = new System.Drawing.Point(165, 334);
            this.tbx_timkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_timkiem.Multiline = true;
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.Size = new System.Drawing.Size(479, 43);
            this.tbx_timkiem.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, -50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Danh Mục Sản Phẩm";
            // 
            // tbx_tendm
            // 
            this.tbx_tendm.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_tendm.ForeColor = System.Drawing.Color.Black;
            this.tbx_tendm.Location = new System.Drawing.Point(334, 101);
            this.tbx_tendm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_tendm.Name = "tbx_tendm";
            this.tbx_tendm.Size = new System.Drawing.Size(160, 30);
            this.tbx_tendm.TabIndex = 2;
            // 
            // tbx_madm
            // 
            this.tbx_madm.BackColor = System.Drawing.SystemColors.Window;
            this.tbx_madm.Enabled = false;
            this.tbx_madm.ForeColor = System.Drawing.Color.Black;
            this.tbx_madm.Location = new System.Drawing.Point(334, 53);
            this.tbx_madm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_madm.Name = "tbx_madm";
            this.tbx_madm.Size = new System.Drawing.Size(156, 30);
            this.tbx_madm.TabIndex = 1;
            this.tbx_madm.TabIndexChanged += new System.EventHandler(this.tbx_madm_TabIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ghi Chú";
            // 
            // dgvDANHMUC
            // 
            this.dgvDANHMUC.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvDANHMUC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDANHMUC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDANHMUC.Location = new System.Drawing.Point(13, 417);
            this.dgvDANHMUC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDANHMUC.Name = "dgvDANHMUC";
            this.dgvDANHMUC.ReadOnly = true;
            this.dgvDANHMUC.RowHeadersVisible = false;
            this.dgvDANHMUC.Size = new System.Drawing.Size(1123, 258);
            this.dgvDANHMUC.TabIndex = 0;
            this.dgvDANHMUC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDANHMUC_CellContentClick);
            // 
            // group_dmsp
            // 
            this.group_dmsp.Controls.Add(this.lb_thongbao);
            this.group_dmsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_dmsp.Location = new System.Drawing.Point(0, 385);
            this.group_dmsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group_dmsp.Name = "group_dmsp";
            this.group_dmsp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group_dmsp.Size = new System.Drawing.Size(1149, 298);
            this.group_dmsp.TabIndex = 37;
            this.group_dmsp.TabStop = false;
            this.group_dmsp.Text = "Danh Sách Danh Mục";
            // 
            // lb_thongbao
            // 
            this.lb_thongbao.AutoSize = true;
            this.lb_thongbao.Location = new System.Drawing.Point(745, 31);
            this.lb_thongbao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thongbao.Name = "lb_thongbao";
            this.lb_thongbao.Size = new System.Drawing.Size(0, 23);
            this.lb_thongbao.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::QuanLyKhoHang.Properties.Resources.reset;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(843, 334);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Làm Mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Timkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timkiem.Image = global::QuanLyKhoHang.Properties.Resources.search;
            this.btn_Timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Timkiem.Location = new System.Drawing.Point(652, 334);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(132, 43);
            this.btn_Timkiem.TabIndex = 11;
            this.btn_Timkiem.Text = "Tìm Kiếm";
            this.btn_Timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên DM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã DM";
            // 
            // group_qldmsp
            // 
            this.group_qldmsp.BackColor = System.Drawing.Color.White;
            this.group_qldmsp.Controls.Add(this.tbx_makho);
            this.group_qldmsp.Controls.Add(this.button2);
            this.group_qldmsp.Controls.Add(this.button_lammoi);
            this.group_qldmsp.Controls.Add(this.btn_ghinhan);
            this.group_qldmsp.Controls.Add(this.bt_xoa);
            this.group_qldmsp.Controls.Add(this.tbx_ghichu);
            this.group_qldmsp.Controls.Add(this.bt_chophepsua);
            this.group_qldmsp.Controls.Add(this.bt_them);
            this.group_qldmsp.Controls.Add(this.tbx_tendm);
            this.group_qldmsp.Controls.Add(this.tbx_madm);
            this.group_qldmsp.Controls.Add(this.label5);
            this.group_qldmsp.Controls.Add(this.label4);
            this.group_qldmsp.Controls.Add(this.label3);
            this.group_qldmsp.Controls.Add(this.label2);
            this.group_qldmsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_qldmsp.Location = new System.Drawing.Point(13, 72);
            this.group_qldmsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group_qldmsp.Name = "group_qldmsp";
            this.group_qldmsp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.group_qldmsp.Size = new System.Drawing.Size(1123, 254);
            this.group_qldmsp.TabIndex = 36;
            this.group_qldmsp.TabStop = false;
            this.group_qldmsp.Text = "Thông Tin Sản Phẩm";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::QuanLyKhoHang.Properties.Resources.Huy1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(660, 174);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 53);
            this.button2.TabIndex = 62;
            this.button2.Text = "Hủy ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_lammoi
            // 
            this.button_lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.button_lammoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lammoi.ForeColor = System.Drawing.Color.White;
            this.button_lammoi.Image = global::QuanLyKhoHang.Properties.Resources.reset;
            this.button_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_lammoi.Location = new System.Drawing.Point(830, 174);
            this.button_lammoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_lammoi.Name = "button_lammoi";
            this.button_lammoi.Size = new System.Drawing.Size(140, 53);
            this.button_lammoi.TabIndex = 42;
            this.button_lammoi.Text = "Làm Mới";
            this.button_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_lammoi.UseVisualStyleBackColor = false;
            this.button_lammoi.Click += new System.EventHandler(this.button_lammoi_Click);
            // 
            // btn_ghinhan
            // 
            this.btn_ghinhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.btn_ghinhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ghinhan.ForeColor = System.Drawing.Color.White;
            this.btn_ghinhan.Image = global::QuanLyKhoHang.Properties.Resources.tick;
            this.btn_ghinhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ghinhan.Location = new System.Drawing.Point(533, 174);
            this.btn_ghinhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ghinhan.Name = "btn_ghinhan";
            this.btn_ghinhan.Size = new System.Drawing.Size(111, 53);
            this.btn_ghinhan.TabIndex = 41;
            this.btn_ghinhan.Text = "Lưu";
            this.btn_ghinhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ghinhan.UseVisualStyleBackColor = false;
            this.btn_ghinhan.Click += new System.EventHandler(this.btn_ghinhan_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.White;
            this.bt_xoa.Image = global::QuanLyKhoHang.Properties.Resources.delete;
            this.bt_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_xoa.Location = new System.Drawing.Point(406, 174);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(111, 53);
            this.bt_xoa.TabIndex = 7;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_chophepsua
            // 
            this.bt_chophepsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.bt_chophepsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chophepsua.ForeColor = System.Drawing.Color.White;
            this.bt_chophepsua.Image = global::QuanLyKhoHang.Properties.Resources.edit;
            this.bt_chophepsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chophepsua.Location = new System.Drawing.Point(279, 174);
            this.bt_chophepsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_chophepsua.Name = "bt_chophepsua";
            this.bt_chophepsua.Size = new System.Drawing.Size(111, 53);
            this.bt_chophepsua.TabIndex = 8;
            this.bt_chophepsua.Text = "Sửa";
            this.bt_chophepsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_chophepsua.UseVisualStyleBackColor = false;
            this.bt_chophepsua.Click += new System.EventHandler(this.bt_chophepsua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.White;
            this.bt_them.Image = global::QuanLyKhoHang.Properties.Resources.plus;
            this.bt_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_them.Location = new System.Drawing.Point(152, 174);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(111, 53);
            this.bt_them.TabIndex = 6;
            this.bt_them.Text = "Thêm ";
            this.bt_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 65);
            this.panel1.TabIndex = 39;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(21, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 41);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(435, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(278, 26);
            this.label12.TabIndex = 32;
            this.label12.Text = "DANH MỤC SẢN PHẨM";
            // 
            // DanhMucSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1149, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDANHMUC);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_timkiem);
            this.Controls.Add(this.group_dmsp);
            this.Controls.Add(this.group_qldmsp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DanhMucSP";
            this.Text = "DanhMucSP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DanhMucSP_FormClosed);
            this.Load += new System.EventHandler(this.DanhMucSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUC)).EndInit();
            this.group_dmsp.ResumeLayout(false);
            this.group_dmsp.PerformLayout();
            this.group_qldmsp.ResumeLayout(false);
            this.group_qldmsp.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox tbx_makho;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_lammoi;
        private System.Windows.Forms.Button btn_ghinhan;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.TextBox tbx_ghichu;
        private System.Windows.Forms.Button bt_chophepsua;
        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tbx_tendm;
        private System.Windows.Forms.TextBox tbx_madm;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDANHMUC;
        private System.Windows.Forms.GroupBox group_dmsp;
        private System.Windows.Forms.Label lb_thongbao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_qldmsp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
    }
}