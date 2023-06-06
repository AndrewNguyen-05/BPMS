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
    public partial class FormAgencyPayment : Form
    {
        DTO.Agency currentAgency = null;
        public FormAgencyPayment()
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
        //It's Import for agency pov but I will leave this for least confusion
        private void LoadExportInfo()
        {
            List<ExportReport> listEr = ExportReportDAO.Instance.GetListExportBill(currentAgency);
            dtgvExport.Rows.Clear();
            foreach (ExportReport er in listEr)
            {
                dtgvExport.Rows.Add(new object[] { er.id
                                                    , er.Agency.Account.DisplayName
                                                    , er.ExportDate
                                                    , er.TotalPrice
                                                    , er.idBill != null ?"Number " + er.idBill.ToString() : "None"});
            }
        }

        private void LoadBillInfo()
        {
            List<Bill> listB = BillDAO.Instance.GetAgencyBills(currentAgency);
            dtgvBill.Rows.Clear();
            foreach (Bill bi in listB)
            {
                dtgvBill.Rows.Add(new object[] { bi.id
                                                    , bi.type == 1 ? "Import" : "None"
                                                    , bi.Sender
                                                    , bi.Receiver
                                                    , bi.CreateDate
                                                    , bi.Account.DisplayName
                                                    , bi.isPaid == 1 ? "yes" : "no"
                                                    , bi.isReceived == 1 ? "yes" : "no" });
            }
        }

        private void FormAgencyPayment_ParentChanged(object sender, EventArgs e)
        {
            if (GetAccountInfo() == -1) return;
            LoadExportInfo();
            LoadBillInfo();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dtgvBill.SelectedRows.Count == 0) return;
            foreach (DataGridViewRow dtgvr in dtgvBill.SelectedRows)
            {
                int idBill = (int)dtgvr.Cells["clmIdBill"].Value;
                Bill tmp = BillDAO.Instance.GetBill(idBill);
                tmp.isPaid = 1;
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
                //It's import for agency pov
                //for label 
                ExportReport ir = ExportReportDAO.Instance.GetExportReportFromBill(idBill);
                if (ir != null)
                {
                    lblBillInfo.Text = string.Format("Import Report number {0}, agency {1} with total price {2}",
                                                    ir.id,
                                                    ir.Agency.Account.DisplayName,
                                                    ir.TotalPrice);
                }
                else
                {
                    lblBillInfo.Text = "";
                }
                //for button
                if (tmp.isPaid == 1) { btnCancel.Visible = true; btnPay.Visible = false; }
                else { btnCancel.Visible = false; btnPay.Visible = true; }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dtgvr in dtgvBill.SelectedRows)
            {
                int idBill = (int)dtgvr.Cells["clmIdBill"].Value;
                Bill tmp = BillDAO.Instance.GetBill(idBill);
                tmp.isPaid = 0;
                BillDAO.Instance.CreateBill(tmp);
            }
            LoadBillInfo();
        }
    }
}
