using BPMS.Classes;
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

namespace BPMS.GUI.Publisher
{
    public partial class FormPublisherExport : Form
    {
        DTO.Publisher currentPublisher = null;
        public FormPublisherExport()
        {
            InitializeComponent();
        }
        private int GetAccountInfo()
        {
            Control c = this;
            while (c.GetType() != typeof(FormMainMenu))
            {
                c = c.Parent;
                if (c == null) return -1;
            }
            if (c != null)
            {
                Account tmp = AccountDAO.Instance.GetAccount((c as FormMainMenu).AccountId);
                if (tmp != null)
                {
                    if ((Permissions)tmp.type == Permissions.Admin)
                    {
                        currentPublisher = null;
                    }
                    else
                    {
                        currentPublisher = tmp.Publishers.FirstOrDefault();
                    }
                }
            }
            return 0;
        }
        void LoadData()
        {
            List<ImportReport> listEr = ImportReportDAO.Instance.GetListImportBill(currentPublisher);
            dtgvImport.Rows.Clear();
            foreach (ImportReport ir in listEr)
            {
                dtgvImport.Rows.Add(new object[] { ir.id
                                                    , ir.Publisher.Account.DisplayName
                                                    , ir.ImportDate
                                                    , ir.DeliveryPerson
                                                    , ir.UnitLeader});
            }
        }

        private void FormPublisherExport_ParentChanged(object sender, EventArgs e)
        {
            if (GetAccountInfo() == -1) return;
            LoadData();
        }
    }
}
