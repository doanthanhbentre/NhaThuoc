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
using DevExpress.XtraReports.UI;

namespace NhaThuoc
{
    public partial class FrmPhiDuoc : DevExpress.XtraEditors.XtraForm
    {
        DataAccess.SanPhamSD spSD = new DataAccess.SanPhamSD();
        DataAccess.PhieuXuat phieuXuat = new DataAccess.PhieuXuat();
        DataAccess.ChiTietXuat chiTiet = new DataAccess.ChiTietXuat();
        DataAccess.SanPhamTon spTon = new DataAccess.SanPhamTon();
        String m_MaPX = String.Empty;
        public FrmPhiDuoc()
        {
            InitializeComponent();
        }
        public String MaPX
        {
            get
            {
                return txtMaPX.Text;
            }
            set
            {
                txtMaPX.Text = value;
            }
        }

        private Boolean kiemTra()
        {
            if (txtTenSP.EditValue == null || txtTenSP.EditValue == "")
            {
                MessageBox.Show("Chưa nhập sản phẩm!", "Hóa đơn");
                txtTenSP.Focus();
                return false;
            }
            if (txtSoLuong.Value == 0)
            {
                MessageBox.Show("Chưa nhập số lượng!", "Hóa đơn");
                txtSoLuong.Focus();
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;
            m_MaPX = txtMaPX.Text;
            phieuXuat.saveData(ref m_MaPX, "0000000000", "01", DateTime.Now, "", "", "", "");
            txtMaPX.Text = m_MaPX;
            chiTiet.saveData(txtMaPX.Text, txtTenSP.EditValue.ToString(), "NULL", Single.Parse(txtSoLuong.Value.ToString()), 0, "");
            //sanPhamTon.updateTonAo(txtNgay.Value.ToString("yyyyMM"), ucKho1.MaSo, ucGetSanPhamTon1.MaSPSD, ucGetSanPhamTon1.HanDung, Single.Parse(txtSoLuong.Value.ToString()));
            loadData();
            //ucGetSanPhamTon1.newData();
            //txtSoLuong.Value = 0;
            //ucGetSanPhamTon1.Focus();
            //ucGetSanPhamTon1.loadData(txtNgay.Value.ToString("yyyyMM"), ucKho1.MaSo);
            txtSoLuong.Value = 0;
            txtTenSP.EditValue = null;
            txtTenSP.Focus();
        }

        private void loadData()
        {
            bindingHoaDon.DataSource = chiTiet.getDataTable(txtMaPX.Text);
            showTongSoTien();
        }

        private void showTongSoTien()
        {
            Decimal m_TongSoTien = 0;
            foreach (DataRowView r in bindingHoaDon)
            {
                m_TongSoTien += Decimal.Parse(r["ThanhTien"].ToString());
            }
            lblTongTien.Text = m_TongSoTien.ToString("#,###");
        }
        private void FrmPhiDuoc_Load(object sender, EventArgs e)
        {
            loadSanPham();
        }

        private void loadSanPham()
        {
            bindingSanPham.DataSource = spSD.getDataTable();
        }

        private void txtMaPX_Validated(object sender, EventArgs e)
        {
            txtMaPX.Text = txtMaPX.Text.Trim();
            if (txtMaPX.Text.Length > 0 && txtMaPX.Text.Length < 7)
                txtMaPX.Text = DateTime.Today.ToString("yy") + txtMaPX.Text.PadLeft(8, '0');
            loadData();
            txtMaPX.Enabled = false;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            DataRowView r = (DataRowView)bindingHoaDon.Current;
            chiTiet.deleteData(r["XuatID"].ToString(), 0);
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaPX.Text = "";
            loadData();
            txtTenSP.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            txtMaPX.Text = "";
            txtMaPX.Enabled = true;
            loadData();
            txtMaPX.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            HoaDon report = new HoaDon();
            report.DataSource = bindingHoaDon;
            report.Parameters["pMaPX"].Value = txtMaPX.Text;
            report.ShowPreviewDialog();
        }

        private void FrmPhiDuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) btnFind_Click(null, null);
            if (e.KeyCode == Keys.F3) btnNew_Click(null, null);
            if (e.KeyCode == Keys.F5) btnPrint_Click(null, null);
            if (e.KeyCode == Keys.F8) btnDelete_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            phieuXuat.deleteData(txtMaPX.Text);
            btnNew_Click(null, null);
        }
    }
}