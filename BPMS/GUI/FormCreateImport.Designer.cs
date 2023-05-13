namespace BPMS.GUI
{
    partial class FormCreateImport
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
            this.PublisherTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeliveryPersonTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UnitLeaderTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.BookTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AuthorTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.QualityTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.QuantityTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.TotalPriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.TempListDtgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SelectClm = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BookClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QualityClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceClm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDateDtp = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.TempListDtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // PublisherTxt
            // 
            this.PublisherTxt.BorderColor = System.Drawing.Color.Black;
            this.PublisherTxt.BorderRadius = 8;
            this.PublisherTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PublisherTxt.DefaultText = "";
            this.PublisherTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PublisherTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PublisherTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PublisherTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PublisherTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PublisherTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PublisherTxt.ForeColor = System.Drawing.Color.Black;
            this.PublisherTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PublisherTxt.Location = new System.Drawing.Point(12, 15);
            this.PublisherTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PublisherTxt.Name = "PublisherTxt";
            this.PublisherTxt.PasswordChar = '\0';
            this.PublisherTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PublisherTxt.PlaceholderText = "Publisher";
            this.PublisherTxt.SelectedText = "";
            this.PublisherTxt.Size = new System.Drawing.Size(993, 40);
            this.PublisherTxt.TabIndex = 1;
            // 
            // DeliveryPersonTxt
            // 
            this.DeliveryPersonTxt.BorderColor = System.Drawing.Color.Black;
            this.DeliveryPersonTxt.BorderRadius = 8;
            this.DeliveryPersonTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DeliveryPersonTxt.DefaultText = "";
            this.DeliveryPersonTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DeliveryPersonTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DeliveryPersonTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeliveryPersonTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DeliveryPersonTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeliveryPersonTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeliveryPersonTxt.ForeColor = System.Drawing.Color.Black;
            this.DeliveryPersonTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DeliveryPersonTxt.Location = new System.Drawing.Point(13, 67);
            this.DeliveryPersonTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeliveryPersonTxt.Name = "DeliveryPersonTxt";
            this.DeliveryPersonTxt.PasswordChar = '\0';
            this.DeliveryPersonTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.DeliveryPersonTxt.PlaceholderText = "DeliveryPerson";
            this.DeliveryPersonTxt.SelectedText = "";
            this.DeliveryPersonTxt.Size = new System.Drawing.Size(644, 40);
            this.DeliveryPersonTxt.TabIndex = 2;
            // 
            // UnitLeaderTxt
            // 
            this.UnitLeaderTxt.BorderColor = System.Drawing.Color.Black;
            this.UnitLeaderTxt.BorderRadius = 8;
            this.UnitLeaderTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UnitLeaderTxt.DefaultText = "";
            this.UnitLeaderTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UnitLeaderTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UnitLeaderTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnitLeaderTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UnitLeaderTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnitLeaderTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UnitLeaderTxt.ForeColor = System.Drawing.Color.Black;
            this.UnitLeaderTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UnitLeaderTxt.Location = new System.Drawing.Point(13, 119);
            this.UnitLeaderTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnitLeaderTxt.Name = "UnitLeaderTxt";
            this.UnitLeaderTxt.PasswordChar = '\0';
            this.UnitLeaderTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UnitLeaderTxt.PlaceholderText = "Unit Leader";
            this.UnitLeaderTxt.SelectedText = "";
            this.UnitLeaderTxt.Size = new System.Drawing.Size(644, 40);
            this.UnitLeaderTxt.TabIndex = 5;
            // 
            // BookTxt
            // 
            this.BookTxt.BorderColor = System.Drawing.Color.Black;
            this.BookTxt.BorderRadius = 8;
            this.BookTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookTxt.DefaultText = "";
            this.BookTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BookTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BookTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BookTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BookTxt.ForeColor = System.Drawing.Color.Black;
            this.BookTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BookTxt.Location = new System.Drawing.Point(13, 199);
            this.BookTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BookTxt.Name = "BookTxt";
            this.BookTxt.PasswordChar = '\0';
            this.BookTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BookTxt.PlaceholderText = "Book";
            this.BookTxt.SelectedText = "";
            this.BookTxt.Size = new System.Drawing.Size(990, 40);
            this.BookTxt.TabIndex = 7;
            // 
            // AuthorTxt
            // 
            this.AuthorTxt.BorderColor = System.Drawing.Color.Black;
            this.AuthorTxt.BorderRadius = 8;
            this.AuthorTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AuthorTxt.DefaultText = "";
            this.AuthorTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AuthorTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AuthorTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AuthorTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AuthorTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AuthorTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AuthorTxt.ForeColor = System.Drawing.Color.Black;
            this.AuthorTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AuthorTxt.Location = new System.Drawing.Point(12, 251);
            this.AuthorTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AuthorTxt.Name = "AuthorTxt";
            this.AuthorTxt.PasswordChar = '\0';
            this.AuthorTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.AuthorTxt.PlaceholderText = "Author";
            this.AuthorTxt.SelectedText = "";
            this.AuthorTxt.Size = new System.Drawing.Size(449, 40);
            this.AuthorTxt.TabIndex = 8;
            // 
            // QualityTxt
            // 
            this.QualityTxt.BorderColor = System.Drawing.Color.Black;
            this.QualityTxt.BorderRadius = 8;
            this.QualityTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QualityTxt.DefaultText = "";
            this.QualityTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QualityTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QualityTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QualityTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QualityTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QualityTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.QualityTxt.ForeColor = System.Drawing.Color.Black;
            this.QualityTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QualityTxt.Location = new System.Drawing.Point(469, 251);
            this.QualityTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.QualityTxt.Name = "QualityTxt";
            this.QualityTxt.PasswordChar = '\0';
            this.QualityTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.QualityTxt.PlaceholderText = "Quality";
            this.QualityTxt.SelectedText = "";
            this.QualityTxt.Size = new System.Drawing.Size(368, 40);
            this.QualityTxt.TabIndex = 9;
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.BorderColor = System.Drawing.Color.Black;
            this.QuantityTxt.BorderRadius = 8;
            this.QuantityTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuantityTxt.DefaultText = "";
            this.QuantityTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuantityTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuantityTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuantityTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.QuantityTxt.ForeColor = System.Drawing.Color.Black;
            this.QuantityTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuantityTxt.Location = new System.Drawing.Point(849, 251);
            this.QuantityTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.PasswordChar = '\0';
            this.QuantityTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.QuantityTxt.PlaceholderText = "Quantity";
            this.QuantityTxt.SelectedText = "";
            this.QuantityTxt.Size = new System.Drawing.Size(156, 40);
            this.QuantityTxt.TabIndex = 10;
            // 
            // TotalPriceTxt
            // 
            this.TotalPriceTxt.BorderColor = System.Drawing.Color.Black;
            this.TotalPriceTxt.BorderRadius = 8;
            this.TotalPriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalPriceTxt.DefaultText = "";
            this.TotalPriceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TotalPriceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TotalPriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotalPriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TotalPriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TotalPriceTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TotalPriceTxt.ForeColor = System.Drawing.Color.Black;
            this.TotalPriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TotalPriceTxt.Location = new System.Drawing.Point(664, 119);
            this.TotalPriceTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.PasswordChar = '\0';
            this.TotalPriceTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TotalPriceTxt.PlaceholderText = "TotalPrice";
            this.TotalPriceTxt.SelectedText = "";
            this.TotalPriceTxt.Size = new System.Drawing.Size(339, 40);
            this.TotalPriceTxt.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(511, 299);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
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
            this.btnModify.Location = new System.Drawing.Point(679, 299);
            this.btnModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(160, 36);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "MODIFY";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDelete.Location = new System.Drawing.Point(845, 299);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(160, 36);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
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
            this.btnCancel.Location = new System.Drawing.Point(677, 568);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 36);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 4;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(844, 568);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(160, 36);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // TempListDtgv
            // 
            this.TempListDtgv.AllowUserToAddRows = false;
            this.TempListDtgv.AllowUserToDeleteRows = false;
            this.TempListDtgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TempListDtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TempListDtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TempListDtgv.ColumnHeadersHeight = 24;
            this.TempListDtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectClm,
            this.BookClm,
            this.AuthorClm,
            this.QuantityClm,
            this.QualityClm,
            this.PriceClm});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TempListDtgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.TempListDtgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TempListDtgv.Location = new System.Drawing.Point(12, 340);
            this.TempListDtgv.Name = "TempListDtgv";
            this.TempListDtgv.RowHeadersVisible = false;
            this.TempListDtgv.RowHeadersWidth = 51;
            this.TempListDtgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TempListDtgv.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempListDtgv.RowTemplate.Height = 24;
            this.TempListDtgv.Size = new System.Drawing.Size(991, 204);
            this.TempListDtgv.TabIndex = 18;
            this.TempListDtgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TempListDtgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TempListDtgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TempListDtgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TempListDtgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TempListDtgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TempListDtgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TempListDtgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.TempListDtgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TempListDtgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempListDtgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TempListDtgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TempListDtgv.ThemeStyle.HeaderStyle.Height = 24;
            this.TempListDtgv.ThemeStyle.ReadOnly = false;
            this.TempListDtgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TempListDtgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TempListDtgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempListDtgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TempListDtgv.ThemeStyle.RowsStyle.Height = 24;
            this.TempListDtgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TempListDtgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TempListDtgv.SelectionChanged += new System.EventHandler(this.TempListDtgv_SelectionChanged);
            // 
            // SelectClm
            // 
            this.SelectClm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SelectClm.HeaderText = "Select";
            this.SelectClm.MinimumWidth = 6;
            this.SelectClm.Name = "SelectClm";
            this.SelectClm.Width = 71;
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
            this.QuantityClm.Width = 112;
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
            // PriceClm
            // 
            this.PriceClm.FillWeight = 43.06221F;
            this.PriceClm.HeaderText = "Price";
            this.PriceClm.MinimumWidth = 6;
            this.PriceClm.Name = "PriceClm";
            this.PriceClm.ReadOnly = true;
            // 
            // CreateDateDtp
            // 
            this.CreateDateDtp.BackColor = System.Drawing.Color.White;
            this.CreateDateDtp.BorderRadius = 4;
            this.CreateDateDtp.BorderThickness = 1;
            this.CreateDateDtp.Checked = true;
            this.CreateDateDtp.FillColor = System.Drawing.Color.White;
            this.CreateDateDtp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CreateDateDtp.Location = new System.Drawing.Point(664, 67);
            this.CreateDateDtp.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CreateDateDtp.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CreateDateDtp.Name = "CreateDateDtp";
            this.CreateDateDtp.Size = new System.Drawing.Size(339, 36);
            this.CreateDateDtp.TabIndex = 19;
            this.CreateDateDtp.Value = new System.DateTime(2023, 5, 13, 20, 57, 45, 837);
            // 
            // FormCreateImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 612);
            this.Controls.Add(this.CreateDateDtp);
            this.Controls.Add(this.TempListDtgv);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TotalPriceTxt);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.QualityTxt);
            this.Controls.Add(this.AuthorTxt);
            this.Controls.Add(this.BookTxt);
            this.Controls.Add(this.UnitLeaderTxt);
            this.Controls.Add(this.DeliveryPersonTxt);
            this.Controls.Add(this.PublisherTxt);
            this.Name = "FormCreateImport";
            this.Text = "Create Import";
            ((System.ComponentModel.ISupportInitialize)(this.TempListDtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox PublisherTxt;
        private Guna.UI2.WinForms.Guna2TextBox DeliveryPersonTxt;
        private Guna.UI2.WinForms.Guna2TextBox UnitLeaderTxt;
        private Guna.UI2.WinForms.Guna2TextBox BookTxt;
        private Guna.UI2.WinForms.Guna2TextBox AuthorTxt;
        private Guna.UI2.WinForms.Guna2TextBox QualityTxt;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTxt;
        private Guna.UI2.WinForms.Guna2TextBox TotalPriceTxt;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2DataGridView TempListDtgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn QualityClm;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceClm;
        private Guna.UI2.WinForms.Guna2DateTimePicker CreateDateDtp;
    }
}