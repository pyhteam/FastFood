using FastFood.Data;
using FastFood.Models;
using FastFood.Uliti.common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Security.Claims;

namespace FastFood.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly FastFoodDbContext context;
        public OrderController(ILogger<OrderController> logger, FastFoodDbContext context)
        {
            this.context = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //[Authorize]
        public IActionResult AddToCart(int? foodId)
        {
            if(foodId == null)
            {
                return NotFound( new { status=404, message = "Food not found" });
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
           // var checkExistFood = context.Carts.FirstOrDefault(x => x.FoodId == foodId);
           
            Cart cart = new Cart()
            {
                FoodId = (int)foodId,
                UserId = Convert.ToInt32(userId),
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            
            };
            context.Carts.Add(cart);
            if (context.SaveChanges() <= 0)
            {
                return Ok(new { status = 203, message = "Something went wrong" });
            }
            return Ok(new { status = 200, message = "Added to cart" });
            
        }
        public IActionResult DetailCart()
        {
            int userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            //var amount = context.Carts.Where(x => x.FoodId == x.Food.Id && x.UserId == userId).Distinct();

            var cart = context.Carts.Include(x => x.User)
                .Include(x => x.Food)

                .Select(x => new CartView()
                {
                    Id = x.Id,
                    UserId = Convert.ToInt32(x.UserId),
                    UserName = x.User.FirstName + " " + x.User.LastName,
                    FoodId = x.FoodId,
                    FoodName = x.Food.Name,
                    Price = x.Food.Price,
                  //  Amount = amount.Count(),
                  //  ToTalPrice = Convert.ToInt32(x.Food.Price * amount.Count()),
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt

                }).Distinct()
                .ToList();


            return View(cart);
        }
        [HttpPost]
        public IActionResult Payment()
        {
            int userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var carts = context.Carts.Where(x => x.FoodId == x.Food.Id && x.UserId == userId).ToList();
            if (carts == null)
            {
                return Ok(new { status = 404, message = "Cart is null" });
            }
            var amount = context.Carts.Where(x => x.FoodId == x.Food.Id && x.UserId == userId).Distinct();
            var totalPrice = amount.Sum(x => x.Food.Price);

            // insert to order
            Order order = new Order()
            {
                Amount = amount.Count(),
                OrderType = Uliti.EOrderType.PAYMENT_COD,
                TotalPrice = totalPrice,
                Status = Uliti.EOrderStatus.Aprove,
                UserId = userId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                
            };
            context.Orders.Add(order);
            if (context.SaveChanges() <= 0)
            {
                return Ok(new { status = 203, message = "Something went wrong" });
            }
            // remove all card by user
            var removeAll = context.Carts.Where(x => x.UserId == userId);
            context.Carts.RemoveRange(removeAll);
            context.SaveChanges();

            return Ok(new { status = 200, message = "Added to cart" });
        }
        public IActionResult RemoveCart(int? id)
        {
            if (id == null)
            {
                return NotFound(new { status = 404, message = "Cart not found" });
            }
            var cart = context.Carts.FirstOrDefault(x => x.Id == id);
            if (cart == null)
            {
                return NotFound(new { status = 404, message = "Cart not found" });
            }
            context.Carts.Remove(cart);
            if (context.SaveChanges() <= 0)
            {
                return Ok(new { status = 203, message = "Something went wrong" });
            }
            return Ok(new { status = 200, message = "Removed from cart" });
            
        }

    }
}
