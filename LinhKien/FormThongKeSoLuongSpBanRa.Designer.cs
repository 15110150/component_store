namespace LinhKien
{
    partial class FormThongKeSoLuongSpBanRa
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKeSoLuongSpBanRa));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.linhKien3DataSet = new LinhKien.LinhKien3DataSet();
            this.linhKien3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhKien3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhKien3DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(11, 42);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(1338, 697);
            this.chartControl1.TabIndex = 1;
            chartTitle1.Text = "Thống kê số lượng sản phẩm bán ra\r\n";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // linhKien3DataSet
            // 
            this.linhKien3DataSet.DataSetName = "LinhKien3DataSet";
            this.linhKien3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linhKien3DataSetBindingSource
            // 
            this.linhKien3DataSetBindingSource.DataSource = this.linhKien3DataSet;
            this.linhKien3DataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lọc theo :";
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Items.AddRange(new object[] {
            "--Toàn bộ--"});
            this.cbbLoaiSP.Location = new System.Drawing.Point(102, 15);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiSP.TabIndex = 4;
            this.cbbLoaiSP.SelectedValueChanged += new System.EventHandler(this.cbbLoaiSP_SelectedValueChanged);
            this.cbbLoaiSP.Click += new System.EventHandler(this.cbbLoaiSP_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(264, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(98, 23);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Lọc toàn bộ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FormThongKeSoLuongSpBanRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cbbLoaiSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartControl1);
            this.Name = "FormThongKeSoLuongSpBanRa";
            this.Text = "FormThongKeSoLuongSpBanRa";
            this.Load += new System.EventHandler(this.FormThongKeSoLuongSpBanRa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhKien3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhKien3DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource linhKien3DataSetBindingSource;
        private LinhKien3DataSet linhKien3DataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}