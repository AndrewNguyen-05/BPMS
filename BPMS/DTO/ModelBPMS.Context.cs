﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BPMS.DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BPMSEntities : DbContext
    {
        public BPMSEntities()
            : base("name=BPMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Accountant> Accountants { get; set; }
        public virtual DbSet<Agency> Agencies { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<ExportReport> ExportReports { get; set; }
        public virtual DbSet<ExportReportDetail> ExportReportDetails { get; set; }
        public virtual DbSet<ImportReport> ImportReports { get; set; }
        public virtual DbSet<ImportReportDetail> ImportReportDetails { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
    }
}
