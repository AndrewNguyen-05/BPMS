using BPMS.Classes;
using BPMS.DAO;
using BPMS.DTO;
using Guna.UI2.WinForms;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            #region Border
            //Form


            #endregion
        }
        public void LoadData(Bill b)
        {
            lblType.Text = b.type == 0 ? "Import Invoice" : "Export Invoice";
            lblIdBill.Text = "Invoice No " + b.id.ToString();
            lblCreatePerson.Text = "Created by " + AccountDAO.Instance.GetAccount(b.idCreatePerson).DisplayName;
            lblSender.Text = b.Sender;
            lblReceiver.Text = b.Receiver;
            lblCreateDate.Text = b.CreateDate.ToString();
            lblImExportDate.Text = (b.type == 0 ?
                                        b.ImportReports.FirstOrDefault().ImportDate.ToString() :
                                        b.ExportReports.FirstOrDefault().ExportDate.ToString()
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
            lblTotalPrice.Text = "Total Price: " + ttprice.ToString() + " VND";
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

        private void panelPreview_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            //Dashline
            using (Pen dashedPen = new Pen(Color.Black))
            {
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                // Draw the 1st dashed line
                Point startPoint = new Point(0, 270);
                Point endPoint = new Point(this.ClientSize.Width, 270);
                e.Graphics.DrawLine(dashedPen, startPoint, endPoint);

                // Draw the 2nd dashed line
                Point startPoint2 = new Point(0, 310);
                Point endPoint2 = new Point(this.ClientSize.Width, 310);
                e.Graphics.DrawLine(dashedPen, startPoint2, endPoint2);
            }

            //Line
            using (Pen solidPen = new Pen(Color.Black))
            {
                solidPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                Point startPoint = new Point(0, 715);
                Point endPoint = new Point(this.ClientSize.Width, 715);
                e.Graphics.DrawLine(solidPen, startPoint, endPoint);

            }

        }
    }
}
