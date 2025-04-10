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
    public partial class FrmSanPham : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.LoaiSP loaiSP = new LibDataDuoc.LoaiSP();
        LibDataDuoc.NhomSP nhomSP = new LibDataDuoc.NhomSP();
        LibDataDuoc.SanPham sanPham = new LibDataDuoc.SanPham();
        LibDataDuoc.DonVi donVi = new LibDataDuoc.DonVi();
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtHoatChat.Text = "";
            cboDonVi.EditValue = "01";
            txtHangSX.Text = "";
            txtNuocSX.Text = "Việt Nam";
            chkTrongNuoc.Checked = true;
            chkHieuLuc.Checked = true;
            txtTenSP.Focus();
        }

        private void loadNhomSP()
        {
            try
            {
                bindingSourceNhom.DataSource = nhomSP.getDataTable(lslLoaiSP.SelectedValue.ToString()).DefaultView;
            }
            catch (Exception)
            {
            }
        }

        private void loadLoaiSP()
        {
            bindingSourceLoai.DataSource = loaiSP.getDataTable().DefaultView;
            lslLoaiSP.DataSource = bindingSourceLoai;
            lslLoaiSP.DisplayMember = "TENLOAISP";
            lslLoaiSP.ValueMember = "LOAISPID";
        }
        private void loadSanPham()
        {
            try
            {
                bindingSourceSanPham.DataSource = sanPham.getListSanPham(lslLoaiSP.SelectedValue.ToString()).DefaultView;
            }
            catch (Exception)
            {
            }
        }

        private void loadDonVi()
        {
            bindingSourceDonVi.DataSource = donVi.getDataTable().DefaultView;
            //lslLoaiSP.DataSource = bindingSourceLoai;
            //lslLoaiSP.DisplayMember = "TENLOAISP";
            //lslLoaiSP.ValueMember = "LOAISPID";
        }
        private void FrmLoaiSP_Load(object sender, EventArgs e)
        {
            loadLoaiSP();
            loadNhomSP();
            loadDonVi();
            loadSanPham();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private Boolean kiemTra()
        {
            if (txtTenSP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm!", "Thông báo");
                txtTenSP.Focus();
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTra()) return;

            String m_MaSP = txtMaSP.Text;
            sanPham.saveData(ref m_MaSP, cboDonVi.EditValue.ToString(), cboNhomSP.EditValue.ToString(), txtTenSP.Text, txtHoatChat.Text, txtHangSX.Text, txtNuocSX.Text, chkTrongNuoc.Checked ? 1 : 0, chkHieuLuc.Checked ? 1 : 0);
            loadSanPham();
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            nhomSP.deleteData(txtMaSP.Text);
            loadNhomSP();
        }

        private void bindingSourceLoai_CurrentChanged(object sender, EventArgs e)
        {
            loadNhomSP();
            loadSanPham();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingSourceSanPham_DataSourceChanged(object sender, EventArgs e)
        {
            lblTongSo.Text = bindingSourceSanPham.Count.ToString();
        }

        private void bindingSourceSanPham_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingSourceSanPham.Current;
            txtMaSP.Text = drv["MaSP"].ToString();
            txtTenSP.Text = drv["TenSP"].ToString();
            txtHoatChat.Text = drv["HoatChat"].ToString();
            cboDonVi.EditValue = drv["DonViID"].ToString();
            txtHangSX.Text = drv["HangSX"].ToString();
            txtNuocSX.Text = drv["NuocSX"].ToString();
            cboNhomSP.EditValue = drv["NhomSPID"].ToString();
            if (drv["TrongNuoc"].ToString().Equals("1"))
                chkTrongNuoc.Checked = true;
            else
                chkTrongNuoc.Checked = false;
            if (drv["HieuLuc"].ToString().Equals("1"))
                chkHieuLuc.Checked = true;
            else
                chkHieuLuc.Checked = false;
        }
    }
}