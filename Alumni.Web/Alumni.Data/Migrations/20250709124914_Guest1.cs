using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class Guest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HelpRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HelpResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HelpRequestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HelpResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HelpResponses_HelpRequests_HelpRequestId",
                        column: x => x.HelpRequestId,
                        principalTable: "HelpRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_HelpResponses_HelpRequestId",
                table: "HelpResponses",
                column: "HelpRequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HelpResponses");

            migrationBuilder.DropTable(
                name: "HelpRequests");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b092d122-015f-48f4-80d2-98467bb28f80", "AQAAAAIAAYagAAAAENV0aCIrEnuizNArhKxDepFDCjtdWKBtkOCa3S3TMRRteXlDYoOsT1mvKgKeugUhww==", "03f036c2-fc49-4083-ab9f-9d6e9f15db45" });

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
    }
}
