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

namespace BPMS.GUI.Publisher
{
    public partial class FormPublisherNewBook : Form
    {
        public FormPublisherNewBook()
        {
            InitializeComponent();
        }
        
        public FormPublisherNewBook(DTO.Book book)
        {
            InitializeComponent();
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;
        #endregion
    }
}
