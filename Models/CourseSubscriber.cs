//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CourseSubscriber
    {
        public int Id { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> IdCourse { get; set; }
        public Nullable<int> IdGroup { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual StudentsGroup StudentsGroup { get; set; }
        public virtual User User { get; set; }
    }
}