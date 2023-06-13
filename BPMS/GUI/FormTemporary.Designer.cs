namespace BPMS.GUI
{
    partial class FormTemporary
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
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTotalMoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Analyze by:";
            // 
            // chartTotalMoney
            // 
            chartArea10.Name = "ChartArea1";
            this.chartTotalMoney.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartTotalMoney.Legends.Add(legend10);
            this.chartTotalMoney.Location = new System.Drawing.Point(-62, 181);
            this.chartTotalMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartTotalMoney.Name = "chartTotalMoney";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Money";
            this.chartTotalMoney.Series.Add(series10);
            this.chartTotalMoney.Size = new System.Drawing.Size(826, 254);
            this.chartTotalMoney.TabIndex = 16;
            this.chartTotalMoney.Text = "chart1";
            title10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title10.Name = "Title1";
            title10.Text = "Total Amount of Money";
            this.chartTotalMoney.Titles.Add(title10);
            // 
            // FormTemporary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 646);
            this.Controls.Add(this.chartTotalMoney);
            this.Controls.Add(this.label1);
            this.Name = "FormTemporary";
            this.Text = "FormTemporary";
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalMoney;
    }
}