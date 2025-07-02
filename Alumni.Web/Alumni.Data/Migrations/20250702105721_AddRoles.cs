using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("b6154565-c62f-433a-98c6-218fde24559f"), "YOUR_NEW_CONCURRENCY_STAMP_FOR_ALUMNI", "Alumni", "ALUMNI" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                column: "ConcurrencyStamp",
                value: "bc84f238-7254-41de-9244-519078c96ca4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "a229cda2-a8ca-47b1-8d00-974ca5d1e97a", new DateTime(2025, 7, 15, 13, 57, 20, 832, DateTimeKind.Local).AddTicks(7295), new DateTime(2025, 7, 16, 13, 57, 20, 832, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                column: "ConcurrencyStamp",
                value: "09f8f50c-c62c-4a5d-824f-3d149f90fc10");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                column: "ConcurrencyStamp",
                value: "1f49470c-1233-405d-a8da-f5753a5575e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited" },
                values: new object[] { "846ddb49-cd38-4705-9d3f-d3fda2a8de2b", new DateTime(2025, 7, 2, 13, 57, 20, 832, DateTimeKind.Local).AddTicks(7236), new DateTime(2025, 7, 9, 13, 57, 20, 832, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 57, 20, 831, DateTimeKind.Local).AddTicks(5941), new DateTime(2025, 7, 2, 13, 57, 20, 831, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 57, 20, 831, DateTimeKind.Local).AddTicks(5887), new DateTime(2025, 7, 2, 13, 57, 20, 831, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2025, 7, 2, 13, 57, 20, 831, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 2, 13, 57, 20, 831, DateTimeKind.Local).AddTicks(6794), new DateTime(2025, 7, 2, 13, 57, 20, 831, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 6, 1, 13, 57, 20, 831, DateTimeKind.Local).AddTicks(6784), new DateTime(2025, 9, 15, 13, 57, 20, 831, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b6154565-c62f-433a-98c6-218fde24559f"), new Guid("30913bf8-4000-4809-801e-764de3136c0e") },
                    { new Guid("b6154565-c62f-433a-98c6-218fde24559f"), new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80") },
                    { new Guid("b6154565-c62f-433a-98c6-218fde24559f"), new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") },
                    { new Guid("b6154565-c62f-433a-98c6-218fde24559f"), new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b6154565-c62f-433a-98c6-218fde24559f"), new Guid("30913bf8-4000-4809-801e-764de3136c0e") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b6154565-c62f-433a-98c6-218fde24559f"), new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b6154565-c62f-433a-98c6-218fde24559f"), new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("b6154565-c62f-433a-98c6-218fde24559f"), new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b6154565-c62f-433a-98c6-218fde24559f"));

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
    }
}
