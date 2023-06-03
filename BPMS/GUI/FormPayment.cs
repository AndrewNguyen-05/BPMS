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
            List<ImportReport> listIr = BillDAO.Instance.GetListImportBill();
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
            List<ExportReport> listEr = BillDAO.Instance.GetListExportBill();
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

        #endregion


    }
}
