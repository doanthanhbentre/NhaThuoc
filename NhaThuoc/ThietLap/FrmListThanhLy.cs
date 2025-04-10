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
    public partial class FrmListThanhLy : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.LoaiThanhLy loaiThanhLy = new LibDataDuoc.LoaiThanhLy();
        public FrmListThanhLy()
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
            bindingSource1.DataSource = loaiThanhLy.getDataTable().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSource1.Current;
            txtMa.Text = drv["loaitlid"].ToString();
            txtTen.Text = drv["tenloaitl"].ToString();
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

            String m_LoaiTLID = txtMa.Text;
            loaiThanhLy.saveData(ref m_LoaiTLID, txtTen.Text);
            FrmLoaiSP_Load(null, null);
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            loaiThanhLy.deleteData(txtMa.Text);
            FrmLoaiSP_Load(null, null);
        }
    }
}