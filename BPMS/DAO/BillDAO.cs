using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;
        private BPMSEntities db = new BPMSEntities();
        internal static BillDAO Instance
        {
            get
            {
                if (instance == null) BillDAO.instance = new BillDAO();
                return instance;
            }
            set { instance = value; }
        }

        public List<ImportReport> GetListImportBill()
        {
            var list = from ir in db.ImportReports
                       select ir;
            return list.ToList();

        }
        public List<ExportReport> GetListExportBill()
        {
            var list = from er in db.ExportReports
                       select er;
            return list.ToList();

        }

        public List<Bill> GetBills()
        {
            return db.Bills.ToList();
        }
        public Bill GetBill(int id)
        {
            var list = from bi in db.Bills
                       where bi.id == id
                       select bi;
            return list.FirstOrDefault();
        }

        public void CreateBill(Bill bi)
        {
            db.Bills.AddOrUpdate(bi);
            db.SaveChanges();
            db.Entry(bi).Reference(c => c.Account).Load();
        }

        public void DeleteBill(int id)
        {

            var item = from bi in db.Bills
                       where bi.id == id
                       select bi;
            if (item != null)
            {
                db.Bills.Remove(item.First());
            }
            db.SaveChanges();
        }
    }
}
