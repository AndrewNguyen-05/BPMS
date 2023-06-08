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

namespace BPMS.GUI.Agency
{
    public partial class FormAgencyImport : Form
    {
        DTO.Agency currentAgency = null;
        public FormAgencyImport()
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
                        currentAgency = null;
                    }
                    else
                    {
                        currentAgency = tmp.Agencies.FirstOrDefault();
                    }
                }
            }
            return 0;
        }
        void LoadData()
        {
            List<ExportReport> listEr = ExportReportDAO.Instance.GetListExportBill(currentAgency);
            dtgvExport.Rows.Clear();
            foreach (ExportReport er in listEr)
            {
                dtgvExport.Rows.Add(new object[] { er.id
                                                    , er.Agency.Account.DisplayName
                                                    , er.ExportDate
                                                    , er.ReceiptPerson});
            }
        }
        private void FormAgencyImport_ParentChanged(object sender, EventArgs e)
        {
            if (GetAccountInfo() == -1) return;
            LoadData();
        }
    }
}
