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

namespace NhaThuoc.QLNhap
{
    public partial class FrmListDaDuyet : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.ChiTietNhap chiTiet = new LibDataDuoc.ChiTietNhap();
        LibDataDuoc.PhieuNhap phieuNhap = new LibDataDuoc.PhieuNhap();
        LibDataDuoc.BaoCao baoCao = new LibDataDuoc.BaoCao();
        public FrmListDaDuyet()
        {
            InitializeComponent();
        }

        private void loadPhieuNhap()
        {
            bindingPhieuNhap.DataSource = phieuNhap.getDataTable(txtTuNgay.DateTime.Date, txtDenNgay.DateTime.Date, true);
        }
        private void FrmListNhap_Load(object sender, EventArgs e)
        {
            txtTuNgay.DateTime = DateTime.Today;
            txtDenNgay.DateTime = DateTime.Today;
            btnRefresh_Click(null, null);
        }

        private void loadChiTiet()
        {
            DataRowView r = (DataRowView)bindingPhieuNhap.Current;
            if (r != null)
                bindingChiTiet.DataSource = chiTiet.getDataTable(r["MaPN"].ToString());
            else
                bindingChiTiet.DataSource = chiTiet.getDataTable("");            
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPhieuNhap();
            loadChiTiet();
        }

        private void bindingPhieuNhap_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTongSo.Text = bindingPhieuNhap.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bindingPhieuNhap_CurrentChanged(object sender, EventArgs e)
        {
            loadChiTiet();
        }
    }
}