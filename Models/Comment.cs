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
    
    public partial class Comment
    {
        public int Id { get; set; }
        public Nullable<int> IdCommentType { get; set; }
        public Nullable<int> IdForum { get; set; }
        public Nullable<int> IdUser { get; set; }
        public string CommentContent { get; set; }
    
        public virtual CommentType CommentType { get; set; }
        public virtual User User { get; set; }
    }
}
