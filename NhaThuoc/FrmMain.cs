using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace NhaThuoc
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private string getThu()
        {
            String m_Thu = "";
            switch (DateTime.Today.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    m_Thu = "thứ Sáu";
                    break;
                case DayOfWeek.Monday:
                    m_Thu = "thứ Hai";
                    break;
                case DayOfWeek.Saturday:
                    m_Thu = "thứ Bảy";
                    break;
                case DayOfWeek.Sunday:
                    m_Thu = "Chủ nhật";
                    break;
                case DayOfWeek.Thursday:
                    m_Thu = "thứ Năm";
                    break;
                case DayOfWeek.Tuesday:
                    m_Thu = "thứ Ba";
                    break;
                case DayOfWeek.Wednesday:
                    m_Thu = "thứ Tư";
                    break;
            }
            return m_Thu;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ribbonControlMain.SelectedPage = ribbonNhap;
            stsHomNay.Caption = String.Format("Hôm nay, {0} ngày {1} tháng {2} năm {3}", getThu(), DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
        }

        private void btnLoaiSP_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmLoaiSP frm = new ThietLap.FrmLoaiSP();
            frm.ShowDialog();
        }

        private void btnDonVi_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmDonVi frm = new ThietLap.FrmDonVi();
            frm.ShowDialog();
        }

        private void btnQuiCach_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmQuiCach frm = new ThietLap.FrmQuiCach();
            frm.ShowDialog();
        }

        private void btnNhomSP_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmNhomSP frm = new ThietLap.FrmNhomSP();
            frm.ShowDialog();
        }

        private void btnSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmSanPham frm = new ThietLap.FrmSanPham();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnNguonGoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmNguonSP frm = new ThietLap.FrmNguonSP();
            frm.ShowDialog();
        }

        private void btnListKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmKho frm = new ThietLap.FrmKho();
            frm.ShowDialog();
        }

        private void btnThanhLy_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmListThanhLy frm = new ThietLap.FrmListThanhLy();
            frm.ShowDialog();
        }

        private void btnNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmNhaCungCap frm = new ThietLap.FrmNhaCungCap();
            frm.ShowDialog();
        }

        private void btnTyLeGiaBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThietLap.FrmGiaBan frm = new ThietLap.FrmGiaBan();
            frm.ShowDialog();
        }

        private void btnNhapKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLNhap.FrmPhieuNhap frm = new QLNhap.FrmPhieuNhap();
            frm.ShowDialog();
        }

        private void btnListNhapChuaDuyet_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLNhap.FrmListChuaDuyet frm = new QLNhap.FrmListChuaDuyet();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnListNhapDaDuyet_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLNhap.FrmListDaDuyet frm = new QLNhap.FrmListDaDuyet();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnBaoCaoNhapNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLNhap.FrmThoiGianLoaiSP frm = new QLNhap.FrmThoiGianLoaiSP();
            if (frm.ShowDialog() == DialogResult.OK)
                MessageBox.Show(frm.m_ThoiGian);
        }

        private void btnBaoCaoNhapHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLNhap.FrmThoiGianLoaiSP frm = new QLNhap.FrmThoiGianLoaiSP();
            if (frm.ShowDialog() == DialogResult.OK)
                MessageBox.Show(frm.m_ThoiGian);
        }
    }
}