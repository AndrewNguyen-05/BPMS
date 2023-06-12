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
    }
}
