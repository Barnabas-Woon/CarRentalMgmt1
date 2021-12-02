using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalMgmt.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "9cc6af35-2eea-4b58-88bd-2c48bb79a984", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "564ae703-0966-4bbf-bb79-c4fee4abaa87", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "dde9029f-907e-4412-b1cc-cc5dc457b991", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEE6rZjqzSdiBYTDTzxU+Sb67N8NiwP25WVLboj2WqkHcRv1BoM5CpIj3RcQaZMTfvw==", null, false, "4bfc2af6-2805-4db3-8a2f-8e35bfec0c50", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 48, 27, 404, DateTimeKind.Local).AddTicks(250), new DateTime(2021, 12, 2, 19, 48, 27, 404, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 48, 27, 404, DateTimeKind.Local).AddTicks(7776), new DateTime(2021, 12, 2, 19, 48, 27, 404, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(5845), new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(5857), new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(8189), new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(8198), new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(8200), new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(8202), new DateTime(2021, 12, 2, 19, 48, 27, 405, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 42, 24, 341, DateTimeKind.Local).AddTicks(8747), new DateTime(2021, 12, 2, 19, 42, 24, 342, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 42, 24, 342, DateTimeKind.Local).AddTicks(7708), new DateTime(2021, 12, 2, 19, 42, 24, 342, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 42, 24, 343, DateTimeKind.Local).AddTicks(7176), new DateTime(2021, 12, 2, 19, 42, 24, 343, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 42, 24, 343, DateTimeKind.Local).AddTicks(7191), new DateTime(2021, 12, 2, 19, 42, 24, 343, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(220), new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(227), new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(229), new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(232), new DateTime(2021, 12, 2, 19, 42, 24, 344, DateTimeKind.Local).AddTicks(233) });
        }
    }
}
