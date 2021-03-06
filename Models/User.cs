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
    
    public partial class User
    {
        public User()
        {
            this.AuthentificationLogs = new HashSet<AuthentificationLog>();
            this.ChatSubscribers = new HashSet<ChatSubscriber>();
            this.Comments = new HashSet<Comment>();
            this.CourseSubscribers = new HashSet<CourseSubscriber>();
            this.Events = new HashSet<Event>();
            this.ModifyResults = new HashSet<ModifyResult>();
            this.PageDesigns = new HashSet<PageDesign>();
            this.PermissionUsers = new HashSet<PermissionUser>();
            this.Posts = new HashSet<Post>();
            this.Results = new HashSet<Result>();
            this.SetNotices = new HashSet<SetNotice>();
            this.UserRoles = new HashSet<UserRole>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<AuthentificationLog> AuthentificationLogs { get; set; }
        public virtual ICollection<ChatSubscriber> ChatSubscribers { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CourseSubscriber> CourseSubscribers { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<ModifyResult> ModifyResults { get; set; }
        public virtual ICollection<PageDesign> PageDesigns { get; set; }
        public virtual ICollection<PermissionUser> PermissionUsers { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<SetNotice> SetNotices { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
