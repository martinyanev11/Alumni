using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class homo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d23fe586-7d83-4aa3-bab5-99cf956d0522"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "4FF41592-5852-41D2-AC58-15B64B4BDF34", "ADMIN" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("d23fe586-7d83-4aa3-bab5-99cf956d0522"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "8d6bb117-cedb-4608-ab9c-4a68d4c82141");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "8bc8939b-4214-4d99-b3a8-ccbc4e25f5ef", new DateTime(2024, 7, 15, 22, 11, 3, 307, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 7, 16, 22, 11, 3, 307, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "a28c21db-9f56-4d1e-8a95-7d606280f777");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                column: "ConcurrencyStamp",
                value: "48f52a83-8359-40de-8ec8-29c7bcd6a08e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "06d6c87a-9f89-44c0-88cf-14c4f343af8c", new DateTime(2024, 7, 2, 22, 11, 3, 307, DateTimeKind.Local).AddTicks(4878), new DateTime(2024, 7, 9, 22, 11, 3, 307, DateTimeKind.Local).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(892), new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(4465), new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 1, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(4445), new DateTime(2024, 9, 15, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(4457) });
        }
    }
}
