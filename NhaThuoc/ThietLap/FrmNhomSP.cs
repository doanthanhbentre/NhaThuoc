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
    public partial class FrmNhomSP : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.LoaiSP loaiSP = new LibDataDuoc.LoaiSP();
        LibDataDuoc.NhomSP nhomSP = new LibDataDuoc.NhomSP();
        public FrmNhomSP()
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

        private void loadNhomSP()
        {
            try
            {
                bindingSourceNhom.DataSource = nhomSP.getDataTable(lslLoaiSP.SelectedValue.ToString()).DefaultView;
                gridControl1.DataSource = bindingSourceNhom;
            }
            catch (Exception)
            {
            }
        }

        private void FrmLoaiSP_Load(object sender, EventArgs e)
        {
            bindingSourceLoai.DataSource = loaiSP.getDataTable().DefaultView;
            lslLoaiSP.DataSource = bindingSourceLoai;
            lslLoaiSP.DisplayMember = "TENLOAISP";
            lslLoaiSP.ValueMember = "LOAISPID";
            loadNhomSP();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSourceNhom.Current;
            txtMa.Text = drv["NHOMSPID"].ToString();
            txtTen.Text = drv["TENNHOMSP"].ToString();
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

            String m_NhomSPID = txtMa.Text;
            nhomSP.saveData(ref m_NhomSPID, lslLoaiSP.SelectedValue.ToString(), txtTen.Text);
            loadNhomSP();
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nhomSP.deleteData(txtMa.Text);
            loadNhomSP();
        }

        private void bindingSourceLoai_CurrentChanged(object sender, EventArgs e)
        {
            loadNhomSP();
        }
    }
}