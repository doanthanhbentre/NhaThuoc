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
    public partial class FrmThoiGianLoaiSP : DevExpress.XtraEditors.XtraForm
    {
        System.Globalization.CultureInfo vn = new System.Globalization.CultureInfo("vi-VN");
        public String m_ThoiGian;
        public DateTime m_TuNgay, m_DenNgay;
        public String m_LoaiSPID;

        LibDataDuoc.LoaiSP loaiSP = new LibDataDuoc.LoaiSP();
        public FrmThoiGianLoaiSP()
        {
            InitializeComponent();
        }

        private void chonThang()
        {
            Int32 DaysInMonth = DateTime.DaysInMonth(Convert.ToInt32(txtDenNam.Value), Convert.ToInt32(txtDenThang.Value));
            m_TuNgay = Convert.ToDateTime("01/" + txtTuThang.Value.ToString() + "/" + txtTuNam.Value.ToString(), vn);
            m_DenNgay = Convert.ToDateTime(DaysInMonth.ToString() + "/" + txtDenThang.Value.ToString() + "/" + txtDenNam.Value.ToString(), vn);
            if (txtTuNam.Value.Equals(txtDenNam.Value))
            {
                if (txtTuThang.Value.Equals(txtDenThang.Value))
                    m_ThoiGian = "Tháng " + txtTuThang.Value.ToString() + " năm " + txtTuNam.Value.ToString();
                else
                    m_ThoiGian = "Từ tháng " + txtTuThang.Value.ToString() + " đến tháng " + txtDenThang.Value.ToString() + " năm " + txtTuNam.Value.ToString();
            }
            else
                m_ThoiGian = "Từ tháng " + txtTuThang.Value.ToString() + " năm " + txtTuNam.Value.ToString() + " đến tháng " + txtDenThang.Value.ToString() + " năm " + txtDenNam.Value.ToString();
        }
        private void chonNgay()
        {
            m_TuNgay = txtTuNgay.DateTime.Date;
            m_DenNgay = txtDenNgay.DateTime.Date;
            if (m_TuNgay.Equals(m_DenNgay))
                m_ThoiGian = "Ngày " + m_TuNgay.ToString("dd/MM/yyyy");
            else
                m_ThoiGian = "Từ ngày " + m_TuNgay.ToString("dd/MM/yyyy") + " đến ngày " + m_DenNgay.ToString("dd/MM/yyyy");
        }
        private void FrmThoiGianLoaiSP_Load(object sender, EventArgs e)
        {
            bindingLoaiSP.DataSource = loaiSP.getDataTable().DefaultView;
            cboLoaiSP.EditValue = "01";
            txtTuNgay.DateTime = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            txtDenNgay.DateTime = DateTime.Today;
            txtTuThang.Value = 1;
            txtTuNam.Value = DateTime.Today.Year;
            txtDenThang.Value = 1;
            txtDenNam.Value = DateTime.Today.Year;
            radioNgay_CheckedChanged(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (radioNgay.Checked)
                chonNgay();
            else
                chonThang();

            this.DialogResult = DialogResult.OK;
            m_LoaiSPID = cboLoaiSP.EditValue.ToString();
            Close();
        }

        private void radioNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNgay.Checked)
            {
                txtTuNgay.Enabled = true;
                txtDenNgay.Enabled = true;
                txtTuThang.Enabled = false;
                txtTuNam.Enabled = false;
                txtDenThang.Enabled = false;
                txtDenNam.Enabled = false;
            }
            else
            {
                txtTuNgay.Enabled = false;
                txtDenNgay.Enabled = false;
                txtTuThang.Enabled = true;
                txtTuNam.Enabled = true;
                txtDenThang.Enabled = true;
                txtDenNam.Enabled = true;
            }
        }
    }
}