namespace LinhKien
{
    partial class FormNhapServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapServer));
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cbbServer = new System.Windows.Forms.ComboBox();
            this.cbbData = new System.Windows.Forms.ComboBox();
            this.rdWT = new System.Windows.Forms.RadioButton();
            this.rdSQL = new System.Windows.Forms.RadioButton();
            this.btnGetData = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.BackgroundImage = global::LinhKien.Properties.Resources.vi;
            this.tileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(712, 457);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(223, 279);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(294, 28);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(223, 220);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(294, 28);
            this.txtUser.TabIndex = 2;
            // 
            // cbbServer
            // 
            this.cbbServer.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbbServer.FormattingEnabled = true;
            this.cbbServer.Location = new System.Drawing.Point(223, 112);
            this.cbbServer.Name = "cbbServer";
            this.cbbServer.Size = new System.Drawing.Size(294, 24);
            this.cbbServer.TabIndex = 3;
            // 
            // cbbData
            // 
            this.cbbData.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbbData.FormattingEnabled = true;
            this.cbbData.Location = new System.Drawing.Point(223, 337);
            this.cbbData.Name = "cbbData";
            this.cbbData.Size = new System.Drawing.Size(183, 24);
            this.cbbData.TabIndex = 4;
            // 
            // rdWT
            // 
            this.rdWT.AutoSize = true;
            this.rdWT.Location = new System.Drawing.Point(223, 166);
            this.rdWT.Name = "rdWT";
            this.rdWT.Size = new System.Drawing.Size(136, 17);
            this.rdWT.TabIndex = 5;
            this.rdWT.TabStop = true;
            this.rdWT.Text = "Window Authentication";
            this.rdWT.UseVisualStyleBackColor = true;
            this.rdWT.CheckedChanged += new System.EventHandler(this.rdWT_CheckedChanged);
            // 
            // rdSQL
            // 
            this.rdSQL.AutoSize = true;
            this.rdSQL.Location = new System.Drawing.Point(365, 166);
            this.rdSQL.Name = "rdSQL";
            this.rdSQL.Size = new System.Drawing.Size(152, 17);
            this.rdSQL.TabIndex = 6;
            this.rdSQL.TabStop = true;
            this.rdSQL.Text = "SQL Server Authentication";
            this.rdSQL.UseVisualStyleBackColor = true;
            this.rdSQL.CheckedChanged += new System.EventHandler(this.rdSQL_CheckedChanged);
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(437, 337);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(80, 23);
            this.btnGetData.TabIndex = 7;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.Location = new System.Drawing.Point(326, 392);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Connect";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormNhapServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 457);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.rdSQL);
            this.Controls.Add(this.rdWT);
            this.Controls.Add(this.cbbData);
            this.Controls.Add(this.cbbServer);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.tileControl1);
            this.Name = "FormNhapServer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormNhapServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cbbServer;
        private System.Windows.Forms.ComboBox cbbData;
        private System.Windows.Forms.RadioButton rdWT;
        private System.Windows.Forms.RadioButton rdSQL;
        private DevExpress.XtraEditors.SimpleButton btnGetData;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}

