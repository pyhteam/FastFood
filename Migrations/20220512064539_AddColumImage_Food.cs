using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FastFood.Migrations
{
    public partial class AddColumImage_Food : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 417, DateTimeKind.Local).AddTicks(3405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 729, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 417, DateTimeKind.Local).AddTicks(2854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 729, DateTimeKind.Local).AddTicks(1098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 410, DateTimeKind.Local).AddTicks(5179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 724, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 410, DateTimeKind.Local).AddTicks(4007),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 724, DateTimeKind.Local).AddTicks(1401));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 401, DateTimeKind.Local).AddTicks(1861),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 717, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 401, DateTimeKind.Local).AddTicks(579),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 717, DateTimeKind.Local).AddTicks(4959));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 394, DateTimeKind.Local).AddTicks(2447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 713, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 394, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 713, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 381, DateTimeKind.Local).AddTicks(3613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 706, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 381, DateTimeKind.Local).AddTicks(1794),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 706, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 375, DateTimeKind.Local).AddTicks(7805),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 703, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 375, DateTimeKind.Local).AddTicks(6752),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 703, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 373, DateTimeKind.Local).AddTicks(145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 702, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 352, DateTimeKind.Local).AddTicks(3031),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 688, DateTimeKind.Local).AddTicks(8030));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Foods");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 729, DateTimeKind.Local).AddTicks(1906),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 417, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 729, DateTimeKind.Local).AddTicks(1098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 417, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 724, DateTimeKind.Local).AddTicks(2129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 410, DateTimeKind.Local).AddTicks(5179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 724, DateTimeKind.Local).AddTicks(1401),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 410, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 717, DateTimeKind.Local).AddTicks(5656),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 401, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 717, DateTimeKind.Local).AddTicks(4959),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 401, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 713, DateTimeKind.Local).AddTicks(1743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 394, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 713, DateTimeKind.Local).AddTicks(1120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 394, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 706, DateTimeKind.Local).AddTicks(2222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 381, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 706, DateTimeKind.Local).AddTicks(1010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 381, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 703, DateTimeKind.Local).AddTicks(9136),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 375, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 703, DateTimeKind.Local).AddTicks(8667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 375, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 702, DateTimeKind.Local).AddTicks(4756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 373, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "CategoryFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 5, 12, 12, 22, 44, 688, DateTimeKind.Local).AddTicks(8030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 5, 12, 13, 45, 38, 352, DateTimeKind.Local).AddTicks(3031));
        }
    }
}
