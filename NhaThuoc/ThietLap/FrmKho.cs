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
    public partial class FrmKho : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.Kho kho = new LibDataDuoc.Kho();
        public FrmKho()
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
            bindingSource1.DataSource = kho.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            txtMa.Text = drv["makho"].ToString();
            txtTen.Text = drv["tenkho"].ToString();
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

            String m_makho = txtMa.Text;
            kho.saveData(ref m_makho, txtTen.Text, 1);
            FrmLoaiSP_Load(null, null);
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            kho.deleteData(txtMa.Text);
            FrmLoaiSP_Load(null, null);
        }
    }
}