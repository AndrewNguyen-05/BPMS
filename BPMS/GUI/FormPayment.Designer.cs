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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPayment = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabImport = new System.Windows.Forms.TabPage();
            this.dtgvImport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBilled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.dtgvExport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clmIdExport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.dtgvBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelImport = new System.Windows.Forms.Label();
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
            this.tabPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPayment.Controls.Add(this.tabImport);
            this.tabPayment.Controls.Add(this.tabExport);
            this.tabPayment.Controls.Add(this.tabBill);
            this.tabPayment.ItemSize = new System.Drawing.Size(180, 40);
            this.tabPayment.Location = new System.Drawing.Point(12, 66);
            this.tabPayment.Name = "tabPayment";
            this.tabPayment.SelectedIndex = 0;
            this.tabPayment.Size = new System.Drawing.Size(966, 374);
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
            this.tabImport.Controls.Add(this.dtgvImport);
            this.tabImport.Location = new System.Drawing.Point(4, 44);
            this.tabImport.Name = "tabImport";
            this.tabImport.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabImport.Size = new System.Drawing.Size(958, 326);
            this.tabImport.TabIndex = 0;
            this.tabImport.Text = "Import";
            this.tabImport.UseVisualStyleBackColor = true;
            // 
            // dtgvImport
            // 
            this.dtgvImport.AllowUserToAddRows = false;
            this.dtgvImport.AllowUserToDeleteRows = false;
            this.dtgvImport.AllowUserToResizeColumns = false;
            this.dtgvImport.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dtgvImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvImport.ColumnHeadersHeight = 30;
            this.dtgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmPublisher,
            this.clmImportDate,
            this.clmTotalPrice,
            this.clmBilled});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvImport.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvImport.GridColor = System.Drawing.Color.RoyalBlue;
            this.dtgvImport.Location = new System.Drawing.Point(6, 4);
            this.dtgvImport.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtgvImport.MultiSelect = false;
            this.dtgvImport.Name = "dtgvImport";
            this.dtgvImport.ReadOnly = true;
            this.dtgvImport.RowHeadersVisible = false;
            this.dtgvImport.RowHeadersWidth = 62;
            this.dtgvImport.RowTemplate.Height = 28;
            this.dtgvImport.Size = new System.Drawing.Size(946, 318);
            this.dtgvImport.TabIndex = 1;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvImport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.GridColor = System.Drawing.Color.RoyalBlue;
            this.dtgvImport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvImport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvImport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvImport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvImport.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvImport.ThemeStyle.ReadOnly = true;
            this.dtgvImport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvImport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvImport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvImport.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvImport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvImport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id Import";
            this.clmId.MinimumWidth = 6;
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
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
            // clmTotalPrice
            // 
            this.clmTotalPrice.HeaderText = "Total Price";
            this.clmTotalPrice.MinimumWidth = 6;
            this.clmTotalPrice.Name = "clmTotalPrice";
            this.clmTotalPrice.ReadOnly = true;
            // 
            // clmBilled
            // 
            this.clmBilled.HeaderText = "Billed";
            this.clmBilled.MinimumWidth = 6;
            this.clmBilled.Name = "clmBilled";
            this.clmBilled.ReadOnly = true;
            // 
            // tabExport
            // 
            this.tabExport.Controls.Add(this.dtgvExport);
            this.tabExport.Location = new System.Drawing.Point(4, 44);
            this.tabExport.Name = "tabExport";
            this.tabExport.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabExport.Size = new System.Drawing.Size(958, 326);
            this.tabExport.TabIndex = 1;
            this.tabExport.Text = "Export";
            this.tabExport.UseVisualStyleBackColor = true;
            // 
            // dtgvExport
            // 
            this.dtgvExport.AllowUserToAddRows = false;
            this.dtgvExport.AllowUserToDeleteRows = false;
            this.dtgvExport.AllowUserToResizeColumns = false;
            this.dtgvExport.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dtgvExport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvExport.ColumnHeadersHeight = 30;
            this.dtgvExport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdExport,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvExport.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvExport.GridColor = System.Drawing.Color.RoyalBlue;
            this.dtgvExport.Location = new System.Drawing.Point(9, 4);
            this.dtgvExport.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtgvExport.MultiSelect = false;
            this.dtgvExport.Name = "dtgvExport";
            this.dtgvExport.ReadOnly = true;
            this.dtgvExport.RowHeadersVisible = false;
            this.dtgvExport.RowHeadersWidth = 62;
            this.dtgvExport.RowTemplate.Height = 28;
            this.dtgvExport.Size = new System.Drawing.Size(946, 318);
            this.dtgvExport.TabIndex = 3;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvExport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvExport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvExport.ThemeStyle.GridColor = System.Drawing.Color.RoyalBlue;
            this.dtgvExport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvExport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvExport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvExport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvExport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvExport.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvExport.ThemeStyle.ReadOnly = true;
            this.dtgvExport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvExport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvExport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvExport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvExport.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvExport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvExport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // clmIdExport
            // 
            this.clmIdExport.HeaderText = "Id Export";
            this.clmIdExport.MinimumWidth = 6;
            this.clmIdExport.Name = "clmIdExport";
            this.clmIdExport.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Agency";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Export Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Billed";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.dtgvBill);
            this.tabBill.Location = new System.Drawing.Point(4, 44);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabBill.Size = new System.Drawing.Size(958, 326);
            this.tabBill.TabIndex = 2;
            this.tabBill.Text = "Bill";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToAddRows = false;
            this.dtgvBill.AllowUserToDeleteRows = false;
            this.dtgvBill.AllowUserToResizeColumns = false;
            this.dtgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dtgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgvBill.ColumnHeadersHeight = 30;
            this.dtgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column1});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBill.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgvBill.GridColor = System.Drawing.Color.RoyalBlue;
            this.dtgvBill.Location = new System.Drawing.Point(6, 4);
            this.dtgvBill.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtgvBill.MultiSelect = false;
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.ReadOnly = true;
            this.dtgvBill.RowHeadersVisible = false;
            this.dtgvBill.RowHeadersWidth = 62;
            this.dtgvBill.RowTemplate.Height = 28;
            this.dtgvBill.Size = new System.Drawing.Size(946, 318);
            this.dtgvBill.TabIndex = 4;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.GridColor = System.Drawing.Color.RoyalBlue;
            this.dtgvBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvBill.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvBill.ThemeStyle.ReadOnly = true;
            this.dtgvBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvBill.ThemeStyle.RowsStyle.Height = 28;
            this.dtgvBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Sender";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Receiver";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Date Create";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Paid";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Received";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // labelImport
            // 
            this.labelImport.AutoSize = true;
            this.labelImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.labelImport.Location = new System.Drawing.Point(12, 9);
            this.labelImport.Name = "labelImport";
            this.labelImport.Size = new System.Drawing.Size(98, 23);
            this.labelImport.TabIndex = 3;
            this.labelImport.Text = "Payment";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 452);
            this.Controls.Add(this.labelImport);
            this.Controls.Add(this.tabPayment);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.tabPayment.ResumeLayout(false);
            this.tabImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImport)).EndInit();
            this.tabExport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExport)).EndInit();
            this.tabBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabPayment;
        private System.Windows.Forms.TabPage tabImport;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.Label labelImport;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvImport;
        private System.Windows.Forms.TabPage tabBill;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBilled;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}