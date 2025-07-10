using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class responderNameIvane : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResponderName",
                table: "HelpResponses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17e0c525-d0a5-49ee-93bb-27da12c6d2f6", "AQAAAAIAAYagAAAAEHhepSv3HAu8oR3YYp52GL8iLDk5Q12WNPs/syOWz4szmTlij2aXPm8xz2JzJutCvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "60348994-c1d6-4062-b737-6ab1e4f41b93", new DateTime(2025, 7, 22, 16, 29, 0, 763, DateTimeKind.Local).AddTicks(3690), new DateTime(2025, 7, 23, 16, 29, 0, 763, DateTimeKind.Local).AddTicks(3733), "AQAAAAIAAYagAAAAEHejvDSCcd4xW/X1cgrPkpznhY3j4h1qAWZWXkYZ4YrKBOjM/AI+IqCr8sfkuM2UhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02e92fe4-97d5-4d4c-a875-51e2dddbe597", "AQAAAAIAAYagAAAAEP+oZR/RvkEugO7EN9FPyt1CWdAkAY1KSvjgHe9IkWdAoBUuCYy2zIoDi097jNUJPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb00921c-c806-43d0-bf84-7454765589d9", "AQAAAAIAAYagAAAAENvwYhxtc1zTt4/XKepSZ764U90nO7R8hatLV7ehcJDWiDUn3SyjH5VQ4Y7geC/U5A==", "4f456b66-bb61-4d35-9016-7ce9c0d8b14a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "d68865fd-463a-4a9a-996a-3bd9a70e6eeb", new DateTime(2025, 7, 9, 16, 29, 0, 728, DateTimeKind.Local).AddTicks(5158), new DateTime(2025, 7, 16, 16, 29, 0, 728, DateTimeKind.Local).AddTicks(5206), "AQAAAAIAAYagAAAAELn5WnsWtuEESDiWCLnJe2tuYz5NFtricdFEPH7y2XxmsriktG9uQedsuGuWMVE4Ig==" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 9, 16, 29, 0, 623, DateTimeKind.Local).AddTicks(2468), new DateTime(2025, 7, 9, 16, 29, 0, 623, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 9, 16, 29, 0, 623, DateTimeKind.Local).AddTicks(2423), new DateTime(2025, 7, 9, 16, 29, 0, 623, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2025, 7, 9, 16, 29, 0, 623, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 9, 16, 29, 0, 623, DateTimeKind.Local).AddTicks(2977), new DateTime(2025, 7, 9, 16, 29, 0, 623, DateTimeKind.Local).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 6, 8, 16, 29, 0, 623, DateTimeKind.Local).AddTicks(2970), new DateTime(2025, 9, 22, 16, 29, 0, 623, DateTimeKind.Local).AddTicks(2975) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResponderName",
                table: "HelpResponses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14c411a9-d472-448f-a4fa-92efe5b65faf", "AQAAAAIAAYagAAAAENRzWJ4ZrDz80ao+NucmFbxXZm0V9Ec+iqjJnP0c6BHV/dbUrFifrmyA5tEDbW1b9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "21322d24-df70-495b-80a4-077fd78e7867", new DateTime(2025, 7, 22, 15, 49, 13, 486, DateTimeKind.Local).AddTicks(8896), new DateTime(2025, 7, 23, 15, 49, 13, 486, DateTimeKind.Local).AddTicks(8948), "AQAAAAIAAYagAAAAECI06wigCOpxS6doJsiLG35SKO7vGyLgYGhmi7EOqk5Hdxja4A8OKYLNo5BnYiUZIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a3a4bf6-266f-44f8-bbe6-3994f0ea7354", "AQAAAAIAAYagAAAAEPu5xs822ULTXeXS82g9epuqG1XlL0FCtbtk0bJ8XdTvMGET80adDK1pZn38KAdvhw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88535830-a4e8-4eac-861c-5477c7473af3", "AQAAAAIAAYagAAAAECK64kHKbQbaNlahL1e4cO4fwrbEjFIh5MmLGnZYx0Olv9s0vHCmdAeA0QvCM+2Ilg==", "67e32bc0-50fb-4581-8749-0b052b5d533a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastEdited", "PasswordHash" },
                values: new object[] { "abccbdd0-d237-4cb5-90bd-ef045940dab5", new DateTime(2025, 7, 9, 15, 49, 13, 451, DateTimeKind.Local).AddTicks(1542), new DateTime(2025, 7, 16, 15, 49, 13, 451, DateTimeKind.Local).AddTicks(1594), "AQAAAAIAAYagAAAAELw8wExuUS4we6PuQfJtPzj8xWNQWzDchJxnxWvRSR3V0/hYdMmfJBZcuy3C1/D3OQ==" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 9, 15, 49, 13, 344, DateTimeKind.Local).AddTicks(5786), new DateTime(2025, 7, 9, 15, 49, 13, 344, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 9, 15, 49, 13, 344, DateTimeKind.Local).AddTicks(5732), new DateTime(2025, 7, 9, 15, 49, 13, 344, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"),
                column: "LastEdited",
                value: new DateTime(2025, 7, 9, 15, 49, 13, 344, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 7, 9, 15, 49, 13, 344, DateTimeKind.Local).AddTicks(6336), new DateTime(2025, 7, 9, 15, 49, 13, 344, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"),
                columns: new[] { "CreatedOn", "LastEdited" },
                values: new object[] { new DateTime(2025, 6, 8, 15, 49, 13, 344, DateTimeKind.Local).AddTicks(6328), new DateTime(2025, 9, 22, 15, 49, 13, 344, DateTimeKind.Local).AddTicks(6333) });
        }
    }
}
