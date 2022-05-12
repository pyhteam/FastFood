using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FastFood.Migrations
{
    public partial class FixNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 417, DateTimeKind.Local).AddTicks(2815),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 211, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 417, DateTimeKind.Local).AddTicks(1644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 211, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 409, DateTimeKind.Local).AddTicks(8182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 208, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 409, DateTimeKind.Local).AddTicks(7282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 208, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 390, DateTimeKind.Local).AddTicks(44),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 203, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 389, DateTimeKind.Local).AddTicks(9134),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 203, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 384, DateTimeKind.Local).AddTicks(2326),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 200, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 384, DateTimeKind.Local).AddTicks(813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 200, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 365, DateTimeKind.Local).AddTicks(2541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 193, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 364, DateTimeKind.Local).AddTicks(8241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 193, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 360, DateTimeKind.Local).AddTicks(6388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 190, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 360, DateTimeKind.Local).AddTicks(5290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 189, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 355, DateTimeKind.Local).AddTicks(9123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 188, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 336, DateTimeKind.Local).AddTicks(2972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 177, DateTimeKind.Local).AddTicks(8769));

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
                    { 1, 2, new DateTime(2022, 5, 12, 14, 5, 27, 447, DateTimeKind.Local).AddTicks(6893), "Cơm chiên là một món ăn được làm từ các nguyên liệu như cơm, đậu phụ, thịt bò, thịt gà, thịt gà và thịt nguội.", "comchien.jpg", "Cơm chiên", null, 100000m, "com-chien", "Cơm chiên là một món ăn được làm từ các nguyên liệu như cơm, đậu phụ, thịt bò, thịt gà, thịt gà và thịt nguội." },
                    { 2, 2, new DateTime(2022, 5, 12, 14, 5, 27, 447, DateTimeKind.Local).AddTicks(7465), "Người bệnh tiểu đường loại hai thường xuyên đi bộ, đạp xe, bơi lội, tập thể dục nhịp điệu có thể kiểm soát đường huyết và cân nặng.", "Banh-socola.jpg", "Bánh Socola", null, 90000m, "banh-socola", "Người bệnh tiểu đường loại hai thường xuyên đi bộ, đạp xe, bơi lội, tập thể dục nhịp điệu" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryPostId", "Content", "CreatedAt", "Image", "Slug", "Summary", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Người bệnh tiểu đường loại hai thường xuyên đi bộ, đạp xe, bơi lội, tập thể dục nhịp điệu có thể kiểm soát đường huyết và cân nặng.", new DateTime(2022, 5, 12, 14, 5, 27, 445, DateTimeKind.Local).AddTicks(9988), "post1.jpg", "10-mon-the-thao-cho-nguoi-benh-tieu-duong", "tom tat", "10 môn thể thao cho người bệnh tiểu đường", 1 },
                    { 2, 2, "Nguyên nhân gây bệnh tiểu đường là những nguyên nhân gây bệnh tiểu đường như sau:", new DateTime(2022, 5, 12, 14, 5, 27, 446, DateTimeKind.Local).AddTicks(574), "post2.jpg", "nguyen-nhan-gay-benh-tieu-duong", "Tom tat", "Nguyên nhân gây bệnh tiểu đường", 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ParentId", "PostId", "UserId" },
                values: new object[] { 1, "Tin hay quá", new DateTime(2022, 5, 12, 14, 5, 27, 446, DateTimeKind.Local).AddTicks(3068), null, 1, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ParentId", "PostId", "UserId" },
                values: new object[] { 2, "Bài viết rất tốt", new DateTime(2022, 5, 12, 14, 5, 27, 446, DateTimeKind.Local).AddTicks(3572), null, 2, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ParentId", "PostId", "UserId" },
                values: new object[] { 3, "Bài viết rất tốt nha", new DateTime(2022, 5, 12, 14, 5, 27, 446, DateTimeKind.Local).AddTicks(3582), null, 2, 2 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "ParentId", "PostId", "UserId" },
                values: new object[] { 4, "Cho mình xin thông tin với", new DateTime(2022, 5, 12, 14, 5, 27, 446, DateTimeKind.Local).AddTicks(9145), 2, 2, 3 });
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
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 211, DateTimeKind.Local).AddTicks(9796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 417, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 211, DateTimeKind.Local).AddTicks(9350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 417, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 208, DateTimeKind.Local).AddTicks(2122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 409, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 208, DateTimeKind.Local).AddTicks(1197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 409, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 203, DateTimeKind.Local).AddTicks(4139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 390, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 203, DateTimeKind.Local).AddTicks(3445),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 389, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 200, DateTimeKind.Local).AddTicks(6575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 384, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 200, DateTimeKind.Local).AddTicks(5969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 384, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 193, DateTimeKind.Local).AddTicks(1927),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 365, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 193, DateTimeKind.Local).AddTicks(657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 364, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 190, DateTimeKind.Local).AddTicks(9),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 360, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 189, DateTimeKind.Local).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 360, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 188, DateTimeKind.Local).AddTicks(8964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 355, DateTimeKind.Local).AddTicks(9123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 1, 53, 177, DateTimeKind.Local).AddTicks(8769),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 5, 27, 336, DateTimeKind.Local).AddTicks(2972));
        }
    }
}
