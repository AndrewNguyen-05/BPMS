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

namespace BPMS.GUI.Publisher
{
    public partial class FormPublisherNewBook : Form
    {
        Book currentBook = null;
        public FormPublisherNewBook()
        {
            InitializeComponent();
            InitLoad();
        }
        
        public FormPublisherNewBook(DTO.Book book)
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

        private void txbPrice_TextChanged(object sender, EventArgs e)
        {
            //if (txbPrice.Text == "") return;
            //if (txbPrice.Text.Count(x => x == '.') > 1)
            //{
            //    txbPrice.Undo();
            //    txbPrice.ClearUndo();
            //    return;
            //}    
            //if (!double.TryParse(txbPrice.Text, out double price))
            //{
            //    txbPrice.Undo();
            //    txbPrice.ClearUndo();
            //    return;
            //}
        }
    }
}
