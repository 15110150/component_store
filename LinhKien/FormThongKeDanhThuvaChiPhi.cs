using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using BALayer;

namespace LinhKien
{
    public partial class FormThongKeDanhThuvaChiPhi : DevExpress.XtraEditors.XtraForm
    {
        BAThongKeChiPhi balThongKe;
        Series series = new Series("Chi phí nhập hàng", ViewType.Line);
        Series series1 = new Series("Doanh thu", ViewType.Line);
        public FormThongKeDanhThuvaChiPhi()
        {
            InitializeComponent();
            balThongKe = new BAThongKeChiPhi();
        }
        private void loadThongtin()
        {
            int year = DateTime.Now.Year;
            while (year != 2010)
            {
                this.cbbTheoNam.Properties.Items.Add(year);
                year--;
            }
            cbbTheoNam.Text = DateTime.Now.Year.ToString();
            //int month = 1;
            //while (month != 13)
            //{
            //    this.cbbMonth.Properties.Items.Add(month);
            //    month++;
            //}
        }

        private void FormThongKeDanhThuvaChiPhi_Load(object sender, EventArgs e)
        {
            loadThongtin();
            LoadChartToanbo();
            chartControl1.Series.Add(series1);
            chartControl1.Series.Add(series);


        }
        private void LoadChartToanbo()
        {
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "Mnth";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Tong" });
            series.DataSource = balThongKe.LayThongKeNhapTheoNam(DateTime.Now.Year).Tables[0];
         

            series1.ArgumentScaleType = ScaleType.Auto;
            series1.ArgumentDataMember = "Mnth";
            series1.ValueScaleType = ScaleType.Numerical;
            series1.ValueDataMembers.AddRange(new string[] { "Tong" });
            series1.DataSource = balThongKe.LayThongKeTheoNam(DateTime.Now.Year).Tables[0];


        }
        private void LoadChartTheoNam()
        {
            series1.DataSource = null;
            series.DataSource = null;
            series1.DataSource = balThongKe.LayThongKeTheoNam(int.Parse(cbbTheoNam.Text.ToString())).Tables[0];
            series.DataSource = balThongKe.LayThongKeNhapTheoNam(int.Parse(cbbTheoNam.Text.ToString())).Tables[0];
        }
        //private void LoadChartTheoThangNam()
        //{
        //    series1.DataSource = null;
        //    series.DataSource = null;
        //    series1.DataSource = balThongKe.LayThongKeTheoThangNam(int.Parse(cbbMonth.Text.ToString()), int.Parse(cbbTheoNam.Text.ToString())).Tables[0];
        //    series.DataSource = balThongKe.LayThongKeNhapTheoThangNam(int.Parse(cbbMonth.Text.ToString()), int.Parse(cbbTheoNam.Text.ToString())).Tables[0];
        //    series.ArgumentDataMember = "Da";
        //    series1.ArgumentDataMember = "Da";
        //}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cbbTheoNam.Text.ToString() == "(none)")
            {
                LoadChartToanbo();
            }
            else if (cbbTheoNam.Text.ToString() != "(none)")
            {
                LoadChartTheoNam();
            }
        }
    }
}