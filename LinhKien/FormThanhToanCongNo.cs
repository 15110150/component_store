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
using System.Data.SqlClient;

namespace LinhKien
{
    public partial class FormThanhToanCongNo : DevExpress.XtraEditors.XtraForm
    {
        BaNhaCungCap balNhaCC;
        BACongNo balCongNo;
        bool ClickCbbNhaCC = false;
        public FormThanhToanCongNo()
        {
            InitializeComponent();
            balNhaCC = new BaNhaCungCap();
           
        }
        private void DonThongTin()
        {
            txtCongNo.ResetText();
            txtConNo.ResetText();
            txtMaPhieu.ResetText();
            txtNguoiNhan.ResetText();
            txtTienThanhToan.ResetText();
            cbbNhaCC.ResetText();
            txtNguoiThanhToan.ResetText();
            txtNguoiThanhToan.Text = "1"; /*FormLogonCT.MaNV;*/
        }

        private void btnThenHoaDon_Click(object sender, EventArgs e)
        {
            DonThongTin();
            HienThiThongTin(true);
        }
        private void LoadNhaCC()
        {
            try
            {
                if (balNhaCC.LayListNhaCungCap().Tables[0].Rows.Count != 0)
                {

                    //load nhà cung cấp vào combobox nhà cung cấp
                    DataTable dtNCC = balNhaCC.LayListNhaCungCap().Tables[0];
                    this.cbbNhaCC.DataSource = dtNCC;

                    this.cbbNhaCC.ValueMember = "MaNCC";
                    this.cbbNhaCC.DisplayMember = "TenNCC";
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu Nhà cung cấp được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu Nhà cung cấp được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiThongTin(bool f)
        {
            txtConNo.Enabled = f;
            txtMaPhieu.Enabled = f;
            txtNguoiNhan.Enabled = f;
            txtTienThanhToan.Enabled = f;
            dateThanhToan.Enabled = f;
            cbbNhaCC.Enabled = f;
        }
        private void loadHD()
        {
            balCongNo = new BACongNo();
            try
            {
                this.dgvThanhToanCongNo.DataSource = balCongNo.LayListThanhToanCN().Tables[0];
                load();
                
            }
            catch (SqlException error)
            {
                MessageBox.Show("Không truy cập dữ liệu công nợ được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception er)
            {
                MessageBox.Show("Không truy cập dữ liệu công nợ được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void load()
        {
            int rowSelected1 = gridView1.FocusedRowHandle;
            txtMaPhieu.Text = gridView1.GetRowCellValue(rowSelected1, "MaThanhToan").ToString();
            cbbNhaCC.SelectedValue = gridView1.GetRowCellValue(rowSelected1, "MaNCC").ToString();
            dateThanhToan.Text = gridView1.GetRowCellValue(rowSelected1, "ThoiGian").ToString();
            txtNguoiNhan.Text= gridView1.GetRowCellValue(rowSelected1, "NguoiNhan").ToString();
            txtNguoiThanhToan.Text = gridView1.GetRowCellValue(rowSelected1, "NgThanhToan").ToString();
            txtCongNo.Text=gridView1.GetRowCellValue(rowSelected1, "CongNo").ToString();
            txtTienThanhToan.Text = gridView1.GetRowCellValue(rowSelected1, "SoTienThanhToan").ToString();
        }
        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa hóa đơn thanh toán này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    string error = "";
                    try
                    {
                        if (balCongNo.XoaThanhToan(ref error, this.txtMaPhieu.Text))
                        {
                            MessageBox.Show("xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi: " + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    catch (SqlException)
                    {
                        MessageBox.Show("Không sửa được. Lỗi rồi!");
                    }
                    loadHD();
                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormThanhToanCongNo_Load(object sender, EventArgs e)
        {
            HienThiThongTin(false);
            LoadNhaCC();
            loadHD();
          
        }

        private void dgvThanhToanCongNo_Click(object sender, EventArgs e)
        {
            load();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.txtNguoiNhan.Text == string.Empty || this.txtTienThanhToan.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập các đầy đủ các thông tin!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(lbTTMaHD.ForeColor==Color.Red)
            {
                MessageBox.Show("Mã hóa đơn đã có!", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(lbSoTienThanhToan.ForeColor==Color.Red)
            {
                MessageBox.Show("Nhập lại số tiền thanh toán !", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    
                    string error = "";

                    try
                    {
                        //cập nhật công nợ còn lại vào thông tin của nhà cung ccấp trước
                        if (balNhaCC.CapNhatCongNoNCC(ref error, this.cbbNhaCC.SelectedValue.ToString(), double.Parse(this.txtConNo.Text), DateTime.Now))
                        {
                            try
                            {
                                //thêm hóa đơn vào csdl
                                if (balCongNo.ThemThanhToan(ref error, txtMaPhieu.Text, this.cbbNhaCC.SelectedValue.ToString(), DateTime.Now, this.txtNguoiNhan.Text,
                                    txtNguoiThanhToan.Text, double.Parse(this.txtCongNo.Text), double.Parse(this.txtTienThanhToan.Text)))
                                {
                                    MessageBox.Show("Thêm hóa đơn thanh toán công nợ vào dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    HienThiThongTin(false);
                                    loadHD();
                                    DonThongTin();
                                }
                                else
                                {
                                    //lỗi từ sqlserver
                                    MessageBox.Show("Lỗi: " + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception er)
                            {
                                //bắt các lỗi khác
                                MessageBox.Show("Thêm hóa đơn thanh toán công nợ vào dữ liệu không thành công!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //nếu có lỗi gi từ sql hay lỗi khác thì dừng tiến trình
                            MessageBox.Show("Cập nhật công nợ vào dữ liệu nhà cung cấp không thành công!\rLỗi:" + error, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Cập nhật công nợ vào dữ liệu nhà cung cấp không thành công!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException err)
                {
                    MessageBox.Show("Không kiểm tra đươc mã hóa đơn thanh toán công nợ.\rLỗi: " + err.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Không kiểm tra đươc mã hóa đơn thanh toán công nợ.\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTienThanhToan_TextChanged(object sender, EventArgs e)
        {
            if (txtTienThanhToan.Enabled == true)
            {
                int distance;
                // nếu text box số lượng khác null
                if (!string.IsNullOrEmpty(txtTienThanhToan.Text))
                {
                    //nếu không phải là số
                    if (!int.TryParse(txtTienThanhToan.Text, out distance))
                    {

                        lbSoTienThanhToan.Text = "Hãy nhập số nguyên";
                        // cho label trạng thái nằm dưới text box đó màu đỏ
                        lbSoTienThanhToan.ForeColor = Color.Red;

                    }
                    //kiểm tra số âm
                    else if ((double.Parse(txtTienThanhToan.Text) <= 0))
                    {
                        lbSoTienThanhToan.Text = "Hãy nhập số dương";
                        // cho label trạng thái nằm dưới text box đó màu đỏ
                        lbSoTienThanhToan.ForeColor = Color.Red;
                    }
                    // nếu là số nguyên 
                    else
                    {
                        txtConNo.Text = (double.Parse(txtCongNo.Text) - double.Parse(txtTienThanhToan.Text)).ToString();
                        lbSoTienThanhToan.ForeColor = Color.Green;

                    }
                }
                else
                {
                    //label trạng thái không hiện gì
                    lbSoTienThanhToan.Text = "";
                    lbSoTienThanhToan.ForeColor = Color.Green;


                }
            }
            else
            {
                this.lbSoTienThanhToan.ForeColor = Color.Green;
                lbSoTienThanhToan.Text = "";
            }
        }
  

        private void txtMaPhieu_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhieu.Enabled == true)
            {
                try
                {
                    //khi nhập mã đơn hàng vào ô mã đơn hàng mới thì cũng kiểm tra sự tồn tại của mã đơn hàng trong csdl
                    if (string.IsNullOrEmpty(txtMaPhieu.Text))
                    {
                        lbTTMaHD.Text = "";
                        lbTTMaHD.ForeColor = Color.Green;
                    }
                    else if (balCongNo.KiemTraMaThahHToan(this.txtMaPhieu.Text).Tables[0].Rows.Count != 0)
                    {
                        //nếu mã hóa đơn đã có
                        this.lbTTMaHD.Text = "Ma hoa don da co";
                        // cho label trạng thái nằm dưới text box đó màu đỏ
                        this.lbTTMaHD.ForeColor = Color.Red;
                    }
                    else
                    {
                        //nếu chưua bị trùng
                        this.lbTTMaHD.Text = "Mã hóa đơn sẵn sàng";
                        // cho label trạng thái nam29 dưới text box đó màu xanh
                        string d = txtMaPhieu.Text;
                        this.lbTTMaHD.ForeColor = Color.Green;
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show("Không truy cập dữ liệu hóa dơn thanh toán công nợ được!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception er)
                {
                    MessageBox.Show("Không truy cập dữ liệu hóa dơn thanh toán công nợ được!\rLỗi: " + er.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.lbTTMaHD.ForeColor = Color.Green;
                lbTTMaHD.Text = "";
            }
        }

        private void cbbNhaCC_SelectedValueChanged(object sender, EventArgs e)
        {

            if (ClickCbbNhaCC)//khi chưua click  vào combobox nhà cung cấp (ClickCbbNhaCC=false) thì chưa xử lý sự kiện này đc
            {
                try
                {
                    //chọn nhà cung cấp để thanh toán công nợ
                    DataTable dt = balNhaCC.LayCongNoNCC(this.cbbNhaCC.SelectedValue.ToString()).Tables[0];
                    this.txtCongNo.Text = dt.Rows[0][0].ToString();

                   
                }
                catch (SqlException error)
                {
                    MessageBox.Show("Không lấy được dữ liệu công nợ từ nhà cung cấp!\rLỗi: " + error.Message, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbbNhaCC_Click(object sender, EventArgs e)
        {
            ClickCbbNhaCC = true;
        }
    }
}