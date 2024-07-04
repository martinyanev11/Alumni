using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class news : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "80c041f9-9abe-4790-836c-ff2f0351f5c3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "9c59b2c7-e064-4a8d-9de6-9e31188ccc9f", new DateTime(2024, 7, 17, 11, 38, 31, 443, DateTimeKind.Local).AddTicks(4242), new DateTime(2024, 7, 18, 11, 38, 31, 443, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "08317cce-2cc9-45d6-9c87-be1bcd424a44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                column: "ConcurrencyStamp",
                value: "0ff0b97b-b758-47a3-8672-8d0ff2e8e452");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "9e608090-fe22-4b78-ab5f-ee0275903475", new DateTime(2024, 7, 4, 11, 38, 31, 443, DateTimeKind.Local).AddTicks(4228), new DateTime(2024, 7, 11, 11, 38, 31, 443, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("541e7f5d-4016-474e-acd2-2f30ecd9a446"),
                column: "ImageUrl",
                value: "/images/event2.jpg");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5762), new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("87c281f4-5052-47a5-a6f4-75c9741663ef"),
                column: "ImageUrl",
                value: "/images/event1.jpg");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9a1172e2-e2e5-44fd-92e6-285c1154e8dc"),
                column: "ImageUrl",
                value: "/images/event3.jpg");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(8054), new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 3, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 9, 17, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(8050) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("541e7f5d-4016-474e-acd2-2f30ecd9a446"),
                column: "ImageUrl",
                value: "asd");

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
                keyValue: new Guid("87c281f4-5052-47a5-a6f4-75c9741663ef"),
                column: "ImageUrl",
                value: "asd");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2024, 7, 2, 22, 26, 19, 349, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9a1172e2-e2e5-44fd-92e6-285c1154e8dc"),
                column: "ImageUrl",
                value: "asd");

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
    }
}
