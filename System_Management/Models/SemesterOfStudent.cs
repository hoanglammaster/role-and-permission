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
    
    public partial class SemesterOfStudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SemesterOfStudent()
        {
            this.ClassOfStudents = new HashSet<ClassOfStudent>();
        }
    
        public int Id { get; set; }
        public int Semester { get; set; }
        public int StudentId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClassOfStudent> ClassOfStudents { get; set; }
        public virtual Semester Semester1 { get; set; }
        public virtual Student Student { get; set; }
    }
}
