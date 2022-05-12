using FastFood.Models;
using FastFood.Uliti;
using FastFood.Uliti.common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace FastFood.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // new user
            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id=1,
                FirstName = "MS",
                LastName = "Sen",
                Email = "mssen@gmail.com",
                Address = "123 Nguyen Van Linh, Quang Nam",
                Phone = "098763543",
                Password = CommonFuntion.MD5("123456"),
                Status = EUserStatus.Active,
                Role = ERoles.Admin,
            },
            new User
            {
                Id = 2,
                FirstName = "Nguyen Van",
                LastName = "Dinh",
                Email = "nguyenvandinh@gmail.com",
                Address = "123 Nguyen Van Linh, Quang Nam",
                Phone = "098565543",
                Password = CommonFuntion.MD5("123456"),
                Status = EUserStatus.Active,
                Role = ERoles.Member,
            },
            new User
            {
                Id =3,
                FirstName = "Tran Thi",
                LastName = "Thuy",
                Email = "tranthithuy@gmail.com",
                Address = "123 Nguyen Van Linh, Quang Nam",
                Phone = "098762543",
                Password = CommonFuntion.MD5("123456"),
                Status = EUserStatus.Active,
                Role = ERoles.Member,
            }
            );

            // CategoryFood
            modelBuilder.Entity<CategoryFood>().HasData(
                new CategoryFood{ Id = 1,Name = "Thức uống",Slug =CommonFuntion.UrlFriendly("Thức uống") },
                new CategoryFood{ Id = 2,Name = "Đồ ăn",Slug =CommonFuntion.UrlFriendly("Đồ ăn") },
                new CategoryFood{ Id = 3,Name = "Đồ uống",Slug =CommonFuntion.UrlFriendly("Đồ uống") },
                new CategoryFood{ Id = 4,Name = "Đô ăn nhẹ",Slug =CommonFuntion.UrlFriendly("Đô ăn nhẹ") },
                new CategoryFood{ Id = 5,Name = "Đô tráng miệng",Slug =CommonFuntion.UrlFriendly("Đồ tráng miệng") },
                new CategoryFood{ Id = 6,Name = "Đồ ăn nhanh",Slug =CommonFuntion.UrlFriendly("Đồ ăn nhanh") }
            );
            // Category Post
            modelBuilder.Entity<CategoryPost>().HasData(
                new CategoryPost{ Id = 1,Name = "Thể thao",Slug =CommonFuntion.UrlFriendly("Thể thao") },
                new CategoryPost{ Id = 2,Name = "Sức khỏe",Slug =CommonFuntion.UrlFriendly("Sức khỏe") },
                new CategoryPost{ Id = 3,Name = "Giải trí",Slug =CommonFuntion.UrlFriendly("Giải trí") },
                new CategoryPost{ Id = 4,Name = "Khoa học",Slug =CommonFuntion.UrlFriendly("Khoa học") },
                new CategoryPost{ Id = 5,Name = "Thế giới",Slug =CommonFuntion.UrlFriendly("Thế giới") }
            );
            // Post
            modelBuilder.Entity<Post>().HasData(
                new Post{ Id = 1,Title = "10 môn thể thao cho người bệnh tiểu đường",Image="post1.jpg", Slug=CommonFuntion.UrlFriendly("10 môn thể thao cho người bệnh tiểu đường"),Summary="tom tat", Content = "Người bệnh tiểu đường loại hai thường xuyên đi bộ, đạp xe, bơi lội, tập thể dục nhịp điệu có thể kiểm soát đường huyết và cân nặng.", CategoryPostId = 1,UserId = 1,CreatedAt = DateTime.Now },
                new Post{ Id = 2,Title = "Nguyên nhân gây bệnh tiểu đường",Image="post2.jpg",Slug=CommonFuntion.UrlFriendly("Nguyên nhân gây bệnh tiểu đường"),Summary="Tom tat", Content = "Nguyên nhân gây bệnh tiểu đường là những nguyên nhân gây bệnh tiểu đường như sau:", CategoryPostId = 2,UserId = 1,CreatedAt = DateTime.Now }
            );

            // comment post
            modelBuilder.Entity<Comment>().HasData(
                new Comment { Id = 1,Content = "Tin hay quá",PostId = 1,UserId = 1,CreatedAt = DateTime.Now },
                new Comment { Id = 2,Content = "Bài viết rất tốt",PostId = 2,UserId = 1,CreatedAt = DateTime.Now },
                new Comment { Id = 3,Content = "Bài viết rất tốt nha",PostId = 2,UserId = 2,CreatedAt = DateTime.Now },
                new Comment { Id = 4,Content = "Cho mình xin thông tin với",PostId = 2,UserId = 3,ParentId=2,CreatedAt = DateTime.Now }
            );
            // Food
            modelBuilder.Entity<Food>().HasData(
                new Food{ 
                    Id = 1,
                    Name = "Cơm chiên",
                    Slug = CommonFuntion.UrlFriendly("Cơm chiên"),
                    Summary = "Cơm chiên là một món ăn được làm từ các nguyên liệu như cơm, đậu phụ, thịt bò, thịt gà, thịt gà và thịt nguội.",
                    Description = "Cơm chiên là một món ăn được làm từ các nguyên liệu như cơm, đậu phụ, thịt bò, thịt gà, thịt gà và thịt nguội.",
                    Price = 100000,
                    Image ="comchien.jpg",
                  
                    CategoryFoodId = 2,
                    CreatedAt = DateTime.Now 
                },
                new Food{ 
                    Id = 2,
                    Name = "Bánh Socola",
                    Slug = CommonFuntion.UrlFriendly("Bánh Socola"),
                    Summary = "Người bệnh tiểu đường loại hai thường xuyên đi bộ, đạp xe, bơi lội, tập thể dục nhịp điệu",
                    Description ="Người bệnh tiểu đường loại hai thường xuyên đi bộ, đạp xe, bơi lội, tập thể dục nhịp điệu có thể kiểm soát đường huyết và cân nặng.",
                    Price = 90000,
                    Image ="Banh-socola.jpg",
                    CategoryFoodId = 2,
                    CreatedAt = DateTime.Now 
                }
            );
        }
    }
}
