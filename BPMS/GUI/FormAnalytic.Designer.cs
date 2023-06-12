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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.chartTotalMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartBookName = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2GroupBox6 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chartAmountOfBook = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnYear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDay = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonth = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMoney)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBookName)).BeginInit();
            this.guna2GroupBox6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.guna2GroupBox5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmountOfBook)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            // chartTotalMoney
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalMoney.ChartAreas.Add(chartArea1);
            this.chartTotalMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTotalMoney.Legends.Add(legend1);
            this.chartTotalMoney.Location = new System.Drawing.Point(0, 0);
            this.chartTotalMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTotalMoney.Name = "chartTotalMoney";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Money";
            this.chartTotalMoney.Series.Add(series1);
            this.chartTotalMoney.Size = new System.Drawing.Size(929, 318);
            this.chartTotalMoney.TabIndex = 4;
            this.chartTotalMoney.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Total Amount of Money";
            this.chartTotalMoney.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartTotalMoney);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 318);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartBookName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(938, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 318);
            this.panel3.TabIndex = 8;
            // 
            // chartBookName
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBookName.ChartAreas.Add(chartArea2);
            this.chartBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartBookName.Legends.Add(legend2);
            this.chartBookName.Location = new System.Drawing.Point(0, 0);
            this.chartBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartBookName.Name = "chartBookName";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBookName.Series.Add(series2);
            this.chartBookName.Size = new System.Drawing.Size(396, 318);
            this.chartBookName.TabIndex = 0;
            this.chartBookName.Text = "chart1";
            title2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "The Number of Exported Books";
            this.chartBookName.Titles.Add(title2);
            // 
            // guna2GroupBox6
            // 
            this.guna2GroupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.guna2GroupBox6.Controls.Add(this.label10);
            this.guna2GroupBox6.Controls.Add(this.label11);
            this.guna2GroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.guna2GroupBox6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox6.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox6.Location = new System.Drawing.Point(7, 2);
            this.guna2GroupBox6.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.guna2GroupBox6.Name = "guna2GroupBox6";
            this.guna2GroupBox6.Size = new System.Drawing.Size(382, 132);
            this.guna2GroupBox6.TabIndex = 4;
            this.guna2GroupBox6.Text = "Highest Earning";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label10.Location = new System.Drawing.Point(3, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "100000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label11.Location = new System.Drawing.Point(215, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "VND";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1337, 487);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.Controls.Add(this.guna2GroupBox4);
            this.panel7.Controls.Add(this.guna2GroupBox5);
            this.panel7.Controls.Add(this.guna2GroupBox6);
            this.panel7.Location = new System.Drawing.Point(3, 4);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(394, 479);
            this.panel7.TabIndex = 0;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.guna2GroupBox4.Controls.Add(this.label6);
            this.guna2GroupBox4.Controls.Add(this.label7);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox4.Location = new System.Drawing.Point(6, 340);
            this.guna2GroupBox4.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(382, 135);
            this.guna2GroupBox4.TabIndex = 6;
            this.guna2GroupBox4.Text = "Highest Earning";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label6.Location = new System.Drawing.Point(3, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "100000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label7.Location = new System.Drawing.Point(212, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "VND";
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.guna2GroupBox5.Controls.Add(this.label8);
            this.guna2GroupBox5.Controls.Add(this.label9);
            this.guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.guna2GroupBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox5.Location = new System.Drawing.Point(7, 171);
            this.guna2GroupBox5.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.Size = new System.Drawing.Size(382, 132);
            this.guna2GroupBox5.TabIndex = 5;
            this.guna2GroupBox5.Text = "Highest Earning";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "100000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(165)))));
            this.label9.Location = new System.Drawing.Point(215, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "VND";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.chartAmountOfBook);
            this.panel8.Controls.Add(this.btnYear);
            this.panel8.Controls.Add(this.btnDay);
            this.panel8.Controls.Add(this.btnMonth);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(404, 4);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(930, 479);
            this.panel8.TabIndex = 1;
            // 
            // chartAmountOfBook
            // 
            this.chartAmountOfBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartAmountOfBook.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartAmountOfBook.Legends.Add(legend3);
            this.chartAmountOfBook.Location = new System.Drawing.Point(3, 82);
            this.chartAmountOfBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartAmountOfBook.Name = "chartAmountOfBook";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 6;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Imported Book";
            series3.YValuesPerPoint = 3;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerSize = 6;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Exported Book";
            series4.YValuesPerPoint = 3;
            this.chartAmountOfBook.Series.Add(series3);
            this.chartAmountOfBook.Series.Add(series4);
            this.chartAmountOfBook.Size = new System.Drawing.Size(923, 384);
            this.chartAmountOfBook.TabIndex = 13;
            this.chartAmountOfBook.Text = "chart2";
            title3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Amount Of Imported/Exported Books";
            this.chartAmountOfBook.Titles.Add(title3);
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
            this.btnYear.Location = new System.Drawing.Point(727, 2);
            this.btnYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(200, 71);
            this.btnYear.TabIndex = 12;
            this.btnYear.Text = "Year";
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
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
            this.btnDay.Location = new System.Drawing.Point(316, 2);
            this.btnDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(202, 71);
            this.btnDay.TabIndex = 12;
            this.btnDay.Text = "Day";
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
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
            this.btnMonth.Location = new System.Drawing.Point(525, 2);
            this.btnMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(195, 71);
            this.btnMonth.TabIndex = 12;
            this.btnMonth.Text = "Month";
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1343, 825);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 499);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1337, 322);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Analyze by:";
            // 
            // FormAnalytic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 825);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAnalytic";
            this.Text = "Analytic";
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMoney)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartBookName)).EndInit();
            this.guna2GroupBox6.ResumeLayout(false);
            this.guna2GroupBox6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmountOfBook)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalMoney;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmountOfBook;
        private Guna.UI2.WinForms.Guna2Button btnYear;
        private Guna.UI2.WinForms.Guna2Button btnDay;
        private Guna.UI2.WinForms.Guna2Button btnMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBookName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
    }
}