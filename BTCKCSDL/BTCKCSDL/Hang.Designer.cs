namespace BTCKCSDL
{
    partial class Hang
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
            this.label7 = new System.Windows.Forms.Label();
            this.bt_TimH = new System.Windows.Forms.Button();
            this.bt_RSH = new System.Windows.Forms.Button();
            this.bt_xoaH = new System.Windows.Forms.Button();
            this.bt_suaH = new System.Windows.Forms.Button();
            this.bt_themH = new System.Windows.Forms.Button();
            this.cb_GioN = new System.Windows.Forms.TextBox();
            this.cb_MaNV = new System.Windows.Forms.TextBox();
            this.bt_timkiemPNH = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_NgayN = new System.Windows.Forms.TextBox();
            this.cb_MaNhapHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_TongTNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label7.Location = new System.Drawing.Point(636, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quản Lý Phiếu Nhập Hàng";
            // 
            // bt_TimH
            // 
            this.bt_TimH.BackColor = System.Drawing.Color.Coral;
            this.bt_TimH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_TimH.ForeColor = System.Drawing.Color.Black;
            this.bt_TimH.Location = new System.Drawing.Point(1310, 76);
            this.bt_TimH.Name = "bt_TimH";
            this.bt_TimH.Size = new System.Drawing.Size(93, 34);
            this.bt_TimH.TabIndex = 6;
            this.bt_TimH.Text = "Tìm kiếm";
            this.bt_TimH.UseVisualStyleBackColor = false;
            this.bt_TimH.Click += new System.EventHandler(this.bt_TimH_Click);
            // 
            // bt_RSH
            // 
            this.bt_RSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_RSH.Location = new System.Drawing.Point(1310, 180);
            this.bt_RSH.Name = "bt_RSH";
            this.bt_RSH.Size = new System.Drawing.Size(101, 54);
            this.bt_RSH.TabIndex = 5;
            this.bt_RSH.Text = "Resert";
            this.bt_RSH.UseVisualStyleBackColor = true;
            this.bt_RSH.Click += new System.EventHandler(this.bt_RSH_Click);
            // 
            // bt_xoaH
            // 
            this.bt_xoaH.BackColor = System.Drawing.Color.Coral;
            this.bt_xoaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xoaH.Location = new System.Drawing.Point(1183, 180);
            this.bt_xoaH.Name = "bt_xoaH";
            this.bt_xoaH.Size = new System.Drawing.Size(106, 54);
            this.bt_xoaH.TabIndex = 3;
            this.bt_xoaH.Text = "Xóa";
            this.bt_xoaH.UseVisualStyleBackColor = false;
            this.bt_xoaH.Click += new System.EventHandler(this.bt_xoaH_Click);
            // 
            // bt_suaH
            // 
            this.bt_suaH.BackColor = System.Drawing.Color.Coral;
            this.bt_suaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_suaH.Location = new System.Drawing.Point(1051, 180);
            this.bt_suaH.Name = "bt_suaH";
            this.bt_suaH.Size = new System.Drawing.Size(114, 54);
            this.bt_suaH.TabIndex = 3;
            this.bt_suaH.Text = "Sửa";
            this.bt_suaH.UseVisualStyleBackColor = false;
            this.bt_suaH.Click += new System.EventHandler(this.bt_suaH_Click);
            // 
            // bt_themH
            // 
            this.bt_themH.BackColor = System.Drawing.Color.Coral;
            this.bt_themH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_themH.Location = new System.Drawing.Point(914, 180);
            this.bt_themH.Name = "bt_themH";
            this.bt_themH.Size = new System.Drawing.Size(116, 54);
            this.bt_themH.TabIndex = 3;
            this.bt_themH.Text = "Thêm";
            this.bt_themH.UseVisualStyleBackColor = false;
            this.bt_themH.Click += new System.EventHandler(this.bt_themH_Click);
            // 
            // cb_GioN
            // 
            this.cb_GioN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_GioN.Location = new System.Drawing.Point(496, 127);
            this.cb_GioN.Name = "cb_GioN";
            this.cb_GioN.Size = new System.Drawing.Size(187, 29);
            this.cb_GioN.TabIndex = 1;
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_MaNV.Location = new System.Drawing.Point(156, 127);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(187, 29);
            this.cb_MaNV.TabIndex = 1;
            // 
            // bt_timkiemPNH
            // 
            this.bt_timkiemPNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_timkiemPNH.Location = new System.Drawing.Point(914, 77);
            this.bt_timkiemPNH.Name = "bt_timkiemPNH";
            this.bt_timkiemPNH.Size = new System.Drawing.Size(375, 31);
            this.bt_timkiemPNH.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1562, 545);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhập hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.Location = new System.Drawing.Point(-9, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1917, 706);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cb_NgayN
            // 
            this.cb_NgayN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_NgayN.Location = new System.Drawing.Point(496, 77);
            this.cb_NgayN.Name = "cb_NgayN";
            this.cb_NgayN.Size = new System.Drawing.Size(187, 29);
            this.cb_NgayN.TabIndex = 1;
            // 
            // cb_MaNhapHang
            // 
            this.cb_MaNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_MaNhapHang.Location = new System.Drawing.Point(156, 77);
            this.cb_MaNhapHang.Name = "cb_MaNhapHang";
            this.cb_MaNhapHang.Size = new System.Drawing.Size(187, 29);
            this.cb_MaNhapHang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(394, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "NgayNhap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(394, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "GioNhap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "MaNV";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_thoat.Location = new System.Drawing.Point(3, 2);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(110, 36);
            this.bt_thoat.TabIndex = 15;
            this.bt_thoat.Text = "Trang chủ";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaNhapHang";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.bt_TimH);
            this.groupBox2.Controls.Add(this.bt_RSH);
            this.groupBox2.Controls.Add(this.bt_xoaH);
            this.groupBox2.Controls.Add(this.bt_suaH);
            this.groupBox2.Controls.Add(this.bt_themH);
            this.groupBox2.Controls.Add(this.cb_TongTNhap);
            this.groupBox2.Controls.Add(this.cb_GioN);
            this.groupBox2.Controls.Add(this.cb_MaNV);
            this.groupBox2.Controls.Add(this.bt_timkiemPNH);
            this.groupBox2.Controls.Add(this.cb_NgayN);
            this.groupBox2.Controls.Add(this.cb_MaNhapHang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1903, 264);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // cb_TongTNhap
            // 
            this.cb_TongTNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_TongTNhap.Location = new System.Drawing.Point(156, 180);
            this.cb_TongTNhap.Name = "cb_TongTNhap";
            this.cb_TongTNhap.Size = new System.Drawing.Size(187, 29);
            this.cb_TongTNhap.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "TongTienNhap";
            // 
            // Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1525, 705);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.groupBox2);
            this.Name = "Hang";
            this.Text = "Hang";
            this.Load += new System.EventHandler(this.Hang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_TimH;
        private System.Windows.Forms.Button bt_RSH;
        private System.Windows.Forms.Button bt_xoaH;
        private System.Windows.Forms.Button bt_suaH;
        private System.Windows.Forms.Button bt_themH;
        private System.Windows.Forms.TextBox cb_GioN;
        private System.Windows.Forms.TextBox cb_MaNV;
        private System.Windows.Forms.TextBox bt_timkiemPNH;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cb_NgayN;
        private System.Windows.Forms.TextBox cb_MaNhapHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cb_TongTNhap;
        private System.Windows.Forms.Label label5;
    }
}