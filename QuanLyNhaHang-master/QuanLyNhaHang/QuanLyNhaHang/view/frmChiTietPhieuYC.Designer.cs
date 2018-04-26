namespace QuanLyNhaHang.view
{
    partial class frmChiTietPhieuYC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietPhieuYC));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPYC = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txt_MaPhieu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDSCT = new System.Windows.Forms.Button();
            this.btnLuuCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDSMon = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPYC)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.dgvChiTietPYC);
            this.groupBox7.Location = new System.Drawing.Point(24, 254);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(514, 173);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chi Tiết Phiếu Yêu Cầu";
            // 
            // dgvChiTietPYC
            // 
            this.dgvChiTietPYC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPYC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MAPHIEU,
            this.TENMON,
            this.SoLuong,
            this.GIA,
            this.THANHTIEN});
            this.dgvChiTietPYC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietPYC.Location = new System.Drawing.Point(3, 16);
            this.dgvChiTietPYC.Name = "dgvChiTietPYC";
            this.dgvChiTietPYC.Size = new System.Drawing.Size(508, 154);
            this.dgvChiTietPYC.TabIndex = 0;
            this.dgvChiTietPYC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietPYC_CellClick);
            this.dgvChiTietPYC.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvChiTietPYC_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MAPHIEU
            // 
            this.MAPHIEU.DataPropertyName = "MAPHIEU";
            this.MAPHIEU.HeaderText = "Mã Phiếu";
            this.MAPHIEU.Name = "MAPHIEU";
            // 
            // TENMON
            // 
            this.TENMON.DataPropertyName = "TENMON";
            this.TENMON.HeaderText = "Món Ăn";
            this.TENMON.Name = "TENMON";
            this.TENMON.Width = 90;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SOLUONG";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 70;
            // 
            // GIA
            // 
            this.GIA.DataPropertyName = "GIA";
            dataGridViewCellStyle1.Format = "0,000";
            this.GIA.DefaultCellStyle = dataGridViewCellStyle1;
            this.GIA.HeaderText = "Giá";
            this.GIA.Name = "GIA";
            this.GIA.Width = 60;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            dataGridViewCellStyle2.Format = "0,000";
            this.THANHTIEN.DefaultCellStyle = dataGridViewCellStyle2;
            this.THANHTIEN.HeaderText = "Thành Tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtGia);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.cbMonAn);
            this.groupBox6.Controls.Add(this.txtSoLuong);
            this.groupBox6.Controls.Add(this.txt_MaPhieu);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(260, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(275, 158);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhập Thông Chi Tiết Phiếu Yêu Cầu";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(83, 123);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(174, 20);
            this.txtGia.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Giá";
            // 
            // cbMonAn
            // 
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(83, 54);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(174, 21);
            this.cbMonAn.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(83, 90);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(174, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txt_MaPhieu
            // 
            this.txt_MaPhieu.Location = new System.Drawing.Point(83, 23);
            this.txt_MaPhieu.Name = "txt_MaPhieu";
            this.txt_MaPhieu.Size = new System.Drawing.Size(174, 20);
            this.txt_MaPhieu.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Món Ăn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã Phiếu";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDSCT);
            this.groupBox5.Controls.Add(this.btnLuuCT);
            this.groupBox5.Controls.Add(this.btnXoaCT);
            this.groupBox5.Controls.Add(this.btnHuy);
            this.groupBox5.Controls.Add(this.btnSuaCT);
            this.groupBox5.Controls.Add(this.btnThemCT);
            this.groupBox5.Location = new System.Drawing.Point(24, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 158);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức Năng";
            // 
            // btnDSCT
            // 
            this.btnDSCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSCT.Image = ((System.Drawing.Image)(resources.GetObject("btnDSCT.Image")));
            this.btnDSCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDSCT.Location = new System.Drawing.Point(123, 76);
            this.btnDSCT.Name = "btnDSCT";
            this.btnDSCT.Size = new System.Drawing.Size(51, 53);
            this.btnDSCT.TabIndex = 13;
            this.btnDSCT.Text = "DS CT";
            this.btnDSCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDSCT.UseVisualStyleBackColor = false;
            this.btnDSCT.Click += new System.EventHandler(this.btnDSCT_Click);
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLuuCT.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCT.Image")));
            this.btnLuuCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuCT.Location = new System.Drawing.Point(9, 76);
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(51, 53);
            this.btnLuuCT.TabIndex = 3;
            this.btnLuuCT.Text = "Lưu Món";
            this.btnLuuCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuCT.UseVisualStyleBackColor = false;
            this.btnLuuCT.Click += new System.EventHandler(this.btnLuuCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.Image")));
            this.btnXoaCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaCT.Location = new System.Drawing.Point(123, 17);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(51, 53);
            this.btnXoaCT.TabIndex = 2;
            this.btnXoaCT.Text = "Xóa Món";
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaCT.UseVisualStyleBackColor = false;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(66, 76);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(51, 53);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSuaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCT.Image")));
            this.btnSuaCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaCT.Location = new System.Drawing.Point(66, 17);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(51, 53);
            this.btnSuaCT.TabIndex = 1;
            this.btnSuaCT.Text = "Sửa Món";
            this.btnSuaCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaCT.UseVisualStyleBackColor = false;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemCT.Location = new System.Drawing.Point(9, 17);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(51, 53);
            this.btnThemCT.TabIndex = 0;
            this.btnThemCT.Text = "Thêm Món";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemCT.UseVisualStyleBackColor = false;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThanhToan.Location = new System.Drawing.Point(24, 186);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(51, 53);
            this.btnThanhToan.TabIndex = 20;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(138, 186);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 53);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDSMon
            // 
            this.btnDSMon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDSMon.Image = ((System.Drawing.Image)(resources.GetObject("btnDSMon.Image")));
            this.btnDSMon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDSMon.Location = new System.Drawing.Point(81, 186);
            this.btnDSMon.Name = "btnDSMon";
            this.btnDSMon.Size = new System.Drawing.Size(51, 53);
            this.btnDSMon.TabIndex = 22;
            this.btnDSMon.Text = "DS Món\r\n";
            this.btnDSMon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDSMon.UseVisualStyleBackColor = false;
            this.btnDSMon.Click += new System.EventHandler(this.btnDSMon_Click);
            // 
            // frmChiTietPhieuYC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 439);
            this.Controls.Add(this.btnDSMon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmChiTietPhieuYC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChiTietPhieuYC";
            this.Load += new System.EventHandler(this.frmChiTietPhieuYC_Load);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPYC)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvChiTietPYC;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txt_MaPhieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnLuuCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDSCT;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHIEU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Button btnDSMon;
    }
}