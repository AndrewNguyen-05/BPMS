using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using BPMS.DAO;
using BPMS.DTO;
using Guna.UI2.WinForms;

namespace BPMS.GUI
{
    public partial class FormAnalytic : Form
    {        
        public FormAnalytic()
        {
            InitializeComponent();
            lblEarning.Text = "Over the last 1 month";
            lblBestSelling.Text = "Over the last 1 month";
            lblExportedNumber.Text = "Over the last 1 month";
            lblImportedBook.Visible = false;
            lblImportedBookNumber.Visible = false;
            lblImportedBookName.Visible = false;
            lblBestImportedBook.Visible = false;
            lblHighestImported.Visible = false;
            lblImportedMoney.Visible = false;
            chartImportedBookName.Visible = false;
            chartTotalImportedMoney.Visible = false;
            LoadData(1, 1, 3);

            #region Border 

            //Buttons
            Guna2Elipse elipse_day = new Guna2Elipse();
            elipse_day.TargetControl = btnDay;
            elipse_day.BorderRadius = 20;

            Guna2Elipse elipse_month = new Guna2Elipse();
            elipse_month.TargetControl = btnMonth;
            elipse_month.BorderRadius = 20;

            Guna2Elipse elipse_year = new Guna2Elipse();
            elipse_year.TargetControl = btnYear;
            elipse_year.BorderRadius = 20;

            #endregion
        }

        private void LoadData(int number, int mode, int GroupBy)
        {
            #region Amount Exported/Imported Book
            List<Book> listBook = BookDAO.Instance.GetBookList();
            List<KeyValuePair<DateTime, int>> listExportedBook = ExportReportDAO.Instance.GetNumberOfExportedBook(number, mode, GroupBy);
            List<KeyValuePair<DateTime, int>> listImportedBook = ImportReportDAO.Instance.GetNumberOfImportedBook(number, mode, GroupBy);

            chartAmountOfBook.Series[0].Points.Clear();
            chartAmountOfBook.Series[1].Points.Clear();
            foreach (var item in listExportedBook)
            {
                chartAmountOfBook.Series[0].Points.AddXY(item.Key, item.Value);
            }
            foreach (var item in listImportedBook)
            {
                chartAmountOfBook.Series[1].Points.AddXY(item.Key, item.Value);
            }

            #endregion

            #region Export
            List<KeyValuePair<DateTime, double>> listRevenue = ExportReportDAO.Instance.GetRevenueOfExportedBook(number, mode, GroupBy);
            List<KeyValuePair<string, int>> listExBookByName = null;
            listExBookByName = ExportReportDAO.Instance.GetNumberOfExportedBookByBook(number, mode);
            chartExportedBookName.Series[0].Points.Clear();
            chartTotalExportedMoney.Series[0].Points.Clear();
            switch (number)
            {
                case 1:
                    chartTotalExportedMoney.DataSource = ListKeyDayConverter(listRevenue, 4);
                    break;
                case 7:
                    chartTotalExportedMoney.DataSource = ListKeyDayConverter(listRevenue, 5);
                    break;
                case 12:
                    chartTotalExportedMoney.DataSource = ListKeyDayConverter(listRevenue, 3);
                    break;
            }
            chartTotalExportedMoney.Series[0].XValueMember = "Key";
            chartTotalExportedMoney.Series[0].YValueMembers = "Value";
            chartTotalExportedMoney.DataBind();

            chartExportedBookName.DataSource = listExBookByName;
            chartExportedBookName.Series[0].XValueMember = "Key";
            chartExportedBookName.Series[0].YValueMembers = "Value";
            chartExportedBookName.DataBind();

            lblExportedMoney.Text = ExportReportDAO.Instance.GetHighestEarning(number, mode).ToString() + " VND";
            lblExportedBookName.Text = ExportReportDAO.Instance.GetBestSellingBook(number, mode);
            lblExportedBookNumber.Text = ExportReportDAO.Instance.GetLargestAmountExportBook(number, mode).ToString() + " books";
            #endregion

            #region Import
            List<KeyValuePair<DateTime, double>> listImportedPrices = ImportReportDAO.Instance.GetTotalPriceOfImportedBook(number, mode, GroupBy);
            List<KeyValuePair<string, int>> listImBookByName = null;
            listImBookByName = ImportReportDAO.Instance.GetNumberOfImportedBookByBook(number, mode);
            chartImportedBookName.Series[0].Points.Clear();
            chartTotalImportedMoney.Series[0].Points.Clear();
            switch (number)
            {
                case 1:
                    chartTotalImportedMoney.DataSource = ListKeyDayConverter(listImportedPrices, 4);
                    break;
                case 7:
                    chartTotalImportedMoney.DataSource = ListKeyDayConverter(listImportedPrices, 5);
                    break;
                case 12:
                    chartTotalImportedMoney.DataSource = ListKeyDayConverter(listImportedPrices, 3);
                    break;
            }
            chartTotalImportedMoney.Series[0].XValueMember = "Key";
            chartTotalImportedMoney.Series[0].YValueMembers = "Value";
            chartTotalImportedMoney.DataBind();

            chartImportedBookName.DataSource = listImBookByName;
            chartImportedBookName.Series[0].XValueMember = "Key";
            chartImportedBookName.Series[0].YValueMembers = "Value";
            chartImportedBookName.DataBind();

            lblImportedMoney.Text = ImportReportDAO.Instance.GetHighestSpending(number, mode).ToString() + " VND";
            lblImportedBookName.Text = ImportReportDAO.Instance.GetTheMostImportedBook(number, mode);
            lblImportedBookNumber.Text = ImportReportDAO.Instance.GetLargestAmountImportBook(number, mode).ToString() + " books";
            #endregion

            //lblImportBookNumber.Text = ImportReportDAO.Instance.GetLargestAmountImportBook(number, mode).ToString() + " books";
            //Debug.WriteLine("{0}", mode);

            //foreach (KeyValuePair<string, int> items in ExportReportDAO.Instance.GetNumberOfExportedBookByBook(number, mode))
            //{
            //    Debug.WriteLine("{0} - {1}", items.Key, items.Value);
            //}
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            LoadData(7, 0, 0);
            lblEarning.Text = "Over the last 7 days";
            lblBestSelling.Text = "Over the last 7 days";
            lblExportedNumber.Text = "Over the last 7 days";
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            LoadData(1, 1, 3);
            lblEarning.Text = "Over the last 1 month";
            lblBestSelling.Text = "Over the last 1 month";
            lblExportedNumber.Text = "Over the last 1 month";
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            LoadData(1, 2, 1);
            lblEarning.Text = "Over the last 1 year";
            lblBestSelling.Text = "Over the last 1 year";
            lblExportedNumber.Text = "Over the last 1 year";
        }

