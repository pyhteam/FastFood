using FastFood.Data;
using FastFood.Models;
using FastFood.Uliti.common;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FastFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FastFoodDbContext context;
        public HomeController(ILogger<HomeController> logger, FastFoodDbContext context)
        {
            this.context = context;
            _logger = logger;

        }
        
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            // check exist Email
            var checkUser = context.Users.FirstOrDefault(x=>x.Email==user.Email);
            if (checkUser != null)
            {
                ModelState.AddModelError("Error", "Email đã tồn tại...!");
                return View();
            }

            if (ModelState.IsValid)
            {
                user.Password = CommonFuntion.MD5(user.Password);
                user.CreatedAt = DateTime.Now;
                user.UpdatedAt = DateTime.Now;
                context.Users.Add(user);
                if(await context.SaveChangesAsync() < 0)
                {
                    ModelState.AddModelError("Error", "Đăng kí thất bại...!");
                    return View();
                }
                ModelState.AddModelError("Success", "Đăng kí thành công..!");
                return View();
            }
            return View();


        }
        public async Task<IActionResult> Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var food = context.Foods.FirstOrDefault(f => f.Id==id);
            return View(food);
        }
        public IActionResult Menu()
        {
            var foods = context.Foods.ToList();
            return View(foods);
        }
        public IActionResult Index()
        {
            var foods = context.Foods.ToList();
            return View(foods);
        }
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Login(string email, string password)
        {
            if(email == "" && password == "")
            {
                return Ok (new ReponseView<User>()
                {
                    StatusCode = 201,
                    Message ="Dữ liệu không được để trống",
                    Data =null,
                });
            }
                ClaimsIdentity identity = null;
                password = CommonFuntion.MD5(password);
                var checkExistUser = context.Users.Where(x=>x.Email==email && x.Password==password).FirstOrDefault();
            if (checkExistUser == null)
            {
                return Ok (new ReponseView<User>()
                {
                    StatusCode = 203,
                    Message = "Tài Khoản không tồn tại",
                    Data = null,
                });
            }
            var userClaims = new List<Claim>()
                 {
                    new Claim(ClaimTypes.NameIdentifier,checkExistUser.Id.ToString()),
                    new Claim(ClaimTypes.Email,checkExistUser.Email),
                    new Claim("Id",checkExistUser.Id.ToString()),
                    new Claim("Phone",checkExistUser.Phone),
                    new Claim("Email",checkExistUser.Email),
                    new Claim(ClaimTypes.Name,checkExistUser.FirstName + checkExistUser.LastName),
                    new Claim(ClaimTypes.Role,checkExistUser.Role.ToString())
                };
            identity = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);
            var userPrincipal = new ClaimsPrincipal(new[] { identity });

            // login 
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                         userPrincipal,
                         new AuthenticationProperties { IsPersistent = true });

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
