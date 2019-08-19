namespace LinhKien
{
    partial class FormLoaiSP
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tlThem = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlSua = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlXoa = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlLuu = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tlHuy = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.gbThongtin = new DevExpress.XtraEditors.GroupControl();
            this.txtTenLoai = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoai = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gbThongtin)).BeginInit();
            this.gbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(4, 13);
            this.tileBar1.MaxId = 5;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(399, 104);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tlThem);
            this.tileBarGroup2.Items.Add(this.tlSua);
            this.tileBarGroup2.Items.Add(this.tlXoa);
            this.tileBarGroup2.Items.Add(this.tlLuu);
            this.tileBarGroup2.Items.Add(this.tlHuy);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tlThem
            // 
            this.tlThem.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = global::LinhKien.Properties.Resources.add1600;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement1.Text = "";
            this.tlThem.Elements.Add(tileItemElement1);
            this.tlThem.Id = 0;
            this.tlThem.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tlThem.Name = "tlThem";
            this.tlThem.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlThem_ItemClick);
            // 
            // tlSua
            // 
            this.tlSua.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = global::LinhKien.Properties.Resources.Programming_Edit_Property_icon;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement2.Text = "";
            this.tlSua.Elements.Add(tileItemElement2);
            this.tlSua.Id = 1;
            this.tlSua.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tlSua.Name = "tlSua";
            this.tlSua.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlSua_ItemClick);
            // 
            // tlXoa
            // 
            this.tlXoa.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = global::LinhKien.Properties.Resources._206529;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement3.Text = "";
            this.tlXoa.Elements.Add(tileItemElement3);
            this.tlXoa.Id = 2;
            this.tlXoa.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tlXoa.Name = "tlXoa";
            this.tlXoa.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlXoa_ItemClick);
            // 
            // tlLuu
            // 
            this.tlLuu.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Image = global::LinhKien.Properties.Resources._1493303491695;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement4.Text = "";
            this.tlLuu.Elements.Add(tileItemElement4);
            this.tlLuu.Id = 3;
            this.tlLuu.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tlLuu.Name = "tlLuu";
            this.tlLuu.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlLuu_ItemClick);
            // 
            // tlHuy
            // 
            this.tlHuy.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = global::LinhKien.Properties.Resources._9308;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement5.Text = "";
            this.tlHuy.Elements.Add(tileItemElement5);
            this.tlHuy.Id = 4;
            this.tlHuy.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tlHuy.Name = "tlHuy";
            this.tlHuy.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tlHuy_ItemClick);
            // 
            // gbThongtin
            // 
            this.gbThongtin.Controls.Add(this.txtTenLoai);
            this.gbThongtin.Controls.Add(this.label2);
            this.gbThongtin.Controls.Add(this.txtMaLoai);
            this.gbThongtin.Controls.Add(this.label1);
            this.gbThongtin.Location = new System.Drawing.Point(4, 123);
            this.gbThongtin.Name = "gbThongtin";
            this.gbThongtin.Size = new System.Drawing.Size(399, 83);
            this.gbThongtin.TabIndex = 1;
            this.gbThongtin.Text = "Thông tin";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(241, 41);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(140, 20);
            this.txtTenLoai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại : ";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(75, 41);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(81, 20);
            this.txtMaLoai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại : ";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(4, 236);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(399, 180);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLoai,
            this.TenLoai});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaLoai
            // 
            this.MaLoai.Caption = "Mã loại";
            this.MaLoai.FieldName = "MaLoai";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Visible = true;
            this.MaLoai.VisibleIndex = 0;
            // 
            // TenLoai
            // 
            this.TenLoai.Caption = "Tên loại";
            this.TenLoai.FieldName = "TenLoai";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Visible = true;
            this.TenLoai.VisibleIndex = 1;
            // 
            // FormLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 428);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gbThongtin);
            this.Controls.Add(this.tileBar1);
            this.Name = "FormLoaiSP";
            this.Text = "FormLoaiSP";
            this.Load += new System.EventHandler(this.FormLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbThongtin)).EndInit();
            this.gbThongtin.ResumeLayout(false);
            this.gbThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tlThem;
        private DevExpress.XtraBars.Navigation.TileBarItem tlSua;
        private DevExpress.XtraBars.Navigation.TileBarItem tlXoa;
        private DevExpress.XtraBars.Navigation.TileBarItem tlLuu;
        private DevExpress.XtraBars.Navigation.TileBarItem tlHuy;
        private DevExpress.XtraEditors.GroupControl gbThongtin;
        private DevExpress.XtraEditors.TextEdit txtTenLoai;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtMaLoai;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoai;
    }
}