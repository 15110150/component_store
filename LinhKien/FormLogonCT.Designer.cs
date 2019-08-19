namespace LinhKien
{
    partial class FormLogonCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogonCT));
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdNVK = new System.Windows.Forms.RadioButton();
            this.rdQLCH = new System.Windows.Forms.RadioButton();
            this.rdNVBH = new System.Windows.Forms.RadioButton();
            this.rdCHC = new System.Windows.Forms.RadioButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = global::LinhKien.Properties.Resources.nền;
            this.tileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(662, 415);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUser.Location = new System.Drawing.Point(151, 89);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(274, 29);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtPass.Location = new System.Drawing.Point(151, 147);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(274, 29);
            this.txtPass.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdNVK);
            this.groupControl1.Controls.Add(this.rdQLCH);
            this.groupControl1.Controls.Add(this.rdNVBH);
            this.groupControl1.Controls.Add(this.rdCHC);
            this.groupControl1.Location = new System.Drawing.Point(151, 212);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(274, 103);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Select one";
            // 
            // rdNVK
            // 
            this.rdNVK.AutoSize = true;
            this.rdNVK.Location = new System.Drawing.Point(154, 68);
            this.rdNVK.Name = "rdNVK";
            this.rdNVK.Size = new System.Drawing.Size(93, 17);
            this.rdNVK.TabIndex = 3;
            this.rdNVK.TabStop = true;
            this.rdNVK.Text = "Nhân viên kho";
            this.rdNVK.UseVisualStyleBackColor = true;
            // 
            // rdQLCH
            // 
            this.rdQLCH.AutoSize = true;
            this.rdQLCH.Location = new System.Drawing.Point(154, 24);
            this.rdQLCH.Name = "rdQLCH";
            this.rdQLCH.Size = new System.Drawing.Size(106, 17);
            this.rdQLCH.TabIndex = 2;
            this.rdQLCH.TabStop = true;
            this.rdQLCH.Text = "Quản lí cửa hàng";
            this.rdQLCH.UseVisualStyleBackColor = true;
            // 
            // rdNVBH
            // 
            this.rdNVBH.AutoSize = true;
            this.rdNVBH.Location = new System.Drawing.Point(15, 68);
            this.rdNVBH.Name = "rdNVBH";
            this.rdNVBH.Size = new System.Drawing.Size(121, 17);
            this.rdNVBH.TabIndex = 1;
            this.rdNVBH.TabStop = true;
            this.rdNVBH.Text = "Nhân viên bán hàng";
            this.rdNVBH.UseVisualStyleBackColor = true;
            // 
            // rdCHC
            // 
            this.rdCHC.AutoSize = true;
            this.rdCHC.Location = new System.Drawing.Point(15, 24);
            this.rdCHC.Name = "rdCHC";
            this.rdCHC.Size = new System.Drawing.Size(92, 17);
            this.rdCHC.TabIndex = 0;
            this.rdCHC.TabStop = true;
            this.rdCHC.Text = "Chủ cửa hàng";
            this.rdCHC.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(246, 349);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormLogonCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 415);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.tileControl1);
            this.Name = "FormLogonCT";
            this.ShowIcon = false;
            this.Text = "Login chương trình";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdNVK;
        private System.Windows.Forms.RadioButton rdQLCH;
        private System.Windows.Forms.RadioButton rdNVBH;
        private System.Windows.Forms.RadioButton rdCHC;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}