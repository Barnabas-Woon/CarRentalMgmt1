using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalMgmt.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 2, 19, 42, 24, 341, DateTimeKind.Local).AddTicks(8747), new DateTime(2021, 12, 2, 19, 42, 24, 342, DateTimeKind.Local).AddTicks(7128), "Black", "System" },
                    { 2, "System", new DateTime(2021, 12, 2, 19, 42, 24, 342, DateTimeKind.Local).AddTicks(7708), new DateTime(2021, 12, 2, 19, 42, 24, 342, DateTimeKind.Local).AddTicks(7711), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 2, 19, 42, 24, 343, DateTimeKind.Local).AddTicks(7176), new DateTime(2021, 12, 2, 19, 42, 24, 343, DateTimeKind.Local).AddTicks(7188), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 12, 2, 19, 42, 24, 343, DateTimeKind.Local).AddTicks(7191), new DateTime(2021, 12, 2, 19, 42, 24, 343, DateTimeKind.Local).AddTicks(7192), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(220), new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(225), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(227), new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(228), "X5", "System" },
                    { 3, "System", new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(229), new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(230), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(232), new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(233), "Rav4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
