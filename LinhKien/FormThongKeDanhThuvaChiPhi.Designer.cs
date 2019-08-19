namespace LinhKien
{
    partial class FormThongKeDanhThuvaChiPhi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeDanhThuvaChiPhi));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbbTheoNam = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbbTheoNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(531, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Theo năm";
            // 
            // cbbTheoNam
            // 
            this.cbbTheoNam.Location = new System.Drawing.Point(600, 12);
            this.cbbTheoNam.Name = "cbbTheoNam";
            this.cbbTheoNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbTheoNam.Properties.Items.AddRange(new object[] {
            "(none)"});
            this.cbbTheoNam.Size = new System.Drawing.Size(100, 20);
            this.cbbTheoNam.TabIndex = 12;
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(12, 53);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(1338, 676);
            this.chartControl1.TabIndex = 15;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(766, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "Lọc";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormThongKeDanhThuvaChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbbTheoNam);
            this.Name = "FormThongKeDanhThuvaChiPhi";
            this.Text = "FormThongKeDanhThuvaChiPhi";
            this.Load += new System.EventHandler(this.FormThongKeDanhThuvaChiPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbbTheoNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbbTheoNam;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}