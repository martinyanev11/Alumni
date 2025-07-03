using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class addEmailForAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "66ff16ec-21a3-4b62-b242-0a001b782805");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "9bc9d731-8b09-4f42-9ec9-859cb05eb569", new DateTime(2025, 7, 16, 10, 17, 51, 508, DateTimeKind.Local).AddTicks(1765), new DateTime(2025, 7, 17, 10, 17, 51, 508, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "779ecf64-b5bf-4a7d-a90a-0f72832382ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "4c5376bc-9853-4ad5-a795-f2770ccbdf4f", "VaskoBilkata@gmail.com", "VASKOBILKATA@gmail.COM", "AQAAAAIAAYagAAAAEPbyF4tixptG2EhfVG6N1sYI2Dvc+hNTqbf2cCKA0xOKCWrWw6dj7suYPoUNs+Qlhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "4aa72fdb-7bea-44d3-afc8-7637b1e3cebd", new DateTime(2025, 7, 3, 10, 17, 51, 508, DateTimeKind.Local).AddTicks(1727), new DateTime(2025, 7, 10, 10, 17, 51, 508, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 17, 51, 464, DateTimeKind.Local).AddTicks(1927), new DateTime(2025, 7, 3, 10, 17, 51, 464, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 17, 51, 464, DateTimeKind.Local).AddTicks(1841), new DateTime(2025, 7, 3, 10, 17, 51, 464, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2025, 7, 3, 10, 17, 51, 464, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 17, 51, 464, DateTimeKind.Local).AddTicks(3231), new DateTime(2025, 7, 3, 10, 17, 51, 464, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 6, 2, 10, 17, 51, 464, DateTimeKind.Local).AddTicks(3210), new DateTime(2025, 9, 16, 10, 17, 51, 464, DateTimeKind.Local).AddTicks(3226) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "8188652d-782c-4cea-80c5-7e050d2b142a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "bde1b935-017e-47d7-a713-2759dc5e3045", new DateTime(2025, 7, 16, 10, 15, 30, 469, DateTimeKind.Local).AddTicks(8815), new DateTime(2025, 7, 17, 10, 15, 30, 469, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "4ac45708-d9f7-403d-bc1b-5169cb781e67");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "a6dfbe95-9743-4917-ab14-91011bcdae53", null, null, "AQAAAAIAAYagAAAAELDRwIsKlYc93BHXFbeOOk49NM0RhhRWuk2bD9u4Ai8euCjUzPyaXgCsqVV7hLpLcA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "8fb5c740-16b2-4fa6-b54e-365e273bd391", new DateTime(2025, 7, 3, 10, 15, 30, 469, DateTimeKind.Local).AddTicks(8765), new DateTime(2025, 7, 10, 10, 15, 30, 469, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 15, 30, 427, DateTimeKind.Local).AddTicks(3369), new DateTime(2025, 7, 3, 10, 15, 30, 427, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 15, 30, 427, DateTimeKind.Local).AddTicks(3322), new DateTime(2025, 7, 3, 10, 15, 30, 427, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2025, 7, 3, 10, 15, 30, 427, DateTimeKind.Local).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 15, 30, 427, DateTimeKind.Local).AddTicks(4041), new DateTime(2025, 7, 3, 10, 15, 30, 427, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 6, 2, 10, 15, 30, 427, DateTimeKind.Local).AddTicks(4032), new DateTime(2025, 9, 16, 10, 15, 30, 427, DateTimeKind.Local).AddTicks(4037) });
        }
    }
}
