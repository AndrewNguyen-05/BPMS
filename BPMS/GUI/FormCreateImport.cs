using BPMS.Classes;
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

namespace BPMS.GUI
{
    public partial class FormCreateImport : Form
    {
        public FormCreateImport()
        {
            InitializeComponent();
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TempListDtgv.Rows.Add();
            DataGridViewRow tmp = TempListDtgv.Rows[TempListDtgv.Rows.Count - 1];
            tmp.Cells["BookClm"].Value = BookTxt.Text;
            tmp.Cells["AuthorClm"].Value = AuthorTxt.Text;
            tmp.Cells["QuantityClm"].Value = QuantityTxt.Text;
            tmp.Cells["QualityClm"].Value = QualityTxt.Text;
            tmp.Cells["PriceClm"].Value = TotalPriceTxt.Text;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DataGridViewRow dtgvr = TempListDtgv.SelectedRows[0];
            dtgvr.Cells["BookClm"].Value = BookTxt.Text;
            dtgvr.Cells["AuthorClm"].Value = AuthorTxt.Text;
            dtgvr.Cells["QuantityClm"].Value = QuantityTxt.Text;
            dtgvr.Cells["QualityClm"].Value = QualityTxt.Text;
            dtgvr.Cells["PriceClm"].Value = TotalPriceTxt.Text;
            //IDTxt.Text = dtgvr.Cells["IDClm"].Value.ToString();
            //BookTxt.Text = dtgvr.Cells["BookClm"].Value.ToString();
            //AuthorTxt.Text = dtgvr.Cells["AuthorClm"].Value.ToString();
            //QuantityTxt.Text = dtgvr.Cells["QuantityClm"].Value.ToString();
            //QualityTxt.Text = dtgvr.Cells["QualityClm"].Value.ToString();
            //TotalPriceTxt.Text = dtgvr.Cells["PriceClm"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dtgvr in TempListDtgv.Rows)
            {
                bool? cbc = dtgvr.Cells["SelectedClm"].Value as bool?;
                if (cbc == true)
                {
                    TempListDtgv.Rows.Remove(dtgvr);
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
        }

    }
}
