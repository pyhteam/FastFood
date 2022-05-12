using System;
using System.Collections.Generic;

namespace FastFood.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int ParentId { get; set; }
        public Comment Parent { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
