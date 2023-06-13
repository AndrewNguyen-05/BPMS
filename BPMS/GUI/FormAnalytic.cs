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
            List<Book> listBook = BookDAO.Instance.GetBookList();
            List<KeyValuePair<DateTime, int>> listExportedBook = ExportReportDAO.Instance.GetNumberOfExportedBook(number, mode, GroupBy);
            List<KeyValuePair<DateTime, int>> listImportedBook = ImportReportDAO.Instance.GetNumberOfImportedBook(number, mode, GroupBy);
            List<KeyValuePair<DateTime, double>> listRevenue = ExportReportDAO.Instance.GetRevenueOfExportedBook(number, mode, GroupBy);
            List<KeyValuePair<string, int>> listExBookByName = null;
            listExBookByName = ExportReportDAO.Instance.GetNumberOfExportedBookByBook(number, mode);

            chartAmountOfBook.Series[0].Points.Clear();
            chartAmountOfBook.Series[1].Points.Clear();
            chartBookName.Series[0].Points.Clear();
            chartTotalMoney.Series[0].Points.Clear();
            switch (number)
            {
                case 1:
                    chartTotalMoney.DataSource = ListKeyDayConverter(listRevenue, 4);
                    break;
                case 7:
                    chartTotalMoney.DataSource = ListKeyDayConverter(listRevenue, 5);
                    break;
                case 12:
                    chartTotalMoney.DataSource = ListKeyDayConverter(listRevenue, 3);
                    break;
            }
            foreach (var item in listExportedBook)
            {
                chartAmountOfBook.Series[0].Points.AddXY(item.Key, item.Value);
            }
            foreach (var item in listImportedBook)
            {
                chartAmountOfBook.Series[1].Points.AddXY(item.Key, item.Value);
            }

            chartTotalMoney.Series[0].XValueMember = "Key";
            chartTotalMoney.Series[0].YValueMembers = "Value";
            chartTotalMoney.DataBind();

            chartBookName.DataSource = listExBookByName;
            chartBookName.Series[0].XValueMember = "Key";
            chartBookName.Series[0].YValueMembers = "Value";
            chartBookName.DataBind();

            lblMoney.Text = ExportReportDAO.Instance.GetHighestEarning(number, mode).ToString() + " VND";
            lblBookName.Text = ExportReportDAO.Instance.GetBestSellingBook(number, mode);
            lblExportBookNumber.Text = ExportReportDAO.Instance.GetLargestAmountExportBook(number, mode).ToString() + " books";
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
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            LoadData(1, 1, 3);
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            LoadData(1, 2, 1);
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
    }
}
