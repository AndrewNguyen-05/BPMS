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
            grbNewAccount.Text = "Modify Account";
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
            LoadAdditional();
        }
        void LoadAdditional()
        {
            txbBankAccount.Text = "";
            txbPhone.Text = "";
            if (CurrentAcc is null) return;
            switch ((Permissions)cbType.SelectedValue)
            {
                case Permissions.Publisher:
                    if (CurrentAcc.Publishers.Where(c => c.isHidden == 0).FirstOrDefault() != null)
                    {
                        txbBankAccount.Text = CurrentAcc.Publishers.Where(c => c.isHidden == 0)
                                                                   .FirstOrDefault()
                                                                   .AccountNumber;
                        txbPhone.Text = CurrentAcc.Publishers.Where(c => c.isHidden == 0)
                                                            .FirstOrDefault()
                                                            .PhoneNumber;
                    }
                    break;
                case Permissions.Accountant:
                    if (CurrentAcc.Accountants.Where(c => c.isHidden == 0).FirstOrDefault() != null)
                    {
                        txbBankAccount.Text = CurrentAcc.Accountants.Where(c => c.isHidden == 0)
                                                                    .FirstOrDefault()
                                                                    .AccountNumber;
                        txbPhone.Text = CurrentAcc.Accountants.Where(c => c.isHidden == 0)
                                                              .FirstOrDefault()
                                                              .PhoneNumber;
                    }
                    break;

            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Account acc = new Account() { UserName = txbUsername.Text,
                                          DisplayName = txbDisplayname.Text,
                                          PassWord = txbPassword.Text,
                                          type = (int)(Permissions)(cbType.SelectedValue),
                                          address = txbAddress.Text,
                                          isHidden = 0
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

            AccountDAO.Instance.CreateAccount(ref acc); //ref id

            switch ((Permissions)acc.type)
            {
                case Permissions.Publisher:
                    DTO.Publisher pb = PublisherDAO.Instance.GetPublisherByAccId(acc.id);
                    pb.idAccount = acc.id;
                    pb.AccountNumber = txbBankAccount.Text;
                    pb.PhoneNumber = txbPhone.Text;
                    pb.isHidden = 0;
                    PublisherDAO.Instance.CreatePublisher(pb);
                    break;
                case Permissions.Accountant:
                    DTO.Accountant act = AccountantDAO.Instance.GetAccountantByAccId(acc.id);
                    act.idAccount = acc.id;
                    act.AccountNumber = txbBankAccount.Text;
                    act.PhoneNumber = txbPhone.Text;
                    act.isHidden = 0;
                    AccountantDAO.Instance.CreateAccountant(act);
                    break;
            }

            NavigationEventArgs navigationE = new NavigationEventArgs(new FormAccount(), this);
            NavigateBack?.Invoke(this, navigationE);
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Permissions)cbType.SelectedValue == Permissions.Publisher 
                || (Permissions)cbType.SelectedValue == Permissions.Accountant)
            {
                txbBankAccount.Enabled = true;
                txbPhone.Enabled = true;
                LoadAdditional();
            }
            else
            {
                txbBankAccount.Enabled = false;
                txbPhone.Enabled = false;
                LoadAdditional();
            }
        }
    }
}
