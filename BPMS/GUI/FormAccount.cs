using BPMS.Classes;
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

namespace BPMS.GUI
{
    public partial class FormAccount : Form
    {
        public FormAccount()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach (Account a in AccountDAO.Instance.GetListAccount())
            {
                dtgvAccount.Rows.Add(new object[] { a.id, a.UserName, a.DisplayName, (Permissions) a.type, a.address });
            }
        }

    }
}
