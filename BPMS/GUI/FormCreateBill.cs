using BPMS.Classes;
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
using System.Windows.Media.TextFormatting;
using BPMS.DAO;
using System.Windows.Controls;
using System.Security.Policy;


namespace BPMS.GUI
{
    public partial class FormCreateBill : Form
    {
        Bill CurrentBill = null;
        public FormCreateBill()
        {
            InitializeComponent();
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;
        #endregion

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Bill bill;
            if(CurrentBill == null)
            {
                bill = new Bill();
            }
            else
            {
                bill = CurrentBill;
            }
            Account account = new Account();
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormPayment(), this);
            NavigateBack?.Invoke(this, navigationE);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormPayment(), this);
            NavigateBack?.Invoke(this, navigationE);
        }
    }
}
