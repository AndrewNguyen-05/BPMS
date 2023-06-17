using BPMS.Classes;
using BPMS.DAO;
using BPMS.DTO;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;


namespace BPMS.GUI
{
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
            tabPayment_SelectedIndexChanged(null, null);
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler InnerFormNavigating;
        #endregion

        #region Methods
        private void LoadImportInfo()
        {
            List<ImportReport> listIr = ImportReportDAO.Instance.GetListImportBill();
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

        private void LoadExportInfo()
        {
            List<ExportReport> listEr = ExportReportDAO.Instance.GetListExportBill();
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
            List<Bill> listB = BillDAO.Instance.GetBills();
            dtgvBill.Rows.Clear();
            foreach (Bill bi in listB)
            {
                dtgvBill.Rows.Add(new object[] { bi.id
                                                    , bi.type == 1 ? "Export" : "Import"
                                                    , bi.Sender
                                                    , bi.Receiver
                                                    , bi.CreateDate
                                                    , bi.Account.DisplayName
                                                    , bi.isPaid == 1 ? "yes" : "no"
                                                    , bi.isReceived == 1 ? "yes" : "no" });
            }
        }
        #endregion

        #region Events
        private void tabPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPayment.SelectedTab.Text == "Import")
            {
                LoadImportInfo();
            }
            else if (tabPayment.SelectedTab.Text == "Export")
            {
                LoadExportInfo();
            }
            else if (tabPayment.SelectedTab.Text == "Bill")
            {
                LoadBillInfo();
            }
        }

        #region Navigation
        private void btnCreateImport_Click(object sender, EventArgs e)
        {
            if (dtgvImport.Rows.Count == 0) return;
            ImportReport importReport = ImportReportDAO.Instance.GetImportReport(int.Parse(dtgvImport.SelectedRows[0].Cells["clmIdImport"].Value.ToString()));
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateBill(importReport), this);
            InnerFormNavigating?.Invoke(this, navigationE);
            
        }

        #endregion

        private void btnCreateExport_Click(object sender, EventArgs e)
        {
            if (dtgvExport.Rows.Count == 0) return;
            ExportReport exportReport = ExportReportDAO.Instance.GetExportReport(int.Parse(dtgvExport.SelectedRows[0].Cells["clmIdExport"].Value.ToString()));
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateBill(exportReport), this);
            InnerFormNavigating?.Invoke(this, navigationE);
           
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dtgvBill.SelectedRows.Count == 0) return;
            Bill bill = BillDAO.Instance.GetBill(int.Parse(dtgvBill.SelectedRows[0].Cells["clmIdBill"].Value.ToString()));
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateBill(bill), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this import form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            foreach (DataGridViewRow dtgvr in dtgvBill.SelectedRows)
            {
                int id = int.Parse(dtgvBill.SelectedRows[0].Cells["clmIdBill"].Value.ToString());
                BillDAO.Instance.DeleteBill(id);
            }
            LoadBillInfo();
        }
        //for payment of export type
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

        //for payment of import type
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtgvBill.SelectedRows.Count == 0) return;
            foreach (DataGridViewRow dtgvr in dtgvBill.SelectedRows)
            {
                int idBill = (int)dtgvr.Cells["clmIdBill"].Value;
                Bill tmp = BillDAO.Instance.GetBill(idBill);
                FormPrintBill fpb = new FormPrintBill(tmp);
                fpb.ShowDialog();
            }
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
                btnCancel.Visible = false;
                btnPay.Visible = false;
                //(0 = import, 1 = export)
                if (tmp.type == 0)
                {
                    //for label 
                    ImportReport ir = ImportReportDAO.Instance.GetImportReportFromBill(idBill);
                    if (ir != null)
                    {
                        lblBillInfo.Text = string.Format("Import Report number {0}, publisher {1} with total price {2}",
                                                        ir.id,
                                                        ir.Publisher.Account.DisplayName,
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
                else if (tmp.type == 1)
                {
                    //for label 
                    ExportReport ir = ExportReportDAO.Instance.GetExportReportFromBill(idBill);
                    if (ir != null)
                    {
                        lblBillInfo.Text = string.Format("Export Report number {0}, agency {1} with total price {2}",
                                                        ir.id,
                                                        ir.Agency.Account.DisplayName,
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


        #endregion


    }
}
