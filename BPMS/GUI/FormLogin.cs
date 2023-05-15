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
    public partial class FormLogin : Form
    {
        internal int LoginAccount = -1;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            bool result = AccountDAO.Instance.CheckPassword(UsernameTxt.Text, PasswordTxt.Text);
            if (result)
            {
                LoginAccount = AccountDAO.Instance.GetAccountId(UsernameTxt.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Error");
            }
        }

    }
}
