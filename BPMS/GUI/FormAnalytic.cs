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

        }

        private void LoadData()
        {
            chartAmountOfBook.Series[0].Points.Clear();
            chartAmountOfBook.Series[1].Points.Clear();
            foreach (var item in ExportReportDAO.Instance.GetNumberOfExportedBook())
            {
                //chartAmountOfBook.Series[0].Points.AddXY(item.Date, item.TotalAmount);
            }
        }
    }
}
