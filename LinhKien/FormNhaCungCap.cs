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
    public partial class FormNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        bool insert = false;
        bool update = false;
        BaNhaCungCap balNhacungcap;
        public FormNhaCungCap()
        {
            InitializeComponent();
            balNhacungcap = new BaNhaCungCap();
        }
        private void load()
        {
            int rowSelected = gridView1.FocusedRowHandle;
            txtMaNCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNCC").ToString();
            txtTenNCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNCC").ToString();
            txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();

            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
            txtSDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Phone").ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GhiChu").ToString();
            ckTTHT.Checked = Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TinhTrangHopTac"));
        }
        private void HienThiHanhDong(bool f)
        {
            tlHuy.Enabled = f;
            tlLuu.Enabled = f;
        }
        private void HienThiChucNang(bool f)
        {
            tlThem.Enabled = f;
            tlSua.Enabled = f;
            tlXoa.Enabled = f;
        }
        private void HienThiThongTin(bool f)
        {
            txtMaNCC.Enabled = f;
            txtTenNCC.Enabled = f;
            txtDiaChi.Enabled = f;
            txtEmail.Enabled = f;
            txtGhiChu.Enabled = f;
            txtSDT.Enabled = f;
            ckTTHT.Enabled = f;
        }
        private void DonChu()
        {
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtEmail.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            txtGhiChu.ResetText();
            ckTTHT.Checked = false;
        }
        private void loadNCC()
        {
            try
            {
                if (balNhacungcap.LayListNhaCungCap().Tables[0].Rows.Count != 0)
                {
                    this.gridNCC.DataSource = balNhacungcap.LayListNhaCungCap().Tables[0];
                    load();
                    HienThiThongTin(false);
                    HienThiHanhDong(false);
                    HienThiChucNang(true);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            loadNCC();
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "TinhTrangHopTac" && e.IsGetData)
                e.Value = Convert.ToBoolean(gridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, gridView1.Columns["TinhTrangHopTac"]));
        }

        private void tlThoat_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Close();
        }

        private void gridNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (balNhacungcap.LayListNhaCungCap().Tables[0].Rows.Count != 0)
                {
                    load();
                    HienThiThongTin(false);
                    HienThiHanhDong(false);
                    HienThiChucNang(true);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tlThem_ItemClick(object sender, TileItemEventArgs e)
        {

            DonChu();
            HienThiThongTin(true);
            HienThiChucNang(false);
            HienThiHanhDong(true);
            insert = true;
        }

        private void tlSua_ItemClick(object sender, TileItemEventArgs e)
        {
            HienThiThongTin(true);
            HienThiChucNang(false);
            HienThiHanhDong(true);
            update = true;
        }

        private void tlXoa_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa nhà cung cấp này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    string error = "";
                    try
                    {
                        if (balNhacungcap.XoaNCC(ref error, this.txtMaNCC.Text))
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
                    loadNCC();
                }
                else
                {

                }
            }
            catch (SqlException err)
            {
                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tlReset_ItemClick(object sender, TileItemEventArgs e)
        {
            loadNCC();
        }

        private void tlHuy_ItemClick(object sender, TileItemEventArgs e)
        {
            loadNCC();
            insert = false;
            update = false;
        }

        private void tlLuu_ItemClick(object sender, TileItemEventArgs e)
        {
            if (insert)
            {
                if (string.IsNullOrEmpty(txtMaNCC.Text))
                {
                    MessageBox.Show("Mã nhà cung cấp chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (balNhacungcap.KiemTraMaNCC(this.txtMaNCC.Text).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("mã nhà cung cấp đã có", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string error = "";
                        try
                        {
                            if (balNhacungcap.ThemNhaCungCap(ref error, this.txtMaNCC.Text, this.txtTenNCC.Text, this.txtSDT.Text,
                                this.txtDiaChi.Text, this.txtEmail.Text, this.ckTTHT.Checked,this.txtGhiChu.Text))
                            {
                                MessageBox.Show("thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadNCC();
                                insert = false;
                            }

                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else if (update)
            {
                try
                {

                    if (string.IsNullOrEmpty(txtMaNCC.Text))
                    {
                        MessageBox.Show("Mã nhà cung cấp chưa được nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (balNhacungcap.KiemTraMaNCC(this.txtMaNCC.Text).Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("Không tìm thấy mã nhà cung cấp", "Yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string error = "";
                            try
                            {
                                if (balNhacungcap.CapNhatNhaCungCap(ref error, this.txtMaNCC.Text, this.txtTenNCC.Text, this.txtSDT.Text,
                                    this.txtDiaChi.Text, this.txtEmail.Text, this.ckTTHT.Checked,this.txtGhiChu.Text))
                                {
                                    MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadNCC();
                                    update = false;
                                }


                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.gridNCC.DataSource = balNhacungcap.DoNCC(txtFind.Text).Tables[0];
        }
    }
    }