using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FastFood.Migrations
{
    public partial class InsertDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 64, DateTimeKind.Local).AddTicks(7790),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 831, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 64, DateTimeKind.Local).AddTicks(6943),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 831, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 60, DateTimeKind.Local).AddTicks(2181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 828, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 60, DateTimeKind.Local).AddTicks(1438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 828, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 54, DateTimeKind.Local).AddTicks(2820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 824, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 54, DateTimeKind.Local).AddTicks(1686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 824, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 49, DateTimeKind.Local).AddTicks(900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 821, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 48, DateTimeKind.Local).AddTicks(9818),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 821, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 43, DateTimeKind.Local).AddTicks(4807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 815, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 43, DateTimeKind.Local).AddTicks(3744),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 814, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 38, DateTimeKind.Local).AddTicks(9619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 813, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 38, DateTimeKind.Local).AddTicks(8897),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 813, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 36, DateTimeKind.Local).AddTicks(7922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 812, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 36, DateTimeKind.Local).AddTicks(7232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 812, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 27, DateTimeKind.Local).AddTicks(9854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 802, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 15, DateTimeKind.Local).AddTicks(3318),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 788, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.InsertData(
                table: "CategoryFoods",
                columns: new[] { "Id", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "Thức uống", "thuc-uong" },
                    { 2, "Đồ ăn", "do-an" },
                    { 3, "Đồ uống", "do-uong" },
                    { 4, "Đô ăn nhẹ", "do-an-nhe" },
                    { 5, "Đô tráng miệng", "do-trang-mieng" },
                    { 6, "Đồ ăn nhanh", "do-an-nhanh" }
                });

            migrationBuilder.InsertData(
                table: "CategoryPosts",
                columns: new[] { "Id", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "Thể thao", "the-thao" },
                    { 2, "Sức khỏe", "suc-khoe" },
                    { 3, "Giải trí", "giai-tri" },
                    { 4, "Khoa học", "khoa-hoc" },
                    { 5, "Thế giới", "the-gioi" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "Status" },
                values: new object[] { 1, "123 Nguyen Van Linh, Quang Nam", "mssen@gmail.com", "MS", "Sen", "e10adc3949ba59abbe56e057f20f883e", "098763543", 2, 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "Password", "Phone", "Status" },
                values: new object[,]
                {
                    { 2, "123 Nguyen Van Linh, Quang Nam", "nguyenvandinh@gmail.com", "Nguyen Van", "Dinh", "e10adc3949ba59abbe56e057f20f883e", "098565543", 1 },
                    { 3, "123 Nguyen Van Linh, Quang Nam", "tranthithuy@gmail.com", "Tran Thi", "Thuy", "e10adc3949ba59abbe56e057f20f883e", "098762543", 1 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CategoryFoodId", "CreatedAt", "Description", "Image", "Name", "OrderId", "Price", "Slug", "Summary" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2022, 5, 12, 20, 49, 54, 83, DateTimeKind.Local).AddTicks(7636), "Cơm chiên là một món ăn được làm từ các nguyên liệu như cơm, đậu phụ, thịt bò, thịt gà, thịt gà và thịt nguội.", "comchien.jpg", "Cơm chiên", null, 100000m, "com-chien", "Cơm chiên là một món ăn được làm từ các nguyên liệu như cơm, đậu phụ, thịt bò, thịt gà, thịt gà và thịt nguội." },
                    { 2, 2, new DateTime(2022, 5, 12, 20, 49, 54, 83, DateTimeKind.Local).AddTicks(8000), "Người bệnh tiểu đường loại hai thường xuyên đi bộ, đạp xe, bơi lội, tập thể dục nhịp điệu có thể kiểm soát đường huyết và cân nặng.", "Banh-socola.jpg", "Bánh Socola", null, 90000m, "banh-socola", "Người bệnh tiểu đường loại hai thường xuyên đi bộ, đạp xe, bơi lội, tập thể dục nhịp điệu" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryPostId", "Content", "CreatedAt", "Image", "Slug", "Summary", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Người bệnh tiểu đường loại hai thường xuyên đi bộ, đạp xe, bơi lội, tập thể dục nhịp điệu có thể kiểm soát đường huyết và cân nặng.", new DateTime(2022, 5, 12, 20, 49, 54, 83, DateTimeKind.Local).AddTicks(1676), "post1.jpg", "10-mon-the-thao-cho-nguoi-benh-tieu-duong", "tom tat", "10 môn thể thao cho người bệnh tiểu đường", 1 },
                    { 2, 2, "Nguyên nhân gây bệnh tiểu đường là những nguyên nhân gây bệnh tiểu đường như sau:", new DateTime(2022, 5, 12, 20, 49, 54, 83, DateTimeKind.Local).AddTicks(2106), "post2.jpg", "nguyen-nhan-gay-benh-tieu-duong", "Tom tat", "Nguyên nhân gây bệnh tiểu đường", 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ParentId", "PostId", "UserId" },
                values: new object[] { 1, "Tin hay quá", new DateTime(2022, 5, 12, 20, 49, 54, 83, DateTimeKind.Local).AddTicks(3782), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ParentId", "PostId", "UserId" },
                values: new object[] { 2, "Bài viết rất tốt", new DateTime(2022, 5, 12, 20, 49, 54, 83, DateTimeKind.Local).AddTicks(4092), null, 2, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ParentId", "PostId", "UserId" },
                values: new object[] { 3, "Bài viết rất tốt nha", new DateTime(2022, 5, 12, 20, 49, 54, 83, DateTimeKind.Local).AddTicks(4098), null, 2, 2 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ParentId", "PostId", "UserId" },
                values: new object[] { 4, "Cho mình xin thông tin với", new DateTime(2022, 5, 12, 20, 49, 54, 83, DateTimeKind.Local).AddTicks(4425), 2, 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryFoods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryFoods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryFoods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryFoods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryFoods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoryPosts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryPosts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryPosts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryFoods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryPosts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryPosts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 831, DateTimeKind.Local).AddTicks(4871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 64, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 831, DateTimeKind.Local).AddTicks(4401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 64, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 828, DateTimeKind.Local).AddTicks(1472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 60, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 828, DateTimeKind.Local).AddTicks(985),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 60, DateTimeKind.Local).AddTicks(1438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 824, DateTimeKind.Local).AddTicks(5134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 54, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 824, DateTimeKind.Local).AddTicks(4530),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 54, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 821, DateTimeKind.Local).AddTicks(9174),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 49, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 821, DateTimeKind.Local).AddTicks(8585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 48, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 815, DateTimeKind.Local).AddTicks(41),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 43, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 814, DateTimeKind.Local).AddTicks(9541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 43, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 813, DateTimeKind.Local).AddTicks(2896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 38, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 813, DateTimeKind.Local).AddTicks(2468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 38, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 812, DateTimeKind.Local).AddTicks(1846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 36, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 812, DateTimeKind.Local).AddTicks(1194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 36, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 802, DateTimeKind.Local).AddTicks(3360),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 27, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 19, 49, 28, 788, DateTimeKind.Local).AddTicks(7837),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 20, 49, 54, 15, DateTimeKind.Local).AddTicks(3318));
        }
    }
}
