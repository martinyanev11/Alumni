using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "9cc570fe-dc9a-4fc9-b6f2-766101ec0946");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "cdb37f1a-268d-45b3-a4f2-ba3d88385596", new DateTime(2024, 7, 15, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(811), new DateTime(2024, 7, 16, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "496c63cb-858f-4fac-8964-b705fd3357f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                column: "ConcurrencyStamp",
                value: "b3a3a991-cd70-4f9f-882e-19d6ca310830");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "2756ccca-fd9e-465c-9f3b-82e2f705efc6", new DateTime(2024, 7, 2, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(759), new DateTime(2024, 7, 9, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(1467), new DateTime(2024, 7, 2, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 7, 2, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2024, 7, 2, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 2, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(1123), new DateTime(2024, 7, 2, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 1, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(1116), new DateTime(2024, 9, 15, 5, 4, 7, 294, DateTimeKind.Local).AddTicks(1119) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "bbb8a124-ff9f-4146-b1ff-c1a1848f9300");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "1114fb0c-d3f2-4994-aebc-707f84e270e0", new DateTime(2024, 7, 11, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8325), new DateTime(2024, 7, 12, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "24826760-fd68-4811-ac0d-4c49f1ff0726");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                column: "ConcurrencyStamp",
                value: "3365c379-ae79-4841-93bb-9ede0e6c750b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "b07f1e43-7bd6-4c88-98a7-2baf55cd25bc", new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8275), new DateTime(2024, 7, 5, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8914), new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8602), new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2024, 5, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 9, 11, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8598) });
        }
    }
}
