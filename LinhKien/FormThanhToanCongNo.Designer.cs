namespace LinhKien
{
    partial class FormThanhToanCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToanCongNo));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaThanhT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvThanhToanCongNo = new DevExpress.XtraGrid.GridControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtConNo = new DevExpress.XtraEditors.TextEdit();
            this.cbbNhaCC = new System.Windows.Forms.ComboBox();
            this.btnXoaHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThenHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTienThanhToan = new DevExpress.XtraEditors.TextEdit();
            this.txtCongNo = new DevExpress.XtraEditors.TextEdit();
            this.txtNguoiNhan = new DevExpress.XtraEditors.TextEdit();
            this.dateThanhToan = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbTTMaHD = new System.Windows.Forms.Label();
            this.lbSoTienThanhToan = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPhieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNguoiThanhToan = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToanCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienThanhToan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiThanhToan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaThanhT,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.dgvThanhToanCongNo;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // MaThanhT
            // 
            this.MaThanhT.Caption = "Mã thanh toán";
            this.MaThanhT.FieldName = "MaThanhToan";
            this.MaThanhT.Name = "MaThanhT";
            this.MaThanhT.Visible = true;
            this.MaThanhT.VisibleIndex = 0;
            this.MaThanhT.Width = 100;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nhà cung cấp";
            this.gridColumn1.FieldName = "MaNCC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Thời gian";
            this.gridColumn2.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn2.FieldName = "ThoiGian";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 108;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Người nhận thanh toán";
            this.gridColumn3.FieldName = "NguoiNhan";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 137;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Người thanh toán";
            this.gridColumn4.FieldName = "NgThanhToan";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 120;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Công nợ cũ";
            this.gridColumn5.FieldName = "CongNo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 119;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Số tiền đã thanh toán";
            this.gridColumn6.FieldName = "SoTienThanhToan";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 150;
            // 
            // dgvThanhToanCongNo
            // 
            this.dgvThanhToanCongNo.Location = new System.Drawing.Point(12, 195);
            this.dgvThanhToanCongNo.MainView = this.gridView1;
            this.dgvThanhToanCongNo.Name = "dgvThanhToanCongNo";
            this.dgvThanhToanCongNo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.dgvThanhToanCongNo.Size = new System.Drawing.Size(836, 402);
            this.dgvThanhToanCongNo.TabIndex = 3;
            this.dgvThanhToanCongNo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgvThanhToanCongNo.Click += new System.EventHandler(this.dgvThanhToanCongNo_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(463, 105);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Còn nợ";
            // 
            // txtConNo
            // 
            this.txtConNo.Enabled = false;
            this.txtConNo.Location = new System.Drawing.Point(558, 102);
            this.txtConNo.Name = "txtConNo";
            this.txtConNo.Size = new System.Drawing.Size(178, 20);
            this.txtConNo.TabIndex = 17;
            // 
            // cbbNhaCC
            // 
            this.cbbNhaCC.BackColor = System.Drawing.Color.White;
            this.cbbNhaCC.FormattingEnabled = true;
            this.cbbNhaCC.Location = new System.Drawing.Point(127, 71);
            this.cbbNhaCC.Name = "cbbNhaCC";
            this.cbbNhaCC.Size = new System.Drawing.Size(205, 21);
            this.cbbNhaCC.TabIndex = 15;
            this.cbbNhaCC.SelectedValueChanged += new System.EventHandler(this.cbbNhaCC_SelectedValueChanged);
            this.cbbNhaCC.Click += new System.EventHandler(this.cbbNhaCC_Click);
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHoaDon.Image")));
            this.btnXoaHoaDon.ImageIndex = 2;
            this.btnXoaHoaDon.Location = new System.Drawing.Point(688, 135);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(131, 23);
            this.btnXoaHoaDon.TabIndex = 14;
            this.btnXoaHoaDon.Text = "Xóa hóa đơn";
            this.btnXoaHoaDon.Click += new System.EventHandler(this.btnXoaHoaDon_Click);
            // 
            // btnThenHoaDon
            // 
            this.btnThenHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnThenHoaDon.Image")));
            this.btnThenHoaDon.ImageIndex = 0;
            this.btnThenHoaDon.Location = new System.Drawing.Point(392, 135);
            this.btnThenHoaDon.Name = "btnThenHoaDon";
            this.btnThenHoaDon.Size = new System.Drawing.Size(131, 23);
            this.btnThenHoaDon.TabIndex = 13;
            this.btnThenHoaDon.Text = "Thêm hóa đơn ";
            this.btnThenHoaDon.Click += new System.EventHandler(this.btnThenHoaDon_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(463, 55);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(89, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Số tiền thanh toán";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(463, 29);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Công nợ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 154);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Người thanh toán";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Thời gian";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 128);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Người nhận";
            // 
            // txtTienThanhToan
            // 
            this.txtTienThanhToan.Location = new System.Drawing.Point(558, 52);
            this.txtTienThanhToan.Name = "txtTienThanhToan";
            this.txtTienThanhToan.Size = new System.Drawing.Size(178, 20);
            this.txtTienThanhToan.TabIndex = 6;
            this.txtTienThanhToan.TextChanged += new System.EventHandler(this.txtTienThanhToan_TextChanged);
            // 
            // txtCongNo
            // 
            this.txtCongNo.Enabled = false;
            this.txtCongNo.Location = new System.Drawing.Point(558, 26);
            this.txtCongNo.Name = "txtCongNo";
            this.txtCongNo.Size = new System.Drawing.Size(178, 20);
            this.txtCongNo.TabIndex = 5;
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.Location = new System.Drawing.Point(127, 124);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.Size = new System.Drawing.Size(205, 20);
            this.txtNguoiNhan.TabIndex = 3;
            // 
            // dateThanhToan
            // 
            this.dateThanhToan.Enabled = false;
            this.dateThanhToan.Location = new System.Drawing.Point(127, 97);
            this.dateThanhToan.Name = "dateThanhToan";
            this.dateThanhToan.Size = new System.Drawing.Size(205, 21);
            this.dateThanhToan.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 75);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhà cung cấp";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lbTTMaHD);
            this.groupControl1.Controls.Add(this.lbSoTienThanhToan);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txtMaPhieu);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtNguoiThanhToan);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtConNo);
            this.groupControl1.Controls.Add(this.cbbNhaCC);
            this.groupControl1.Controls.Add(this.btnXoaHoaDon);
            this.groupControl1.Controls.Add(this.btnThenHoaDon);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtTienThanhToan);
            this.groupControl1.Controls.Add(this.txtCongNo);
            this.groupControl1.Controls.Add(this.txtNguoiNhan);
            this.groupControl1.Controls.Add(this.dateThanhToan);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(836, 177);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin thanh toán";
            // 
            // lbTTMaHD
            // 
            this.lbTTMaHD.AutoSize = true;
            this.lbTTMaHD.Location = new System.Drawing.Point(127, 52);
            this.lbTTMaHD.Name = "lbTTMaHD";
            this.lbTTMaHD.Size = new System.Drawing.Size(0, 13);
            this.lbTTMaHD.TabIndex = 24;
            // 
            // lbSoTienThanhToan
            // 
            this.lbSoTienThanhToan.AutoSize = true;
            this.lbSoTienThanhToan.Location = new System.Drawing.Point(555, 78);
            this.lbSoTienThanhToan.Name = "lbSoTienThanhToan";
            this.lbSoTienThanhToan.Size = new System.Drawing.Size(0, 13);
            this.lbSoTienThanhToan.TabIndex = 23;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageIndex = 0;
            this.simpleButton1.Location = new System.Drawing.Point(541, 135);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(131, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Lưu hóa đơn ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(127, 26);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(205, 20);
            this.txtMaPhieu.TabIndex = 21;
            this.txtMaPhieu.TextChanged += new System.EventHandler(this.txtMaPhieu_TextChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(16, 29);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Mã thanh toán";
            // 
            // txtNguoiThanhToan
            // 
            this.txtNguoiThanhToan.Enabled = false;
            this.txtNguoiThanhToan.Location = new System.Drawing.Point(127, 151);
            this.txtNguoiThanhToan.Name = "txtNguoiThanhToan";
            this.txtNguoiThanhToan.Size = new System.Drawing.Size(205, 20);
            this.txtNguoiThanhToan.TabIndex = 19;
            // 
            // FormThanhToanCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 609);
            this.Controls.Add(this.dgvThanhToanCongNo);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormThanhToanCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThanhToanCongNo";
            this.Load += new System.EventHandler(this.FormThanhToanCongNo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToanCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTienThanhToan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCongNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNguoiThanhToan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaThanhT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.GridControl dgvThanhToanCongNo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtConNo;
        private System.Windows.Forms.ComboBox cbbNhaCC;
        private DevExpress.XtraEditors.SimpleButton btnXoaHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnThenHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTienThanhToan;
        private DevExpress.XtraEditors.TextEdit txtCongNo;
        private DevExpress.XtraEditors.TextEdit txtNguoiNhan;
        private System.Windows.Forms.DateTimePicker dateThanhToan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtNguoiThanhToan;
        private DevExpress.XtraEditors.TextEdit txtMaPhieu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label lbSoTienThanhToan;
        private System.Windows.Forms.Label lbTTMaHD;
    }
}