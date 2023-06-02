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

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler InnerFormNavigating;
        #endregion

        public void LoadData()
        {
            dtgvAccount.Rows.Clear();
            foreach (Account a in AccountDAO.Instance.GetListAccount())
            {
                dtgvAccount.Rows.Add(new object[] { a.id, a.UserName, a.DisplayName, (Permissions) a.type, a.address });
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateAccount(), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgvAccount.SelectedRows[0].Cells["clmId"].Value.ToString());
            Account acc = AccountDAO.Instance.GetAccount(id);
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormCreateAccount(acc), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgvAccount.SelectedRows[0].Cells["clmId"].Value.ToString());
            Control t = this;
            while (t.GetType() != typeof(FormMainMenu))
            {
                t = t.Parent;
            }
            if (id == (t as FormMainMenu).AccountId)
            {
                MessageBox.Show("Can't delete current login account");
                return;
            }

            Account acc = AccountDAO.Instance.GetAccount(id);
            AccountDAO.Instance.DeleteAccount(acc);
            LoadData();
        }
    }
}
