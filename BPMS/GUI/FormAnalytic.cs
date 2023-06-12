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
using System.Windows.Forms;
using BPMS.DAO;
using BPMS.DTO;

namespace BPMS.GUI
{
    public partial class FormAnalytic : Form
    {

        private List<Book> listBook = BookDAO.Instance.GetBookList(); 
        
        public FormAnalytic()
        {
            InitializeComponent();
            LoadData(1, 1, 3);
        }

        private void LoadData(int number, int mode, int GroupBy)
        {
            List<KeyValuePair<DateTime, int>> listExportedBook = ExportReportDAO.Instance.GetNumberOfExportedBook(number, mode, GroupBy);
            List<KeyValuePair<DateTime, int>> listImportedBook = ImportReportDAO.Instance.GetNumberOfImportedBook(number, mode, GroupBy);
            List<KeyValuePair<DateTime, double>> listRevenue = ExportReportDAO.Instance.GetRevenueOfExportedBook(number, mode, GroupBy);

            chartAmountOfBook.Series[0].Points.Clear();
            chartAmountOfBook.Series[1].Points.Clear();
            chartBookName.Series[0].Points.Clear();
            chartTotalMoney.Series[0].Points.Clear();
            switch (number)
            {
                case 1:
                    chartTotalMoney.DataSource = ListKeyDayConverter(listRevenue, 1);
                    ListKeyDayConverter(listExportedBook, 1);
                    ListKeyDayConverter(listImportedBook, 1);
                    break;
                case 7:
                    chartTotalMoney.DataSource = listRevenue;
                    ListKeyDayConverter(listExportedBook, 2);
                    ListKeyDayConverter(listImportedBook, 1);
                    break;
                case 12:
                    chartTotalMoney.DataSource = ListKeyDayConverter(listRevenue, 3);
                    ListKeyDayConverter(listExportedBook, 3);
                    ListKeyDayConverter(listImportedBook, 3);
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
            

            //foreach (var item in listBook)
            //{
            //    chartBookName.DataSource = ExportReportDAO.Instance.GetNumberOfExportedBookByBook();
            //    chartBookName.Series[0].XValueMember = "Key";
            //    chartBookName.Series[0].YValueMembers = "Value";
            //    chartBookName.DataBind();
            //}
            
            chartBookName.Series[0].Points.Add(1, 1);
            chartBookName.Series[0].Points.Add(4, 2);
            chartBookName.Series[0].Points.Add(3, 4);
            chartBookName.Series[0].Points.Add(2, 1);

            chartTotalMoney.Series[0].XValueMember = "Key";
            chartTotalMoney.Series[0].YValueMembers = "Value";
            chartTotalMoney.DataBind();
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
            LoadData(12, 1, 1);
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
                }
                result.Add(new KeyValuePair<string, T>(converted, item.Value));
            }
            return result;
        }
    }
}
