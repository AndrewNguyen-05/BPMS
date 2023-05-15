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
    
    public partial class ImportReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ImportReport()
        {
            this.ImportReportDetails = new HashSet<ImportReportDetail>();
        }
    
        public int id { get; set; }
        public int idPublisher { get; set; }
        public string DeliveryPerson { get; set; }
        public System.DateTime ImportDate { get; set; }
        public string UnitLeader { get; set; }
        public double TotalPrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImportReportDetail> ImportReportDetails { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
