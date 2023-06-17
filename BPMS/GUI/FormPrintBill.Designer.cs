namespace BPMS.GUI
{
    partial class FormPrintBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrintBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbPreview = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.lblSender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblImExportDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dtgvBookList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BookClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIdBill = new System.Windows.Forms.Label();
            this.lblCreatePerson = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.grbPreview.SuspendLayout();
            this.panelPreview.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPreview
            // 
            this.grbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbPreview.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.grbPreview.Controls.Add(this.panelPreview);
            this.grbPreview.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.grbPreview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPreview.ForeColor = System.Drawing.Color.White;
            this.grbPreview.Location = new System.Drawing.Point(12, 12);
            this.grbPreview.Name = "grbPreview";
            this.grbPreview.Size = new System.Drawing.Size(1067, 985);
            this.grbPreview.TabIndex = 1;
            this.grbPreview.Text = "Print preview";
            // 
            // panelPreview
            // 
            this.panelPreview.Controls.Add(this.groupBox2);
            this.panelPreview.Controls.Add(this.groupBox1);
            this.panelPreview.Controls.Add(this.label6);
            this.panelPreview.Controls.Add(this.label5);
            this.panelPreview.Controls.Add(this.label4);
            this.panelPreview.Controls.Add(this.label3);
            this.panelPreview.Controls.Add(this.label2);
            this.panelPreview.Controls.Add(this.label1);
            this.panelPreview.Controls.Add(this.pictureBox1);
            this.panelPreview.Controls.Add(this.lblTotalPrice);
            this.panelPreview.Controls.Add(this.dtgvBookList);
            this.panelPreview.Controls.Add(this.lblIdBill);
            this.panelPreview.Controls.Add(this.lblCreatePerson);
            this.panelPreview.Controls.Add(this.lblType);
            this.panelPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPreview.Location = new System.Drawing.Point(0, 40);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(1067, 945);
            this.panelPreview.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblReceiver);
            this.groupBox2.Controls.Add(this.lblSender);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(539, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 155);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "People";
            // 
            // lblReceiver
            // 
            this.lblReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiver.ForeColor = System.Drawing.Color.Black;
            this.lblReceiver.Location = new System.Drawing.Point(11, 55);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(99, 26);
            this.lblReceiver.TabIndex = 22;
            this.lblReceiver.Text = "Receiver:";
            // 
            // lblSender
            // 
            this.lblSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.ForeColor = System.Drawing.Color.Black;
            this.lblSender.Location = new System.Drawing.Point(11, 112);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(83, 26);
            this.lblSender.TabIndex = 23;
            this.lblSender.Text = "Sender:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCreateDate);
            this.groupBox1.Controls.Add(this.lblImExportDate);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 155);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.ForeColor = System.Drawing.Color.Black;
            this.lblCreateDate.Location = new System.Drawing.Point(6, 55);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(125, 26);
            this.lblCreateDate.TabIndex = 24;
            this.lblCreateDate.Text = "Create Date:";
            // 
            // lblImExportDate
            // 
            this.lblImExportDate.AutoSize = true;
            this.lblImExportDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImExportDate.ForeColor = System.Drawing.Color.Black;
            this.lblImExportDate.Location = new System.Drawing.Point(7, 112);
            this.lblImExportDate.Name = "lblImExportDate";
            this.lblImExportDate.Size = new System.Drawing.Size(122, 26);
            this.lblImExportDate.TabIndex = 27;
            this.lblImExportDate.Text = "Export Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(230, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Mail: BPMS@gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(230, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tel: 028 3725 2002";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(230, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "Thủ Đức, TPHCM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(229, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tòa A, Đường Hàn Thuyên, Khu phố 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(229, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(229, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "BOOK PUBLISH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.Location = new System.Drawing.Point(18, 893);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(136, 29);
            this.lblTotalPrice.TabIndex = 29;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // dtgvBookList
            // 
            this.dtgvBookList.AllowUserToAddRows = false;
            this.dtgvBookList.AllowUserToDeleteRows = false;
            this.dtgvBookList.AllowUserToResizeColumns = false;
            this.dtgvBookList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvBookList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvBookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvBookList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvBookList.ColumnHeadersHeight = 35;
            this.dtgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookClm,
            this.AuthorClm,
            this.QuantityClm,
            this.QualityClm,
            this.PriceClm,
            this.TotalPriceClm});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvBookList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBookList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvBookList.Location = new System.Drawing.Point(12, 483);
            this.dtgvBookList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvBookList.MultiSelect = false;
            this.dtgvBookList.Name = "dtgvBookList";
            this.dtgvBookList.RowHeadersVisible = false;
            this.dtgvBookList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dtgvBookList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvBookList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtgvBookList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookList.RowTemplate.Height = 37;
            this.dtgvBookList.Size = new System.Drawing.Size(1043, 406);
            this.dtgvBookList.TabIndex = 28;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvBookList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvBookList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBookList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvBookList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dtgvBookList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvBookList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvBookList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvBookList.ThemeStyle.HeaderStyle.Height = 35;
            this.dtgvBookList.ThemeStyle.ReadOnly = false;
            this.dtgvBookList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvBookList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvBookList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvBookList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvBookList.ThemeStyle.RowsStyle.Height = 37;
            this.dtgvBookList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvBookList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // AuthorClm
            // 
            this.AuthorClm.FillWeight = 43.06221F;
            this.AuthorClm.HeaderText = "Author";
            this.AuthorClm.MinimumWidth = 6;
            this.AuthorClm.Name = "AuthorClm";
            this.AuthorClm.ReadOnly = true;
            // 
            // QuantityClm
            // 
            this.QuantityClm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuantityClm.FillWeight = 143.5407F;
            this.QuantityClm.HeaderText = "Quantity";
            this.QuantityClm.MinimumWidth = 6;
            this.QuantityClm.Name = "QuantityClm";
            this.QuantityClm.ReadOnly = true;
            this.QuantityClm.Width = 122;
            // 
            // QualityClm
            // 
            this.QualityClm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QualityClm.FillWeight = 227.2727F;
            this.QualityClm.HeaderText = "Quality";
            this.QualityClm.MinimumWidth = 6;
            this.QualityClm.Name = "QualityClm";
            this.QualityClm.ReadOnly = true;
            this.QualityClm.Width = 108;
            // 
            // PriceClm
            // 
            this.PriceClm.FillWeight = 20F;
            this.PriceClm.HeaderText = "Price";
            this.PriceClm.MinimumWidth = 6;
            this.PriceClm.Name = "PriceClm";
            // 
            // TotalPriceClm
            // 
            this.TotalPriceClm.FillWeight = 43.06221F;
            this.TotalPriceClm.HeaderText = "Total Price";
            this.TotalPriceClm.MinimumWidth = 6;
            this.TotalPriceClm.Name = "TotalPriceClm";
            this.TotalPriceClm.ReadOnly = true;
            // 
            // lblIdBill
            // 
            this.lblIdBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdBill.AutoSize = true;
            this.lblIdBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBill.ForeColor = System.Drawing.Color.Black;
            this.lblIdBill.Location = new System.Drawing.Point(847, 5);
            this.lblIdBill.Name = "lblIdBill";
            this.lblIdBill.Size = new System.Drawing.Size(72, 22);
            this.lblIdBill.TabIndex = 26;
            this.lblIdBill.Text = "Bill ID:";
            // 
            // lblCreatePerson
            // 
            this.lblCreatePerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatePerson.AutoSize = true;
            this.lblCreatePerson.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatePerson.ForeColor = System.Drawing.Color.Black;
            this.lblCreatePerson.Location = new System.Drawing.Point(792, 37);
            this.lblCreatePerson.Name = "lblCreatePerson";
            this.lblCreatePerson.Size = new System.Drawing.Size(127, 22);
            this.lblCreatePerson.TabIndex = 25;
            this.lblCreatePerson.Text = "Create Person:";
            // 
            // lblType
            // 
            this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(402, 196);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(197, 38);
            this.lblType.TabIndex = 21;
            this.lblType.Text = "BILL TYPE";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BorderRadius = 14;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(448, 1002);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(203, 42);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 1055);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grbPreview);
            this.Name = "FormPrintBill";
            this.Text = "FormPrintBill";
            this.grbPreview.ResumeLayout(false);
            this.panelPreview.ResumeLayout(false);
            this.panelPreview.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox grbPreview;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.Label lblTotalPrice;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvBookList;
        private System.Windows.Forms.Label lblImExportDate;
        private System.Windows.Forms.Label lblIdBill;
        private System.Windows.Forms.Label lblCreatePerson;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceClm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}