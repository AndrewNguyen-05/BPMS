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
    public partial class FormImport : Form
    {
        public FormImport()
        {
            InitializeComponent();
            LoadData();

            #region Border form
            //Button
            Guna2Elipse elipse = new Guna2Elipse();
            elipse.TargetControl = btnCreate;
            elipse.BorderRadius = 25;

            //Dtgv
            Guna2Elipse elipse_dtgv = new Guna2Elipse();
            elipse_dtgv.TargetControl = dtgvImport;
            elipse_dtgv.BorderRadius = 20;
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
            dynamic result = ImportReportDAO.Instance.GetImportReports();

            if (result != null)
            {
                List<object> dataList = new List<object>();
                foreach (var item in result)
                {
                    dataList.Add(new object[] { item.id, item.DisplayName, item.ImportDate, item.DeliveryPerson, item.UnitLeader });
                }
                dtgvImport.Rows.Clear();
                foreach (var row in dataList)
                {
                    dtgvImport.Rows.Add((object[])row);
                }
            }

            //foreach (var item in res)
            //{
            //    dtgvImport.Rows.Add(res.);
            //}
        }
        #endregion

        #region Events
        private void btnCreate_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateImport(), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }
        #endregion
    }
}
