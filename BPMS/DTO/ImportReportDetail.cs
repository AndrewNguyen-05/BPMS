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
    
    public partial class ImportReportDetail
    {
        public int id { get; set; }
        public int idBook { get; set; }
        public int idImport { get; set; }
        public int quantity { get; set; }
        public string quality { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual ImportReport ImportReport { get; set; }
    }
}
