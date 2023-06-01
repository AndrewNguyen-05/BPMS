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
    
    public partial class ExportReport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExportReport()
        {
            this.ExportReportDetails = new HashSet<ExportReportDetail>();
        }
    
        public int id { get; set; }
        public int idAgency { get; set; }
        public Nullable<int> idBill { get; set; }
        public string ReceiptPerson { get; set; }
        public System.DateTime ExportDate { get; set; }
        public double TotalPrice { get; set; }
    
        public virtual Agency Agency { get; set; }
        public virtual Bill Bill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportReportDetail> ExportReportDetails { get; set; }
    }
}
