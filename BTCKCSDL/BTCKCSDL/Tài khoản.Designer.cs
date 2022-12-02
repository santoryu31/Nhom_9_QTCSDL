namespace BTCKCSDL
{
    partial class Tài_khoản
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
            this.bt_TimTK = new System.Windows.Forms.Button();
            this.bt_rsTk = new System.Windows.Forms.Button();
            this.bt_xoatk = new System.Windows.Forms.Button();
            this.bt_suaTK = new System.Windows.Forms.Button();
            this.bt_themtk = new System.Windows.Forms.Button();
            this.cb_MK = new System.Windows.Forms.TextBox();
            this.bt_timkiemTK = new System.Windows.Forms.TextBox();
            this.cb_TK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Controls.Add(this.bt_TimTK);
            this.groupBox2.Controls.Add(this.bt_rsTk);
            this.groupBox2.Controls.Add(this.bt_xoatk);
            this.groupBox2.Controls.Add(this.bt_suaTK);
            this.groupBox2.Controls.Add(this.bt_themtk);
            this.groupBox2.Controls.Add(this.cb_MK);
            this.groupBox2.Controls.Add(this.bt_timkiemTK);
            this.groupBox2.Controls.Add(this.cb_TK);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(602, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 558);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // bt_TimTK
            // 
            this.bt_TimTK.BackColor = System.Drawing.Color.Coral;
            this.bt_TimTK.ForeColor = System.Drawing.Color.Black;
            this.bt_TimTK.Location = new System.Drawing.Point(532, 45);
            this.bt_TimTK.Name = "bt_TimTK";
            this.bt_TimTK.Size = new System.Drawing.Size(93, 34);
            this.bt_TimTK.TabIndex = 6;
            this.bt_TimTK.Text = "Tìm kiếm";
            this.bt_TimTK.UseVisualStyleBackColor = false;
            this.bt_TimTK.Click += new System.EventHandler(this.bt_TimTK_Click);
            // 
            // bt_rsTk
            // 
            this.bt_rsTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_rsTk.Location = new System.Drawing.Point(531, 415);
            this.bt_rsTk.Name = "bt_rsTk";
            this.bt_rsTk.Size = new System.Drawing.Size(94, 50);
            this.bt_rsTk.TabIndex = 5;
            this.bt_rsTk.Text = "Resert";
            this.bt_rsTk.UseVisualStyleBackColor = true;
            this.bt_rsTk.Click += new System.EventHandler(this.bt_rsTk_Click);
            // 
            // bt_xoatk
            // 
            this.bt_xoatk.BackColor = System.Drawing.Color.Coral;
            this.bt_xoatk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_xoatk.Location = new System.Drawing.Point(394, 415);
            this.bt_xoatk.Name = "bt_xoatk";
            this.bt_xoatk.Size = new System.Drawing.Size(92, 50);
            this.bt_xoatk.TabIndex = 3;
            this.bt_xoatk.Text = "Xóa";
            this.bt_xoatk.UseVisualStyleBackColor = false;
            this.bt_xoatk.Click += new System.EventHandler(this.bt_xoatk_Click);
            // 
            // bt_suaTK
            // 
            this.bt_suaTK.BackColor = System.Drawing.Color.Coral;
            this.bt_suaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_suaTK.Location = new System.Drawing.Point(253, 415);
            this.bt_suaTK.Name = "bt_suaTK";
            this.bt_suaTK.Size = new System.Drawing.Size(100, 50);
            this.bt_suaTK.TabIndex = 3;
            this.bt_suaTK.Text = "Sửa";
            this.bt_suaTK.UseVisualStyleBackColor = false;
            this.bt_suaTK.Click += new System.EventHandler(this.bt_suaTK_Click);
            // 
            // bt_themtk
            // 
            this.bt_themtk.BackColor = System.Drawing.Color.Coral;
            this.bt_themtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_themtk.Location = new System.Drawing.Point(124, 415);
            this.bt_themtk.Name = "bt_themtk";
            this.bt_themtk.Size = new System.Drawing.Size(102, 50);
            this.bt_themtk.TabIndex = 3;
            this.bt_themtk.Text = "Thêm";
            this.bt_themtk.UseVisualStyleBackColor = false;
            this.bt_themtk.Click += new System.EventHandler(this.bt_themtk_Click);
            // 
            // cb_MK
            // 
            this.cb_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_MK.Location = new System.Drawing.Point(133, 231);
            this.cb_MK.Name = "cb_MK";
            this.cb_MK.Size = new System.Drawing.Size(353, 31);
            this.cb_MK.TabIndex = 1;
            // 
            // bt_timkiemTK
            // 
            this.bt_timkiemTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_timkiemTK.Location = new System.Drawing.Point(133, 49);
            this.bt_timkiemTK.Name = "bt_timkiemTK";
            this.bt_timkiemTK.Size = new System.Drawing.Size(353, 29);
            this.bt_timkiemTK.TabIndex = 1;
            // 
            // cb_TK
            // 
            this.cb_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_TK.Location = new System.Drawing.Point(133, 178);
            this.cb_TK.Name = "cb_TK";
            this.cb_TK.Size = new System.Drawing.Size(353, 31);
            this.cb_TK.TabIndex = 1;
            this.cb_TK.TextChanged += new System.EventHandler(this.cb_MaKH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 558);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 585);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label7.Location = new System.Drawing.Point(566, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tài khoản";
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_thoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_thoat.Location = new System.Drawing.Point(18, 4);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(132, 46);
            this.bt_thoat.TabIndex = 11;
            this.bt_thoat.Text = "Trang chủ";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Tài_khoản
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_thoat);
            this.Name = "Tài_khoản";
            this.Text = "Tài_khoản";
            this.Load += new System.EventHandler(this.Tài_khoản_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_TimTK;
        private System.Windows.Forms.Button bt_rsTk;
        private System.Windows.Forms.Button bt_xoatk;
        private System.Windows.Forms.Button bt_suaTK;
        private System.Windows.Forms.Button bt_themtk;
        private System.Windows.Forms.TextBox cb_MK;
        private System.Windows.Forms.TextBox bt_timkiemTK;
        private System.Windows.Forms.TextBox cb_TK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_thoat;
    }
}