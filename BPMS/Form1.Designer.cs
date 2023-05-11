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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnImport = new FontAwesome.Sharp.IconButton();
            this.btnExport = new FontAwesome.Sharp.IconButton();
            this.btnPayment = new FontAwesome.Sharp.IconButton();
            this.btnAnalytic = new FontAwesome.Sharp.IconButton();
            this.panelLogOut = new System.Windows.Forms.Panel();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelLogo1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panelLogOut);
            this.panelMenu.Controls.Add(this.btnAnalytic);
            this.panelMenu.Controls.Add(this.btnPayment);
            this.panelMenu.Controls.Add(this.btnExport);
            this.panelMenu.Controls.Add(this.btnImport);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(288, 741);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.labelLogo1);
            this.panelLogo.Controls.Add(this.guna2PictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(288, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(288, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1127, 120);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnImport.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnImport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(-2, 153);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnImport.Size = new System.Drawing.Size(288, 72);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnExport.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.btnExport.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(-1, 229);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnExport.Size = new System.Drawing.Size(288, 72);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btnPayment.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(-2, 305);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPayment.Size = new System.Drawing.Size(288, 72);
            this.btnPayment.TabIndex = 3;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnAnalytic
            // 
            this.btnAnalytic.FlatAppearance.BorderSize = 0;
            this.btnAnalytic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytic.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalytic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(23)))), ((int)(((byte)(55)))));
            this.btnAnalytic.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnAnalytic.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(114)))), ((int)(((byte)(133)))));
            this.btnAnalytic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnalytic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytic.Location = new System.Drawing.Point(-1, 381);
            this.btnAnalytic.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalytic.Name = "btnAnalytic";
            this.btnAnalytic.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAnalytic.Size = new System.Drawing.Size(288, 72);
            this.btnAnalytic.TabIndex = 4;
            this.btnAnalytic.Text = "Analytic";
            this.btnAnalytic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalytic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalytic.UseVisualStyleBackColor = true;
            // 
            // panelLogOut
            // 
            this.panelLogOut.Controls.Add(this.btnLogOut);
            this.panelLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogOut.Location = new System.Drawing.Point(0, 600);
            this.panelLogOut.Name = "panelLogOut";
            this.panelLogOut.Size = new System.Drawing.Size(288, 141);
            this.panelLogOut.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnLogOut.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(40, 55);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(192, 50);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(124, 120);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // labelLogo1
            // 
            this.labelLogo1.AutoSize = true;
            this.labelLogo1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo1.Location = new System.Drawing.Point(131, 9);
            this.labelLogo1.Name = "labelLogo1";
            this.labelLogo1.Size = new System.Drawing.Size(157, 26);
            this.labelLogo1.TabIndex = 1;
            this.labelLogo1.Text = "BOOK PUBLISH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "SYSTEM";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 48;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 31);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(48, 48);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.Location = new System.Drawing.Point(70, 42);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(78, 28);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "HOME";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 741);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelLogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAnalytic;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconButton btnExport;
        private FontAwesome.Sharp.IconButton btnImport;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelLogOut;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogo1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
    }
}

