namespace NhaThuoc.QLNhap
{
    partial class FrmThoiGianLoaiSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThoiGianLoaiSP));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboLoaiSP = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTuNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtDenNgay = new DevExpress.XtraEditors.DateEdit();
            this.radioNgay = new System.Windows.Forms.RadioButton();
            this.radioThang = new System.Windows.Forms.RadioButton();
            this.txtTuThang = new DevExpress.XtraEditors.SpinEdit();
            this.txtTuNam = new DevExpress.XtraEditors.SpinEdit();
            this.txtDenThang = new DevExpress.XtraEditors.SpinEdit();
            this.txtDenNam = new DevExpress.XtraEditors.SpinEdit();
            this.btnContinue = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.bindingLoaiSP = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Loại sản phẩm:";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.EditValue = "";
            this.cboLoaiSP.Location = new System.Drawing.Point(129, 25);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiSP.Properties.DataSource = this.bindingLoaiSP;
            this.cboLoaiSP.Properties.DisplayMember = "TENLOAISP";
            this.cboLoaiSP.Properties.ValueMember = "LOAISPID";
            this.cboLoaiSP.Properties.View = this.searchLookUpEdit1View;
            this.cboLoaiSP.Size = new System.Drawing.Size(300, 26);
            this.cboLoaiSP.TabIndex = 1;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.EditValue = null;
            this.txtTuNgay.Location = new System.Drawing.Point(129, 57);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtTuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtTuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtTuNgay.Size = new System.Drawing.Size(147, 26);
            this.txtTuNgay.TabIndex = 2;
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.EditValue = null;
            this.txtDenNgay.Location = new System.Drawing.Point(282, 57);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtDenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtDenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtDenNgay.Size = new System.Drawing.Size(147, 26);
            this.txtDenNgay.TabIndex = 2;
            // 
            // radioNgay
            // 
            this.radioNgay.AutoSize = true;
            this.radioNgay.Checked = true;
            this.radioNgay.Location = new System.Drawing.Point(12, 58);
            this.radioNgay.Name = "radioNgay";
            this.radioNgay.Size = new System.Drawing.Size(99, 23);
            this.radioNgay.TabIndex = 3;
            this.radioNgay.TabStop = true;
            this.radioNgay.Text = "Từ ngày:";
            this.radioNgay.UseVisualStyleBackColor = true;
            this.radioNgay.CheckedChanged += new System.EventHandler(this.radioNgay_CheckedChanged);
            // 
            // radioThang
            // 
            this.radioThang.AutoSize = true;
            this.radioThang.Location = new System.Drawing.Point(12, 90);
            this.radioThang.Name = "radioThang";
            this.radioThang.Size = new System.Drawing.Size(105, 23);
            this.radioThang.TabIndex = 3;
            this.radioThang.Text = "Từ tháng:";
            this.radioThang.UseVisualStyleBackColor = true;
            this.radioThang.CheckedChanged += new System.EventHandler(this.radioNgay_CheckedChanged);
            // 
            // txtTuThang
            // 
            this.txtTuThang.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTuThang.Location = new System.Drawing.Point(129, 89);
            this.txtTuThang.Name = "txtTuThang";
            this.txtTuThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTuThang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTuThang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTuThang.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtTuThang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTuThang.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtTuThang.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTuThang.Size = new System.Drawing.Size(65, 26);
            this.txtTuThang.TabIndex = 2;
            // 
            // txtTuNam
            // 
            this.txtTuNam.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTuNam.Location = new System.Drawing.Point(200, 89);
            this.txtTuNam.Name = "txtTuNam";
            this.txtTuNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTuNam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTuNam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTuNam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtTuNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTuNam.Size = new System.Drawing.Size(76, 26);
            this.txtTuNam.TabIndex = 2;
            // 
            // txtDenThang
            // 
            this.txtDenThang.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDenThang.Location = new System.Drawing.Point(282, 89);
            this.txtDenThang.Name = "txtDenThang";
            this.txtDenThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDenThang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDenThang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDenThang.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtDenThang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDenThang.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtDenThang.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDenThang.Size = new System.Drawing.Size(65, 26);
            this.txtDenThang.TabIndex = 2;
            // 
            // txtDenNam
            // 
            this.txtDenNam.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDenNam.Location = new System.Drawing.Point(353, 89);
            this.txtDenNam.Name = "txtDenNam";
            this.txtDenNam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDenNam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDenNam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDenNam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtDenNam.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDenNam.Size = new System.Drawing.Size(76, 26);
            this.txtDenNam.TabIndex = 2;
            // 
            // btnContinue
            // 
            this.btnContinue.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Appearance.Options.UseFont = true;
            this.btnContinue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnContinue.ImageOptions.Image")));
            this.btnContinue.Location = new System.Drawing.Point(129, 134);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(106, 30);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(241, 134);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmThoiGianLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 187);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.radioThang);
            this.Controls.Add(this.radioNgay);
            this.Controls.Add(this.txtDenNgay);
            this.Controls.Add(this.txtTuNgay);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDenNam);
            this.Controls.Add(this.txtTuNam);
            this.Controls.Add(this.txtDenThang);
            this.Controls.Add(this.txtTuThang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThoiGianLoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời gian và Loại sản phẩm";
            this.Load += new System.EventHandler(this.FrmThoiGianLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDenNam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingLoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cboLoaiSP;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit txtTuNgay;
        private DevExpress.XtraEditors.DateEdit txtDenNgay;
        private System.Windows.Forms.RadioButton radioNgay;
        private System.Windows.Forms.RadioButton radioThang;
        private DevExpress.XtraEditors.SpinEdit txtTuThang;
        private DevExpress.XtraEditors.SpinEdit txtTuNam;
        private DevExpress.XtraEditors.SpinEdit txtDenThang;
        private DevExpress.XtraEditors.SpinEdit txtDenNam;
        private DevExpress.XtraEditors.SimpleButton btnContinue;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.BindingSource bindingLoaiSP;
    }
}