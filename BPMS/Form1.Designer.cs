namespace BPMS
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMainPage = new FontAwesome.Sharp.IconButton();
            this.panelLogOut = new System.Windows.Forms.Panel();
            this.cbViewAs = new System.Windows.Forms.ComboBox();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnAnalytic = new FontAwesome.Sharp.IconButton();
            this.btnPayment = new FontAwesome.Sharp.IconButton();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnImport = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.controlMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.controlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogOut.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.panelMenu.Controls.Add(this.btnAccount);
            this.panelMenu.Controls.Add(this.btnMainPage);
            this.panelMenu.Controls.Add(this.panelLogOut);
            this.panelMenu.Controls.Add(this.btnAnalytic);
            this.panelMenu.Controls.Add(this.btnPayment);
            this.panelMenu.Controls.Add(this.btnExport);
            this.panelMenu.Controls.Add(this.btnImport);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(279, 741);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // btnMainPage
            // 
            this.btnMainPage.FlatAppearance.BorderSize = 0;
            this.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainPage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btnMainPage.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnMainPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnMainPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMainPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPage.Location = new System.Drawing.Point(2, 150);
            this.btnMainPage.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMainPage.Size = new System.Drawing.Size(277, 72);
            this.btnMainPage.TabIndex = 2;
            this.btnMainPage.Text = "Home";
            this.btnMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // panelLogOut
            // 
            this.panelLogOut.Controls.Add(this.cbViewAs);
            this.panelLogOut.Controls.Add(this.btnLogOut);
            this.panelLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogOut.Location = new System.Drawing.Point(0, 600);
            this.panelLogOut.Name = "panelLogOut";
            this.panelLogOut.Size = new System.Drawing.Size(279, 141);
            this.panelLogOut.TabIndex = 5;
            // 
            // cbViewAs
            // 
            this.cbViewAs.FormattingEnabled = true;
            this.cbViewAs.Items.AddRange(new object[] {
            "Manager",
            "Accountant",
            "Publisher",
            "Agency"});
            this.cbViewAs.Location = new System.Drawing.Point(20, 22);
            this.cbViewAs.Name = "cbViewAs";
            this.cbViewAs.Size = new System.Drawing.Size(238, 27);
            this.cbViewAs.TabIndex = 1;
            this.cbViewAs.Visible = false;
            this.cbViewAs.SelectedIndexChanged += new System.EventHandler(this.cbViewAs_SelectedIndexChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 42;
            this.btnLogOut.Location = new System.Drawing.Point(43, 59);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(192, 50);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAnalytic
            // 
            this.btnAnalytic.FlatAppearance.BorderSize = 0;
            this.btnAnalytic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btnAnalytic.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnAnalytic.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnAnalytic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnalytic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytic.Location = new System.Drawing.Point(2, 453);
            this.btnAnalytic.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalytic.Name = "btnAnalytic";
            this.btnAnalytic.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAnalytic.Size = new System.Drawing.Size(275, 72);
            this.btnAnalytic.TabIndex = 4;
            this.btnAnalytic.Text = "Analytic";
            this.btnAnalytic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalytic.UseVisualStyleBackColor = true;
            this.btnAnalytic.Click += new System.EventHandler(this.btnAnalytic_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btnPayment.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(2, 377);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPayment.Size = new System.Drawing.Size(275, 72);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnExport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(0, 301);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnExport.Size = new System.Drawing.Size(277, 72);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btnImport.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnImport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(0, 225);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnImport.Size = new System.Drawing.Size(277, 72);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(279, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(279, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            this.pbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLogo_MouseDown);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.controlMinimize);
            this.panelTitleBar.Controls.Add(this.controlClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(279, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1136, 120);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // controlMinimize
            // 
            this.controlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.controlMinimize.FillColor = System.Drawing.Color.White;
            this.controlMinimize.IconColor = System.Drawing.Color.Black;
            this.controlMinimize.Location = new System.Drawing.Point(1037, 3);
            this.controlMinimize.Name = "controlMinimize";
            this.controlMinimize.Size = new System.Drawing.Size(45, 40);
            this.controlMinimize.TabIndex = 3;
            // 
            // controlClose
            // 
            this.controlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlClose.Animated = true;
            this.controlClose.BackColor = System.Drawing.Color.White;
            this.controlClose.FillColor = System.Drawing.Color.White;
            this.controlClose.ForeColor = System.Drawing.Color.Black;
            this.controlClose.IconColor = System.Drawing.Color.Black;
            this.controlClose.Location = new System.Drawing.Point(1088, 3);
            this.controlClose.Name = "controlClose";
            this.controlClose.Size = new System.Drawing.Size(45, 40);
            this.controlClose.TabIndex = 2;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(70, 42);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(69, 23);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 48;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 31);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(48, 48);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(279, 120);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1136, 621);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktop_MouseDown);
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 30;
            this.Elipse.TargetControl = this;
            // 
            // btnAccount
            // 
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(127)))));
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnAccount.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(2, 529);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(275, 72);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Visible = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1415, 741);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainMenu_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panelLogOut.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAnalytic;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton btnImport;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelLogOut;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private Guna.UI2.WinForms.Guna2ControlBox controlMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox controlClose;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton btnMainPage;
        private System.Windows.Forms.ComboBox cbViewAs;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnAccount;
    }
}

