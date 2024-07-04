using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class seededimages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("18065e6b-eb60-4bbc-a877-829e28fc60d6"),
                column: "ImageUrl",
                value: "/images/event3.jpg");

            migrationBuilder.UpdateData(
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("59a312f0-e57a-4cd7-9c7e-66a29918792d"),
                column: "ImageUrl",
                value: "/images/event3.jpg");

            migrationBuilder.UpdateData(
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("d5e58825-c20b-4e58-9c60-12bc6253681c"),
                column: "ImageUrl",
                value: "/images/event3.jpg");

            migrationBuilder.UpdateData(
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("f0e619aa-c6fc-49cb-9e48-67533f3904ff"),
                column: "ImageUrl",
                value: "/images/event3.jpg");

            migrationBuilder.UpdateData(
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("f376c876-984f-4605-b488-d6bc6872c0bf"),
                column: "ImageUrl",
                value: "/images/event3.jpg");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("257cb7ad-df19-4cac-a009-f68eeb305afa"),
                column: "ImageUrl",
                value: "/images/event1.jpg");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "ImageUrl", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2924), "/images/event1.jpg", new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "ImageUrl", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2894), "/images/event3.jpg", new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                columns: new[] { "ImageUrl", "LastEdited" },
                values: new object[] { "/images/event1.jpg", new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "ImageUrl", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(4999), "/images/event3.jpg", new DateTime(2024, 7, 4, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("85183070-d0af-41a1-9b3b-95d0073995eb"),
                column: "ImageUrl",
                value: "/images/event3.jpg");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "ImageUrl", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 3, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(4983), "/images/event3.jpg", new DateTime(2024, 9, 17, 12, 23, 35, 422, DateTimeKind.Local).AddTicks(4995) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("18065e6b-eb60-4bbc-a877-829e28fc60d6"),
                column: "ImageUrl",
                value: "asd");

            migrationBuilder.UpdateData(
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("59a312f0-e57a-4cd7-9c7e-66a29918792d"),
                column: "ImageUrl",
                value: "asd");

            migrationBuilder.UpdateData(
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("d5e58825-c20b-4e58-9c60-12bc6253681c"),
                column: "ImageUrl",
                value: "asd");

            migrationBuilder.UpdateData(
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("f0e619aa-c6fc-49cb-9e48-67533f3904ff"),
                column: "ImageUrl",
                value: "asd");

            migrationBuilder.UpdateData(
                table: "CharityDonations",
                keyColumn: "CharityDonationId",
                keyValue: new Guid("f376c876-984f-4605-b488-d6bc6872c0bf"),
                column: "ImageUrl",
                value: "asd");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("257cb7ad-df19-4cac-a009-f68eeb305afa"),
                column: "ImageUrl",
                value: "asd");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "ImageUrl", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5762), "asd", new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "ImageUrl", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5727), "asd", new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                columns: new[] { "ImageUrl", "LastEdited" },
                values: new object[] { "asd", new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "ImageUrl", "LastEdited" },
                values: new object[] { new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(8054), "asd", new DateTime(2024, 7, 4, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("85183070-d0af-41a1-9b3b-95d0073995eb"),
                column: "ImageUrl",
                value: "asd");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "ImageUrl", "LastEdited" },
                values: new object[] { new DateTime(2024, 6, 3, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(8040), "asd", new DateTime(2024, 9, 17, 11, 38, 31, 442, DateTimeKind.Local).AddTicks(8050) });
        }
    }
}
