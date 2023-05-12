using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class DeliveryReportDAO
    {
        private static DeliveryReportDAO instance;
        private BPMSEntities db = new BPMSEntities();
        internal static DeliveryReportDAO Instance
        {
            get 
            {
                if(instance == null) DeliveryReportDAO.instance = new DeliveryReportDAO();
                return instance;
            }
            set { instance = value; }
        }

        private DeliveryReportDAO() { }

        public dynamic GetDeliveryReports()
        {
            //var result = from c in db.DeliveryReports
            //             select c;
            //select new { id = c.id, agency_name = c.Agency.Account.DisplayName };
            var result = db.DeliveryReports.Select(r => new {r.id, r.Agency.Account.DisplayName, r.DeliveryDate, r.DeliveryPerson }).ToList();
            
            return result;
        }
    }
}
