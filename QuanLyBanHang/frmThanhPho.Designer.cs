namespace QuanLyBanHang
{
    partial class frmThanhPho
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvTHANHPHO = new System.Windows.Forms.DataGridView();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTenThanhPho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlThongTinTP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txThanhPho = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.thanhpho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThanhPho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).BeginInit();
            this.pnlThongTinTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(382, 485);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 80);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Trở Về";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvTHANHPHO
            // 
            this.dgvTHANHPHO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHANHPHO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thanhpho,
            this.tenThanhPho});
            this.dgvTHANHPHO.Location = new System.Drawing.Point(18, 149);
            this.dgvTHANHPHO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTHANHPHO.Name = "dgvTHANHPHO";
            this.dgvTHANHPHO.RowHeadersWidth = 62;
            this.dgvTHANHPHO.Size = new System.Drawing.Size(477, 312);
            this.dgvTHANHPHO.TabIndex = 1;
            // 
            // btnReLoad
            // 
            this.btnReLoad.Location = new System.Drawing.Point(18, 485);
            this.btnReLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(112, 35);
            this.btnReLoad.TabIndex = 2;
            this.btnReLoad.Text = "ReLoad";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(261, 529);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTenThanhPho
            // 
            this.txtTenThanhPho.Location = new System.Drawing.Point(148, 52);
            this.txtTenThanhPho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenThanhPho.Name = "txtTenThanhPho";
            this.txtTenThanhPho.Size = new System.Drawing.Size(308, 26);
            this.txtTenThanhPho.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên Thành Phố:";
            // 
            // pnlThongTinTP
            // 
            this.pnlThongTinTP.Controls.Add(this.label1);
            this.pnlThongTinTP.Controls.Add(this.label2);
            this.pnlThongTinTP.Controls.Add(this.txThanhPho);
            this.pnlThongTinTP.Controls.Add(this.txtTenThanhPho);
            this.pnlThongTinTP.Location = new System.Drawing.Point(18, 18);
            this.pnlThongTinTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlThongTinTP.Name = "pnlThongTinTP";
            this.pnlThongTinTP.Size = new System.Drawing.Size(477, 98);
            this.pnlThongTinTP.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thành Phố:";
            // 
            // txThanhPho
            // 
            this.txThanhPho.Location = new System.Drawing.Point(148, 12);
            this.txThanhPho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txThanhPho.Name = "txThanhPho";
            this.txThanhPho.Size = new System.Drawing.Size(148, 26);
            this.txThanhPho.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(140, 485);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 35);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(261, 485);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 35);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(18, 529);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 35);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(140, 529);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 35);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // thanhpho
            // 
            this.thanhpho.DataPropertyName = "ThanhPho";
            this.thanhpho.HeaderText = "Thành Phố";
            this.thanhpho.MinimumWidth = 8;
            this.thanhpho.Name = "thanhpho";
            this.thanhpho.Width = 150;
            // 
            // tenThanhPho
            // 
            this.tenThanhPho.DataPropertyName = "TenThanhPho";
            this.tenThanhPho.HeaderText = "Tên Thành Phố";
            this.tenThanhPho.MinimumWidth = 8;
            this.tenThanhPho.Name = "tenThanhPho";
            this.tenThanhPho.Width = 150;
            // 
            // frmThanhPho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 577);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pnlThongTinTP);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.dgvTHANHPHO);
            this.Controls.Add(this.btnThoat);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThanhPho";
            this.Text = "Quản lý Danh mục Thành phố";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThanhPho_FormClosing);
            this.Load += new System.EventHandler(this.frmThanhPho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).EndInit();
            this.pnlThongTinTP.ResumeLayout(false);
            this.pnlThongTinTP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvTHANHPHO;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTenThanhPho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlThongTinTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txThanhPho;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhpho;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThanhPho;
    }
}