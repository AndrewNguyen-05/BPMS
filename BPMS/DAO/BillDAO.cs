using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace BPMS.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;
        private BPMSEntities db = Program.db;
        internal static BillDAO Instance
        {
            get
            {
                if (instance == null) BillDAO.instance = new BillDAO();
                return instance;
            }
            set { instance = value; }
        }

        public List<Bill> GetBills()
        {
            return db.Bills.Where(e => e.isHidden == 0).ToList();
        }
        public List<Bill> GetAgencyBills(Agency agency)
        {
            if (agency == null) return GetBills();
            var data = from ag in db.Agencies
                       join er in db.ExportReports
                       on ag.id equals er.idAgency
                       join b in db.Bills
                       on er.idBill equals b.id
                       where ag.id == agency.id && b.isHidden == 0
                       select b;
            return data.ToList();
        }
        public Bill GetBill(int id)
        {
            var list = from bi in db.Bills
                       where bi.id == id && bi.isHidden == 0
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
                if (item.First().type == 0)
                {
                    var tmp = from bi in db.Bills
                              join ir in db.ImportReports on bi.id equals ir.idBill
                              select ir;
                    if (tmp != null)
                    {
                        ImportReport irt = tmp.First();
                        irt.idBill = null;
                        db.ImportReports.AddOrUpdate(irt);
                        db.Entry(irt).State = EntityState.Modified;
                    }
                }
                else if (item.First().type == 1)
                {
                    var tmp = from bi in db.Bills
                              join er in db.ExportReports on bi.id equals er.idBill
                              select er;
                    if (tmp != null)
                    {
                        ExportReport ert = tmp.First();
                        ert.idBill = null;
                        db.ExportReports.AddOrUpdate(ert);
                        db.Entry(ert).State = EntityState.Modified;
                    }
                }
                db.SaveChanges();
                item.First().isHidden = 1;
                db.SaveChanges();
            }
        }
    }
}
