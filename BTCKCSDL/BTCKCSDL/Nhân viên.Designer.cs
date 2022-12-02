namespace BTCKCSDL
{
    partial class Nhân_viên
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxGT = new System.Windows.Forms.TextBox();
            this.textBoxNS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.cb_DC = new System.Windows.Forms.TextBox();
            this.cb_tenNV = new System.Windows.Forms.TextBox();
            this.bt_timkiem = new System.Windows.Forms.TextBox();
            this.cb_SDT = new System.Windows.Forms.TextBox();
            this.cb_CCCD = new System.Windows.Forms.TextBox();
            this.cb_MaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_GT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(4, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1348, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1336, 378);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.textBoxGT);
            this.groupBox2.Controls.Add(this.textBoxNS);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.cb_DC);
            this.groupBox2.Controls.Add(this.cb_tenNV);
            this.groupBox2.Controls.Add(this.bt_timkiem);
            this.groupBox2.Controls.Add(this.cb_SDT);
            this.groupBox2.Controls.Add(this.cb_CCCD);
            this.groupBox2.Controls.Add(this.cb_MaNV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cb_GT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(4, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1348, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // textBoxGT
            // 
            this.textBoxGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxGT.Location = new System.Drawing.Point(407, 123);
            this.textBoxGT.Name = "textBoxGT";
            this.textBoxGT.Size = new System.Drawing.Size(167, 26);
            this.textBoxGT.TabIndex = 7;
            this.textBoxGT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNS
            // 
            this.textBoxNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxNS.Location = new System.Drawing.Point(407, 80);
            this.textBoxNS.Name = "textBoxNS";
            this.textBoxNS.Size = new System.Drawing.Size(167, 26);
            this.textBoxNS.TabIndex = 7;
            this.textBoxNS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1169, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1169, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Resert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Coral;
            this.bt_xoa.Location = new System.Drawing.Point(1070, 150);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(83, 44);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.Coral;
            this.bt_sua.Location = new System.Drawing.Point(963, 150);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(91, 44);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.Coral;
            this.bt_them.Location = new System.Drawing.Point(855, 150);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(93, 44);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // cb_DC
            // 
            this.cb_DC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_DC.Location = new System.Drawing.Point(103, 168);
            this.cb_DC.Name = "cb_DC";
            this.cb_DC.Size = new System.Drawing.Size(471, 26);
            this.cb_DC.TabIndex = 1;
            this.cb_DC.TextChanged += new System.EventHandler(this.cb_DC_TextChanged);
            // 
            // cb_tenNV
            // 
            this.cb_tenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_tenNV.Location = new System.Drawing.Point(103, 80);
            this.cb_tenNV.Name = "cb_tenNV";
            this.cb_tenNV.Size = new System.Drawing.Size(187, 26);
            this.cb_tenNV.TabIndex = 1;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_timkiem.Location = new System.Drawing.Point(855, 29);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(298, 26);
            this.bt_timkiem.TabIndex = 1;
            this.bt_timkiem.TextChanged += new System.EventHandler(this.bt_timkiem_TextChanged);
            // 
            // cb_SDT
            // 
            this.cb_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_SDT.Location = new System.Drawing.Point(103, 124);
            this.cb_SDT.Name = "cb_SDT";
            this.cb_SDT.Size = new System.Drawing.Size(187, 26);
            this.cb_SDT.TabIndex = 1;
            // 
            // cb_CCCD
            // 
            this.cb_CCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_CCCD.Location = new System.Drawing.Point(407, 33);
            this.cb_CCCD.Name = "cb_CCCD";
            this.cb_CCCD.Size = new System.Drawing.Size(167, 26);
            this.cb_CCCD.TabIndex = 1;
            this.cb_CCCD.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cb_MaNV
            // 
            this.cb_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_MaNV.Location = new System.Drawing.Point(103, 33);
            this.cb_MaNV.Name = "cb_MaNV";
            this.cb_MaNV.Size = new System.Drawing.Size(187, 26);
            this.cb_MaNV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "SDT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(312, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "NgaySinh";
            // 
            // cb_GT
            // 
            this.cb_GT.AutoSize = true;
            this.cb_GT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_GT.ForeColor = System.Drawing.Color.Black;
            this.cb_GT.Location = new System.Drawing.Point(312, 124);
            this.cb_GT.Name = "cb_GT";
            this.cb_GT.Size = new System.Drawing.Size(76, 18);
            this.cb_GT.TabIndex = 0;
            this.cb_GT.Text = "Gioi Tinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(312, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "CCCD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaNV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "DiaChi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "TenNV";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_thoat.Location = new System.Drawing.Point(4, 3);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(103, 40);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.Text = "Trang chủ";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label7.Location = new System.Drawing.Point(514, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quản Lý Nhân Viên";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Nhân_viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 713);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_thoat);
            this.Name = "Nhân_viên";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.Nhân_viên_Load);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cb_tenNV;
        private System.Windows.Forms.TextBox cb_MaNV;
        private System.Windows.Forms.TextBox cb_SDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cb_DC;
        private System.Windows.Forms.TextBox cb_CCCD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Label cb_GT;
        private System.Windows.Forms.TextBox bt_timkiem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNS;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxGT;
    }
}