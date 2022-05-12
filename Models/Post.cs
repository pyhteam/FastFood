using System;
using System.Collections.Generic;

namespace FastFood.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryPostId { get; set; }
        public CategoryPost CategoryPost { get; set; }
        public List<Comment> Comments { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
