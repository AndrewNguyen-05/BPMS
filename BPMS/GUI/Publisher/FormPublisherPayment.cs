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
    public partial class FormPublisherPayment : Form
    {
        DTO.Publisher currentPublisher = null;
        public FormPublisherPayment()
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
        //It's export for publisher pov but I will leave this for least confusion
        private void LoadImportInfo()
        {
            List<ImportReport> listIr = ImportReportDAO.Instance.GetListImportBill(currentPublisher);
            dtgvImport.Rows.Clear();
            foreach (ImportReport ir in listIr)
            {
                dtgvImport.Rows.Add(new object[] { ir.id
                                                    , ir.Publisher.Account.DisplayName
                                                    , ir.ImportDate
                                                    , ir.TotalPrice
                                                    , ir.idBill != null ? "Number " + ir.idBill.ToString() : "None"});
            }
        }
        private void LoadBillInfo()
        {
            List<Bill> listB = BillDAO.Instance.GetPublisherBill(currentPublisher);
            dtgvBill.Rows.Clear();
            foreach (Bill bi in listB)
            {
                dtgvBill.Rows.Add(new object[] { bi.id
                                                    , bi.type == 1 ? "None" : "Export"
                                                    , bi.Sender
                                                    , bi.Receiver
                                                    , bi.CreateDate
                                                    , bi.Account.DisplayName
                                                    , bi.isPaid == 1 ? "yes" : "no"
                                                    , bi.isReceived == 1 ? "yes" : "no" });
            }
        }

        private void FormPublisherPayment_ParentChanged(object sender, EventArgs e)
        {
            if (GetAccountInfo() == -1) return;
            LoadImportInfo();
            LoadBillInfo();
        }

        private void btnConfirmReceived_Click(object sender, EventArgs e)
        {
            if (dtgvBill.SelectedRows.Count == 0) return;
            foreach (DataGridViewRow dtgvr in dtgvBill.SelectedRows)
            {
                int idBill = (int)dtgvr.Cells["clmIdBill"].Value;
                Bill tmp = BillDAO.Instance.GetBill(idBill);
                tmp.isReceived = 1;
                BillDAO.Instance.CreateBill(tmp);
            }
            LoadBillInfo();

        }

        private void btnCancelReceived_Click(object sender, EventArgs e)
        {
            if (dtgvBill.SelectedRows.Count == 0) return;
            foreach (DataGridViewRow dtgvr in dtgvBill.SelectedRows)
            {
                int idBill = (int)dtgvr.Cells["clmIdBill"].Value;
                Bill tmp = BillDAO.Instance.GetBill(idBill);
                tmp.isReceived = 0;
                BillDAO.Instance.CreateBill(tmp);
            }
            LoadBillInfo();
        }
        private void dtgvBill_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dtgvr in dtgvBill.SelectedRows)
            {
                int idBill = (int)dtgvr.Cells["clmIdBill"].Value;
                Bill tmp = BillDAO.Instance.GetBill(idBill);
                //reset all btn
                btnCancelReceived.Visible = false;
                btnConfirmReceived.Visible = false;
                //(0 = import, 1 = export)                
                //It's export for publisher pov
                //for label 
                ImportReport ir = ImportReportDAO.Instance.GetImportReportFromBill(idBill);
                if (ir != null)
                {
                    lblBillInfo.Text = string.Format("Export Report number {0}, publisher {1} with total price {2}",
                                                    ir.id,
                                                    ir.Publisher.Account.DisplayName,
                                                    ir.TotalPrice);
                }
                else
                {
                    lblBillInfo.Text = "";
                }
                //for button
                if (tmp.isPaid == 1)
                {
                    if (tmp.isReceived == 1)
                    {
                        btnCancelReceived.Visible = true;
                        btnConfirmReceived.Visible = false;
                    }
                    else
                    {
                        btnCancelReceived.Visible = false;
                        btnConfirmReceived.Visible = true;
                    }
                }
            }
        }
    }
}
