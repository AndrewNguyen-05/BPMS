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

namespace BPMS.GUI.Publisher
{
    public partial class FormPublisherBook : Form
    {
        DTO.Publisher currentPublisher = null;
        public FormPublisherBook()
        {
            InitializeComponent();
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler InnerFormNavigating;
        #endregion

        private int GetAccountInfo()
        {
            Control c = this;
            while (c.GetType() != typeof(FormMainMenu))
            {
                c = c.Parent;
                if (c == null) return -1;
            }
            if (c != null)
            {
                Account tmp = AccountDAO.Instance.GetAccount((c as FormMainMenu).AccountId);
                if (tmp != null)
                {
                    if ((Permissions)tmp.type == Permissions.Admin)
                    {
                        currentPublisher = null;
                    }
                    else
                    {
                        currentPublisher = tmp.Publishers.FirstOrDefault();
                    }
                }
            }
            return 0;
        }
        void LoadBookInfo()
        {
            List<Book> listBk = BookDAO.Instance.GetBookList(currentPublisher);
            dtgvBook.Rows.Clear();
            foreach (Book bk in listBk)
            {
                dtgvBook.Rows.Add(new object[] { bk.id
                                                    , bk.name
                                                    , bk.type
                                                    , bk.Publisher.Account.DisplayName
                                                    , bk.author
                                                    , bk.price});
            }
        }

        private void FormPublisherBook_ParentChanged(object sender, EventArgs e)
        {
            if (GetAccountInfo() == -1) return;
            LoadBookInfo();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormPublisherNewBook(), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dtgvBook.SelectedRows.Count == 0) return;
            Book book = BookDAO.Instance.GetBookById(int.Parse(dtgvBook.SelectedRows[0].Cells["ClmBookID"].Value.ToString()));
            NavigationEventArgs navigationE = new NavigationEventArgs(new FormPublisherNewBook(book), this);
            InnerFormNavigating?.Invoke(this, navigationE);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book book = BookDAO.Instance.GetBookById(int.Parse(dtgvBook.SelectedRows[0].Cells["ClmBookID"].Value.ToString()));
            book.isHidden = 1;
            BookDAO.Instance.CreateBook(book);
            GetAccountInfo();
        }
    }
}
