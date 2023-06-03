namespace BPMS.GUI
{
    partial class FormPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPayment = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.btnCreateImport = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvImport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.btnCreateExport = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvExport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.dtgvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmIdExport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPriceEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBilledEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdImport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPriceIm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBilledIm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTypeReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatePerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPayment.SuspendLayout();
            this.tabImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImport)).BeginInit();
            this.tabExport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExport)).BeginInit();
            this.tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPayment
            // 
            this.tabPayment.Controls.Add(this.tabImport);
            this.tabPayment.Controls.Add(this.tabExport);
            this.tabPayment.Controls.Add(this.tabBill);
            this.tabPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPayment.ItemSize = new System.Drawing.Size(180, 40);
            this.tabPayment.Location = new System.Drawing.Point(0, 0);
            this.tabPayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.SelectedIndex = 0;
            this.tabPayment.Size = new System.Drawing.Size(1343, 825);
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
            this.tabPayment.TabIndex = 0;
            this.tabPayment.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabPayment.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tabPayment.SelectedIndexChanged += new System.EventHandler(this.tabPayment_SelectedIndexChanged);
            // 
            // tabImport
            // 
            this.tabImport.Controls.Add(this.btnCreateImport);
            this.tabImport.Controls.Add(this.dtgvImport);
            this.tabImport.Location = new System.Drawing.Point(4, 44);
            this.tabImport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabImport.Size = new System.Drawing.Size(1335, 777);
            this.tabImport.TabIndex = 0;
            this.tabImport.Text = "Import";
            this.tabImport.UseVisualStyleBackColor = true;
            // 
            // btnCreateImport
            // 
            this.btnCreateImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateImport.Animated = true;
            this.btnCreateImport.BorderRadius = 4;
            this.btnCreateImport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateImport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnCreateImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateImport.ForeColor = System.Drawing.Color.White;
            this.btnCreateImport.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateImport.Image")));
            this.btnCreateImport.Location = new System.Drawing.Point(1051, 6);
            this.btnCreateImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateImport.Name = "btnCreateImport";
            this.btnCreateImport.Size = new System.Drawing.Size(276, 55);
            this.btnCreateImport.TabIndex = 7;
            this.btnCreateImport.Text = "Create bill";
            this.btnCreateImport.Click += new System.EventHandler(this.btnCreateImport_Click);
            // 
            // dtgvImport
            // 
            this.dtgvImport.AllowUserToAddRows = false;
            this.dtgvImport.AllowUserToDeleteRows = false;
            this.dtgvImport.AllowUserToResizeColumns = false;
            this.dtgvImport.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            this.dtgvImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dtgvImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dtgvImport.ColumnHeadersHeight = 35;
            this.dtgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdImport,
            this.clmPublisher,
            this.clmImportDate,
            this.clmTotalPriceIm,
            this.clmBilledIm});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvImport.DefaultCellStyle = dataGridViewCellStyle31;
            this.dtgvImport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvImport.Location = new System.Drawing.Point(7, 78);
            this.dtgvImport.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtgvImport.MultiSelect = false;
            this.dtgvImport.Name = "dtgvImport";
            this.dtgvImport.ReadOnly = true;
            this.dtgvImport.RowHeadersVisible = false;
            this.dtgvImport.RowHeadersWidth = 62;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dtgvImport.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dtgvImport.RowTemplate.Height = 32;
            this.dtgvImport.Size = new System.Drawing.Size(1320, 682);
            this.dtgvImport.TabIndex = 1;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvImport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvImport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvImport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvImport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvImport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvImport.ThemeStyle.HeaderStyle.Height = 35;
            this.dtgvImport.ThemeStyle.ReadOnly = true;
            this.dtgvImport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvImport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvImport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvImport.ThemeStyle.RowsStyle.Height = 32;
            this.dtgvImport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvImport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.btnCreateExport);
            this.tabExport.Controls.Add(this.dtgvExport);
            this.tabExport.Location = new System.Drawing.Point(4, 44);
            this.tabExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabExport.Size = new System.Drawing.Size(1335, 777);
            this.tabExport.TabIndex = 1;
            this.tabExport.Text = "Export";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // btnCreateExport
            // 
            this.btnCreateExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateExport.Animated = true;
            this.btnCreateExport.BorderRadius = 4;
            this.btnCreateExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateExport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnCreateExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateExport.ForeColor = System.Drawing.Color.White;
            this.btnCreateExport.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateExport.Image")));
            this.btnCreateExport.Location = new System.Drawing.Point(1040, 6);
            this.btnCreateExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateExport.Name = "btnCreateExport";
            this.btnCreateExport.Size = new System.Drawing.Size(276, 55);
            this.btnCreateExport.TabIndex = 8;
            this.btnCreateExport.Text = "Create bill";
            this.btnCreateExport.Click += new System.EventHandler(this.btnCreateExport_Click);
            // 
            // dtgvExport
            // 
            this.dtgvExport.AllowUserToAddRows = false;
            this.dtgvExport.AllowUserToDeleteRows = false;
            this.dtgvExport.AllowUserToResizeColumns = false;
            this.dtgvExport.AllowUserToResizeRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            this.dtgvExport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dtgvExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dtgvExport.ColumnHeadersHeight = 35;
            this.dtgvExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdExport,
            this.clmAgency,
            this.clmExportDate,
            this.clmTotalPriceEx,
            this.clmBilledEx});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvExport.DefaultCellStyle = dataGridViewCellStyle35;
            this.dtgvExport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvExport.Location = new System.Drawing.Point(6, 65);
            this.dtgvExport.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtgvExport.MultiSelect = false;
            this.dtgvExport.Name = "dtgvExport";
            this.dtgvExport.ReadOnly = true;
            this.dtgvExport.RowHeadersVisible = false;
            this.dtgvExport.RowHeadersWidth = 62;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dtgvExport.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dtgvExport.RowTemplate.Height = 32;
            this.dtgvExport.Size = new System.Drawing.Size(1305, 632);
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
            // tabBill
            // 
            this.tabBill.Controls.Add(this.btnDelete);
            this.tabBill.Controls.Add(this.btnModify);
            this.tabBill.Controls.Add(this.dtgvBill);
            this.tabBill.Location = new System.Drawing.Point(4, 44);
            this.tabBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabBill.Size = new System.Drawing.Size(1335, 777);
            this.tabBill.TabIndex = 2;
            this.tabBill.Text = "Bill";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Animated = true;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1108, 19);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 55);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Animated = true;
            this.btnModify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.btnModify.BorderRadius = 4;
            this.btnModify.BorderThickness = 1;
            this.btnModify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModify.FillColor = System.Drawing.Color.White;
            this.btnModify.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(842, 19);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(207, 55);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToDeleteRows = false;
            this.dtgvBill.AllowUserToResizeColumns = false;
            this.dtgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dtgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dtgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
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
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.DefaultCellStyle = dataGridViewCellStyle27;
            this.dtgvBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvBill.Location = new System.Drawing.Point(7, 90);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtgvBill.MultiSelect = false;
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.RowHeadersWidth = 62;
            this.dtgvBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dtgvBill.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dtgvBill.RowTemplate.Height = 28;
            this.dtgvBill.Size = new System.Drawing.Size(1308, 612);
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
            // 
            // clmIdExport
            // 
            this.clmIdExport.HeaderText = "Id Export";
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
            this.clmBilledEx.HeaderText = "Billed";
            this.clmBilledEx.MinimumWidth = 6;
            this.clmBilledEx.Name = "clmBilledEx";
            this.clmBilledEx.ReadOnly = true;
            // 
            // clmIdImport
            // 
            this.clmIdImport.HeaderText = "Id Import";
            this.clmIdImport.MinimumWidth = 6;
            this.clmIdImport.Name = "clmIdImport";
            this.clmIdImport.ReadOnly = true;
            // 
            // clmPublisher
            // 
            this.clmPublisher.HeaderText = "Publisher";
            this.clmPublisher.MinimumWidth = 6;
            this.clmPublisher.Name = "clmPublisher";
            this.clmPublisher.ReadOnly = true;
            // 
            // clmImportDate
            // 
            this.clmImportDate.HeaderText = "Import Date";
            this.clmImportDate.MinimumWidth = 6;
            this.clmImportDate.Name = "clmImportDate";
            this.clmImportDate.ReadOnly = true;
            // 
            // clmTotalPriceIm
            // 
            this.clmTotalPriceIm.HeaderText = "Total Price";
            this.clmTotalPriceIm.MinimumWidth = 6;
            this.clmTotalPriceIm.Name = "clmTotalPriceIm";
            this.clmTotalPriceIm.ReadOnly = true;
            // 
            // clmBilledIm
            // 
            this.clmBilledIm.HeaderText = "Billed";
            this.clmBilledIm.MinimumWidth = 6;
            this.clmBilledIm.Name = "clmBilledIm";
            this.clmBilledIm.ReadOnly = true;
            // 
            // clmIdBill
            // 
            this.clmIdBill.HeaderText = "Id";
            this.clmIdBill.MinimumWidth = 6;
            this.clmIdBill.Name = "clmIdBill";
            this.clmIdBill.ReadOnly = true;
            // 
            // clmTypeReport
            // 
            this.clmTypeReport.HeaderText = "Type";
            this.clmTypeReport.MinimumWidth = 8;
            this.clmTypeReport.Name = "clmTypeReport";
            this.clmTypeReport.ReadOnly = true;
            // 
            // clmSender
            // 
            this.clmSender.HeaderText = "Sender";
            this.clmSender.MinimumWidth = 6;
            this.clmSender.Name = "clmSender";
            this.clmSender.ReadOnly = true;
            // 
            // clmReceiver
            // 
            this.clmReceiver.HeaderText = "Receiver";
            this.clmReceiver.MinimumWidth = 6;
            this.clmReceiver.Name = "clmReceiver";
            this.clmReceiver.ReadOnly = true;
            // 
            // clmDateCreate
            // 
            this.clmDateCreate.HeaderText = "Date Create";
            this.clmDateCreate.MinimumWidth = 6;
            this.clmDateCreate.Name = "clmDateCreate";
            this.clmDateCreate.ReadOnly = true;
            // 
            // clmCreatePerson
            // 
            this.clmCreatePerson.HeaderText = "Create Person";
            this.clmCreatePerson.MinimumWidth = 8;
            this.clmCreatePerson.Name = "clmCreatePerson";
            this.clmCreatePerson.ReadOnly = true;
            // 
            // clmPaid
            // 
            this.clmPaid.HeaderText = "Paid";
            this.clmPaid.MinimumWidth = 6;
            this.clmPaid.Name = "clmPaid";
            this.clmPaid.ReadOnly = true;
            // 
            // clmReceived
            // 
            this.clmReceived.HeaderText = "Received";
            this.clmReceived.MinimumWidth = 6;
            this.clmReceived.Name = "clmReceived";
            this.clmReceived.ReadOnly = true;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 825);
            this.Controls.Add(this.tabPayment);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPayment";
            this.Text = "Payment";
            this.tabPayment.ResumeLayout(false);
            this.tabImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImport)).EndInit();
            this.tabExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExport)).EndInit();
            this.tabBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabPayment;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.TabPage tabExport;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvImport;
        private System.Windows.Forms.TabPage tabBill;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvExport;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBill;
        private Guna.UI2.WinForms.Guna2Button btnCreateImport;
        private Guna.UI2.WinForms.Guna2Button btnCreateExport;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPriceIm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBilledIm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAgency;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPriceEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBilledEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTypeReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceived;
    }
}