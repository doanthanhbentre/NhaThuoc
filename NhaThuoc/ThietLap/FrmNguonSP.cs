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
    public partial class FrmNguonSP : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.NguonSP nguonSP = new LibDataDuoc.NguonSP();
        public FrmNguonSP()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtTen.Focus();
        }

        private void FrmLoaiSP_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = nguonSP.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            txtMa.Text = drv["nguonspid"].ToString();
            txtTen.Text = drv["tennguonsp"].ToString();
        }
        private Boolean kiemTra()
        {
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên!", "Thông báo");
                txtTen.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;

            String m_NguonSPID = txtMa.Text;
            nguonSP.saveData(ref m_NguonSPID, txtTen.Text);
            FrmLoaiSP_Load(null, null);
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nguonSP.deleteData(txtMa.Text);
            FrmLoaiSP_Load(null, null);
        }
    }
}