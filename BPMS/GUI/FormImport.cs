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
            dynamic result = DeliveryReportDAO.Instance.GetDeliveryReports();

            // Kiểm tra nếu dữ liệu trả về là null hoặc không phải kiểu danh sách, thoát khỏi hàm
            //if (result == null || !(result is List<object>))
            //{
            //    return;
            //}

            // Ép kiểu dữ liệu từ object sang List<object>
            //List<object> dataList = (List<object>)result;

            //// Duyệt từng đối tượng trong danh sách và thêm vào DataGridView
            //foreach (var item in dataList)
            //{
            //    // Ép kiểu từ object sang kiểu dữ liệu mới tạo
            //    var newItem = (dynamic)item;

            //    // Thêm dòng mới vào DataGridView và lấy chỉ số của dòng đó
            //    int rowIndex = dtgvImport.Rows.Add();

            //    // Gán giá trị cho từng ô trong dòng đó bằng cách truy cập theo tên cột
            //    dtgvImport.Rows[rowIndex].Cells["ID"].Value = newItem.id;
            //    dtgvImport.Rows[rowIndex].Cells["DisplayName"].Value = newItem.DisplayName;
            //    dtgvImport.Rows[rowIndex].Cells["DeliveryDate"].Value = newItem.DeliveryDate;
            //    dtgvImport.Rows[rowIndex].Cells["DeliverPerson"].Value = newItem.DeliveryPerson;
            //}

            if (result != null)
            {
                List<object> dataList = new List<object>();
                foreach (var item in result)
                {
                    dataList.Add(new object[] { item.id, item.DisplayName, item.DeliveryDate, item.DeliveryPerson });
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
