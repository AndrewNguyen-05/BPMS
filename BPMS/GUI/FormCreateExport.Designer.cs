﻿namespace BPMS.GUI
{
    partial class FormCreateExport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nudQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PriceClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectClm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbBook = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbAgency = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpCreateDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtgvBookList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbReceiptPerson = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.BackColor = System.Drawing.Color.Transparent;
            this.nudQuantity.BorderColor = System.Drawing.Color.Black;
            this.nudQuantity.BorderRadius = 8;
            this.nudQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudQuantity.Location = new System.Drawing.Point(942, 216);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudQuantity.Maximum = new decimal(new int[] {
            987654321,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(160, 45);
            this.nudQuantity.TabIndex = 38;
            this.nudQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.nudQuantity.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PriceClm
            // 
            this.PriceClm.FillWeight = 43.06221F;
            this.PriceClm.HeaderText = "Price";
            this.PriceClm.MinimumWidth = 6;
            this.PriceClm.Name = "PriceClm";
            this.PriceClm.ReadOnly = true;
            // 
            // QualityClm
            // 
            this.QualityClm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QualityClm.FillWeight = 227.2727F;
            this.QualityClm.HeaderText = "Quality";
            this.QualityClm.MinimumWidth = 6;
            this.QualityClm.Name = "QualityClm";
            this.QualityClm.ReadOnly = true;
            // 
            // QuantityClm
            // 
            this.QuantityClm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuantityClm.FillWeight = 143.5407F;
            this.QuantityClm.HeaderText = "Quantity";
            this.QuantityClm.MinimumWidth = 6;
            this.QuantityClm.Name = "QuantityClm";
            this.QuantityClm.ReadOnly = true;
            this.QuantityClm.Width = 112;
            // 
            // AuthorClm
            // 
            this.AuthorClm.FillWeight = 43.06221F;
            this.AuthorClm.HeaderText = "Author";
            this.AuthorClm.MinimumWidth = 6;
            this.AuthorClm.Name = "AuthorClm";
            this.AuthorClm.ReadOnly = true;
            // 
            // BookClm
            // 
            this.BookClm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookClm.FillWeight = 43.06221F;
            this.BookClm.HeaderText = "Book";
            this.BookClm.MinimumWidth = 6;
            this.BookClm.Name = "BookClm";
            this.BookClm.ReadOnly = true;
            this.BookClm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BookClm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SelectClm
            // 
            this.SelectClm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SelectClm.HeaderText = "Select";
            this.SelectClm.MinimumWidth = 6;
            this.SelectClm.Name = "SelectClm";
            this.SelectClm.Visible = false;
            this.SelectClm.Width = 71;
            // 
            // cbBook
            // 
            this.cbBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBook.BackColor = System.Drawing.Color.Transparent;
            this.cbBook.BorderColor = System.Drawing.Color.Black;
            this.cbBook.BorderRadius = 8;
            this.cbBook.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBook.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBook.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbBook.ForeColor = System.Drawing.Color.Black;
            this.cbBook.ItemHeight = 30;
            this.cbBook.Location = new System.Drawing.Point(12, 148);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(1090, 36);
            this.cbBook.TabIndex = 37;
            // 
            // cbAgency
            // 
            this.cbAgency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAgency.BackColor = System.Drawing.Color.Transparent;
            this.cbAgency.BorderColor = System.Drawing.Color.Black;
            this.cbAgency.BorderRadius = 8;
            this.cbAgency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgency.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAgency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAgency.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbAgency.ForeColor = System.Drawing.Color.Black;
            this.cbAgency.ItemHeight = 30;
            this.cbAgency.Location = new System.Drawing.Point(12, 12);
            this.cbAgency.Name = "cbAgency";
            this.cbAgency.Size = new System.Drawing.Size(1090, 36);
            this.cbAgency.TabIndex = 36;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCreateDate.BackColor = System.Drawing.Color.White;
            this.dtpCreateDate.BorderRadius = 4;
            this.dtpCreateDate.BorderThickness = 1;
            this.dtpCreateDate.Checked = true;
            this.dtpCreateDate.FillColor = System.Drawing.Color.White;
            this.dtpCreateDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCreateDate.Location = new System.Drawing.Point(11, 296);
            this.dtpCreateDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCreateDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(539, 45);
            this.dtpCreateDate.TabIndex = 35;
            this.dtpCreateDate.Value = new System.DateTime(2023, 5, 13, 20, 57, 45, 837);
            // 
            // dtgvBookList
            // 
            this.dtgvBookList.AllowUserToAddRows = false;
            this.dtgvBookList.AllowUserToDeleteRows = false;
            this.dtgvBookList.AllowUserToResizeColumns = false;
            this.dtgvBookList.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dtgvBookList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dtgvBookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dtgvBookList.ColumnHeadersHeight = 30;
            this.dtgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectClm,
            this.BookClm,
            this.AuthorClm,
            this.QuantityClm,
            this.QualityClm,
            this.PriceClm});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBookList.DefaultCellStyle = dataGridViewCellStyle21;
            this.dtgvBookList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvBookList.Location = new System.Drawing.Point(15, 412);
            this.dtgvBookList.MultiSelect = false;
            this.dtgvBookList.Name = "dtgvBookList";
            this.dtgvBookList.RowHeadersVisible = false;
            this.dtgvBookList.RowHeadersWidth = 51;
            this.dtgvBookList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtgvBookList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookList.RowTemplate.Height = 24;
            this.dtgvBookList.Size = new System.Drawing.Size(1091, 111);
            this.dtgvBookList.TabIndex = 34;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvBookList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBookList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvBookList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dtgvBookList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBookList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBookList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvBookList.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvBookList.ThemeStyle.ReadOnly = false;
            this.dtgvBookList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBookList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBookList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvBookList.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvBookList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBookList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvBookList.SelectionChanged += new System.EventHandler(this.dtgvBookList_SelectionChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BorderRadius = 4;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(944, 528);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(160, 36);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 4;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.btnCancel.Location = new System.Drawing.Point(780, 528);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 36);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDelete.Location = new System.Drawing.Point(944, 358);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 36);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.BorderRadius = 4;
            this.btnModify.BorderThickness = 1;
            this.btnModify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModify.FillColor = System.Drawing.Color.White;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.btnModify.Location = new System.Drawing.Point(778, 358);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(160, 36);
            this.btnModify.TabIndex = 30;
            this.btnModify.Text = "MODIFY";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(613, 358);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 36);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalPrice.BorderColor = System.Drawing.Color.Black;
            this.txbTotalPrice.BorderRadius = 8;
            this.txbTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTotalPrice.DefaultText = "0";
            this.txbTotalPrice.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.txbTotalPrice.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbTotalPrice.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txbTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTotalPrice.Enabled = false;
            this.txbTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txbTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTotalPrice.Location = new System.Drawing.Point(557, 296);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.PasswordChar = '\0';
            this.txbTotalPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbTotalPrice.PlaceholderText = "TotalPrice";
            this.txbTotalPrice.SelectedText = "";
            this.txbTotalPrice.Size = new System.Drawing.Size(546, 45);
            this.txbTotalPrice.TabIndex = 28;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAuthor.BorderColor = System.Drawing.Color.Black;
            this.txbAuthor.BorderRadius = 8;
            this.txbAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbAuthor.DefaultText = "";
            this.txbAuthor.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.txbAuthor.DisabledState.FillColor = System.Drawing.Color.White;
            this.txbAuthor.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.txbAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbAuthor.Enabled = false;
            this.txbAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbAuthor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthor.ForeColor = System.Drawing.Color.Black;
            this.txbAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbAuthor.Location = new System.Drawing.Point(11, 216);
            this.txbAuthor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.PasswordChar = '\0';
            this.txbAuthor.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbAuthor.PlaceholderText = "";
            this.txbAuthor.SelectedText = "";
            this.txbAuthor.Size = new System.Drawing.Size(539, 40);
            this.txbAuthor.TabIndex = 26;
            // 
            // txbReceiptPerson
            // 
            this.txbReceiptPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbReceiptPerson.BorderColor = System.Drawing.Color.Black;
            this.txbReceiptPerson.BorderRadius = 8;
            this.txbReceiptPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbReceiptPerson.DefaultText = "";
            this.txbReceiptPerson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbReceiptPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbReceiptPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbReceiptPerson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbReceiptPerson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbReceiptPerson.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReceiptPerson.ForeColor = System.Drawing.Color.Black;
            this.txbReceiptPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbReceiptPerson.Location = new System.Drawing.Point(12, 81);
            this.txbReceiptPerson.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txbReceiptPerson.Name = "txbReceiptPerson";
            this.txbReceiptPerson.PasswordChar = '\0';
            this.txbReceiptPerson.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txbReceiptPerson.PlaceholderText = "";
            this.txbReceiptPerson.SelectedText = "";
            this.txbReceiptPerson.Size = new System.Drawing.Size(1090, 40);
            this.txbReceiptPerson.TabIndex = 24;
            // 
            // cbQuality
            // 
            this.cbQuality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuality.BackColor = System.Drawing.Color.Transparent;
            this.cbQuality.BorderColor = System.Drawing.Color.Black;
            this.cbQuality.BorderRadius = 8;
            this.cbQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbQuality.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbQuality.ForeColor = System.Drawing.Color.Black;
            this.cbQuality.ItemHeight = 30;
            this.cbQuality.Items.AddRange(new object[] {
            "Đạt yêu cầu",
            "Không đạt yêu cầu"});
            this.cbQuality.Location = new System.Drawing.Point(557, 216);
            this.cbQuality.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(379, 36);
            this.cbQuality.StartIndex = 0;
            this.cbQuality.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label1.Location = new System.Drawing.Point(22, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label2.Location = new System.Drawing.Point(573, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "Quality";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Name of Book";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label4.Location = new System.Drawing.Point(20, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 42;
            this.label4.Text = "Create Date";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label5.Location = new System.Drawing.Point(574, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Total Price";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label6.Location = new System.Drawing.Point(944, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label7.Location = new System.Drawing.Point(20, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Receipt Person";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label8.Location = new System.Drawing.Point(17, -5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Agency";
            // 
            // FormCreateExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 574);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbQuality);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbBook);
            this.Controls.Add(this.cbAgency);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.dtgvBookList);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbTotalPrice);
            this.Controls.Add(this.txbAuthor);
            this.Controls.Add(this.txbReceiptPerson);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCreateExport";
            this.Text = "Create Export";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuantity;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookClm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectClm;
        private Guna.UI2.WinForms.Guna2ComboBox cbBook;
        private Guna.UI2.WinForms.Guna2ComboBox cbAgency;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCreateDate;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBookList;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txbTotalPrice;
        private Guna.UI2.WinForms.Guna2TextBox txbAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txbReceiptPerson;
        private Guna.UI2.WinForms.Guna2ComboBox cbQuality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}