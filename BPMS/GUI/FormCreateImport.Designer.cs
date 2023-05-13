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
            this.NameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.PublisherTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeliveryPersonTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignatureTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UnitLeaderTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.BookTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AuthorTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.QualityTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.QuantityTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.TotalPriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnModify = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // NameTxt
            // 
            this.NameTxt.BorderColor = System.Drawing.Color.Black;
            this.NameTxt.BorderRadius = 8;
            this.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxt.DefaultText = "";
            this.NameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NameTxt.ForeColor = System.Drawing.Color.Black;
            this.NameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.Location = new System.Drawing.Point(13, 15);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PasswordChar = '\0';
            this.NameTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.NameTxt.PlaceholderText = "Name";
            this.NameTxt.SelectedText = "";
            this.NameTxt.Size = new System.Drawing.Size(591, 40);
            this.NameTxt.TabIndex = 0;
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
            this.PublisherTxt.Location = new System.Drawing.Point(612, 15);
            this.PublisherTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PublisherTxt.Name = "PublisherTxt";
            this.PublisherTxt.PasswordChar = '\0';
            this.PublisherTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PublisherTxt.PlaceholderText = "Publisher";
            this.PublisherTxt.SelectedText = "";
            this.PublisherTxt.Size = new System.Drawing.Size(393, 40);
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
            // DateTxt
            // 
            this.DateTxt.BorderColor = System.Drawing.Color.Black;
            this.DateTxt.BorderRadius = 8;
            this.DateTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DateTxt.DefaultText = "";
            this.DateTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DateTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DateTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DateTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DateTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DateTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateTxt.ForeColor = System.Drawing.Color.Black;
            this.DateTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DateTxt.Location = new System.Drawing.Point(665, 67);
            this.DateTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DateTxt.Name = "DateTxt";
            this.DateTxt.PasswordChar = '\0';
            this.DateTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.DateTxt.PlaceholderText = "Date";
            this.DateTxt.SelectedText = "";
            this.DateTxt.Size = new System.Drawing.Size(340, 40);
            this.DateTxt.TabIndex = 3;
            // 
            // SignatureTxt
            // 
            this.SignatureTxt.BorderColor = System.Drawing.Color.Black;
            this.SignatureTxt.BorderRadius = 8;
            this.SignatureTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignatureTxt.DefaultText = "";
            this.SignatureTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SignatureTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SignatureTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignatureTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SignatureTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignatureTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SignatureTxt.ForeColor = System.Drawing.Color.Black;
            this.SignatureTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SignatureTxt.Location = new System.Drawing.Point(13, 119);
            this.SignatureTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SignatureTxt.Name = "SignatureTxt";
            this.SignatureTxt.PasswordChar = '\0';
            this.SignatureTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.SignatureTxt.PlaceholderText = "Signature";
            this.SignatureTxt.SelectedText = "";
            this.SignatureTxt.Size = new System.Drawing.Size(579, 40);
            this.SignatureTxt.TabIndex = 4;
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
            this.UnitLeaderTxt.Location = new System.Drawing.Point(600, 119);
            this.UnitLeaderTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnitLeaderTxt.Name = "UnitLeaderTxt";
            this.UnitLeaderTxt.PasswordChar = '\0';
            this.UnitLeaderTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UnitLeaderTxt.PlaceholderText = "Unit Leader";
            this.UnitLeaderTxt.SelectedText = "";
            this.UnitLeaderTxt.Size = new System.Drawing.Size(405, 40);
            this.UnitLeaderTxt.TabIndex = 5;
            // 
            // IDTxt
            // 
            this.IDTxt.BorderColor = System.Drawing.Color.Black;
            this.IDTxt.BorderRadius = 8;
            this.IDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTxt.DefaultText = "";
            this.IDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IDTxt.ForeColor = System.Drawing.Color.Black;
            this.IDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.Location = new System.Drawing.Point(13, 199);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.PasswordChar = '\0';
            this.IDTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.IDTxt.PlaceholderText = "ID";
            this.IDTxt.SelectedText = "";
            this.IDTxt.Size = new System.Drawing.Size(236, 40);
            this.IDTxt.TabIndex = 6;
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
            this.BookTxt.Location = new System.Drawing.Point(257, 199);
            this.BookTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BookTxt.Name = "BookTxt";
            this.BookTxt.PasswordChar = '\0';
            this.BookTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BookTxt.PlaceholderText = "Book";
            this.BookTxt.SelectedText = "";
            this.BookTxt.Size = new System.Drawing.Size(447, 40);
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
            this.AuthorTxt.Location = new System.Drawing.Point(712, 199);
            this.AuthorTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AuthorTxt.Name = "AuthorTxt";
            this.AuthorTxt.PasswordChar = '\0';
            this.AuthorTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.AuthorTxt.PlaceholderText = "Author";
            this.AuthorTxt.SelectedText = "";
            this.AuthorTxt.Size = new System.Drawing.Size(293, 40);
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
            this.QualityTxt.Location = new System.Drawing.Point(13, 251);
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
            this.QuantityTxt.Location = new System.Drawing.Point(389, 251);
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
            this.TotalPriceTxt.Location = new System.Drawing.Point(553, 251);
            this.TotalPriceTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TotalPriceTxt.Name = "TotalPriceTxt";
            this.TotalPriceTxt.PasswordChar = '\0';
            this.TotalPriceTxt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TotalPriceTxt.PlaceholderText = "TotalPrice";
            this.TotalPriceTxt.SelectedText = "";
            this.TotalPriceTxt.Size = new System.Drawing.Size(452, 40);
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
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 340);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(992, 97);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.btnCancel.Location = new System.Drawing.Point(679, 442);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 36);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "CANCEL";
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
            this.btnConfirm.Location = new System.Drawing.Point(846, 442);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(160, 36);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "CONFIRM";
            // 
            // FormCreateImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 488);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TotalPriceTxt);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.QualityTxt);
            this.Controls.Add(this.AuthorTxt);
            this.Controls.Add(this.BookTxt);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.UnitLeaderTxt);
            this.Controls.Add(this.SignatureTxt);
            this.Controls.Add(this.DateTxt);
            this.Controls.Add(this.DeliveryPersonTxt);
            this.Controls.Add(this.PublisherTxt);
            this.Controls.Add(this.NameTxt);
            this.Name = "FormCreateImport";
            this.Text = "Create Import";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox NameTxt;
        private Guna.UI2.WinForms.Guna2TextBox PublisherTxt;
        private Guna.UI2.WinForms.Guna2TextBox DeliveryPersonTxt;
        private Guna.UI2.WinForms.Guna2TextBox DateTxt;
        private Guna.UI2.WinForms.Guna2TextBox SignatureTxt;
        private Guna.UI2.WinForms.Guna2TextBox UnitLeaderTxt;
        private Guna.UI2.WinForms.Guna2TextBox IDTxt;
        private Guna.UI2.WinForms.Guna2TextBox BookTxt;
        private Guna.UI2.WinForms.Guna2TextBox AuthorTxt;
        private Guna.UI2.WinForms.Guna2TextBox QualityTxt;
        private Guna.UI2.WinForms.Guna2TextBox QuantityTxt;
        private Guna.UI2.WinForms.Guna2TextBox TotalPriceTxt;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnModify;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
    }
}