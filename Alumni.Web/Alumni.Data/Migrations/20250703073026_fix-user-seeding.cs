using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixuserseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fcae851a-7bce-455c-b1b9-2d5d9f7b6ad7", "AQAAAAIAAYagAAAAEKQ5DV+1tD7/TxRzfaP7QGNumwOEjuC48QjOlWL1cZwYZDgVRUNF281vV0gBQL/toQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "8e7eeafc-efe0-4ae0-91d1-fdd801e4e273", new DateTime(2025, 7, 16, 10, 30, 25, 709, DateTimeKind.Local).AddTicks(2477), new DateTime(2025, 7, 17, 10, 30, 25, 709, DateTimeKind.Local).AddTicks(2541), "AQAAAAIAAYagAAAAEAaSjBtK+no50Rl72E87nlyq1me8O8f1gsVv8AYrMc/C7zG+cMH4mek4ngjpbtlNEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1227b40-41a8-4324-8af4-609127e13218", "AQAAAAIAAYagAAAAEO4bmllz95Q90vWtgde7islizaJHUHoIwsecrDybw8GtGKQ3PAljo6XLGXOUjdUdqw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "8aea700b-92f3-4ba2-8940-986607ad4bae", "VASKOBILKATA@GMAIL.COM", "AQAAAAIAAYagAAAAEM1pBqq4PrSFSBnH4suwr+nxMtt0lYqvJ6+yqZKJaUyb3BP2dWmoGUADg/Zcpbej4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "5316f0f1-5d04-4d13-a7b3-da11cf140e4b", new DateTime(2025, 7, 3, 10, 30, 25, 664, DateTimeKind.Local).AddTicks(109), new DateTime(2025, 7, 10, 10, 30, 25, 664, DateTimeKind.Local).AddTicks(164), "AQAAAAIAAYagAAAAEEiamtQE8cD/Ah9DMoE1FFtFfjRM/TuE5HEEiVRf9Tqiz/NZFLgpcuTZpgIwGpM8Lw==" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 30, 25, 545, DateTimeKind.Local).AddTicks(8756), new DateTime(2025, 7, 3, 10, 30, 25, 545, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 30, 25, 545, DateTimeKind.Local).AddTicks(8698), new DateTime(2025, 7, 3, 10, 30, 25, 545, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2025, 7, 3, 10, 30, 25, 545, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 30, 25, 545, DateTimeKind.Local).AddTicks(9477), new DateTime(2025, 7, 3, 10, 30, 25, 545, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 6, 2, 10, 30, 25, 545, DateTimeKind.Local).AddTicks(9463), new DateTime(2025, 9, 16, 10, 30, 25, 545, DateTimeKind.Local).AddTicks(9474) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66ff16ec-21a3-4b62-b242-0a001b782805", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "9bc9d731-8b09-4f42-9ec9-859cb05eb569", new DateTime(2025, 7, 16, 10, 17, 51, 508, DateTimeKind.Local).AddTicks(1765), new DateTime(2025, 7, 17, 10, 17, 51, 508, DateTimeKind.Local).AddTicks(1767), null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "779ecf64-b5bf-4a7d-a90a-0f72832382ae", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "4c5376bc-9853-4ad5-a795-f2770ccbdf4f", "VASKOBILKATA@gmail.COM", "AQAAAAIAAYagAAAAEPbyF4tixptG2EhfVG6N1sYI2Dvc+hNTqbf2cCKA0xOKCWrWw6dj7suYPoUNs+Qlhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "4aa72fdb-7bea-44d3-afc8-7637b1e3cebd", new DateTime(2025, 7, 3, 10, 17, 51, 508, DateTimeKind.Local).AddTicks(1727), new DateTime(2025, 7, 10, 10, 17, 51, 508, DateTimeKind.Local).AddTicks(1756), null });

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
    }
}
