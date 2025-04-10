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
    public partial class FrmGiaBan : DevExpress.XtraEditors.XtraForm
    {
        LibDataDuoc.GiaBan giaBan = new LibDataDuoc.GiaBan();
        public FrmGiaBan()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
        }

        private void FrmLoaiSP_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = giaBan.getGiaBan().DefaultView;
            gridControl1.DataSource = bindingSource1;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
    }
}