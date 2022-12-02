namespace BTCKCSDL
{
    partial class Hóa_đơn_chi_tiết
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_TimKH = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_xoaHD = new System.Windows.Forms.Button();
            this.bt_suaHD = new System.Windows.Forms.Button();
            this.bt_themHD = new System.Windows.Forms.Button();
            this.cb_Thanhtien = new System.Windows.Forms.TextBox();
            this.bt_timkiemCTHD = new System.Windows.Forms.TextBox();
            this.cb_SL = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_MaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.bt_TimKH);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.bt_xoaHD);
            this.groupBox2.Controls.Add(this.bt_suaHD);
            this.groupBox2.Controls.Add(this.bt_themHD);
            this.groupBox2.Controls.Add(this.cb_Thanhtien);
            this.groupBox2.Controls.Add(this.bt_timkiemCTHD);
            this.groupBox2.Controls.Add(this.cb_SL);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.cb_MaHD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1339, 218);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // bt_TimKH
            // 
            this.bt_TimKH.BackColor = System.Drawing.Color.Coral;
            this.bt_TimKH.ForeColor = System.Drawing.Color.Black;
            this.bt_TimKH.Location = new System.Drawing.Point(1191, 39);
            this.bt_TimKH.Name = "bt_TimKH";
            this.bt_TimKH.Size = new System.Drawing.Size(93, 34);
            this.bt_TimKH.TabIndex = 6;
            this.bt_TimKH.Text = "Tìm kiếm";
            this.bt_TimKH.UseVisualStyleBackColor = false;
            this.bt_TimKH.Click += new System.EventHandler(this.bt_TimKH_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1191, 148);
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
            this.bt_xoaHD.Location = new System.Drawing.Point(1092, 148);
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
            this.bt_suaHD.Location = new System.Drawing.Point(985, 148);
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
            this.bt_themHD.Location = new System.Drawing.Point(877, 148);
            this.bt_themHD.Name = "bt_themHD";
            this.bt_themHD.Size = new System.Drawing.Size(93, 44);
            this.bt_themHD.TabIndex = 3;
            this.bt_themHD.Text = "Thêm";
            this.bt_themHD.UseVisualStyleBackColor = false;
            this.bt_themHD.Click += new System.EventHandler(this.bt_themHD_Click);
            // 
            // cb_Thanhtien
            // 
            this.cb_Thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_Thanhtien.Location = new System.Drawing.Point(421, 84);
            this.cb_Thanhtien.Name = "cb_Thanhtien";
            this.cb_Thanhtien.Size = new System.Drawing.Size(187, 29);
            this.cb_Thanhtien.TabIndex = 1;
            this.cb_Thanhtien.TextChanged += new System.EventHandler(this.cb_DCKH_TextChanged);
            // 
            // bt_timkiemCTHD
            // 
            this.bt_timkiemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_timkiemCTHD.Location = new System.Drawing.Point(877, 43);
            this.bt_timkiemCTHD.Name = "bt_timkiemCTHD";
            this.bt_timkiemCTHD.Size = new System.Drawing.Size(298, 29);
            this.bt_timkiemCTHD.TabIndex = 1;
            // 
            // cb_SL
            // 
            this.cb_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_SL.Location = new System.Drawing.Point(421, 40);
            this.cb_SL.Name = "cb_SL";
            this.cb_SL.Size = new System.Drawing.Size(187, 29);
            this.cb_SL.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(112, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 29);
            this.textBox1.TabIndex = 1;
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
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "SoLuong";
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
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ThanhTien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "MaMon";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.Location = new System.Drawing.Point(0, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1339, 378);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(3, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1345, 403);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách chi tiết hóa đơn";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_thoat.Location = new System.Drawing.Point(3, 4);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(96, 38);
            this.bt_thoat.TabIndex = 11;
            this.bt_thoat.Text = "Trang chủ";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label7.Location = new System.Drawing.Point(538, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Chi Tiết Hóa Đơn";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Hóa_đơn_chi_tiết
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.label7);
            this.Name = "Hóa_đơn_chi_tiết";
            this.Text = "Hóa_đơn_chi_tiết";
            this.Load += new System.EventHandler(this.Hóa_đơn_chi_tiết_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_TimKH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_xoaHD;
        private System.Windows.Forms.Button bt_suaHD;
        private System.Windows.Forms.Button bt_themHD;
        private System.Windows.Forms.TextBox cb_Thanhtien;
        private System.Windows.Forms.TextBox bt_timkiemCTHD;
        private System.Windows.Forms.TextBox cb_SL;
        private System.Windows.Forms.TextBox cb_MaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}