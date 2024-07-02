using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class homo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharityDonations",
                columns: table => new
                {
                    CharityDonationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DonationGoal = table.Column<decimal>(type: "decimal(12,3)", nullable: false),
                    CurrentlyRaisedDonations = table.Column<decimal>(type: "decimal(12,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityDonations", x => x.CharityDonationId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharityDonationsUsers",
                columns: table => new
                {
                    CharityDonationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityDonationsUsers", x => new { x.CharityDonationId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CharityDonationsUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharityDonationsUsers_CharityDonations_CharityDonationId",
                        column: x => x.CharityDonationId,
                        principalTable: "CharityDonations",
                        principalColumn: "CharityDonationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersEvents",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EventId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersEvents", x => new { x.UserId, x.EventId });
                    table.ForeignKey(
                        name: "FK_UsersEvents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "NewsId");
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("d23fe586-7d83-4aa3-bab5-99cf956d0522"), null, "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "ImageUrl", "IsDeleted", "LastEdited", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("30913bf8-4000-4809-801e-764de3136c0e"), 0, "8d6bb117-cedb-4608-ab9c-4a68d4c82141", new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "asd", true, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, null, null, false, null, false, "Michael Caine" },
                    { new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"), 0, "8bc8939b-4214-4d99-b3a8-ccbc4e25f5ef", new DateTime(2024, 7, 15, 22, 11, 3, 307, DateTimeKind.Local).AddTicks(4924), null, false, "asd", true, new DateTime(2024, 7, 16, 22, 11, 3, 307, DateTimeKind.Local).AddTicks(4926), false, null, null, null, null, null, false, null, false, "gazelle trueman" },
                    { new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"), 0, "a28c21db-9f56-4d1e-8a95-7d606280f777", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "asd", false, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, null, null, false, null, false, "Prince Ferdinand" },
                    { new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"), 0, "48f52a83-8359-40de-8ec8-29c7bcd6a08e", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "asd", false, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, null, null, false, null, false, "Vasko Bilkata" },
                    { new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"), 0, "06d6c87a-9f89-44c0-88cf-14c4f343af8c", new DateTime(2024, 7, 2, 22, 11, 3, 307, DateTimeKind.Local).AddTicks(4878), null, false, "asd", false, new DateTime(2024, 7, 9, 22, 11, 3, 307, DateTimeKind.Local).AddTicks(4886), false, null, null, null, null, null, false, null, false, "Burxh califchar" }
                });

            migrationBuilder.InsertData(
                table: "CharityDonations",
                columns: new[] { "CharityDonationId", "Content", "CreatedOn", "CurrentlyRaisedDonations", "DonationGoal", "ImageUrl", "IsDeleted", "LastEdited", "Title" },
                values: new object[,]
                {
                    { new Guid("18065e6b-eb60-4bbc-a877-829e28fc60d6"), "for this cause", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 34m, 6000m, "asd", false, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donate" },
                    { new Guid("59a312f0-e57a-4cd7-9c7e-66a29918792d"), "for this cause", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4396m, 6000m, "asd", false, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donate" },
                    { new Guid("d5e58825-c20b-4e58-9c60-12bc6253681c"), "for this cause", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 9485m, 10342m, "asd", false, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donate" },
                    { new Guid("f0e619aa-c6fc-49cb-9e48-67533f3904ff"), "for this cause", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4786m, 6069m, "asd", false, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donate" },
                    { new Guid("f376c876-984f-4605-b488-d6bc6872c0bf"), "for this cause", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5078m, 5000m, "asd", true, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Donate" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Contents", "CreatedOn", "EndDateTime", "ImageUrl", "IsDeleted", "LastEdited", "StartDateTime", "Title" },
                values: new object[,]
                {
                    { new Guid("257cb7ad-df19-4cac-a009-f68eeb305afa"), "The class of 2009 is going to have a meeting at the local pub.", new DateTime(2023, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2022, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2009 class" },
                    { new Guid("541e7f5d-4016-474e-acd2-2f30ecd9a446"), "The class of 2011 is going to have a meeting at the local beach.", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2011 class" },
                    { new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"), "The class of 2009 is going to have a meeting at the local pub.", new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(892), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(894), new DateTime(2010, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2009 class" },
                    { new Guid("832388e9-e1d9-4878-9299-273129c9f247"), "The class of 2003 is going to have a meeting at the local pub.", new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "asd", true, new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(881), new DateTime(2024, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2003 class" },
                    { new Guid("87c281f4-5052-47a5-a6f4-75c9741663ef"), "The class of 2016 is going to have a meeting at the local park. There`s going to be food, but you can bring some.", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2016 class" },
                    { new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"), "The class of 2009 is going to have a meeting at the local pub.", new DateTime(2025, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(905), new DateTime(2024, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2009 class" },
                    { new Guid("9a1172e2-e2e5-44fd-92e6-285c1154e8dc"), "The class of 2009 is going to have a meeting at the local pub.", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2009 class" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "Contents", "CreatedOn", "ImageUrl", "IsDeleted", "LastEdited", "Title" },
                values: new object[,]
                {
                    { new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"), "f k y u d b j g d", new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(4465), "asd", false, new DateTime(2024, 7, 2, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(4467), "News" },
                    { new Guid("85183070-d0af-41a1-9b3b-95d0073995eb"), "Test seed", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "News" },
                    { new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"), "funny haha get shmucked", new DateTime(2024, 6, 1, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(4445), "asd", true, new DateTime(2024, 9, 15, 22, 11, 3, 306, DateTimeKind.Local).AddTicks(4457), "file" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d23fe586-7d83-4aa3-bab5-99cf956d0522"), new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918") });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Contents", "CreatedOn", "ImageUrl", "IsDeleted", "LastEdited", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("22a984ee-76a2-4c73-b0bf-7ac5e30ccc1b"), "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") },
                    { new Guid("2fae760d-6a45-45ed-ae78-e4451ebf47f8"), "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") },
                    { new Guid("62c9dd2b-1ad2-4089-a157-c358c0422884"), "Hello everyone! I hope you're doing well. I'm thrilled to announce the launch of our new alumni mentorship program.This initiative aims to connect recent graduates with seasoned professionals.It's a fantastic opportunity to share your knowledge, give back to our community, and guide the next generation. I look forward to seeing many of you participate!", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") },
                    { new Guid("7463e718-280e-47b6-93b3-f6d629e26a9d"), "My master is a guy who likes to wear black and fights crime", new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Just a random post", new Guid("30913bf8-4000-4809-801e-764de3136c0e") },
                    { new Guid("ecfccb98-75a2-49ee-910d-e5a5ec44ae5b"), "On the 23.08.24 the alumni of Softuni Buditel will gather for a tea party in South park", new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "asd", false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alumni gathering", new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") },
                    { new Guid("ee03701f-f3c6-4872-8dc8-800a99947a9d"), "I am prince Ferdinand, the first tzar of the new Bulgaria", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "asd", true, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Listen to your tzar", new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CharityDonationsUsers_UserId",
                table: "CharityDonationsUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_NewsId",
                table: "Comments",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersEvents_EventId",
                table: "UsersEvents",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CharityDonationsUsers");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "UsersEvents");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CharityDonations");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
