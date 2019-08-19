namespace LinhKien
{
    partial class FormDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMK));
            this.txtTK = new DevExpress.XtraEditors.TextEdit();
            this.txtMKC = new DevExpress.XtraEditors.TextEdit();
            this.txtMKM = new DevExpress.XtraEditors.TextEdit();
            this.txtNhapLaiMKM = new DevExpress.XtraEditors.TextEdit();
            this.tctHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMKM.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(255, 134);
            this.txtTK.Name = "txtTK";
            this.txtTK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTK.Properties.Appearance.Options.UseFont = true;
            this.txtTK.Size = new System.Drawing.Size(221, 22);
            this.txtTK.TabIndex = 1;
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(255, 182);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMKC.Properties.Appearance.Options.UseFont = true;
            this.txtMKC.Size = new System.Drawing.Size(221, 22);
            this.txtMKC.TabIndex = 2;
            // 
            // txtMKM
            // 
            this.txtMKM.Location = new System.Drawing.Point(255, 235);
            this.txtMKM.Name = "txtMKM";
            this.txtMKM.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMKM.Properties.Appearance.Options.UseFont = true;
            this.txtMKM.Size = new System.Drawing.Size(221, 22);
            this.txtMKM.TabIndex = 3;
            // 
            // txtNhapLaiMKM
            // 
            this.txtNhapLaiMKM.Location = new System.Drawing.Point(255, 286);
            this.txtNhapLaiMKM.Name = "txtNhapLaiMKM";
            this.txtNhapLaiMKM.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNhapLaiMKM.Properties.Appearance.Options.UseFont = true;
            this.txtNhapLaiMKM.Size = new System.Drawing.Size(221, 22);
            this.txtNhapLaiMKM.TabIndex = 4;
            // 
            // tctHuy
            // 
            this.tctHuy.Image = ((System.Drawing.Image)(resources.GetObject("tctHuy.Image")));
            this.tctHuy.Location = new System.Drawing.Point(401, 347);
            this.tctHuy.Name = "tctHuy";
            this.tctHuy.Size = new System.Drawing.Size(75, 23);
            this.tctHuy.TabIndex = 6;
            this.tctHuy.Text = "Hủy";
            this.tctHuy.Click += new System.EventHandler(this.tctHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(255, 347);
            this.btnCapNhat.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = global::LinhKien.Properties.Resources.MK;
            this.tileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(673, 441);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 441);
            this.Controls.Add(this.tctHuy);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNhapLaiMKM);
            this.Controls.Add(this.txtMKM);
            this.Controls.Add(this.txtMKC);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.tileControl1);
            this.Name = "FormDoiMK";
            this.Text = "FormDoiMK";
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMKM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLaiMKM.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TextEdit txtTK;
        private DevExpress.XtraEditors.TextEdit txtMKC;
        private DevExpress.XtraEditors.TextEdit txtMKM;
        private DevExpress.XtraEditors.TextEdit txtNhapLaiMKM;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton tctHuy;
    }
}