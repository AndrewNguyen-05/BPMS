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
using static Guna.UI2.Native.WinApi;

namespace BPMS.GUI.Publisher
{
    public partial class FormPublisherNewBook : Form
    {
        Book currentBook = null;
        DTO.Publisher currentPublisher = null;
        public FormPublisherNewBook(DTO.Publisher pb)
        {
            InitializeComponent();
            InitLoad();
            currentPublisher = pb;
            LoadCurretPb();
        }
        
        public FormPublisherNewBook(DTO.Publisher pb, DTO.Book book)
        {
            InitializeComponent();
            InitLoad();
            currentBook = book;
            txbAuthor.Text = book.author;
            txbName.Text = book.name;
            txbPrice.Text = book.price.ToString();
            txbType.Text = book.type;
            cbPublisher.SelectedIndex = cbPublisher.Items.IndexOf(book.Publisher.Account);
            grbNewBook.Text = "Modify Book";
            btnCreate.Text = "Modify";
            currentPublisher = pb;
            LoadCurretPb();
        }

        #region Handler
        public delegate void InnerFormNavigatingHandler(object sender, NavigationEventArgs e);
        public event InnerFormNavigatingHandler NavigateBack;
        #endregion

        public void InitLoad()
        {
            cbPublisher.Items.Clear();
            cbPublisher.DataSource = PublisherDAO.Instance.GetPublisherAccountList();
            cbPublisher.DisplayMember = "DisplayName";
        }
       
        public void LoadCurretPb()
        {
            if (currentPublisher == null) return;
            cbPublisher.Enabled = false;
            cbPublisher.SelectedIndex = cbPublisher.Items.IndexOf(currentPublisher.Account);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (currentBook == null)
            {
                currentBook = new Book();
            }
            currentBook.name = txbName.Text;
            currentBook.price = double.Parse(txbPrice.Text);
            currentBook.author = txbAuthor.Text;
            currentBook.type = txbType.Text;
            currentBook.idPublisher = (cbPublisher.SelectedItem as Account).Publishers.FirstOrDefault().id;
            currentBook.isHidden = 0;
            BookDAO.Instance.CreateBook(currentBook);

            NavigationEventArgs navigationE = new NavigationEventArgs(new FormPublisherBook(), this);
            NavigateBack?.Invoke(this, navigationE);
        }

        private void RevertTyped()
        {
            int tmp = txbPrice.SelectionStart;
            txbPrice.Text = txbPrice.Text.Remove(txbPrice.SelectionStart - 1, 1);
            txbPrice.SelectionStart = tmp - 1 >= 0 ? tmp - 1: 0;
        }

        private void txbPrice_TextChanged(object sender, EventArgs e)
        {
            if (txbPrice.Text == "") return;
            if (txbPrice.Text.Count(x => x == '.') > 1
                || txbPrice.Text.Count(x => x == 'e') > 0)
            {
                RevertTyped();
                return;
            }
            if (!double.TryParse(txbPrice.Text, out double price))
            {
                RevertTyped();
                return;
            }
        }
    }
}
