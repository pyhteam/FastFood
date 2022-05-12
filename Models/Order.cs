using FastFood.Uliti;
using System;
using System.Collections.Generic;

namespace FastFood.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Food> Foods { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public EOrderType OrderType { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }
        public EOrderStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
       
    }
}
