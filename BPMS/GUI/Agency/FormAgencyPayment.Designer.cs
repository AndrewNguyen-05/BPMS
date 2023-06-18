namespace BPMS.GUI.Agency
{
    partial class FormAgencyPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgencyPayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPayment = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.dtgvExport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmIdExport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPriceEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBilledEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPaid = new System.Windows.Forms.TabPage();
            this.lblBillInfo = new System.Windows.Forms.Label();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmIdBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTypeReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.tabPayment.SuspendLayout();
            this.tabExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExport)).BeginInit();
            this.tabPaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.tabExport);
            this.tabPayment.Controls.Add(this.tabPaid);
            this.tabPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPayment.ItemSize = new System.Drawing.Size(180, 40);
            this.tabPayment.Location = new System.Drawing.Point(0, 0);
            this.tabPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.SelectedIndex = 0;
            this.tabPayment.Size = new System.Drawing.Size(1193, 660);
            this.tabPayment.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabPayment.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabPayment.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabPayment.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabPayment.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabPayment.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabPayment.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabPayment.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabPayment.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabPayment.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabPayment.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabPayment.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabPayment.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabPayment.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabPayment.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabPayment.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabPayment.TabIndex = 1;
            this.tabPayment.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabPayment.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.dtgvExport);
            this.tabExport.Location = new System.Drawing.Point(4, 44);
            this.tabExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabExport.Size = new System.Drawing.Size(1185, 612);
            this.tabExport.TabIndex = 1;
            this.tabExport.Text = "Import";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // dtgvExport
            // 
            this.dtgvExport.AllowUserToAddRows = false;
            this.dtgvExport.AllowUserToDeleteRows = false;
            this.dtgvExport.AllowUserToResizeColumns = false;
            this.dtgvExport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvExport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvExport.ColumnHeadersHeight = 35;
            this.dtgvExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdExport,
            this.clmAgency,
            this.clmExportDate,
            this.clmTotalPriceEx,
            this.clmBilledEx});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvExport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvExport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvExport.Location = new System.Drawing.Point(5, 5);
            this.dtgvExport.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtgvExport.MultiSelect = false;
            this.dtgvExport.Name = "dtgvExport";
            this.dtgvExport.ReadOnly = true;
            this.dtgvExport.RowHeadersVisible = false;
            this.dtgvExport.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dtgvExport.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvExport.RowTemplate.Height = 32;
            this.dtgvExport.Size = new System.Drawing.Size(1160, 553);
            this.dtgvExport.TabIndex = 3;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvExport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvExport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvExport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvExport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvExport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvExport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvExport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvExport.ThemeStyle.HeaderStyle.Height = 35;
            this.dtgvExport.ThemeStyle.ReadOnly = true;
            this.dtgvExport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvExport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvExport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvExport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvExport.ThemeStyle.RowsStyle.Height = 32;
            this.dtgvExport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvExport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clmIdExport
            // 
            this.clmIdExport.HeaderText = "Id Import";
            this.clmIdExport.MinimumWidth = 6;
            this.clmIdExport.Name = "clmIdExport";
            this.clmIdExport.ReadOnly = true;
            // 
            // clmAgency
            // 
            this.clmAgency.HeaderText = "Agency";
            this.clmAgency.MinimumWidth = 6;
            this.clmAgency.Name = "clmAgency";
            this.clmAgency.ReadOnly = true;
            // 
            // clmExportDate
            // 
            this.clmExportDate.HeaderText = "Export Date";
            this.clmExportDate.MinimumWidth = 6;
            this.clmExportDate.Name = "clmExportDate";
            this.clmExportDate.ReadOnly = true;
            // 
            // clmTotalPriceEx
            // 
            this.clmTotalPriceEx.HeaderText = "Total Price";
            this.clmTotalPriceEx.MinimumWidth = 6;
            this.clmTotalPriceEx.Name = "clmTotalPriceEx";
            this.clmTotalPriceEx.ReadOnly = true;
            // 
            // clmBilledEx
            // 
            this.clmBilledEx.HeaderText = "Bill";
            this.clmBilledEx.MinimumWidth = 6;
            this.clmBilledEx.Name = "clmBilledEx";
            this.clmBilledEx.ReadOnly = true;
            // 
            // tabPaid
            // 
            this.tabPaid.Controls.Add(this.lblBillInfo);
            this.tabPaid.Controls.Add(this.btnPay);
            this.tabPaid.Controls.Add(this.dtgvBill);
            this.tabPaid.Controls.Add(this.btnCancel);
            this.tabPaid.Location = new System.Drawing.Point(4, 44);
            this.tabPaid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPaid.Name = "tabPaid";
            this.tabPaid.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPaid.Size = new System.Drawing.Size(1185, 612);
            this.tabPaid.TabIndex = 2;
            this.tabPaid.Text = "Bill";
            this.tabPaid.UseVisualStyleBackColor = true;
            // 
            // lblBillInfo
            // 
            this.lblBillInfo.AutoSize = true;
            this.lblBillInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillInfo.Location = new System.Drawing.Point(8, 26);
            this.lblBillInfo.Name = "lblBillInfo";
            this.lblBillInfo.Size = new System.Drawing.Size(0, 22);
            this.lblBillInfo.TabIndex = 14;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.Animated = true;
            this.btnPay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnPay.BorderRadius = 4;
            this.btnPay.BorderThickness = 1;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.White;
            this.btnPay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.Location = new System.Drawing.Point(993, 5);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(184, 44);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToDeleteRows = false;
            this.dtgvBill.AllowUserToResizeColumns = false;
            this.dtgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvBill.ColumnHeadersHeight = 35;
            this.dtgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdBill,
            this.clmTypeReport,
            this.clmSender,
            this.clmReceiver,
            this.clmDateCreate,
            this.clmCreatePerson,
            this.clmPaid,
            this.clmReceived});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvBill.Location = new System.Drawing.Point(7, 56);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtgvBill.MultiSelect = false;
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.RowHeadersWidth = 62;
            this.dtgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dtgvBill.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvBill.RowTemplate.Height = 28;
            this.dtgvBill.Size = new System.Drawing.Size(1172, 505);
            this.dtgvBill.TabIndex = 4;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvBill.ThemeStyle.HeaderStyle.Height = 35;
            this.dtgvBill.ThemeStyle.ReadOnly = true;
            this.dtgvBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvBill.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvBill.SelectionChanged += new System.EventHandler(this.dtgvBill_SelectionChanged);
            // 
            // clmIdBill
            // 
            this.clmIdBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmIdBill.FillWeight = 203.0457F;
            this.clmIdBill.HeaderText = "Id";
            this.clmIdBill.MinimumWidth = 6;
            this.clmIdBill.Name = "clmIdBill";
            this.clmIdBill.ReadOnly = true;
            this.clmIdBill.Width = 50;
            // 
            // clmTypeReport
            // 
            this.clmTypeReport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmTypeReport.FillWeight = 85.2792F;
            this.clmTypeReport.HeaderText = "Type";
            this.clmTypeReport.MinimumWidth = 8;
            this.clmTypeReport.Name = "clmTypeReport";
            this.clmTypeReport.ReadOnly = true;
            this.clmTypeReport.Width = 125;
            // 
            // clmSender
            // 
            this.clmSender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSender.FillWeight = 42.52884F;
            this.clmSender.HeaderText = "Sender";
            this.clmSender.MinimumWidth = 6;
            this.clmSender.Name = "clmSender";
            this.clmSender.ReadOnly = true;
            // 
            // clmReceiver
            // 
            this.clmReceiver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmReceiver.FillWeight = 42.52884F;
            this.clmReceiver.HeaderText = "Receiver";
            this.clmReceiver.MinimumWidth = 6;
            this.clmReceiver.Name = "clmReceiver";
            this.clmReceiver.ReadOnly = true;
            // 
            // clmDateCreate
            // 
            this.clmDateCreate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmDateCreate.FillWeight = 299.031F;
            this.clmDateCreate.HeaderText = "Date Create";
            this.clmDateCreate.MinimumWidth = 6;
            this.clmDateCreate.Name = "clmDateCreate";
            this.clmDateCreate.ReadOnly = true;
            this.clmDateCreate.Width = 210;
            // 
            // clmCreatePerson
            // 
            this.clmCreatePerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCreatePerson.FillWeight = 42.52884F;
            this.clmCreatePerson.HeaderText = "Create Person";
            this.clmCreatePerson.MinimumWidth = 8;
            this.clmCreatePerson.Name = "clmCreatePerson";
            this.clmCreatePerson.ReadOnly = true;
            // 
            // clmPaid
            // 
            this.clmPaid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmPaid.FillWeight = 42.52884F;
            this.clmPaid.HeaderText = "Paid";
            this.clmPaid.MinimumWidth = 6;
            this.clmPaid.Name = "clmPaid";
            this.clmPaid.ReadOnly = true;
            this.clmPaid.Width = 90;
            // 
            // clmReceived
            // 
            this.clmReceived.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmReceived.FillWeight = 42.52884F;
            this.clmReceived.HeaderText = "Received";
            this.clmReceived.MinimumWidth = 6;
            this.clmReceived.Name = "clmReceived";
            this.clmReceived.ReadOnly = true;
            this.clmReceived.Width = 90;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Animated = true;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnCancel.BorderRadius = 4;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(993, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 44);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAgencyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 660);
            this.Controls.Add(this.tabPayment);
            this.Name = "FormAgencyPayment";
            this.Text = "Payment";
            this.ParentChanged += new System.EventHandler(this.FormAgencyPayment_ParentChanged);
            this.tabPayment.ResumeLayout(false);
            this.tabExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExport)).EndInit();
            this.tabPaid.ResumeLayout(false);
            this.tabPaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabPayment;
        private System.Windows.Forms.TabPage tabExport;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvExport;
        private System.Windows.Forms.TabPage tabPaid;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTypeReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceived;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.Label lblBillInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPriceEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBilledEx;
    }
}