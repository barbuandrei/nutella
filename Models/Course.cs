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
    
    public partial class Course
    {
        public Course()
        {
            this.CourseSubscribers = new HashSet<CourseSubscriber>();
            this.Events = new HashSet<Event>();
            this.Homework = new HashSet<Homework>();
            this.PermissionUsers = new HashSet<PermissionUser>();
            this.QuizQuestions = new HashSet<QuizQuestion>();
            this.Results = new HashSet<Result>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> StarDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> IdDepartment { get; set; }
        public Nullable<int> IdGradeFormula { get; set; }
        public string ContactInfo { get; set; }
        public Nullable<bool> CourseBlock { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<CourseSubscriber> CourseSubscribers { get; set; }
        public virtual GradeFormula GradeFormula { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Homework> Homework { get; set; }
        public virtual ICollection<PermissionUser> PermissionUsers { get; set; }
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
