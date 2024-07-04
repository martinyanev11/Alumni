using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class seededimagess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "f90b2733-1af9-494d-8b99-5e1b5133e12a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "b0aa3b86-64fe-40b4-90be-a91fd3ee84e2", new DateTime(2024, 7, 17, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(8424), new DateTime(2024, 7, 18, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "09213f80-5e0d-4dbd-928b-7fa62dca778b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                column: "ConcurrencyStamp",
                value: "c72f1d1f-ef6a-4ec0-8b9a-5d1ad00a0254");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "f46a8536-233b-41ed-a0ff-bac64b49edbe", new DateTime(2024, 7, 4, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(8407), new DateTime(2024, 7, 11, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 7, 4, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(1861), new DateTime(2024, 7, 4, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2024, 7, 4, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(3547), new DateTime(2024, 7, 4, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 3, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 9, 17, 12, 57, 42, 16, DateTimeKind.Local).AddTicks(3543) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "d417c1f6-de25-4fae-8928-081039c9603c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "e076261b-fb1c-4be3-939f-2aae8f31bc25", new DateTime(2024, 7, 17, 12, 23, 35, 423, DateTimeKind.Local).AddTicks(1053), new DateTime(2024, 7, 18, 12, 23, 35, 423, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "b96721cb-ad4a-4654-a35e-84187e53bbb0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                column: "ConcurrencyStamp",
                value: "c85ef801-1d0f-481d-99a8-104d8b0711a5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "b55299e7-718b-433e-badf-87aa63dac61a", new DateTime(2024, 7, 4, 12, 23, 35, 423, DateTimeKind.Local).AddTicks(1041), new DateTime(2024, 7, 11, 12, 23, 35, 423, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2924), new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2894), new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(4999), new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 3, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(4983), new DateTime(2024, 9, 17, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(4995) });
        }
    }
}
