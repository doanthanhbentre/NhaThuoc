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
    public partial class FrmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.NhaCungCap nhaCungCap = new LibDataDuoc.NhaCungCap();
        LibDataDuoc.NguonSP nguonSP = new LibDataDuoc.NguonSP();
        LibDataDuoc.Kho kho = new LibDataDuoc.Kho();
        LibDataDuoc.SanPham sanPham = new LibDataDuoc.SanPham();
        LibDataDuoc.DonVi donVi = new LibDataDuoc.DonVi();
        LibDataDuoc.QuiCach quiCach = new LibDataDuoc.QuiCach();
        LibDataDuoc.GiaBan giaBan = new LibDataDuoc.GiaBan();

        LibDataDuoc.PhieuNhap phieuNhap = new LibDataDuoc.PhieuNhap();
        LibDataDuoc.ChiTietNhap chiTiet = new LibDataDuoc.ChiTietNhap();

        private String m_MaPN;

        public string MaPN
        {
            get
            {
                return m_MaPN;
            }

            set
            {
                m_MaPN = value;
            }
        }

        public FrmPhieuNhap()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            bindingNhaCC.DataSource = nhaCungCap.getDataTable().DefaultView;
            bindingNguon.DataSource = nguonSP.getDataTable().DefaultView;
            bindingKho.DataSource = kho.getDataTable().DefaultView;
            bindingSanPham.DataSource = sanPham.getDataTable().DefaultView;
            bindingDonVi.DataSource = donVi.getDataTable().DefaultView;
            bindingQuiCach.DataSource = quiCach.getDataTable().DefaultView;
            bindingQuiCach.DataSource = quiCach.getDataTable().DefaultView;

            cboKho.EditValue = "01";
            cboNguonSP.EditValue = "01";
            txtNgay.EditValue = DateTime.Today;
        }
        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            loadData();
            if (MaPN.Length > 0)
                loadPhieuNhap();
        }

        private void cboSanPham_EditValueChanged(object sender, EventArgs e)
        {
            if (cboSanPham.EditValue != null)
            {
                Int32 index = bindingSanPham.Find("MASP", cboSanPham.EditValue.ToString());
                if (index >= 0)
                {
                    DataRowView drv = (DataRowView)bindingSanPham[index];
                    if (drv != null)
                    {
                        cboDonVi.EditValue = drv["DonViID"];
                    }
                    else
                    {
                        cboDonVi.EditValue = null;
                    }
                }
            }
        }

        private void labelControl22_DoubleClick(object sender, EventArgs e)
        {
            ThietLap.FrmGiaBan frm = new ThietLap.FrmGiaBan();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newValue();
        }

        private void txtSLQC_EditValueChanged(object sender, EventArgs e)
        {
            txtSoLuongDV.Value = txtSoLuong.Value * txtSLQC.Value;
            txtThanhTien.Value = txtDonGiaQC.Value * txtSoLuong.Value;
            txtThanhTien.Value += txtThanhTien.Value * txtVAT.Value / 100;
        }

        private void txtThanhTien_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSoLuongDV.Value > 0)
            {
                txtGiaNhap.Value = txtThanhTien.Value / txtSoLuongDV.Value;
                txtTyLe.Value = giaBan.getTyLe(txtGiaNhap.Value);
                txtGiaXuat.Value = txtGiaNhap.Value + (txtGiaNhap.Value * txtTyLe.Value / 100);

            }
        }
        private void newValue()
        {
            cboSanPham.EditValue = "";
            txtSoLo.Text = "";
            txtSoDangKy.Text = "";
            txtChietKhau.Value = 0;
            txtSoLuong.Value = 0;
            txtSLQC.Value = 0;
            txtSoLuongDV.Value = 0;
            txtGiaXuat.Value = 0;
            txtGiaNhap.Value = 0;
            txtDonGiaQC.Value = 0;
            txtTyLe.Value = 0;
            cboDonVi.Text = "";
            cboQuiCach.Text = "";
            cboSanPham.Focus();
        }

        private void btnPhieuMoi_Click(object sender, EventArgs e)
        {
            newValue();
            txtMaPN.Text = "";
            cboNhaCungCap.Text = "";
            cboNguonSP.EditValue = "01";
            txtChietKhauTong.Value = 0;
            txtNgay.EditValue = DateTime.Today;
            cboKho.EditValue = "01";
            txtSoHD.Text = "";
            txtNgayHD.EditValue = null;

            loadChiTietNhap();
            cboNhaCungCap.Focus();
        }
        private void loadPhieuNhap()
        {
            DataRow dr = phieuNhap.getDataRow(MaPN);
            if (dr != null)
            {
                txtMaPN.Text = dr["MaPN"].ToString();
                cboNhaCungCap.EditValue = dr["MaNCC"];
                cboNguonSP.EditValue = dr["NguonSPID"];
                txtNgay.EditValue = dr["Ngay"];
                cboKho.EditValue = dr["MaKho"];
                txtSoHD.Text = dr["SoHD"].ToString();
                txtNgayHD.EditValue = dr["NgayHD"];
            }
            else
            {
                btnPhieuMoi_Click(null, null);
            }

            loadChiTietNhap();
        }
        private void loadChiTietNhap()
        {
            bindingChiTiet.DataSource = chiTiet.getDataTable(txtMaPN.Text);
        }

        private Boolean kiemTraThongTinPhieu()
        {
            if (cboNhaCungCap.EditValue == null)
            {
                MessageBox.Show("Chưa chọn Nhà cung cấp!");
                cboNhaCungCap.Focus();
                return false;
            }

            if (cboNguonSP.EditValue == null)
            {
                MessageBox.Show("Chưa chọn Nguồn sản phẩmp!");
                cboNguonSP.Focus();
                return false;
            }

            if (cboKho.EditValue == null)
            {
                MessageBox.Show("Chưa chọn Kho nhập!");
                cboKho.Focus();
                return false;
            }

            if (txtNgay.EditValue == null)
            {
                MessageBox.Show("Ngày nhập không được trống!");
                txtNgay.Focus();
                return false;
            }

            if (txtNgay.DateTime.Date.CompareTo(DateTime.Today) > 0)
            {
                MessageBox.Show("Ngày nhập không được lớn hơn ngày hiện hành!");
                txtNgay.Focus();
                return false;
            }

            if (txtSoHD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số hóa đơn không được trống!");
                txtSoHD.Focus();
                return false;
            }

            if (txtNgayHD.EditValue == null)
            {
                MessageBox.Show("Ngày hóa đơn không được trống!");
                txtNgayHD.Focus();
                return false;
            }

            if (txtNgayHD.DateTime.Date.CompareTo(DateTime.Today) > 0)
            {
                MessageBox.Show("Ngày hóa đơn không được lớn hơn ngày hiện hành!");
                txtNgayHD.Focus();
                return false;
            }

            if (txtNgayHD.DateTime.Date.CompareTo(txtNgay.DateTime.Date) > 0)
            {
                MessageBox.Show("Ngày hóa đơn không được lớn hơn ngày nhập!");
                txtNgayHD.Focus();
                return false;
            }

            return true;
        }

        private Boolean kiemTraThongTinChiTiet()
        {
            if (cboSanPham.EditValue == null)
            {
                MessageBox.Show("Chưa nhập sản phẩmp!");
                cboSanPham.Focus();
                return false;
            }

            if (cboQuiCach.EditValue == null)
            {
                MessageBox.Show("Chưa nhập qui cách sản phẩmp!");
                cboQuiCach.Focus();
                return false;
            }

            if (txtSoLuong.Value == 0)
            {
                MessageBox.Show("Chưa nhập số lượng sản phẩmp!");
                txtSoLuong.Focus();
                return false;
            }

            if (txtSLQC.Value == 0)
            {
                MessageBox.Show("Chưa nhập số lượng đơn vị trên qui cách!");
                txtSLQC.Focus();
                return false;
            }
            if (txtDonGiaQC.Value == 0)
            {
                MessageBox.Show("Chưa nhập đơn giá qui cách!");
                txtDonGiaQC.Focus();
                return false;
            }

            return true;
        }

        private void cboQuiCach_EditValueChanged(object sender, EventArgs e)
        {
            if (cboQuiCach.Text == cboDonVi.Text)
            {
                txtSLQC.Value = 1;
            }

        }

        private void labelControl9_DoubleClick(object sender, EventArgs e)
        {
            ThietLap.FrmSanPham frm = new ThietLap.FrmSanPham();
            frm.ShowDialog();
            bindingSanPham.DataSource = sanPham.getDataTable().DefaultView;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!kiemTraThongTinPhieu()) return;
            String m_MaPN = txtMaPN.Text;
            phieuNhap.saveData(ref m_MaPN, cboNhaCungCap.EditValue.ToString(), cboNguonSP.EditValue.ToString(), cboKho.EditValue.ToString(), txtNgay.DateTime.Date, txtSoHD.Text, txtNgayHD.DateTime.Date, txtChietKhauTong.Value);
            txtMaPN.Text = m_MaPN;
            if (!kiemTraThongTinChiTiet()) return;
            chiTiet.saveData(m_MaPN, cboSanPham.EditValue.ToString(), cboQuiCach.EditValue.ToString(), txtSoDangKy.Text, txtSoLo.Text, txtHanDung.DateTime.ToString("yyyyMM"), (Double) txtSoLuong.Value, (Int16) txtSLQC.Value, (Double)txtDonGiaQC.Value, (Double)txtVAT.Value, (Double)txtSoLuongDV.Value, (Double)txtGiaNhap.Value, (Double)txtGiaXuat.Value, (Double)txtChietKhau.Value, (Double)txtThanhTien.Value);
            newValue();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)bindingChiTiet.Current;
            if (drv != null)
            {
                chiTiet.deleteData(txtMaPN.Text, drv["MaSP"].ToString());
                loadChiTietNhap();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void bindingChiTiet_DataSourceChanged(object sender, EventArgs e)
        {
            Double m_TongTien = 0;
            Double m_ChietKhau = 0;
            for (Int16 i=0; i < bindingChiTiet.Count; i++)
            {
                DataRowView drv = (DataRowView)bindingChiTiet[i];
                m_TongTien += (Double)drv["ThanhTien"];
                m_ChietKhau += (Double)drv["ChietKhau"];
            }
            lblTongTien.Text = m_TongTien.ToString("#,##0");
            txtChietKhauTong.Value = (Decimal) m_ChietKhau;

        }
    }
}