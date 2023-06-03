using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPMS.Classes;
using BPMS.DAO;
using BPMS.DTO;


namespace BPMS.GUI
{
    public partial class FormCreateBill : Form
    {
        Bill CurrentBill = new Bill();
        public FormCreateBill()
        {
            InitializeComponent();
        }

        public FormCreateBill(ImportReport ir)
        {
            InitializeComponent();
            ir.idBill = CurrentBill.id;
            CurrentBill.type = 0;
        }

        public FormCreateBill(ExportReport er)
        {
            InitializeComponent();
            er.idBill = CurrentBill.id;
            CurrentBill.type = 1;
        }

        public FormCreateBill(Bill bi)
        {
            InitializeComponent();
            CurrentBill = bi;
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;
        #endregion

        #region Methods

        #endregion

        #region Events
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Control t = this;
            while (t.GetType() != typeof(FormMainMenu))
            {
                t = t.Parent;
            }
            Account acc = AccountDAO.Instance.GetAccount((t as FormMainMenu).AccountId);
            CurrentBill.CreateDate = dtpCreateDate.Value;
            CurrentBill.Sender = txbSender.Text;
            CurrentBill.Receiver = txbReceiver.Text;
            CurrentBill.idCreatePerson = acc.id;
            CurrentBill.isPaid = 0;
            CurrentBill.isReceived = 0;


            BillDAO.Instance.CreateBill(CurrentBill);

            NavigationEventArgs navigationE = new NavigationEventArgs(new FormPayment(), this);
            NavigateBack?.Invoke(this, navigationE);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormPayment(), this);
            NavigateBack?.Invoke(this, navigationE);
        }
        #endregion

    }
}
