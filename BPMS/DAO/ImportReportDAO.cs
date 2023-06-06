﻿using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BPMS.DAO
{
    internal class ImportReportDAO
    {
        private static ImportReportDAO instance;
        private BPMSEntities db = Program.db;
        internal static ImportReportDAO Instance
        {
            get
            {
                if (instance == null) ImportReportDAO.instance = new ImportReportDAO();
                return instance;
            }
            set { instance = value; }
        }

        public int CreateImportReport(ImportReport ir, bool isUpdate)
        {
            db.ImportReports.AddOrUpdate(ir);
            db.SaveChanges();
            db.Entry(ir).Reference(c => c.Publisher).Load();
            return (isUpdate ? ir.id : db.ImportReports.ToList().Last().id);
            
        }

        public void CreateImportReportDetail(ImportReportDetail ird)
        {
            db.ImportReportDetails.Add(ird);
            db.SaveChanges();
            db.Entry(ird).Reference(c => c.ImportReport).Load();
            db.Entry(ird).Reference(c => c.Book).Load();
        }

        public dynamic GetImportReports()
        {
            var result = db.ImportReports.Select(r => new {r.id, r.Publisher.Account.DisplayName, r.ImportDate, r.DeliveryPerson, r.UnitLeader }).ToList();
            return result;
        }


        public List<ImportReportDetail> GetImportDetail(ImportReport currentir)
        {
            var list = from ird in db.ImportReportDetails
                       join ir in db.ImportReports on ird.idImport equals ir.id
                       where ir.id == currentir.id
                       select ird;
            return list.ToList();
        }

        public ImportReport GetImportReport(int id)
        {
            var list = from ir in db.ImportReports
                       where ir.id == id
                       select ir;
            return list.FirstOrDefault();
        }

        public ImportReport GetImportReportFromBill(int idBill)
        {
            var list = from ir in db.ImportReports
                       join b in db.Bills
                       on ir.idBill equals b.id
                       where b.id == idBill
                       select ir;
            return list.FirstOrDefault();
        }

        public void RemoveAllDetailInImportReport(int id)
        {
            var list = from ird in db.ImportReportDetails
                        where ird.idImport == id
                        select ird;
            foreach (ImportReportDetail item in list)
            {
                db.ImportReportDetails.Remove(item);
            }
            db.SaveChanges();
        }

        public void DeleteImportReport(int id)
        {
            RemoveAllDetailInImportReport(id);
            var item = from ir in db.ImportReports
                       where ir.id == id
                       select ir;
            if (item != null)
            {
                db.ImportReports.Remove(item.First());
            }
            db.SaveChanges();
        }
        
        public void UpdateIdBill(int id, int idBill)
        {
            ImportReport item = GetImportReport(id);
            if (item != null) 
            {
                item.idBill = idBill;
                db.SaveChanges();
                db.Entry(item).Reference(c => c.Bill).Load();
            }
        }

        public List<ImportReport> GetListImportBill()
        {
            var list = from ir in db.ImportReports
                       select ir;
            return list.ToList();

        }
        public List<ImportReport> GetListImportBill(Publisher publisher)
        {
            if (publisher == null) return GetListImportBill();
            var list = from ir in db.ImportReports
                       join pb in db.Publishers
                       on ir.idPublisher equals pb.id
                       where publisher.id == pb.id
                       select ir;
            return list.ToList();

        }
    }
}
