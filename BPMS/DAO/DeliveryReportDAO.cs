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
            return db.DeliveryReports.ToList();
        }
    }
}
