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
        BPMSDatabase db = new BPMSDatabase();
        public FormImport()
        {
            InitializeComponent();
            LoadData();
        }
        #region Methods
        void LoadData()
        {
            var result = from c in db.DeliveryReports
                         select c;

            dtgvImport.DataSource = result.ToList();
        }
        #endregion

        #region Events
        #endregion
    }
}
