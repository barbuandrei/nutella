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
    
    public partial class GradeFormula
    {
        public GradeFormula()
        {
            this.Courses = new HashSet<Course>();
        }
    
        public int Id { get; set; }
        public Nullable<int> HomeworkPercentage { get; set; }
        public Nullable<int> QuizPercentage { get; set; }
        public Nullable<int> FinalExamPercentage { get; set; }
    
        public virtual ICollection<Course> Courses { get; set; }
    }
}
