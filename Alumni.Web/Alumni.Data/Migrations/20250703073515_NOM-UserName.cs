using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class NOMUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7d71707a-433b-43dd-a340-89c65e007fcf", "AQAAAAIAAYagAAAAEG5kyf9+6qGpOmSvDQ82QSDCuVA1RlRaMQ7dQdH4NJNFDQeKgbZk0txyoMA5zwvaPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "7f10a8d4-3225-40a7-8b22-8ef0050f13b8", new DateTime(2025, 7, 16, 10, 35, 14, 710, DateTimeKind.Local).AddTicks(8727), new DateTime(2025, 7, 17, 10, 35, 14, 710, DateTimeKind.Local).AddTicks(8786), "AQAAAAIAAYagAAAAEPpyFJmv4EzT/Wx0AmbadQ1Jk8PWszPC4nfsldPmkPaDZdh8S0qx02fK+M5tHZeamg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71777dd4-60b1-4b73-8340-9f8cb1efaecc", "AQAAAAIAAYagAAAAEFrmOwcLiWho5Bq/NwGiG20DmENZ6lnYdMug7Y/tKMMSqjyu2iyYp3IcoYPEsbv3DA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "f26ea9c0-3581-4aa0-a426-9b0b451b7ca5", "VASKOBILKATA", "AQAAAAIAAYagAAAAEO56SwsIaZbMh+v86cSuopTsG3wGdAou1W3i3qwRGjy8ldVtgAzW0v65xopNf96ABg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "8443f418-fc48-43e6-8de1-d7c63f7b88b9", new DateTime(2025, 7, 3, 10, 35, 14, 664, DateTimeKind.Local).AddTicks(4816), new DateTime(2025, 7, 10, 10, 35, 14, 664, DateTimeKind.Local).AddTicks(4883), "AQAAAAIAAYagAAAAEFzyJxrC7rijml4AH6gcAPjwOOmQp29FO5za0gOw1zulhG0cV8UNDFZXBQ7Q3hfcSA==" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 35, 14, 542, DateTimeKind.Local).AddTicks(3774), new DateTime(2025, 7, 3, 10, 35, 14, 542, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 35, 14, 542, DateTimeKind.Local).AddTicks(3722), new DateTime(2025, 7, 3, 10, 35, 14, 542, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2025, 7, 3, 10, 35, 14, 542, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 35, 14, 542, DateTimeKind.Local).AddTicks(4580), new DateTime(2025, 7, 3, 10, 35, 14, 542, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 6, 2, 10, 35, 14, 542, DateTimeKind.Local).AddTicks(4569), new DateTime(2025, 9, 16, 10, 35, 14, 542, DateTimeKind.Local).AddTicks(4576) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "8aea700b-92f3-4ba2-8940-986607ad4bae", null, "AQAAAAIAAYagAAAAEM1pBqq4PrSFSBnH4suwr+nxMtt0lYqvJ6+yqZKJaUyb3BP2dWmoGUADg/Zcpbej4A==" });

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
    }
}
