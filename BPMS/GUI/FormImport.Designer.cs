﻿using System.Drawing;

namespace BPMS.GUI
{
    partial class FormImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImport));
            this.dtgvImport = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnModify = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvImport
            // 
            this.dtgvImport.AllowUserToAddRows = false;
            this.dtgvImport.AllowUserToDeleteRows = false;
            this.dtgvImport.AllowUserToResizeColumns = false;
            this.dtgvImport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvImport.ColumnHeadersHeight = 35;
            this.dtgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DisplayName,
            this.ImportDate,
            this.DeliveryPerson,
            this.UnitLeader});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvImport.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvImport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvImport.Location = new System.Drawing.Point(17, 98);
            this.dtgvImport.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dtgvImport.MultiSelect = false;
            this.dtgvImport.Name = "dtgvImport";
            this.dtgvImport.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvImport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvImport.RowHeadersVisible = false;
            this.dtgvImport.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvImport.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvImport.RowTemplate.Height = 37;
            this.dtgvImport.Size = new System.Drawing.Size(1316, 694);
            this.dtgvImport.TabIndex = 0;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvImport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvImport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.dtgvImport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvImport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvImport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvImport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvImport.ThemeStyle.HeaderStyle.Height = 35;
            this.dtgvImport.ThemeStyle.ReadOnly = true;
            this.dtgvImport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvImport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvImport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvImport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvImport.ThemeStyle.RowsStyle.Height = 37;
            this.dtgvImport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvImport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ID
            // 
            this.ID.HeaderText = "Import ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // DisplayName
            // 
            this.DisplayName.HeaderText = "Publisher";
            this.DisplayName.MinimumWidth = 8;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // ImportDate
            // 
            this.ImportDate.HeaderText = "Import Date";
            this.ImportDate.MinimumWidth = 8;
            this.ImportDate.Name = "ImportDate";
            this.ImportDate.ReadOnly = true;
            // 
            // DeliveryPerson
            // 
            this.DeliveryPerson.HeaderText = "Delivery Person";
            this.DeliveryPerson.MinimumWidth = 8;
            this.DeliveryPerson.Name = "DeliveryPerson";
            this.DeliveryPerson.ReadOnly = true;
            // 
            // UnitLeader
            // 
            this.UnitLeader.HeaderText = "Unit Leader";
            this.UnitLeader.MinimumWidth = 8;
            this.UnitLeader.Name = "UnitLeader";
            this.UnitLeader.ReadOnly = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderRadius = 17;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1124, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 55);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.BorderRadius = 17;
            this.btnModify.BorderThickness = 1;
            this.btnModify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModify.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.btnModify.FillColor2 = System.Drawing.Color.White;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.Location = new System.Drawing.Point(896, 25);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(207, 55);
            this.btnModify.TabIndex = 34;
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BorderRadius = 17;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Location = new System.Drawing.Point(669, 25);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(207, 55);
            this.btnCreate.TabIndex = 33;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 825);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtgvImport);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FormImport";
            this.Text = "Import";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtgvImport;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitLeader;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnModify;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreate;
    }
}