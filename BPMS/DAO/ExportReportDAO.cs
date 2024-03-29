﻿using BPMS.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

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

        public ExportReport GetExportReportFromBill(int idBill)
        {
            var list = from er in db.ExportReports
                       join b in db.Bills
                       on er.idBill equals b.id
                       where b.id == idBill
                       select er;
            return list.FirstOrDefault();
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

        public List<ExportReport> GetListExportBill(Agency agency)
        {
            if (agency == null) return GetListExportBill();
            var list = from er in db.ExportReports
                       join ag in db.Agencies
                       on er.idAgency equals ag.id
                       where agency.id == ag.id
                       select er;
            return list.ToList();

        }
        public DateTime GetNext(DateTime current, int GroupBy)
        {
            switch (GroupBy)
            {
                case 0:
                    return current.Add(-current.TimeOfDay).AddDays(1);
                case 1:
                    return current.Add(-current.TimeOfDay).AddDays(-current.Day + 1).AddMonths(1);
                case 2:
                    return current.Add(-current.TimeOfDay).AddDays(-current.Day + 1).AddMonths(-current.Month + 1).AddYears(1);
                case 3:
                    return current.Add(-current.TimeOfDay).AddDays(7);

            }
            return current;
        }
        /// <summary>
        /// GroupBy mode: 0 - day, 1 - month, 2 - year
        /// </summary>
        public List<KeyValuePair<DateTime, int>> GetNumberOfExportedBook(DateTime startDate, DateTime endDate, int GroupBy)
        {
            List<KeyValuePair<DateTime, int>> result = new List<KeyValuePair<DateTime, int>>();
            //By month
            for (DateTime start = startDate;
                 start < endDate;
                 start = GetNext(start, GroupBy)
                )
            {
                DateTime end = GetNext(start, GroupBy) < endDate ? GetNext(start, GroupBy) : endDate;
                end = end.AddMilliseconds(-1);
                var list = from er in db.ExportReports
                           join erd in db.ExportReportDetails
                           on er.id equals erd.idExport
                           where start <= er.ExportDate && er.ExportDate <= end
                           select erd.quantity;
                result.Add(new KeyValuePair<DateTime, int> (start, Enumerable.Sum(list)));
            }
            return result;
        }

        /// <summary>
        /// Get last number - mode of imported book
        /// mode 0 - day, 1 - month, 2 - year
        /// GroupBy mode: 0 - day, 1 - month, 2 - year
        /// </summary>
        public List<KeyValuePair<DateTime, int>> GetNumberOfExportedBook(int number, int mode, int GroupBy)
        {
            switch (mode)
            {
                case 0:
                    return GetNumberOfExportedBook(DateTime.Now.AddDays(-number), DateTime.Now, GroupBy);
                case 1:
                    return GetNumberOfExportedBook(DateTime.Now.AddMonths(-number), DateTime.Now, GroupBy);
                case 2:
                    return GetNumberOfExportedBook(DateTime.Now.AddYears(-number), DateTime.Now, GroupBy);
            }
            return null;
        }        
        /// <summary>
        /// GroupBy mode: 0 - day, 1 - month, 2 - year
        /// </summary>
        public List<KeyValuePair<DateTime, double>> GetRevenueOfExportedBook(DateTime startDate, DateTime endDate, int GroupBy)
        {
            List<KeyValuePair<DateTime, double>> result = new List<KeyValuePair<DateTime, double>>();
            //By month
            for (DateTime start = startDate;
                 start < endDate;
                 start = GetNext(start, GroupBy)
                )
            {
                DateTime end = GetNext(start, GroupBy) < endDate ? GetNext(start, GroupBy) : endDate;
                end = end.AddMilliseconds(-1);
                var list = from er in db.ExportReports
                           where start <= er.ExportDate && er.ExportDate <= end
                           select er.TotalPrice;
                result.Add(new KeyValuePair<DateTime, double> (start, Enumerable.Sum(list)));
            }
            return result;
        }

        /// <summary>
        /// Get last number - mode of imported book
        /// mode 0 - day, 1 - month, 2 - year
        /// GroupBy mode: 0 - day, 1 - month, 2 - year
        /// </summary>
        public List<KeyValuePair<DateTime, double>> GetRevenueOfExportedBook(int number, int mode, int GroupBy)
        {
            switch (mode)
            {
                case 0:
                    return GetRevenueOfExportedBook(DateTime.Now.AddDays(-number), DateTime.Now, GroupBy);
                case 1:
                    return GetRevenueOfExportedBook(DateTime.Now.AddMonths(-number), DateTime.Now, GroupBy);
                case 2:
                    return GetRevenueOfExportedBook(DateTime.Now.AddYears(-number), DateTime.Now, GroupBy);
            }
            return null;
        } 
        /// <summary>
        /// GroupBy mode: 0 - day, 1 - month, 2 - year
        /// </summary>
        public List<KeyValuePair<string, int>> GetNumberOfExportedBookByBook(DateTime startDate, DateTime endDate)
        {
            List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();
            //By month

            foreach (Book bk in BookDAO.Instance.GetBookList())
            {
                var list = from er in db.ExportReports
                           join erd in db.ExportReportDetails
                           on er.id equals erd.idExport
                           where startDate <= er.ExportDate && er.ExportDate <= endDate && bk.id == erd.idBook
                           select erd.quantity;
                result.Add(new KeyValuePair<string, int>(bk.name, Enumerable.Sum(list)));
            }
            return result;
        }

        /// <summary>
        /// Get last number - mode of imported book
        /// mode 0 - day, 1 - month, 2 - year
        /// GroupBy mode: 0 - day, 1 - month, 2 - year
        /// </summary>
        public List<KeyValuePair<string, int>> GetNumberOfExportedBookByBook(int number, int mode)
        {
            switch (mode)
            {
                case 0:
                    return GetNumberOfExportedBookByBook(DateTime.Now.AddDays(-number), DateTime.Now);
                case 1:
                    return GetNumberOfExportedBookByBook(DateTime.Now.AddMonths(-number), DateTime.Now);
                case 2:
                    return GetNumberOfExportedBookByBook(DateTime.Now.AddYears(-number), DateTime.Now);
            }
            return null;
        }

        public double GetHighestEarning(DateTime startDate, DateTime endDate)
        {
            var item = from er in db.ExportReports
                       where startDate <= er.ExportDate && er.ExportDate <= endDate
                       orderby er.TotalPrice descending
                       select er.TotalPrice;


            return item.FirstOrDefault();
        }

        public double GetHighestEarning(int number, int mode)
        {
            switch (mode)
            {
                case 0:
                    return GetHighestEarning(DateTime.Now.AddDays(-number), DateTime.Now);
                case 1:
                    return GetHighestEarning(DateTime.Now.AddMonths(-number), DateTime.Now);
                case 2:
                    return GetHighestEarning(DateTime.Now.AddYears(-number), DateTime.Now);
            }
            return 0;
        }

        public string GetBestSellingBook(DateTime start, DateTime end)
        {
            var item = from er in db.ExportReports
                       join erd in db.ExportReportDetails
                       on er.id equals erd.idExport
                       where start <= er.ExportDate && er.ExportDate <= end
                       group erd by erd.idBook into allErdOfBook
                       join bk in db.Books
                       on allErdOfBook.FirstOrDefault().idBook equals bk.id
                       orderby allErdOfBook.Sum(x => x.quantity) descending
                       select bk.name;
            return item.FirstOrDefault();
        }

        public string GetBestSellingBook(int number, int mode)
        {
            switch (mode)
            {
                case 0:
                    return GetBestSellingBook(DateTime.Now.AddDays(-number), DateTime.Now);
                case 1:
                    return GetBestSellingBook(DateTime.Now.AddMonths(-number), DateTime.Now);
                case 2:
                    return GetBestSellingBook(DateTime.Now.AddYears(-number), DateTime.Now);
            }
            return "";
        }

        public int GetLargestAmountExportBook(DateTime start, DateTime end)
        {
            var item = from er in db.ExportReports
                       join erd in db.ExportReportDetails
                       on er.id equals erd.idExport
                       where start <= er.ExportDate && er.ExportDate <= end
                       group erd by erd.idBook into allErdOfBook
                       join bk in db.Books
                       on allErdOfBook.FirstOrDefault().idBook equals bk.id
                       orderby allErdOfBook.Sum(x => x.quantity) descending
                       select allErdOfBook.Sum(x => x.quantity);
            return item.FirstOrDefault();
        }

        public int GetLargestAmountExportBook(int number ,int mode)
        {
            switch (mode)
            {
                case 0:
                    return GetLargestAmountExportBook(DateTime.Now.AddDays(-number), DateTime.Now);
                case 1:
                    return GetLargestAmountExportBook(DateTime.Now.AddMonths(-number), DateTime.Now);
                case 2:
                    return GetLargestAmountExportBook(DateTime.Now.AddYears(-number), DateTime.Now);
            }
            return 0;
        }
    }
}
