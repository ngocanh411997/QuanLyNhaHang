namespace QuanLyNhaHang.view
{
    partial class frmDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDTNgay = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOANHTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDTThang = new System.Windows.Forms.DataGridView();
            this._STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DOANHTHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDTNam = new System.Windows.Forms.DataGridView();
            this._SoTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doanh_thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTNgay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTThang)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTNam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Theo dõi doanh thu nhà hàng";
            // 
            // dgvDTNgay
            // 
            this.dgvDTNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.NGAYNHAP,
            this.DOANHTHU});
            this.dgvDTNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDTNgay.Location = new System.Drawing.Point(3, 16);
            this.dgvDTNgay.Name = "dgvDTNgay";
            this.dgvDTNgay.Size = new System.Drawing.Size(342, 294);
            this.dgvDTNgay.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày";
            this.NGAYNHAP.Name = "NGAYNHAP";
            // 
            // DOANHTHU
            // 
            this.DOANHTHU.DataPropertyName = "DOANHTHU";
            dataGridViewCellStyle7.Format = "0,000";
            this.DOANHTHU.DefaultCellStyle = dataGridViewCellStyle7;
            this.DOANHTHU.HeaderText = "Doanh thu";
            this.DOANHTHU.Name = "DOANHTHU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDTNgay);
            this.groupBox1.Location = new System.Drawing.Point(18, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 313);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theo Ngày";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDTThang);
            this.groupBox2.Location = new System.Drawing.Point(372, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 165);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Theo Tháng";
            // 
            // dgvDTThang
            // 
            this.dgvDTThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._STT,
            this._NGAYNHAP,
            this._DOANHTHU});
            this.dgvDTThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDTThang.Location = new System.Drawing.Point(3, 16);
            this.dgvDTThang.Name = "dgvDTThang";
            this.dgvDTThang.Size = new System.Drawing.Size(340, 146);
            this.dgvDTThang.TabIndex = 0;
            // 
            // _STT
            // 
            this._STT.HeaderText = "STT";
            this._STT.Name = "_STT";
            // 
            // _NGAYNHAP
            // 
            this._NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this._NGAYNHAP.HeaderText = "Tháng";
            this._NGAYNHAP.Name = "_NGAYNHAP";
            // 
            // _DOANHTHU
            // 
            this._DOANHTHU.DataPropertyName = "DOANHTHU";
            dataGridViewCellStyle8.Format = "0,000";
            this._DOANHTHU.DefaultCellStyle = dataGridViewCellStyle8;
            this._DOANHTHU.HeaderText = "Doanh thu";
            this._DOANHTHU.Name = "_DOANHTHU";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDTNam);
            this.groupBox3.Location = new System.Drawing.Point(375, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 142);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Theo Năm";
            // 
            // dgvDTNam
            // 
            this.dgvDTNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTNam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._SoTT,
            this.Nam,
            this.doanh_thu});
            this.dgvDTNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDTNam.Location = new System.Drawing.Point(3, 16);
            this.dgvDTNam.Name = "dgvDTNam";
            this.dgvDTNam.Size = new System.Drawing.Size(340, 123);
            this.dgvDTNam.TabIndex = 0;
            // 
            // _SoTT
            // 
            this._SoTT.HeaderText = "STT";
            this._SoTT.Name = "_SoTT";
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "NGAYNHAP";
            this.Nam.HeaderText = "Tháng";
            this.Nam.Name = "Nam";
            // 
            // doanh_thu
            // 
            this.doanh_thu.DataPropertyName = "DOANHTHU";
            dataGridViewCellStyle9.Format = "0,000";
            this.doanh_thu.DefaultCellStyle = dataGridViewCellStyle9;
            this.doanh_thu.HeaderText = "Doanh thu";
            this.doanh_thu.Name = "doanh_thu";
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 519);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTNgay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTThang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDTNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOANHTHU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDTThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn _STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn _NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DOANHTHU;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDTNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn _SoTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn doanh_thu;
    }
}