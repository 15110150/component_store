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
using BALayer;
using DevExpress.XtraCharts;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Controls;

namespace LinhKien
{
    public partial class FormThongKeSoLuongSpBanRa : DevExpress.XtraEditors.XtraForm
    {
        BASanPham balSP;
        BAThongKeSanPham balThongKe;
        BALoaiSP balLoaiSP;
        Series series = new Series("Số lượng sản phẩm bán ra", ViewType.Bar);
        Series series1 = new Series("Số lượng sản phẩm còn trong kho", ViewType.Bar);
        bool click = false;
        public FormThongKeSoLuongSpBanRa()
        {
            InitializeComponent();
            balSP= new BASanPham();
            balThongKe = new BAThongKeSanPham();
        }
       private void Tai(Series s, DataTable a)
        {
            //s = null;
            s.DataSource = a;
        }
        private void LoadLoaiSP()
        {
            balLoaiSP = new BALoaiSP();
            try
            {
                if (balLoaiSP.LayListLoaiSanPham().Tables[0].Rows.Count != 0)
                {
                    //load danh sách loại sản phẩm lên gridcontrol loại sản phẩm

                    DataTable dtLoaiSP = balLoaiSP.LayListLoaiSanPham().Tables[0];
                    //load lên combobox loại sản phẩm
                    this.cbbLoaiSP.DataSource = dtLoaiSP;
                    this.cbbLoaiSP.ValueMember = "MaLoai";
                    this.cbbLoaiSP.DisplayMember = "TenLoai";

                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu Loại sản phẩm được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu Loại sản phẩm được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormThongKeSoLuongSpBanRa_Load(object sender, EventArgs e)
        {
            // Create a chart.
            LoadLoaiSP();
            LoadChartToanbo();
            chartControl1.Series.Add(series1);
            chartControl1.Series.Add(series);

        }
        private void LoadChartTheoLoai()
        {
            Tai(series, balThongKe.ThongKeSLTheoLoai(cbbLoaiSP.SelectedValue.ToString()).Tables[0]);
            Tai(series1, balThongKe.ThongKeSLTheoLoai(cbbLoaiSP.SelectedValue.ToString()).Tables[0]);
        }

        private void cbbLoaiSP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (click)
            {
                Tai(series, null);
                Tai(series1, null);
                LoadChartTheoLoai();
            }
        }
        private void LoadChartToanbo()
        {
            series.ArgumentScaleType = ScaleType.Auto;
            series.ArgumentDataMember = "TenSP";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "SlBan" });
            Tai(series, balThongKe.ThongKeSLToanBo().Tables[0]);



            series1.ArgumentScaleType = ScaleType.Auto;
            series1.ArgumentDataMember = "TenSP";
            series1.ValueScaleType = ScaleType.Numerical;
            series1.ValueDataMembers.AddRange(new string[] { "SoLuongTrongKho" });
            Tai(series1, balThongKe.ThongKeSLToanBo().Tables[0]);
          

        }

        private void cbbLoaiSP_Click(object sender, EventArgs e)
        {
            click = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
             Tai(series, null);
                Tai(series1, null);
            LoadChartToanbo();

        }
    }
}