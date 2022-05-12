using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FastFood.Migrations
{
    public partial class FixUnicode_AndSetNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 69, DateTimeKind.Local).AddTicks(6719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 417, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 69, DateTimeKind.Local).AddTicks(6007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 417, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 63, DateTimeKind.Local).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 410, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 63, DateTimeKind.Local).AddTicks(2907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 410, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 54, DateTimeKind.Local).AddTicks(3981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 401, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 54, DateTimeKind.Local).AddTicks(2732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 401, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 48, DateTimeKind.Local).AddTicks(6464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 394, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Foods",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 48, DateTimeKind.Local).AddTicks(5310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 394, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 35, DateTimeKind.Local).AddTicks(4377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 381, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 35, DateTimeKind.Local).AddTicks(2016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 381, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 30, DateTimeKind.Local).AddTicks(304),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 375, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 29, DateTimeKind.Local).AddTicks(9305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 375, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 25, DateTimeKind.Local).AddTicks(2925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 373, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 10, DateTimeKind.Local).AddTicks(3171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 352, DateTimeKind.Local).AddTicks(3031));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 417, DateTimeKind.Local).AddTicks(3405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 69, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 417, DateTimeKind.Local).AddTicks(2854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 69, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 410, DateTimeKind.Local).AddTicks(5179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 63, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 410, DateTimeKind.Local).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 63, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 401, DateTimeKind.Local).AddTicks(1861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 54, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 401, DateTimeKind.Local).AddTicks(579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 54, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 394, DateTimeKind.Local).AddTicks(2447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 48, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 394, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 48, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 381, DateTimeKind.Local).AddTicks(3613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 35, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 381, DateTimeKind.Local).AddTicks(1794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 35, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 375, DateTimeKind.Local).AddTicks(7805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 30, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 375, DateTimeKind.Local).AddTicks(6752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 29, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 373, DateTimeKind.Local).AddTicks(145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 25, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 352, DateTimeKind.Local).AddTicks(3031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 14, 0, 44, 10, DateTimeKind.Local).AddTicks(3171));
        }
    }
}
