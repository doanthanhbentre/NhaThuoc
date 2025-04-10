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

namespace NhaThuoc.ThietLap
{
    public partial class FrmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.NhaCungCap nhaCungCap = new LibDataDuoc.NhaCungCap();
        public FrmNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newdata();
        }

        private void newdata()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtSoTaiKhoan.Text = "";
            txtTenNCC.Focus();
        }

        private void FrmLoaiSP_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = nhaCungCap.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
            lblTongSo.Text = bindingSource1.Count.ToString();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            txtMaNCC.Text = drv["mancc"].ToString();
            txtTenNCC.Text = drv["tenncc"].ToString();
            txtDiaChi.Text = drv["diachi"].ToString();
            txtDienThoai.Text = drv["dienthoai"].ToString();
            txtSoTaiKhoan.Text = drv["sotaikhoan"].ToString();
        }
        private Boolean kiemTra()
        {
            if (txtTenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên Nhà cung cấp!", "Thông báo");
                txtTenNCC.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;

            String m_MaNCC = txtMaNCC.Text;
            nhaCungCap.saveData(ref m_MaNCC, txtTenNCC.Text, txtDiaChi.Text, txtSoTaiKhoan.Text, txtDienThoai.Text);
            FrmLoaiSP_Load(null, null);
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nhaCungCap.deleteData(txtMaNCC.Text);
            FrmLoaiSP_Load(null, null);
        }
    }
}