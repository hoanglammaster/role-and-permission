//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System_Management.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GradeHasCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GradeHasCategory()
        {
            this.GradeHasItems = new HashSet<GradeHasItem>();
        }
    
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public string CategoryName { get; set; }
        public decimal Weights { get; set; }
    
        public virtual Subject Subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GradeHasItem> GradeHasItems { get; set; }
    }
}
