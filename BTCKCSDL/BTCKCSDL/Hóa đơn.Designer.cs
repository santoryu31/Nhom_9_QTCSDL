namespace BTCKCSDL
{
    partial class Hóa_đơn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_TimKH = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_xoaHD = new System.Windows.Forms.Button();
            this.bt_suaHD = new System.Windows.Forms.Button();
            this.bt_themHD = new System.Windows.Forms.Button();
            this.cb_GioHD = new System.Windows.Forms.TextBox();
            this.cb_NV = new System.Windows.Forms.TextBox();
            this.bt_timkiemHD = new System.Windows.Forms.TextBox();
            this.cb_MaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_TongTHD = new System.Windows.Forms.TextBox();
            this.cb_MaKH = new System.Windows.Forms.TextBox();
            this.cb_NgayHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(4, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1352, 403);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.Location = new System.Drawing.Point(0, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1346, 378);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_thoat.Location = new System.Drawing.Point(4, 7);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(93, 34);
            this.bt_thoat.TabIndex = 15;
            this.bt_thoat.Text = "Trang chủ";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_TimKH
            // 
            this.bt_TimKH.BackColor = System.Drawing.Color.Coral;
            this.bt_TimKH.ForeColor = System.Drawing.Color.Black;
            this.bt_TimKH.Location = new System.Drawing.Point(1217, 37);
            this.bt_TimKH.Name = "bt_TimKH";
            this.bt_TimKH.Size = new System.Drawing.Size(93, 34);
            this.bt_TimKH.TabIndex = 6;
            this.bt_TimKH.Text = "Tìm kiếm";
            this.bt_TimKH.UseVisualStyleBackColor = false;
            this.bt_TimKH.Click += new System.EventHandler(this.bt_TimKH_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1217, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Resert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_xoaHD
            // 
            this.bt_xoaHD.BackColor = System.Drawing.Color.Coral;
            this.bt_xoaHD.Location = new System.Drawing.Point(1118, 150);
            this.bt_xoaHD.Name = "bt_xoaHD";
            this.bt_xoaHD.Size = new System.Drawing.Size(83, 44);
            this.bt_xoaHD.TabIndex = 3;
            this.bt_xoaHD.Text = "Xóa";
            this.bt_xoaHD.UseVisualStyleBackColor = false;
            this.bt_xoaHD.Click += new System.EventHandler(this.bt_xoaHD_Click);
            // 
            // bt_suaHD
            // 
            this.bt_suaHD.BackColor = System.Drawing.Color.Coral;
            this.bt_suaHD.Location = new System.Drawing.Point(1011, 150);
            this.bt_suaHD.Name = "bt_suaHD";
            this.bt_suaHD.Size = new System.Drawing.Size(91, 44);
            this.bt_suaHD.TabIndex = 3;
            this.bt_suaHD.Text = "Sửa";
            this.bt_suaHD.UseVisualStyleBackColor = false;
            this.bt_suaHD.Click += new System.EventHandler(this.bt_suaHD_Click);
            // 
            // bt_themHD
            // 
            this.bt_themHD.BackColor = System.Drawing.Color.Coral;
            this.bt_themHD.Location = new System.Drawing.Point(903, 150);
            this.bt_themHD.Name = "bt_themHD";
            this.bt_themHD.Size = new System.Drawing.Size(93, 44);
            this.bt_themHD.TabIndex = 3;
            this.bt_themHD.Text = "Thêm";
            this.bt_themHD.UseVisualStyleBackColor = false;
            this.bt_themHD.Click += new System.EventHandler(this.bt_themHD_Click);
            // 
            // cb_GioHD
            // 
            this.cb_GioHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_GioHD.Location = new System.Drawing.Point(421, 84);
            this.cb_GioHD.Name = "cb_GioHD";
            this.cb_GioHD.Size = new System.Drawing.Size(187, 29);
            this.cb_GioHD.TabIndex = 1;
            // 
            // cb_NV
            // 
            this.cb_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_NV.Location = new System.Drawing.Point(112, 84);
            this.cb_NV.Name = "cb_NV";
            this.cb_NV.Size = new System.Drawing.Size(187, 29);
            this.cb_NV.TabIndex = 1;
            this.cb_NV.TextChanged += new System.EventHandler(this.cb_Mamon_TextChanged);
            // 
            // bt_timkiemHD
            // 
            this.bt_timkiemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_timkiemHD.Location = new System.Drawing.Point(903, 41);
            this.bt_timkiemHD.Name = "bt_timkiemHD";
            this.bt_timkiemHD.Size = new System.Drawing.Size(298, 29);
            this.bt_timkiemHD.TabIndex = 1;
            // 
            // cb_MaHD
            // 
            this.cb_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_MaHD.Location = new System.Drawing.Point(112, 37);
            this.cb_MaHD.Name = "cb_MaHD";
            this.cb_MaHD.Size = new System.Drawing.Size(187, 29);
            this.cb_MaHD.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(329, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaHD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(329, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "MaNV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.bt_TimKH);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.bt_xoaHD);
            this.groupBox2.Controls.Add(this.bt_suaHD);
            this.groupBox2.Controls.Add(this.bt_themHD);
            this.groupBox2.Controls.Add(this.cb_TongTHD);
            this.groupBox2.Controls.Add(this.cb_GioHD);
            this.groupBox2.Controls.Add(this.cb_MaKH);
            this.groupBox2.Controls.Add(this.cb_NV);
            this.groupBox2.Controls.Add(this.bt_timkiemHD);
            this.groupBox2.Controls.Add(this.cb_NgayHD);
            this.groupBox2.Controls.Add(this.cb_MaHD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(4, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1352, 218);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // cb_TongTHD
            // 
            this.cb_TongTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_TongTHD.Location = new System.Drawing.Point(421, 130);
            this.cb_TongTHD.Name = "cb_TongTHD";
            this.cb_TongTHD.Size = new System.Drawing.Size(187, 29);
            this.cb_TongTHD.TabIndex = 1;
            // 
            // cb_MaKH
            // 
            this.cb_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_MaKH.Location = new System.Drawing.Point(112, 130);
            this.cb_MaKH.Name = "cb_MaKH";
            this.cb_MaKH.Size = new System.Drawing.Size(187, 29);
            this.cb_MaKH.TabIndex = 1;
            this.cb_MaKH.TextChanged += new System.EventHandler(this.cb_Mamon_TextChanged);
            // 
            // cb_NgayHD
            // 
            this.cb_NgayHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_NgayHD.Location = new System.Drawing.Point(421, 40);
            this.cb_NgayHD.Name = "cb_NgayHD";
            this.cb_NgayHD.Size = new System.Drawing.Size(187, 29);
            this.cb_NgayHD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(329, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "TongTien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "MaKH";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label7.Location = new System.Drawing.Point(547, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hóa Đơn";
            // 
            // Hóa_đơn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Name = "Hóa_đơn";
            this.Text = "Hóa_đơn";
            this.Load += new System.EventHandler(this.Hóa_đơn_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_TimKH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_xoaHD;
        private System.Windows.Forms.Button bt_suaHD;
        private System.Windows.Forms.Button bt_themHD;
        private System.Windows.Forms.TextBox cb_GioHD;
        private System.Windows.Forms.TextBox cb_NV;
        private System.Windows.Forms.TextBox bt_timkiemHD;
        private System.Windows.Forms.TextBox cb_MaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cb_NgayHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cb_TongTHD;
        private System.Windows.Forms.TextBox cb_MaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}