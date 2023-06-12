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

namespace BPMS.GUI
{
    public partial class FormAnalytic : Form
    {
        public FormAnalytic()
        {
            InitializeComponent();

        }

        private void FormAnalytic_Load(object sender, EventArgs e)
        {
            LoadData(12,1,2);
        }

        private void LoadData(int number, int mode, int GroupBy)
        {
            chartAmountOfBook.Series[0].Points.Clear();
            chartAmountOfBook.Series[1].Points.Clear();
            foreach (var item in ExportReportDAO.Instance.GetNumberOfExportedBook(number, mode, GroupBy))
            {
                chartAmountOfBook.Series[0].Points.AddXY(item.Key, item.Value);
            }
            foreach (var item in ImportReportDAO.Instance.GetNumberOfImportedBook(number, mode, GroupBy))
            {
                chartAmountOfBook.Series[1].Points.AddXY(item.Key, item.Value);
            }
            chartBookName.Series[0].Points.Clear();
            chartBookName.Series[0].Points.Add(1, 1);
            chartBookName.Series[0].Points.Add(4, 2);
            chartBookName.Series[0].Points.Add(3, 4);
            chartBookName.Series[0].Points.Add(2, 1);

            chartTotalMoney.Series[0].Points.AddXY(1, 2);
            chartTotalMoney.Series[0].Points.AddXY(3, 4);
            chartTotalMoney.Series[0].Points.AddXY(2, 1);
            chartTotalMoney.Series[0].Points.AddXY(0, 3);
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
                }
                result.Add(new KeyValuePair<string, T>(converted, item.Value));
            }
            return result;
        }
    }
}
