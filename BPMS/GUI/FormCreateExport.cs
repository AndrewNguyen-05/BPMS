﻿using BPMS.Classes;
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
using System.Windows.Media.TextFormatting;
using BPMS.DAO;
using System.Windows.Controls;
using System.Security.Policy;

namespace BPMS.GUI
{
    public partial class FormCreateExport : Form
    {
        bool IsAddMode = false;
        ExportReport CurrentExportReport = null;
        List<DTO.Account> CurrentAgencyList = AgencyDAO.Instance.GetAgencyAccountList();
        List<DTO.Book> CurrentBookList = BookDAO.Instance.GetBookList();
        public FormCreateExport()
        {
            InitializeComponent();
            cbAgency.DataSource = CurrentAgencyList;
            cbAgency.DisplayMember = "DisplayName";
            cbBook.DataSource = CurrentBookList;
            cbBook.DisplayMember = "name";
            CurrentExportReport = null;
            dtpCreateDate.Value = DateTime.Now;
        }
        public FormCreateExport(ExportReport er)
        {
            InitializeComponent();
            cbAgency.DataSource = CurrentAgencyList;
            cbAgency.DisplayMember = "DisplayName";
            cbBook.DataSource = CurrentBookList;
            cbBook.DisplayMember = "name";
            CurrentExportReport = er;
            LoadExportReportInformation();
            this.Text = "Modify Export";
            dtpCreateDate.Value = DateTime.Now;
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;
        #endregion

        #region Methods
        private void LoadExportReportInformation()
        {
            int id = CurrentExportReport.Agency.Account.id;
            foreach (DTO.Account acc in CurrentAgencyList)
            {
                if (acc.id == id)
                {
                    cbAgency.SelectedIndex = CurrentAgencyList.IndexOf(acc); break;
                }
            }
            txbReceiptPerson.Text = CurrentExportReport.ReceiptPerson;
            dtpCreateDate.Value = CurrentExportReport.ExportDate;

            List<ExportReportDetail> detail = ExportReportDAO.Instance.GetExportDetail(CurrentExportReport);
            foreach (ExportReportDetail erd in detail)
            {
                Book currentBook = BookDAO.Instance.GetBookById(erd.idBook);
                cbBook.SelectedIndex = cbBook.Items.IndexOf(currentBook);
                txbAuthor.Text = currentBook.author;
                nudQuantity.Value = erd.quantity;
                cbQuality.Text = erd.quality;
                btnAdd_Click(null, null);
            }
        }
        private void UpdateTotalPrice()
        {
            double total = 0;
            foreach (DataGridViewRow dtgvr in dtgvBookList.Rows)
            {
                total += double.Parse(dtgvr.Cells["PriceClm"].Value as string);
            }
            txbTotalPrice.Text = total.ToString();
        }
        #endregion

        #region Events
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ExportReport exportReport;
            if (CurrentExportReport == null)
            {
                exportReport = new ExportReport();
            }
            else
            {
                exportReport = CurrentExportReport;
            }
            if (cbAgency.SelectedItem == null) return;

            Account account = cbAgency.SelectedItem as Account;
            exportReport.idAgency = AgencyDAO.Instance.GetAgencyID(account.UserName);
            exportReport.ReceiptPerson = txbReceiptPerson.Text;
            exportReport.ExportDate = dtpCreateDate.Value;

            exportReport.TotalPrice = double.Parse(txbTotalPrice.Text);
            int idExport = ExportReportDAO.Instance.CreateExportReport(exportReport, CurrentExportReport != null);
            ExportReportDAO.Instance.RemoveAllDetailInExportReport(exportReport.id);
            foreach (DataGridViewRow dtgvr in dtgvBookList.Rows)
            {
                ExportReportDetail exportReportDetail = new ExportReportDetail();
                Book currentBook = dtgvr.Cells["BookClm"].Tag as Book;
                exportReportDetail.idBook = currentBook.id;
                exportReportDetail.idExport = idExport;
                exportReportDetail.quantity = int.Parse(dtgvr.Cells["QuantityClm"].Value.ToString());
                exportReportDetail.quality = dtgvr.Cells["QualityClm"].Value.ToString();
                ExportReportDAO.Instance.CreateExportReportDetail(exportReportDetail);
            }


            NavigationEventArgs navigationE = new NavigationEventArgs(new FormExport(), this);
            NavigateBack?.Invoke(this, navigationE);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormExport(), this);
            NavigateBack?.Invoke(this, navigationE);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow tmp = null;
            Book selectedBook = cbBook.SelectedItem as Book;

