using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class trytologasadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce62c258-29fb-4f21-a038-ccd96bbbec75", "AQAAAAIAAYagAAAAEIvLCcplsf1D24W8Ufk8ZYFZT6wFV83DdWG0qtYWXBTyizYcQ5p6uahZhkl1F59ntQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "c2bc7d4d-0d26-4c5e-8d0b-d1a066cfdb4c", new DateTime(2025, 7, 16, 10, 37, 26, 737, DateTimeKind.Local).AddTicks(9923), new DateTime(2025, 7, 17, 10, 37, 26, 737, DateTimeKind.Local).AddTicks(9972), "AQAAAAIAAYagAAAAEFxxXcXppqey1t6/xCa8nSZFsIBEhtJsQAdkJoXouEVwBzXg2mFsrWhD0y3nv0UeJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c1e89b5-25bf-4afd-96ff-0abe6ee4113f", "AQAAAAIAAYagAAAAENp5L8wVhj42k44rYknvoQUsxosHg+SdUG/1xuRds6EW5hhWQo8HupcqR7hvcrLM6w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b092d122-015f-48f4-80d2-98467bb28f80", true, "AQAAAAIAAYagAAAAENV0aCIrEnuizNArhKxDepFDCjtdWKBtkOCa3S3TMRRteXlDYoOsT1mvKgKeugUhww==", "03f036c2-fc49-4083-ab9f-9d6e9f15db45", "VaskoBilkata" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "ae348b7b-dddd-433a-ab04-559dc33de084", new DateTime(2025, 7, 3, 10, 37, 26, 696, DateTimeKind.Local).AddTicks(9746), new DateTime(2025, 7, 10, 10, 37, 26, 696, DateTimeKind.Local).AddTicks(9790), "AQAAAAIAAYagAAAAEPLKn9QLr6ssGTG1gP0Ja5FtcjL5ZclqyPFnI0QrXvsTsNCYNCbhRe8A/gpKSmbd8w==" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 37, 26, 577, DateTimeKind.Local).AddTicks(6389), new DateTime(2025, 7, 3, 10, 37, 26, 577, DateTimeKind.Local).AddTicks(6391) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 37, 26, 577, DateTimeKind.Local).AddTicks(6331), new DateTime(2025, 7, 3, 10, 37, 26, 577, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2025, 7, 3, 10, 37, 26, 577, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 3, 10, 37, 26, 577, DateTimeKind.Local).AddTicks(7190), new DateTime(2025, 7, 3, 10, 37, 26, 577, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 6, 2, 10, 37, 26, 577, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 9, 16, 10, 37, 26, 577, DateTimeKind.Local).AddTicks(7187) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f26ea9c0-3581-4aa0-a426-9b0b451b7ca5", false, "AQAAAAIAAYagAAAAEO56SwsIaZbMh+v86cSuopTsG3wGdAou1W3i3qwRGjy8ldVtgAzW0v65xopNf96ABg==", null, "Vasko Bilkata" });

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
    }
}
