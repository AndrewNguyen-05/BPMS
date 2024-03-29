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
    public partial class FormExport : Form
    {
        public FormExport()
        {
            InitializeComponent();
            LoadData();

            #region Border form
            //Button
            Guna2Elipse elipse = new Guna2Elipse();
            elipse.TargetControl = btnCreate;
            elipse.BorderRadius = 4;

            //Dtgv
            Guna2Elipse elipse_dtgv = new Guna2Elipse();
            elipse_dtgv.TargetControl = dtgvExport;
            elipse_dtgv.BorderRadius = 4;
            #endregion
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler InnerFormNavigating;
        #endregion


        #region Methods
        void LoadData()
        {
            // Gọi hàm để lấy dữ liệu từ database (?)
            dynamic result = ExportReportDAO.Instance.GetExportReports();

            if (result != null)
            {
                List<object> dataList = new List<object>();
                foreach (var item in result)
                {
                    dataList.Add(new object[] { item.id, item.DisplayName, item.ExportDate, item.ReceiptPerson});
                }
                dtgvExport.Rows.Clear();
                foreach (var row in dataList)
                {
                    dtgvExport.Rows.Add((object[])row);
                }
            }
        }
        #endregion

        #region Events
        private void btnCreate_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateExport(), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dtgvExport.SelectedRows.Count == 0) return;
            ExportReport exportReport = ExportReportDAO.Instance.GetExportReport(int.Parse(dtgvExport.SelectedRows[0].Cells["id"].Value.ToString()));
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateExport(exportReport), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this export form?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            foreach (DataGridViewRow dtgvr in dtgvExport.SelectedRows)
            {
                int id = int.Parse(dtgvExport.SelectedRows[0].Cells["id"].Value.ToString());
                ExportReportDAO.Instance.DeleteExportReport(id);
            }
            LoadData();
        }


        #endregion
    }
}
