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
    
    public partial class Bill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bill()
        {
            this.ExportReports = new HashSet<ExportReport>();
            this.ImportReports = new HashSet<ImportReport>();
        }
    
        public int id { get; set; }
        public int idReceiver { get; set; }
        public int idSender { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<int> isPaid { get; set; }
        public Nullable<int> isReceived { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportReport> ExportReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportReport> ImportReports { get; set; }
    }
}
