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
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.Text = "Modify Import";
        }


        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;
        #endregion

        #region Methods
        private void LoadImportReportInformation()
        {
            int id = CurrentImportReport.Publisher.Account.id;
            foreach (DTO.Account acc in CurrentPublisherList)
            {
                if (acc.id == id)
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
                cbQuality.Text = ird.quality;
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
        private void TempListDtgv_SelectionChanged(object sender, EventArgs e)
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsAddMode = true;
            dtgvBookList.Rows.Add();
            IsAddMode = false;
            DataGridViewRow tmp = dtgvBookList.Rows[dtgvBookList.Rows.Count - 1];
            Book selectedBook = cbBook.SelectedItem as Book;

            bool isUpdate = false;
            foreach(DataGridViewRow row in dtgvBookList.Rows)
            {
                if (row.Cells["BookClm"].Value == selectedBook.name)
                {
                    isUpdate = true;
                    int quantity = int.Parse(row.Cells["QuantityClm"].Value as string) + (int)nudQuantity.Value;
                    row.Cells["QuantityClm"].Value = quantity.ToString();
                    double? bookPrice = selectedBook.price * int.Parse(row.Cells["QuantityClm"].Value as string);
                    row.Cells["PriceClm"].Value = bookPrice.ToString();
                    dtgvBookList.Rows.Remove(tmp);

                    UpdateTotalPrice();
                    break;
                }
            }

            if (!isUpdate)
            {
                tmp.Cells["BookClm"].Value = selectedBook.name;
                tmp.Cells["BookClm"].Tag = cbBook.SelectedItem;
                tmp.Cells["AuthorClm"].Value = txbAuthor.Text;
                tmp.Cells["QuantityClm"].Value = nudQuantity.Value.ToString();
                tmp.Cells["QualityClm"].Value = cbQuality.Text;
                double? bookprice = selectedBook.price * (double)nudQuantity.Value;
                tmp.Cells["PriceClm"].Value = bookprice.ToString();
                UpdateTotalPrice();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dtgvBookList.SelectedRows.Count == 0) return;
            Book selectedBook = cbBook.SelectedItem as Book;
            foreach (DataGridViewRow dtgvr in dtgvBookList.SelectedRows)
            {
                dtgvr.Cells["BookClm"].Value = selectedBook.name;
                dtgvr.Cells["BookClm"].Tag = selectedBook;
                dtgvr.Cells["AuthorClm"].Value = txbAuthor.Text;
                dtgvr.Cells["QuantityClm"].Value = nudQuantity.Value.ToString();
                dtgvr.Cells["QualityClm"].Value = cbQuality.Text;
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
            ImportReport importReport;
            if (CurrentImportReport == null)
            {
                importReport = new ImportReport();
            }
            else
            {
                importReport = CurrentImportReport;
            }
            if (cbPublisher.SelectedItem == null) return;

            Account account = cbPublisher.SelectedItem as Account;
            importReport.idPublisher = PublisherDAO.Instance.GetPublisherID(account.UserName);
            importReport.DeliveryPerson = txbDeliveryPerson.Text;
            importReport.ImportDate = dtpCreateDate.Value;
            importReport.UnitLeader = txbUnitLeader.Text;

            importReport.TotalPrice = double.Parse(txbTotalPrice.Text);
            int idImport = ImportReportDAO.Instance.CreateImportReport(importReport, CurrentImportReport != null);
            ImportReportDAO.Instance.RemoveAllDetailInImportReport(importReport.id);
            foreach (DataGridViewRow dtgvr in dtgvBookList.Rows)
            {
                ImportReportDetail importReportDetail = new ImportReportDetail();
                Book currentBook = dtgvr.Cells["BookClm"].Tag as Book;
                importReportDetail.idBook = currentBook.id;
                importReportDetail.idImport = idImport;
                importReportDetail.quantity = int.Parse(dtgvr.Cells["QuantityClm"].Value.ToString());
                importReportDetail.quality = dtgvr.Cells["QualityClm"].Value.ToString();
                ImportReportDAO.Instance.CreateImportReportDetail(importReportDetail);
            }

            NavigationEventArgs navigationE = new NavigationEventArgs(new FormImport(), this);
            NavigateBack?.Invoke(this, navigationE);
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbAuthor.Text = (cbBook.SelectedItem as Book).author;
        }
        #endregion
    }
}
