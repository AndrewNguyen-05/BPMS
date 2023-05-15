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
            foreach(DataGridViewRow dtgvr in TempListDtgv.Rows)
            {
                total += double.Parse(dtgvr.Cells["PriceClm"].Value as string);
            }
            TotalPriceTxt.Text = total.ToString();
        }
        private void TempListDtgv_SelectionChanged(object sender, EventArgs e)
        {
            if (TempListDtgv.SelectedRows.Count == 0) return;
            if (IsAddMode) return;
            DataGridViewRow dtgvr = TempListDtgv.SelectedRows[0];
            if (dtgvr is null) return;
            BookTxt.Text = dtgvr.Cells["BookClm"].Value.ToString();
            AuthorTxt.Text = dtgvr.Cells["AuthorClm"].Value.ToString();
            QuantityTxt.Text = dtgvr.Cells["QuantityClm"].Value.ToString();
            QualityTxt.Text = dtgvr.Cells["QualityClm"].Value.ToString();
            TotalPriceTxt.Text = dtgvr.Cells["PriceClm"].Value.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsAddMode = true;
            TempListDtgv.Rows.Add();
            IsAddMode = false;
            DataGridViewRow tmp = TempListDtgv.Rows[TempListDtgv.Rows.Count - 1];
            tmp.Cells["BookClm"].Value = BookTxt.Text;
            tmp.Cells["AuthorClm"].Value = AuthorTxt.Text;
            tmp.Cells["QuantityClm"].Value = QuantityTxt.Text;
            tmp.Cells["QualityClm"].Value = QualityTxt.Text;
            double? bookprice = BookDAO.Instance.GetBookPrice(BookTxt.Text) * double.Parse(QuantityTxt.Text);
            tmp.Cells["PriceClm"].Value = bookprice.ToString();
            UpdateTotalPrice();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (TempListDtgv.SelectedRows.Count == 0) return;
            DataGridViewRow dtgvr = TempListDtgv.SelectedRows[0];
            dtgvr.Cells["BookClm"].Value = BookTxt.Text;
            dtgvr.Cells["AuthorClm"].Value = AuthorTxt.Text;
            dtgvr.Cells["QuantityClm"].Value = QuantityTxt.Text;
            dtgvr.Cells["QualityClm"].Value = QualityTxt.Text;
            double? bookprice = BookDAO.Instance.GetBookPrice(BookTxt.Text) * double.Parse(QuantityTxt.Text);
            dtgvr.Cells["PriceClm"].Value = bookprice.ToString();
            UpdateTotalPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = TempListDtgv.Rows.Count - 1; i > 0; i--)
            {
                bool? cbc = TempListDtgv.Rows[i].Cells["SelectClm"].Value as bool?;
                if (cbc == true)
                {
                    TempListDtgv.Rows.Remove(TempListDtgv.Rows[i]);
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
            importReport.idPublisher = PublisherDAO.Instance.GetPublisherID(PublisherTxt.Text);
            importReport.DeliveryPerson = DeliveryPersonTxt.Text;
            importReport.ImportDate = CreateDateDtp.Value;
            importReport.UnitLeader = UnitLeaderTxt.Text;
            if(!double.TryParse(TotalPriceTxt.Text, out double totalPrice))
            {
                System.Windows.Forms.MessageBox.Show("Lỗi! Tổng giá tiền không đúng định dạng!", "Thông báo lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            importReport.TotalPrice = double.Parse(TotalPriceTxt.Text); 
            int idImport = ImportReportDAO.Instance.CreateImportReport(importReport);
            foreach (DataGridViewRow dtgvr in TempListDtgv.Rows)
            {
                ImportReportDetail importReportDetail = new ImportReportDetail();
                importReportDetail.idBook = BookDAO.Instance.GetBookID(BookTxt.Text);
                importReportDetail.idImport = idImport;
                importReportDetail.quantity = int.Parse(QuantityTxt.Text);
                ImportReportDAO.Instance.CreateImportReportDetail(importReportDetail);
            }
        }

    }
}
