namespace BPMS.GUI
{
    partial class FormAnalytic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartAmountOfBook = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartTotalMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartBookName = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grbAmountOfBook = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblExportBookNumber = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grbAmountOfBookByName = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grbMoney = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnYear = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnDay = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmountOfBook)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMoney)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookName)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.grbAmountOfBook.SuspendLayout();
            this.panel6.SuspendLayout();
            this.grbAmountOfBookByName.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grbMoney.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1194, 660);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartAmountOfBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 154);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel1.Size = new System.Drawing.Size(1188, 248);
            this.panel1.TabIndex = 0;
            // 
            // chartAmountOfBook
            // 
            this.chartAmountOfBook.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea10.Name = "ChartArea1";
            this.chartAmountOfBook.ChartAreas.Add(chartArea10);
            this.chartAmountOfBook.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chartAmountOfBook.Legends.Add(legend10);
            this.chartAmountOfBook.Location = new System.Drawing.Point(20, 10);
            this.chartAmountOfBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartAmountOfBook.Name = "chartAmountOfBook";
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.MarkerSize = 6;
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series13.Name = "Exported Book";
            series13.YValuesPerPoint = 3;
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.MarkerSize = 6;
            series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series14.Name = "Imported Book";
            series14.YValuesPerPoint = 3;
            this.chartAmountOfBook.Series.Add(series13);
            this.chartAmountOfBook.Series.Add(series14);
            this.chartAmountOfBook.Size = new System.Drawing.Size(1148, 228);
            this.chartAmountOfBook.TabIndex = 25;
            this.chartAmountOfBook.Text = "chart2";
            title10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title10.Name = "Title1";
            title10.Text = "Amount Of Imported/Exported Books";
            this.chartAmountOfBook.Titles.Add(title10);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 408);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1188, 249);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartTotalMoney);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel2.Size = new System.Drawing.Size(706, 243);
            this.panel2.TabIndex = 0;
            // 
            // chartTotalMoney
            // 
            this.chartTotalMoney.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea11.Name = "ChartArea1";
            this.chartTotalMoney.ChartAreas.Add(chartArea11);
            this.chartTotalMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            legend11.Name = "Legend1";
            this.chartTotalMoney.Legends.Add(legend11);
            this.chartTotalMoney.Location = new System.Drawing.Point(20, 10);
            this.chartTotalMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTotalMoney.Name = "chartTotalMoney";
            this.chartTotalMoney.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            series15.ChartArea = "ChartArea1";
            series15.Legend = "Legend1";
            series15.Name = "Money";
            this.chartTotalMoney.Series.Add(series15);
            this.chartTotalMoney.Size = new System.Drawing.Size(666, 223);
            this.chartTotalMoney.TabIndex = 17;
            this.chartTotalMoney.Text = "chart1";
            title11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title11.Name = "Title1";
            title11.Text = "Total Amount of Money";
            this.chartTotalMoney.Titles.Add(title11);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartBookName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(715, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel3.Size = new System.Drawing.Size(470, 243);
            this.panel3.TabIndex = 1;
            // 
            // chartBookName
            // 
            this.chartBookName.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea12.Name = "ChartArea1";
            this.chartBookName.ChartAreas.Add(chartArea12);
            this.chartBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            legend12.Name = "Legend1";
            this.chartBookName.Legends.Add(legend12);
            this.chartBookName.Location = new System.Drawing.Point(20, 10);
            this.chartBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartBookName.Name = "chartBookName";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series16.CustomProperties = "PieLabelStyle=Disabled";
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            this.chartBookName.Series.Add(series16);
            this.chartBookName.Size = new System.Drawing.Size(430, 223);
            this.chartBookName.TabIndex = 16;
            this.chartBookName.Text = "chart1";
            title12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title12.Name = "Title1";
            title12.Text = "The Number of Exported Books";
            this.chartBookName.Titles.Add(title12);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 53);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel4.Size = new System.Drawing.Size(1188, 95);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1148, 95);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grbAmountOfBook);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(806, 3);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.panel7.Size = new System.Drawing.Size(339, 89);
            this.panel7.TabIndex = 2;
            // 
            // grbAmountOfBook
            // 
            this.grbAmountOfBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.grbAmountOfBook.Controls.Add(this.lblExportBookNumber);
            this.grbAmountOfBook.Controls.Add(this.label9);
            this.grbAmountOfBook.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.grbAmountOfBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAmountOfBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grbAmountOfBook.ForeColor = System.Drawing.Color.White;
            this.grbAmountOfBook.Location = new System.Drawing.Point(10, 3);
            this.grbAmountOfBook.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.grbAmountOfBook.Name = "grbAmountOfBook";
            this.grbAmountOfBook.Size = new System.Drawing.Size(329, 83);
            this.grbAmountOfBook.TabIndex = 28;
            this.grbAmountOfBook.Text = "Highest Earning";
            // 
            // lblExportBookNumber
            // 
            this.lblExportBookNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExportBookNumber.AutoSize = true;
            this.lblExportBookNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblExportBookNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.lblExportBookNumber.Location = new System.Drawing.Point(3, 62);
            this.lblExportBookNumber.Name = "lblExportBookNumber";
            this.lblExportBookNumber.Size = new System.Drawing.Size(97, 29);
            this.lblExportBookNumber.TabIndex = 1;
            this.lblExportBookNumber.Text = "100000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label9.Location = new System.Drawing.Point(191, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "VND";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grbAmountOfBookByName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(347, 3);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel6.Size = new System.Drawing.Size(453, 89);
            this.panel6.TabIndex = 1;
            // 
            // grbAmountOfBookByName
            // 
            this.grbAmountOfBookByName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.grbAmountOfBookByName.Controls.Add(this.lblBookName);
            this.grbAmountOfBookByName.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.grbAmountOfBookByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAmountOfBookByName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grbAmountOfBookByName.ForeColor = System.Drawing.Color.White;
            this.grbAmountOfBookByName.Location = new System.Drawing.Point(10, 3);
            this.grbAmountOfBookByName.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.grbAmountOfBookByName.Name = "grbAmountOfBookByName";
            this.grbAmountOfBookByName.Size = new System.Drawing.Size(433, 83);
            this.grbAmountOfBookByName.TabIndex = 29;
            this.grbAmountOfBookByName.Text = "Best-selling Book";
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.lblBookName.Location = new System.Drawing.Point(4, 40);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(69, 20);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "100000";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grbMoney);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.panel5.Size = new System.Drawing.Size(338, 89);
            this.panel5.TabIndex = 0;
            // 
            // grbMoney
            // 
            this.grbMoney.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.grbMoney.Controls.Add(this.lblMoney);
            this.grbMoney.Controls.Add(this.label11);
            this.grbMoney.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.grbMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMoney.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grbMoney.ForeColor = System.Drawing.Color.White;
            this.grbMoney.Location = new System.Drawing.Point(0, 3);
            this.grbMoney.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.grbMoney.Name = "grbMoney";
            this.grbMoney.Size = new System.Drawing.Size(328, 83);
            this.grbMoney.TabIndex = 27;
            this.grbMoney.Text = "Highest Earning";
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.lblMoney.Location = new System.Drawing.Point(3, 64);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(97, 29);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "100000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label11.Location = new System.Drawing.Point(191, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "VND";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnYear);
            this.panel8.Controls.Add(this.btnMonth);
            this.panel8.Controls.Add(this.btnDay);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1188, 44);
            this.panel8.TabIndex = 3;
            // 
            // btnYear
            // 
            this.btnYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYear.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(1027, 2);
            this.btnYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(155, 40);
            this.btnYear.TabIndex = 27;
            this.btnYear.Text = "Year";
            // 
            // btnMonth
            // 
            this.btnMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonth.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.Location = new System.Drawing.Point(848, 2);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(150, 40);
            this.btnMonth.TabIndex = 28;
            this.btnMonth.Text = "Month";
            // 
            // btnDay
            // 
            this.btnDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDay.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDay.ForeColor = System.Drawing.Color.White;
            this.btnDay.Location = new System.Drawing.Point(662, 2);
            this.btnDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(157, 40);
            this.btnDay.TabIndex = 29;
            this.btnDay.Text = "Day";
            // 
            // FormAnalytic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 660);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAnalytic";
            this.Text = "Analytic";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAmountOfBook)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMoney)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBookName)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.grbAmountOfBook.ResumeLayout(false);
            this.grbAmountOfBook.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.grbAmountOfBookByName.ResumeLayout(false);
            this.grbAmountOfBookByName.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.grbMoney.ResumeLayout(false);
            this.grbMoney.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmountOfBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalMoney;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2GroupBox grbMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2GroupBox grbAmountOfBookByName;
        private System.Windows.Forms.Label lblBookName;
        private Guna.UI2.WinForms.Guna2GroupBox grbAmountOfBook;
        private System.Windows.Forms.Label lblExportBookNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button btnYear;
        private Guna.UI2.WinForms.Guna2Button btnMonth;
        private Guna.UI2.WinForms.Guna2Button btnDay;
    }
}