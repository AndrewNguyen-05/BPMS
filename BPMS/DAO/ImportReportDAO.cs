using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class ImportReportDAO
    {
        private static ImportReportDAO instance;
        private BPMSEntities db = new BPMSEntities();
        internal static ImportReportDAO Instance
        {
            get
            {
                if (instance == null) ImportReportDAO.instance = new ImportReportDAO();
                return instance;
            }
            set { instance = value; }
        }

        public int CreateImportReport(ImportReport ir)
        {
            db.ImportReports.Add(ir);
            return db.ImportReports.Last().id;
            
        }

        public void CreateImportReportDetail(ImportReportDetail ird)
        {
            db.ImportReportDetails.Add(ird);
        }
    }
}
