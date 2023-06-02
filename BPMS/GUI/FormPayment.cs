﻿using BPMS.Classes;
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
                                                    , ir.idBill != null ? ir.Bill.ToString() : "none"});
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
                                                    , er.idBill != null ? er.Bill.ToString() : "none"});
            }
        }

        private void LoadBillInfo()
        {
            List<Bill> listB = BillDAO.Instance.GetBills();
            dtgvExport.Rows.Clear();
            foreach (Bill b in listB)
            {
                dtgvExport.Rows.Add(new object[] { b.id
                                                    , AccountDAO.Instance.GetAccount(b.idSender).DisplayName
                                                    , AccountDAO.Instance.GetAccount(b.idReceiver).DisplayName
                                                    , b.CreateDate
                                                    , b.isPaid == 1 ? "yes" : "no"
                                                    , b.isReceived == 1 ? "yes" : "no" });
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
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateBill(), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }


        private void btnCreateExport_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateBill(), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }

        #endregion

        #endregion
    }
}
