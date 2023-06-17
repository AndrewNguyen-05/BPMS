﻿using BPMS.Classes;
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
using System.Web;
using System.Windows.Forms;

namespace BPMS.GUI
{
    public partial class FormPrintBill : Form
    {
        public FormPrintBill(Bill b)
        {
            InitializeComponent();
            LoadData(b);
        }
        public void LoadData(Bill b)
        {
            lblType.Text = b.type == 0 ? "Import" : "Export";
            lblIdBill.Text = "Bill id: " + b.id.ToString();
            lblCreatePerson.Text = "Create Person: " + AccountDAO.Instance.GetAccount(b.idCreatePerson).DisplayName;
            lblSender.Text = "Sender: " + b.Sender;
            lblReceiver.Text = "Receiver: " + b.Receiver;
            lblCreateDate.Text = "Create Date: " + b.CreateDate;
            lblImExportDate.Text = (b.type == 0 ? "Im" : "Ex" ) 
                                    + "port Date: " 
                                    + (b.type == 0 ?
                                        b.ImportReports.FirstOrDefault().ImportDate :
                                        b.ExportReports.FirstOrDefault().ExportDate
                                        );
            double? ttprice = 0;
            if (b.type == 0)
            {
                List<ImportReportDetail> detail = ImportReportDAO.Instance.GetImportDetail(b.ImportReports.FirstOrDefault());
                foreach (ImportReportDetail ird in detail)
                {
                    dtgvBookList.Rows.Add(new object[] { ird.Book.name 
                                                            , ird.Book.author
                                                            , ird.quantity
                                                            , ird.quality
                                                            , ird.Book.price
                                                            , ird.quantity * ird.Book.price });
                    ttprice += ird.quantity * ird.Book.price;
                }
            }
            else
            {
                List<ExportReportDetail> detail = ExportReportDAO.Instance.GetExportDetail(b.ExportReports.FirstOrDefault());
                foreach (ExportReportDetail erd in detail)
                {
                    dtgvBookList.Rows.Add(new object[] { erd.Book.name
                                                            , erd.Book.author
                                                            , erd.quantity
                                                            , erd.quality
                                                            , erd.Book.price
                                                            , erd.quantity * erd.Book.price });
                    ttprice += erd.quantity * erd.Book.price;
                }
            }
            lblTotalPrice.Text = "Total Price: " + ttprice.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = panelPreview.CreateGraphics();
            Size s = panelPreview.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X + grbPreview.Location.X + panelPreview.Location.X ,
                                            this.Location.Y + grbPreview.Location.Y + panelPreview.Location.Y + grbPreview.CustomBorderThickness.Top, 0, 0, s);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);

        }
    }
}
