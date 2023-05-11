using BPMS.DAO;
using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BPMS.GUI
{
    public partial class FormImport : Form
    {
        public FormImport()
        {
            InitializeComponent();
            LoadData();
        }
        #region Methods
        void LoadData()
        {
            dtgvImport.DataSource = DeliveryReportDAO.Instance.GetDeliveryReports();
        }
        #endregion

        #region Events
        #endregion
    }
}
