using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "70bad780-3e72-46aa-a953-29180d0b49e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "f9470bcd-34cc-401a-9f81-94fdb3bac778", new DateTime(2024, 7, 15, 22, 26, 19, 354, DateTimeKind.Local).AddTicks(6099), new DateTime(2024, 7, 16, 22, 26, 19, 354, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "e1610021-d175-44dc-be02-86838d198143");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                column: "ConcurrencyStamp",
                value: "aa69b99a-065d-41d0-b808-1c1e2283bde8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "c243a189-47e9-4234-b976-e5e16784b658", new DateTime(2024, 7, 2, 22, 26, 19, 354, DateTimeKind.Local).AddTicks(6063), new DateTime(2024, 7, 9, 22, 26, 19, 354, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 26, 19, 349, DateTimeKind.Local).AddTicks(2958), new DateTime(2024, 7, 2, 22, 26, 19, 349, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 26, 19, 349, DateTimeKind.Local).AddTicks(2936), new DateTime(2024, 7, 2, 22, 26, 19, 349, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2024, 7, 2, 22, 26, 19, 349, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 26, 19, 350, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 7, 2, 22, 26, 19, 350, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 1, 22, 26, 19, 350, DateTimeKind.Local).AddTicks(4878), new DateTime(2024, 9, 15, 22, 26, 19, 350, DateTimeKind.Local).AddTicks(4905) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "157cdcbb-3010-406b-98dc-fb983c490b54");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "618e3b63-f828-43d7-87e2-167101a2f00e", new DateTime(2024, 7, 15, 22, 15, 32, 295, DateTimeKind.Local).AddTicks(490), new DateTime(2024, 7, 16, 22, 15, 32, 295, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "6f940e49-9ac6-49ee-b65f-8c30e8ab4aad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                column: "ConcurrencyStamp",
                value: "3b6d7671-1c20-4397-98e6-b232d7236aae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "a15f20f5-52e0-4105-a62d-fc0def7f95d1", new DateTime(2024, 7, 2, 22, 15, 32, 295, DateTimeKind.Local).AddTicks(470), new DateTime(2024, 7, 9, 22, 15, 32, 295, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 15, 32, 293, DateTimeKind.Local).AddTicks(9885), new DateTime(2024, 7, 2, 22, 15, 32, 293, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 15, 32, 293, DateTimeKind.Local).AddTicks(9864), new DateTime(2024, 7, 2, 22, 15, 32, 293, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2024, 7, 2, 22, 15, 32, 293, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 15, 32, 294, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 7, 2, 22, 15, 32, 294, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 1, 22, 15, 32, 294, DateTimeKind.Local).AddTicks(2634), new DateTime(2024, 9, 15, 22, 15, 32, 294, DateTimeKind.Local).AddTicks(2646) });
        }
    }
}
