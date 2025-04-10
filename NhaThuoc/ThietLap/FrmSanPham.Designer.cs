namespace NhaThuoc.ThietLap
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceSanPham = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSourceNhom = new System.Windows.Forms.BindingSource(this.components);
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaSP = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lslLoaiSP = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bindingSourceLoai = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblTongSo = new DevExpress.XtraEditors.LabelControl();
            this.chkHieuLuc = new DevExpress.XtraEditors.CheckEdit();
            this.chkTrongNuoc = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtHoatChat = new DevExpress.XtraEditors.TextEdit();
            this.txtNuocSX = new DevExpress.XtraEditors.TextEdit();
            this.txtHangSX = new DevExpress.XtraEditors.TextEdit();
            this.cboDonVi = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bindingSourceDonVi = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboNhomSP = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lslLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkHieuLuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrongNuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoatChat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuocSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHangSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSourceSanPham;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1028, 361);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourceSanPham
            // 
            this.bindingSourceSanPham.DataSourceChanged += new System.EventHandler(this.bindingSourceSanPham_DataSourceChanged);
            this.bindingSourceSanPham.CurrentChanged += new System.EventHandler(this.bindingSourceSanPham_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMa,
            this.gridColumnTen,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn7});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnMa
            // 
            this.gridColumnMa.Caption = "Mã SP";
            this.gridColumnMa.FieldName = "MASP";
            this.gridColumnMa.Name = "gridColumnMa";
            this.gridColumnMa.Visible = true;
            this.gridColumnMa.VisibleIndex = 0;
            this.gridColumnMa.Width = 106;
            // 
            // gridColumnTen
            // 
            this.gridColumnTen.Caption = "Tên SP";
            this.gridColumnTen.FieldName = "TENSP";
            this.gridColumnTen.Name = "gridColumnTen";
            this.gridColumnTen.Visible = true;
            this.gridColumnTen.VisibleIndex = 1;
            this.gridColumnTen.Width = 273;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Hoạt chất";
            this.gridColumn1.FieldName = "HOATCHAT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 101;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Đơn vị";
            this.gridColumn2.FieldName = "TENDONVI";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 101;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hãng SX";
            this.gridColumn3.FieldName = "HANGSX";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 101;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nước SX";
            this.gridColumn4.FieldName = "NUOCSX";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 101;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Nhóm SP";
            this.gridColumn6.FieldName = "TENNHOMSP";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            this.gridColumn6.Width = 138;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Trong nước";
            this.gridColumn5.FieldName = "TRONGNUOC";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 101;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Hiệu lực";
            this.gridColumn7.FieldName = "HIEULUC";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            this.gridColumn7.Width = 87;
            // 
            // bindingSourceNhom
            // 
            this.bindingSourceNhom.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(342, 129);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 34);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Thêm";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(442, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Ghi";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(523, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(604, 129);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 34);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã số:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(120, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên sản phẩm:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.EnterMoveNextControl = true;
            this.txtMaSP.Location = new System.Drawing.Point(6, 31);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(105, 26);
            this.txtMaSP.TabIndex = 0;
            // 
            // txtTenSP
            // 
            this.txtTenSP.EnterMoveNextControl = true;
            this.txtTenSP.Location = new System.Drawing.Point(120, 31);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(405, 26);
            this.txtTenSP.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lslLoaiSP);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(262, 578);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Loại sản phẩm";
            // 
            // lslLoaiSP
            // 
            this.lslLoaiSP.Cursor = System.Windows.Forms.Cursors.Default;
            this.lslLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lslLoaiSP.Location = new System.Drawing.Point(3, 30);
            this.lslLoaiSP.Name = "lslLoaiSP";
            this.lslLoaiSP.Size = new System.Drawing.Size(256, 545);
            this.lslLoaiSP.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(262, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1034, 394);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Sản phẩm";
            // 
            // bindingSourceLoai
            // 
            this.bindingSourceLoai.CurrentChanged += new System.EventHandler(this.bindingSourceLoai_CurrentChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblTongSo);
            this.panelControl1.Controls.Add(this.chkHieuLuc);
            this.panelControl1.Controls.Add(this.chkTrongNuoc);
            this.panelControl1.Controls.Add(this.btnNew);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.txtHoatChat);
            this.panelControl1.Controls.Add(this.txtNuocSX);
            this.panelControl1.Controls.Add(this.txtHangSX);
            this.panelControl1.Controls.Add(this.txtTenSP);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.txtMaSP);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Controls.Add(this.cboDonVi);
            this.panelControl1.Controls.Add(this.cboNhomSP);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(262, 394);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1034, 184);
            this.panelControl1.TabIndex = 0;
            // 
            // lblTongSo
            // 
            this.lblTongSo.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongSo.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblTongSo.Appearance.Options.UseFont = true;
            this.lblTongSo.Appearance.Options.UseForeColor = true;
            this.lblTongSo.Location = new System.Drawing.Point(24, 137);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(10, 19);
            this.lblTongSo.TabIndex = 6;
            this.lblTongSo.Text = "0";
            // 
            // chkHieuLuc
            // 
            this.chkHieuLuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHieuLuc.EnterMoveNextControl = true;
            this.chkHieuLuc.Location = new System.Drawing.Point(937, 91);
            this.chkHieuLuc.Name = "chkHieuLuc";
            this.chkHieuLuc.Properties.Caption = "Hiệu lực";
            this.chkHieuLuc.Size = new System.Drawing.Size(85, 23);
            this.chkHieuLuc.TabIndex = 8;
            // 
            // chkTrongNuoc
            // 
            this.chkTrongNuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTrongNuoc.EnterMoveNextControl = true;
            this.chkTrongNuoc.Location = new System.Drawing.Point(764, 91);
            this.chkTrongNuoc.Name = "chkTrongNuoc";
            this.chkTrongNuoc.Properties.Caption = "Sản xuất trong nước";
            this.chkTrongNuoc.Size = new System.Drawing.Size(167, 23);
            this.chkTrongNuoc.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(879, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 19);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Đơn vị:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(533, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Hoạt chất:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(533, 63);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(123, 19);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Nhóm sản phẩm:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(336, 63);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(107, 19);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Nước sản xuất:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 63);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 19);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Hãng sản xuất:";
            // 
            // txtHoatChat
            // 
            this.txtHoatChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoatChat.EnterMoveNextControl = true;
            this.txtHoatChat.Location = new System.Drawing.Point(533, 31);
            this.txtHoatChat.Name = "txtHoatChat";
            this.txtHoatChat.Size = new System.Drawing.Size(340, 26);
            this.txtHoatChat.TabIndex = 2;
            // 
            // txtNuocSX
            // 
            this.txtNuocSX.EnterMoveNextControl = true;
            this.txtNuocSX.Location = new System.Drawing.Point(336, 88);
            this.txtNuocSX.Name = "txtNuocSX";
            this.txtNuocSX.Size = new System.Drawing.Size(189, 26);
            this.txtNuocSX.TabIndex = 5;
            this.txtNuocSX.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txtHangSX
            // 
            this.txtHangSX.EnterMoveNextControl = true;
            this.txtHangSX.Location = new System.Drawing.Point(6, 88);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(324, 26);
            this.txtHangSX.TabIndex = 4;
            this.txtHangSX.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // cboDonVi
            // 
            this.cboDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDonVi.EnterMoveNextControl = true;
            this.cboDonVi.Location = new System.Drawing.Point(879, 31);
            this.cboDonVi.Name = "cboDonVi";
            this.cboDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDonVi.Properties.DataSource = this.bindingSourceDonVi;
            this.cboDonVi.Properties.DisplayMember = "TENDONVI";
            this.cboDonVi.Properties.NullText = "";
            this.cboDonVi.Properties.PopupSizeable = false;
            this.cboDonVi.Properties.ValueMember = "DONVIID";
            this.cboDonVi.Properties.View = this.gridView2;
            this.cboDonVi.Size = new System.Drawing.Size(143, 26);
            this.cboDonVi.TabIndex = 3;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Mã đơn vị";
            this.gridColumn10.FieldName = "DONVIID";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 209;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Tên đơn vị";
            this.gridColumn11.FieldName = "TENDONVI";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 900;
            // 
            // cboNhomSP
            // 
            this.cboNhomSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboNhomSP.EnterMoveNextControl = true;
            this.cboNhomSP.Location = new System.Drawing.Point(531, 88);
            this.cboNhomSP.Name = "cboNhomSP";
            this.cboNhomSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhomSP.Properties.DataSource = this.bindingSourceNhom;
            this.cboNhomSP.Properties.DisplayMember = "TENNHOMSP";
            this.cboNhomSP.Properties.NullText = "";
            this.cboNhomSP.Properties.PopupSizeable = false;
            this.cboNhomSP.Properties.ValueMember = "NHOMSPID";
            this.cboNhomSP.Properties.View = this.searchLookUpEdit1View;
            this.cboNhomSP.Size = new System.Drawing.Size(226, 26);
            this.cboNhomSP.TabIndex = 6;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn9});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Mã nhóm";
            this.gridColumn8.FieldName = "NHOMSPID";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 209;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên nhóm";
            this.gridColumn9.FieldName = "TENNHOMSP";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 900;
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 578);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "FrmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.FrmLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lslLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkHieuLuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrongNuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoatChat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuocSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHangSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaSP;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTen;
        private System.Windows.Forms.BindingSource bindingSourceNhom;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl lslLoaiSP;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource bindingSourceLoai;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SearchLookUpEdit cboNhomSP;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHoatChat;
        private DevExpress.XtraEditors.SearchLookUpEdit cboDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.BindingSource bindingSourceDonVi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtHangSX;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtNuocSX;
        private DevExpress.XtraEditors.CheckEdit chkHieuLuc;
        private DevExpress.XtraEditors.CheckEdit chkTrongNuoc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.BindingSource bindingSourceSanPham;
        private DevExpress.XtraEditors.LabelControl lblTongSo;
    }
}