        public List<KeyValuePair<string, T>> ListKeyDayConverter<T>(List<KeyValuePair<DateTime, T>> list, int mode)
        {
            List<KeyValuePair<string, T>> result = new List<KeyValuePair<string, T>>();
            result.Clear();
            foreach (var item in list)
            {
                string converted = "";
                switch (mode)
                {
                    case 0:
                        converted = string.Format("{0}", item.Key.Date);
                        break;
                    case 1:
                        converted = string.Format("{0}/{1}", item.Key.Month, item.Key.Year);
                        break;
                    case 2:
                        converted = string.Format("{0}", item.Key.Year);
                        break;
                    case 3:
                        converted = string.Format("{0}", item.Key.Month);
                        break;
                    case 4:
                        converted = string.Format("{0}/{1}", item.Key.Day, item.Key.Month);
                        break;
                    case 5:
                        converted = string.Format("{0}/{1}/{2}", item.Key.Day, item.Key.Month, item.Key.Year);
                        break;
                }
                result.Add(new KeyValuePair<string, T>(converted, item.Value));
            }
            return result;
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            if(btnSwitchMode.Text == "Import Statistics")
            {
                //Import
                lblImportedBook.Visible = true;
                lblImportedBookNumber.Visible = true;
                lblImportedBookName.Visible = true;
                lblBestImportedBook.Visible = true;
                lblHighestImported.Visible = true;
                lblImportedMoney.Visible = true;
                chartImportedBookName.Visible = true;
                chartTotalImportedMoney.Visible = true;

                //Export
                lblExportedBook.Visible = false;
                lblExportedBookNumber.Visible = false;
                lblExportedBookName.Visible = false;
                lblBestExportedBook.Visible = false;
                lblHighestExported.Visible = false;
                lblExportedMoney.Visible = false;
                chartExportedBookName.Visible = false;
                chartTotalExportedMoney.Visible = false;

                btnSwitchMode.Text = "Export Statistics";
            } 
            else
            {
                //Import
                lblImportedBook.Visible = false;
                lblImportedBookNumber.Visible = false;
                lblImportedBookName.Visible = false;
                lblBestImportedBook.Visible = false;
                lblHighestImported.Visible = false;
                lblImportedMoney.Visible = false;
                chartImportedBookName.Visible = false;
                chartTotalImportedMoney.Visible = false;

                //Export
                lblExportedBook.Visible = true;
                lblExportedBookNumber.Visible = true;
                lblExportedBookName.Visible = true;
                lblBestExportedBook.Visible = true;
                lblHighestExported.Visible = true;
                lblExportedMoney.Visible = true;
                chartExportedBookName.Visible = true;
                chartTotalExportedMoney.Visible = true;

                btnSwitchMode.Text = "Import Statistics";
            }
           
        }
    }
}
