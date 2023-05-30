using BPMS.Classes;
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

namespace BPMS.GUI
{
    public partial class FormCreateImport : Form
    {
        bool IsAddMode = false;
        ImportReport CurrentImportReport = null;
        List<DTO.Account> CurrentPublisherList = PublisherDAO.Instance.GetPublisherAccountList();
        List<DTO.Book> CurrentBookList = BookDAO.Instance.GetBookList();
        public FormCreateImport()
        {
            InitializeComponent();
            cbPublisher.DataSource = CurrentPublisherList;
            cbPublisher.DisplayMember = "DisplayName";
            cbBook.DataSource = CurrentBookList;
            cbBook.DisplayMember = "name";
            CurrentImportReport = null;
        }

        public FormCreateImport(ImportReport ir)
        {
            InitializeComponent();
            cbPublisher.DataSource = CurrentPublisherList;
            cbPublisher.DisplayMember = "DisplayName";
            cbBook.DataSource = CurrentBookList;
            cbBook.DisplayMember = "name";
            CurrentImportReport = ir;
            LoadImportReportInformation();
        }


        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;
        #endregion
        private void LoadImportReportInformation()
        {
            foreach (DTO.Account acc in CurrentPublisherList) 
            {
                if (acc.id == CurrentImportReport.Publisher.Account.id)
                {
                    cbPublisher.SelectedIndex = CurrentPublisherList.IndexOf(acc); break;
                }
            }
            txbDeliveryPerson.Text = CurrentImportReport.DeliveryPerson;
            txbUnitLeader.Text = CurrentImportReport.UnitLeader;
            dtpCreateDate.Value = CurrentImportReport.ImportDate;

            List<ImportReportDetail> detail = ImportReportDAO.Instance.GetImportDetail(CurrentImportReport);
            foreach (ImportReportDetail ird in detail)
            {
                Book currentBook = BookDAO.Instance.GetBookById(ird.idBook);
                cbBook.SelectedIndex = cbBook.Items.IndexOf(currentBook);
                txbAuthor.Text = currentBook.author;
                nudQuantity.Value = ird.quantity;
                txbQuality.Text = ird.quality; 
            }
        }
        private void UpdateTotalPrice()
        {
            double total = 0;
            foreach(DataGridViewRow dtgvr in dtgvBookList.Rows)
            {
                total += double.Parse(dtgvr.Cells["PriceClm"].Value as string);
            }
            txbTotalPrice.Text = total.ToString();
        }
        private void TempListDtgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvBookList.SelectedRows.Count == 0) return;
            if (IsAddMode) return;
            DataGridViewRow dtgvr = dtgvBookList.SelectedRows[0];
            if (dtgvr is null) return;
            cbBook.SelectedIndex = cbBook.Items.IndexOf(dtgvr.Cells["BookClm"].Tag);
            txbAuthor.Text = dtgvr.Cells["AuthorClm"].Value.ToString();
            nudQuantity.Value = decimal.Parse(dtgvr.Cells["QuantityClm"].Value.ToString());
            txbQuality.Text = dtgvr.Cells["QualityClm"].Value.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsAddMode = true;
            dtgvBookList.Rows.Add();
            IsAddMode = false;
            DataGridViewRow tmp = dtgvBookList.Rows[dtgvBookList.Rows.Count - 1];
            Book selectedBook = cbBook.SelectedItem as Book;
            tmp.Cells["BookClm"].Value = selectedBook.name;
            tmp.Cells["BookClm"].Tag = cbBook.SelectedItem;
            tmp.Cells["AuthorClm"].Value = txbAuthor.Text;
            tmp.Cells["QuantityClm"].Value = nudQuantity.Value.ToString();
            tmp.Cells["QualityClm"].Value = txbQuality.Text;
            double? bookprice = selectedBook.price * (double)nudQuantity.Value;
            tmp.Cells["PriceClm"].Value = bookprice.ToString();
            UpdateTotalPrice();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dtgvBookList.SelectedRows.Count == 0) return;
            Book selectedBook = cbBook.SelectedItem as Book;
            foreach (DataGridViewRow dtgvr in dtgvBookList.SelectedRows)
            {
                dtgvr.Cells["BookClm"].Value = selectedBook.name;
                dtgvr.Cells["AuthorClm"].Value = txbAuthor.Text;
                dtgvr.Cells["QuantityClm"].Value = nudQuantity.Value.ToString();
                dtgvr.Cells["QualityClm"].Value = txbQuality.Text;
                double? bookprice = selectedBook.price * (double)nudQuantity.Value;
                dtgvr.Cells["PriceClm"].Value = bookprice.ToString();
            }
            UpdateTotalPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dtgvr in dtgvBookList.SelectedRows)
            {
                dtgvBookList.Rows.Remove(dtgvr);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormImport(), this);
            NavigateBack?.Invoke(this, navigationE);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ImportReport importReport = new ImportReport();
            if (cbPublisher.SelectedItem == null) return;
            Account account = cbPublisher.SelectedItem as Account; 
            importReport.idPublisher = PublisherDAO.Instance.GetPublisherID(account.UserName);
            importReport.DeliveryPerson = txbDeliveryPerson.Text;
            importReport.ImportDate = dtpCreateDate.Value;
            importReport.UnitLeader = txbUnitLeader.Text;
            if(!double.TryParse(txbTotalPrice.Text, out double totalPrice))
            {
                System.Windows.Forms.MessageBox.Show("Lỗi! Tổng giá tiền không đúng định dạng!", "Thông báo lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            Book selectedBook = cbBook.SelectedItem as Book;
            importReport.TotalPrice = double.Parse(txbTotalPrice.Text); 
            int idImport = ImportReportDAO.Instance.CreateImportReport(importReport);
            foreach (DataGridViewRow dtgvr in dtgvBookList.Rows)
            {
                ImportReportDetail importReportDetail = new ImportReportDetail();
                importReportDetail.idBook = selectedBook.id;
                importReportDetail.idImport = idImport;
                importReportDetail.quantity = (int)nudQuantity.Value;
                importReportDetail.quality = txbQuality.Text;
                ImportReportDAO.Instance.CreateImportReportDetail(importReportDetail);
            }
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormImport(), this);
            NavigateBack?.Invoke(this, navigationE);
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbAuthor.Text = (cbBook.SelectedItem as Book).author;
        }
    }
}
