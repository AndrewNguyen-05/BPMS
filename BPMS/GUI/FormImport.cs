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
        }
        #region Methods
        void LoadData()
        {
            // Gọi hàm để lấy dữ liệu từ database
            dynamic result = ExportReportDAO.Instance.GetExportReports();

            if (result != null)
            {
                List<object> dataList = new List<object>();
                foreach (var item in result)
                {
                    dataList.Add(new object[] { item.id, item.DisplayName, item.ExportDate, item.ReceiptPerson });
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
        #endregion
    }
}
