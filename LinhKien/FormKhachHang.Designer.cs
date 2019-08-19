namespace LinhKien
{
    partial class FormKhachHang
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
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement13 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement14 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardKhachHang = new DevExpress.XtraGrid.Views.Card.CardView();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridHDKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLapHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tlThem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlSua = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlXoa = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlLuu = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlHuy = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItem6 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlThoat = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHDKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 1);
            this.tileBar1.MaxId = 9;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(1337, 104);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 304);
            this.gridControl1.MainView = this.cardKhachHang;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(822, 425);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardKhachHang});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // cardKhachHang
            // 
            this.cardKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKH,
            this.TenKH,
            this.Phone,
            this.DiaChi,
            this.GhiChu});
            this.cardKhachHang.FocusedCardTopFieldIndex = 0;
            this.cardKhachHang.GridControl = this.gridControl1;
            this.cardKhachHang.Name = "cardKhachHang";
            this.cardKhachHang.OptionsBehavior.Editable = false;
            this.cardKhachHang.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // MaKH
            // 
            this.MaKH.Caption = "Mã khách hàng";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 0;
            // 
            // TenKH
            // 
            this.TenKH.Caption = "Tên khách hàng";
            this.TenKH.FieldName = "TenKH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Visible = true;
            this.TenKH.VisibleIndex = 1;
            // 
            // Phone
            // 
            this.Phone.Caption = "Phone";
            this.Phone.FieldName = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Visible = true;
            this.Phone.VisibleIndex = 2;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 4;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(841, 304);
            this.gridControl2.MainView = this.gridHDKH;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(509, 425);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridHDKH});
            // 
            // gridHDKH
            // 
            this.gridHDKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHD,
            this.NgayLapHD,
            this.MaNV,
            this.ThanhTien});
            this.gridHDKH.GridControl = this.gridControl2;
            this.gridHDKH.Name = "gridHDKH";
            this.gridHDKH.OptionsBehavior.Editable = false;
            // 
            // MaHD
            // 
            this.MaHD.Caption = "Mã hóa đơn";
            this.MaHD.FieldName = "MaHD";
            this.MaHD.Name = "MaHD";
            this.MaHD.Visible = true;
            this.MaHD.VisibleIndex = 0;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.Caption = "Ngày lập hóa đơn";
            this.NgayLapHD.FieldName = "NgayLapHD";
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.Visible = true;
            this.NgayLapHD.VisibleIndex = 1;
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Mã nhân viên";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 2;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 3;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tlThem);
            this.tileBarGroup2.Items.Add(this.tlSua);
            this.tileBarGroup2.Items.Add(this.tlXoa);
            this.tileBarGroup2.Items.Add(this.tlLuu);
            this.tileBarGroup2.Items.Add(this.tlHuy);
            this.tileBarGroup2.Items.Add(this.tileBarItem6);
            this.tileBarGroup2.Items.Add(this.tlThoat);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tlThem
            // 
            this.tlThem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.Image = global::LinhKien.Properties.Resources.add1600;
            tileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement8.Text = "Thêm";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tlThem.Elements.Add(tileItemElement8);
            this.tlThem.Id = 1;
            this.tlThem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tlThem.Name = "tlThem";
            this.tlThem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlThem_ItemClick);
            // 
            // tlSua
            // 
            this.tlSua.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.Image = global::LinhKien.Properties.Resources.Programming_Edit_Property_icon;
            tileItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement9.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement9.Text = "Sửa";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tlSua.Elements.Add(tileItemElement9);
            this.tlSua.Id = 2;
            this.tlSua.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tlSua.Name = "tlSua";
            this.tlSua.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlSua_ItemClick);
            // 
            // tlXoa
            // 
            this.tlXoa.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.Image = global::LinhKien.Properties.Resources._206529;
            tileItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement10.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement10.Text = "Xóa";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tlXoa.Elements.Add(tileItemElement10);
            this.tlXoa.Id = 3;
            this.tlXoa.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tlXoa.Name = "tlXoa";
            this.tlXoa.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlXoa_ItemClick);
            // 
            // tlLuu
            // 
            this.tlLuu.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement11.Image = global::LinhKien.Properties.Resources._1493303491695;
            tileItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement11.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement11.Text = "Lưu";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tlLuu.Elements.Add(tileItemElement11);
            this.tlLuu.Id = 4;
            this.tlLuu.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tlLuu.Name = "tlLuu";
            this.tlLuu.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlLuu_ItemClick);
            // 
            // tlHuy
            // 
            this.tlHuy.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement12.Image = global::LinhKien.Properties.Resources._9308;
            tileItemElement12.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement12.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement12.Text = "Hủy";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tlHuy.Elements.Add(tileItemElement12);
            this.tlHuy.Id = 5;
            this.tlHuy.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tlHuy.Name = "tlHuy";
            this.tlHuy.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlHuy_ItemClick);
            // 
            // tileBarItem6
            // 
            this.tileBarItem6.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement13.Image = global::LinhKien.Properties.Resources._61681_200;
            tileItemElement13.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement13.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement13.Text = "Reset";
            tileItemElement13.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileBarItem6.Elements.Add(tileItemElement13);
            this.tileBarItem6.Id = 6;
            this.tileBarItem6.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem6.Name = "tileBarItem6";
            this.tileBarItem6.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem6_ItemClick);
            // 
            // tlThoat
            // 
            this.tlThoat.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement14.Image = global::LinhKien.Properties.Resources.log_off_to_exit_icon_63849;
            tileItemElement14.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement14.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement14.Text = "Thoát";
            tileItemElement14.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tlThoat.Elements.Add(tileItemElement14);
            this.tlThoat.Id = 8;
            this.tlThoat.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tlThoat.Name = "tlThoat";
            this.tlThoat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlThoat_ItemClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.txtPhone);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtTenKH);
            this.groupControl1.Controls.Add(this.txtMaKH);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(13, 111);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1324, 128);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(451, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(451, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(825, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú :";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMaKH.Location = new System.Drawing.Point(152, 35);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(235, 24);
            this.txtMaKH.TabIndex = 5;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTenKH.Location = new System.Drawing.Point(152, 92);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(235, 24);
            this.txtTenKH.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDiaChi.Location = new System.Drawing.Point(523, 32);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(235, 24);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPhone.Location = new System.Drawing.Point(523, 89);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(235, 24);
            this.txtPhone.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtGhiChu.Location = new System.Drawing.Point(917, 35);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(358, 81);
            this.txtGhiChu.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.textBox6.Location = new System.Drawing.Point(360, 270);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(235, 24);
            this.textBox6.TabIndex = 8;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(257, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tìm kiếm :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label7.Location = new System.Drawing.Point(927, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Danh sách hóa đơn của khách hàng :";
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.tileBar1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHDKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn TenKH;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridHDKH;
        private DevExpress.XtraGrid.Columns.GridColumn MaHD;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLapHD;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tlThem;
        private DevExpress.XtraBars.Navigation.TileBarItem tlSua;
        private DevExpress.XtraBars.Navigation.TileBarItem tlXoa;
        private DevExpress.XtraBars.Navigation.TileBarItem tlLuu;
        private DevExpress.XtraBars.Navigation.TileBarItem tlHuy;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem6;
        private DevExpress.XtraBars.Navigation.TileBarItem tlThoat;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}