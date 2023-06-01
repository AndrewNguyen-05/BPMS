using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPMS.Classes;
using BPMS.DAO;
using BPMS.DTO;

namespace BPMS.GUI
{
    public partial class FormCreateAccount : Form
    {
        Account CurrentAcc = null;
        public FormCreateAccount()
        {
            InitializeComponent();
            cbType.DataSource = Enum.GetValues(typeof(Permissions));
            cbType.DisplayMember = "Name";
        }
        public FormCreateAccount(Account acc)
        {
            InitializeComponent();
            cbType.DataSource = Enum.GetValues(typeof(Permissions));
            cbType.DisplayMember = "Name";
            CurrentAcc = acc;
            lblNewAccount.Text = "Modify Account";
            btnCreate.Text = "Modify";
            LoadAcc();
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;

        #endregion
        void LoadAcc()
        {
            txbUsername.Text = CurrentAcc.UserName;
            txbDisplayname.Text = CurrentAcc.DisplayName;
            txbPassword.Text = CurrentAcc.PassWord;
            txbAddress.Text = CurrentAcc.address;
            cbType.SelectedIndex = cbType.Items.IndexOf((Permissions)CurrentAcc.type);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Account acc = new Account() { UserName = txbUsername.Text,
                                          DisplayName = txbDisplayname.Text,
                                          PassWord = txbPassword.Text,
                                          type = (int)(Permissions)(cbType.SelectedValue),
                                          address = txbAddress.Text,
                                            };
            if (CurrentAcc != null)
            {
                acc.id = CurrentAcc.id;
            }
            if (AccountDAO.Instance.GetAccount(acc.UserName) != null)
            {
                if (CurrentAcc == null || (CurrentAcc != null && CurrentAcc.UserName != acc.UserName))
                {
                    MessageBox.Show("Username existed");
                    return;
                }    
            }
            AccountDAO.Instance.CreateAccount(acc);
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormAccount(), this);
            NavigateBack?.Invoke(this, navigationE);
        }
    }
}
