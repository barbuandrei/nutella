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
    
    public partial class Post
    {
        public Post()
        {
            this.ResourcePosts = new HashSet<ResourcePost>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdPostType { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual PostType PostType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ResourcePost> ResourcePosts { get; set; }
    }
}
