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

namespace BPMS.GUI
{
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount()
        {
            InitializeComponent();
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;

        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {
            

            NavigationEventArgs navigationE = new NavigationEventArgs(new FormAccount(), this);
            NavigateBack?.Invoke(this, navigationE);
        }
    }
}
