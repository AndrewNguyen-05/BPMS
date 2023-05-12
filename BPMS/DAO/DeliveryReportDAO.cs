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
        private  BPMSDatabase db = new BPMSDatabase();
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

        public List<DeliveryReport> GetDeliveryReports()
        {
            //var result = from c in db.DeliveryReports 
            //             select new {id = c.id, agency_name = c.Agency.Account.DisplayName}

            //return result.ToList();
        }
    }
}
