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
        public FormCreateImport()
        {
            InitializeComponent();
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;
        #endregion
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
            txbBook.Text = dtgvr.Cells["BookClm"].Value.ToString();
            txbAuthor.Text = dtgvr.Cells["AuthorClm"].Value.ToString();
            txbQuantity.Text = dtgvr.Cells["QuantityClm"].Value.ToString();
            txbQuality.Text = dtgvr.Cells["QualityClm"].Value.ToString();
            txbTotalPrice.Text = dtgvr.Cells["PriceClm"].Value.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsAddMode = true;
            dtgvBookList.Rows.Add();
            IsAddMode = false;
            DataGridViewRow tmp = dtgvBookList.Rows[dtgvBookList.Rows.Count - 1];
            tmp.Cells["BookClm"].Value = txbBook.Text;
            tmp.Cells["AuthorClm"].Value = txbAuthor.Text;
            tmp.Cells["QuantityClm"].Value = txbQuantity.Text;
            tmp.Cells["QualityClm"].Value = txbQuality.Text;
            double? bookprice = BookDAO.Instance.GetBookPrice(txbBook.Text) * double.Parse(txbQuantity.Text);
            tmp.Cells["PriceClm"].Value = bookprice.ToString();
            UpdateTotalPrice();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dtgvBookList.SelectedRows.Count == 0) return;
            DataGridViewRow dtgvr = dtgvBookList.SelectedRows[0];
            dtgvr.Cells["BookClm"].Value = txbBook.Text;
            dtgvr.Cells["AuthorClm"].Value = txbAuthor.Text;
            dtgvr.Cells["QuantityClm"].Value = txbQuantity.Text;
            dtgvr.Cells["QualityClm"].Value = txbQuality.Text;
            double? bookprice = BookDAO.Instance.GetBookPrice(txbBook.Text) * double.Parse(txbQuantity.Text);
            dtgvr.Cells["PriceClm"].Value = bookprice.ToString();
            UpdateTotalPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = dtgvBookList.Rows.Count - 1; i > 0; i--)
            {
                bool? cbc = dtgvBookList.Rows[i].Cells["SelectClm"].Value as bool?;
                if (cbc == true)
                {
                    dtgvBookList.Rows.Remove(dtgvBookList.Rows[i]);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormImport(), this);
            NavigateBack?.Invoke(this, navigationE);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormImport(), this);
            NavigateBack?.Invoke(this, navigationE);
            ImportReport importReport = new ImportReport();
            importReport.idPublisher = PublisherDAO.Instance.GetPublisherID(txbPublisher.Text);
            importReport.DeliveryPerson = txbDeliveryPerson.Text;
            importReport.ImportDate = dtpCreateDate.Value;
            importReport.UnitLeader = txbUnitLeader.Text;
            if(!double.TryParse(txbTotalPrice.Text, out double totalPrice))
            {
                System.Windows.Forms.MessageBox.Show("Lỗi! Tổng giá tiền không đúng định dạng!", "Thông báo lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            importReport.TotalPrice = double.Parse(txbTotalPrice.Text); 
            int idImport = ImportReportDAO.Instance.CreateImportReport(importReport);
            foreach (DataGridViewRow dtgvr in dtgvBookList.Rows)
            {
                ImportReportDetail importReportDetail = new ImportReportDetail();
                importReportDetail.idBook = BookDAO.Instance.GetBookID(txbBook.Text);
                importReportDetail.idImport = idImport;
                importReportDetail.quantity = int.Parse(txbQuantity.Text);
                ImportReportDAO.Instance.CreateImportReportDetail(importReportDetail);
            }
        }

    }
}
