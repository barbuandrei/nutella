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
    
    public partial class Homework
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> IdResource { get; set; }
        public Nullable<int> Score { get; set; }
        public Nullable<int> IdGroup { get; set; }
        public Nullable<int> IdHomeworkType { get; set; }
        public Nullable<int> IdTurninType { get; set; }
        public Nullable<int> IdCourse { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual GroupHomeworkQuestion GroupHomeworkQuestion { get; set; }
        public virtual HomeworkType HomeworkType { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual TurninType TurninType { get; set; }
    }
}
