using System;
using System.Collections.Generic;

namespace FastFood.Models
{
    public class CategoryFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public List<Food> Foods { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
