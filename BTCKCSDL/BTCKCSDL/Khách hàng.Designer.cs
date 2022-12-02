namespace BTCKCSDL
{
    partial class Khách_hàng
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
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_TimKH = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.cb_DCKH = new System.Windows.Forms.TextBox();
            this.cb_tenKH = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_timkiemKH = new System.Windows.Forms.TextBox();
            this.cb_SDTKH = new System.Windows.Forms.TextBox();
            this.cb_MaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label7.Location = new System.Drawing.Point(541, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quản Lý Khách Hàng";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_thoat.Location = new System.Drawing.Point(3, 3);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(94, 37);
            this.bt_thoat.TabIndex = 7;
            this.bt_thoat.Text = "Trang chủ";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_TimKH
            // 
            this.bt_TimKH.BackColor = System.Drawing.Color.Coral;
            this.bt_TimKH.ForeColor = System.Drawing.Color.Black;
            this.bt_TimKH.Location = new System.Drawing.Point(1213, 28);
            this.bt_TimKH.Name = "bt_TimKH";
            this.bt_TimKH.Size = new System.Drawing.Size(93, 34);
            this.bt_TimKH.TabIndex = 6;
            this.bt_TimKH.Text = "Tìm kiếm";
            this.bt_TimKH.UseVisualStyleBackColor = false;
            this.bt_TimKH.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1213, 149);
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
            this.bt_xoa.Location = new System.Drawing.Point(1114, 149);
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
            this.bt_sua.Location = new System.Drawing.Point(1007, 149);
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
            this.bt_them.Location = new System.Drawing.Point(899, 149);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(93, 44);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // cb_DCKH
            // 
            this.cb_DCKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_DCKH.Location = new System.Drawing.Point(98, 167);
            this.cb_DCKH.Name = "cb_DCKH";
            this.cb_DCKH.Size = new System.Drawing.Size(372, 26);
            this.cb_DCKH.TabIndex = 1;
            this.cb_DCKH.TextChanged += new System.EventHandler(this.cb_DCKH_TextChanged);
            // 
            // cb_tenKH
            // 
            this.cb_tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_tenKH.Location = new System.Drawing.Point(98, 79);
            this.cb_tenKH.Name = "cb_tenKH";
            this.cb_tenKH.Size = new System.Drawing.Size(372, 26);
            this.cb_tenKH.TabIndex = 1;
            this.cb_tenKH.TextChanged += new System.EventHandler(this.cb_tenKH_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(3, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1386, 403);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.Location = new System.Drawing.Point(0, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1380, 378);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_timkiemKH
            // 
            this.bt_timkiemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_timkiemKH.Location = new System.Drawing.Point(899, 28);
            this.bt_timkiemKH.Name = "bt_timkiemKH";
            this.bt_timkiemKH.Size = new System.Drawing.Size(298, 26);
            this.bt_timkiemKH.TabIndex = 1;
            this.bt_timkiemKH.TextChanged += new System.EventHandler(this.bt_timkiemKH_TextChanged);
            // 
            // cb_SDTKH
            // 
            this.cb_SDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_SDTKH.Location = new System.Drawing.Point(98, 123);
            this.cb_SDTKH.Name = "cb_SDTKH";
            this.cb_SDTKH.Size = new System.Drawing.Size(372, 26);
            this.cb_SDTKH.TabIndex = 1;
            this.cb_SDTKH.TextChanged += new System.EventHandler(this.cb_SDTKH_TextChanged);
            // 
            // cb_MaKH
            // 
            this.cb_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_MaKH.Location = new System.Drawing.Point(98, 28);
            this.cb_MaKH.Name = "cb_MaKH";
            this.cb_MaKH.Size = new System.Drawing.Size(372, 26);
            this.cb_MaKH.TabIndex = 1;
            this.cb_MaKH.TextChanged += new System.EventHandler(this.cb_MaKH_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "SDT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaKH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "DiaChi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "TenKH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.bt_TimKH);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.bt_xoa);
            this.groupBox2.Controls.Add(this.bt_sua);
            this.groupBox2.Controls.Add(this.bt_them);
            this.groupBox2.Controls.Add(this.cb_DCKH);
            this.groupBox2.Controls.Add(this.cb_tenKH);
            this.groupBox2.Controls.Add(this.bt_timkiemKH);
            this.groupBox2.Controls.Add(this.cb_SDTKH);
            this.groupBox2.Controls.Add(this.cb_MaKH);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(3, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1386, 218);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Khách_hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 690);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Khách_hàng";
            this.Text = "Khách_hàng";
            this.Load += new System.EventHandler(this.Khách_hàng_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_TimKH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox cb_DCKH;
        private System.Windows.Forms.TextBox cb_tenKH;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox bt_timkiemKH;
        private System.Windows.Forms.TextBox cb_SDTKH;
        private System.Windows.Forms.TextBox cb_MaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}