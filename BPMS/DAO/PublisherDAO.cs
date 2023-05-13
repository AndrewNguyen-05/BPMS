using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class PublisherDAO
    {
        private static PublisherDAO instance;
        private BPMSEntities db = new BPMSEntities();
        internal static PublisherDAO Instance
        {
            get
            {
                if (instance == null) PublisherDAO.instance = new PublisherDAO();
                return instance;
            }
            set { instance = value; }
        }
        public int GetPublisherID(string publisherName)
        {
            var matchedPublisher = from pub in db.Publishers
                                   join acc in db.Accounts on pub.idAccount equals acc.id
                                   where acc.UserName == publisherName || acc.DisplayName == publisherName
                                   select pub.id;
            return matchedPublisher.First();
        }
    }
}
