//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.ExportReportDetails = new HashSet<ExportReportDetail>();
            this.ImportReportDetails = new HashSet<ImportReportDetail>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string author { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<int> idPublisher { get; set; }
        public Nullable<int> isHidden { get; set; }
    
        public virtual Publisher Publisher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportReportDetail> ExportReportDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportReportDetail> ImportReportDetails { get; set; }
    }
}
