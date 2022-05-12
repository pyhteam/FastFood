using System;

namespace FastFood.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int CategoryFoodId { get; set; }
        public CategoryFood CategoryFood { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
