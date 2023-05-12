using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class ExportReportDAO
    {
        private static ExportReportDAO instance;
        private BPMSEntities db = new BPMSEntities();
        internal static ExportReportDAO Instance
        {
            get
            {
                if (instance == null) ExportReportDAO.instance = new ExportReportDAO();
                return instance;
            }
            set { instance = value; }
        }

        private ExportReportDAO() { }

        public dynamic GetExportReports()
        {
            var result = db.ExportReports.Select(r => new { r.id, r.Agency.Account.DisplayName, r.ExportDate, r.ReceiptPerson }).ToList();

            return result;
        }
    }
}