            foreach (DataGridViewRow dgvr in dtgvBookList.Rows)
            {
                if (dgvr.Cells["BookClm"].Tag != null)
                {
                    if ((dgvr.Cells["BookClm"].Tag as Book).name == selectedBook.name)
                    {
                        nudQuantity.Value += decimal.Parse(dgvr.Cells["QuantityClm"].Value.ToString());
                        tmp = dgvr;
                        break;
                    }
                }
            }
            if (tmp is null)
            {
                IsAddMode = true;
                dtgvBookList.Rows.Add();
                IsAddMode = false;
                tmp = dtgvBookList.Rows[dtgvBookList.Rows.Count - 1];
            }

            tmp.Cells["BookClm"].Value = selectedBook.name;
            tmp.Cells["BookClm"].Tag = cbBook.SelectedItem;
            tmp.Cells["AuthorClm"].Value = txbAuthor.Text;
            tmp.Cells["QuantityClm"].Value = nudQuantity.Value.ToString();
            tmp.Cells["QualityClm"].Value = cbQuality.Text;
            double? bookprice = selectedBook.price * (double)nudQuantity.Value;
            tmp.Cells["PriceClm"].Value = bookprice.ToString();
            UpdateTotalPrice();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dtgvBookList.SelectedRows.Count == 0) return;
            DataGridViewRow tmp = null;
            Book selectedBook = cbBook.SelectedItem as Book;

            foreach (DataGridViewRow dtgvr in dtgvBookList.Rows)
            {
                if (dtgvr.Cells["BookClm"].Tag != null)
                {
                    if ((dtgvr.Cells["BookClm"].Tag as Book).name == selectedBook.name && dtgvr != dtgvBookList.SelectedRows[0])
                    {
                        nudQuantity.Value += decimal.Parse(dtgvr.Cells["QuantityClm"].Value.ToString());
                        dtgvr.Cells["QuantityClm"].Value = nudQuantity.Value.ToString();
                        double? bookprice = selectedBook.price * (double)nudQuantity.Value;
                        dtgvr.Cells["PriceClm"].Value = bookprice.ToString();
                        tmp = dtgvr;
                        dtgvBookList.Rows.Remove(dtgvBookList.SelectedRows[0]);
                        UpdateTotalPrice();
                        break;
                    }
                }
            }

            if (tmp is null)
            {
                tmp = dtgvBookList.SelectedRows[0];
                tmp.Cells["BookClm"].Value = selectedBook.name;
                tmp.Cells["BookClm"].Tag = selectedBook;
                tmp.Cells["AuthorClm"].Value = txbAuthor.Text;
                tmp.Cells["QuantityClm"].Value = nudQuantity.Value.ToString();
                tmp.Cells["QualityClm"].Value = cbQuality.Text;
                double? bookprice = selectedBook.price * (double)nudQuantity.Value;
                tmp.Cells["PriceClm"].Value = bookprice.ToString();
                UpdateTotalPrice();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dtgvr in dtgvBookList.SelectedRows)
            {
                dtgvBookList.Rows.Remove(dtgvr);
            }
        }
        private void dtgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvBookList.SelectedRows.Count == 0) return;
            if (IsAddMode) return;
            DataGridViewRow dtgvr = dtgvBookList.SelectedRows[0];
            if (dtgvr is null) return;
            cbBook.SelectedIndex = cbBook.Items.IndexOf(dtgvr.Cells["BookClm"].Tag);
            txbAuthor.Text = dtgvr.Cells["AuthorClm"].Value.ToString();
            nudQuantity.Value = decimal.Parse(dtgvr.Cells["QuantityClm"].Value.ToString());
            cbQuality.Text = dtgvr.Cells["QualityClm"].Value.ToString();
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbAuthor.Text = (cbBook.SelectedItem as Book).author;
        }
        #endregion


    }
}
