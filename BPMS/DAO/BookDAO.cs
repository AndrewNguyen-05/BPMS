using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class BookDAO
    {
        private static BookDAO instance;
        private BPMSEntities db = new BPMSEntities();
        internal static BookDAO Instance
        {
            get
            {
                if (instance == null) BookDAO.instance = new BookDAO();
                return instance;
            }
            set { instance = value; }
        }
        public double? GetBookPrice(string BookName)
        {
            var price = from bk in db.Books
                        where BookName == bk.name
                        select bk.price;
            if (price.Count() == 0) return 0;
            return price.First();
        }
        public int GetBookID(string BookName)
        {
            var id = from bk in db.Books
                       where bk.name == BookName
                       select bk.id;
            return id.First();
        }
    }
}
