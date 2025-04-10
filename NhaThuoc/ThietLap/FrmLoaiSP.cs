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
    public partial class FrmLoaiSP : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.LoaiSP loaiSP = new LibDataDuoc.LoaiSP();
        public FrmLoaiSP()
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
            bindingSource1.DataSource = loaiSP.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            txtMa.Text = drv["loaispid"].ToString();
            txtTen.Text = drv["tenloaisp"].ToString();
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

            String m_LoaiSPID = txtMa.Text;
            loaiSP.saveData(ref m_LoaiSPID, txtTen.Text);
            FrmLoaiSP_Load(null, null);
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loaiSP.deleteData(txtMa.Text);
            FrmLoaiSP_Load(null, null);
        }
    }
}