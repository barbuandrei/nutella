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
    
    public partial class Result
    {
        public Result()
        {
            this.ModifyResults = new HashSet<ModifyResult>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdUser { get; set; }
        public Nullable<int> IdCourse { get; set; }
        public Nullable<int> HomeworkGrade { get; set; }
        public Nullable<int> QuizGrade { get; set; }
        public Nullable<int> ExamGrade { get; set; }
        public Nullable<int> FinalGrade { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual ICollection<ModifyResult> ModifyResults { get; set; }
        public virtual User User { get; set; }
    }
}
