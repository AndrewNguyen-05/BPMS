using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class ExportReportDAO
    {
        private static ExportReportDAO instance;
        private BPMSEntities db = Program.db;
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

        public int CreateExportReport(ExportReport er, bool isUpdate)
        {
            db.ExportReports.AddOrUpdate(er);
            db.SaveChanges();
            db.Entry(er).Reference(c => c.Agency).Load();
            return (isUpdate ? er.id : db.ExportReports.ToList().Last().id);

        }

        public void CreateExportReportDetail(ExportReportDetail erd)
        {
            db.ExportReportDetails.Add(erd);
            db.SaveChanges();
            db.Entry(erd).Reference(c => c.ExportReport).Load();
            db.Entry(erd).Reference(c => c.Book).Load();
        }
        public dynamic GetExportReports()
        {
            var result = db.ExportReports.Select(r => new { r.id, r.Agency.Account.DisplayName, r.ExportDate, r.ReceiptPerson }).ToList();      
            return result;
        }
        public List<ExportReportDetail> GetExportDetail(ExportReport currenter)
        {
            var list = from erd in db.ExportReportDetails
                       join er in db.ExportReports on erd.idExport equals er.id
                       where er.id == currenter.id
                       select erd;
            return list.ToList();
        }

        public ExportReport GetExportReport(int id)
        {
            var list = from er in db.ExportReports
                       where er.id == id
                       select er;
            return list.FirstOrDefault();
        }
        public void RemoveAllDetailInExportReport(int id)
        {
            var list = from erd in db.ExportReportDetails
                       where erd.idExport == id
                       select erd;
            foreach (ExportReportDetail item in list)
            {
                db.ExportReportDetails.Remove(item);
            }
            db.SaveChanges();
        }

        public void DeleteExportReport(int id)
        {
            RemoveAllDetailInExportReport(id);
            var item = from er in db.ExportReports
                       where er.id == id
                       select er;
            if (item != null)
            {
                db.ExportReports.Remove(item.First());
            }
            db.SaveChanges();
        }
        public void UpdateIdBill(int id, int idBill)
        {
            var item = db.ExportReports.FirstOrDefault(er => er.id == id);
            if (item != null)
            {
                item.idBill = idBill;
                db.SaveChanges();
                db.Entry(item).Reference(b => b.Bill).Load();
            }
        }
        public List<ExportReport> GetListExportBill()
        {
            var list = from er in db.ExportReports
                       select er;
            return list.ToList();

        }
    }
}
