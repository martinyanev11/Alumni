using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    CharityDonationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    NewsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CharityDonationsUsers",
                columns: table => new
                {
                    CharityDonationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    CommentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NewsId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "NewsId");
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "IsDeleted", "LastEdited", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "27b79543-4841-47b3-9218-2b54c56ed07b", new DateTime(2024, 6, 18, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5420), null, false, false, new DateTime(2024, 6, 18, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5469), false, null, null, null, null, null, false, "77926f90-b09b-42ad-95ae-537e110f11f4", false, "Vasko Bilkata" },
                    { "102", 0, "81a13adf-1af5-4935-828f-e4204b235ef1", new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5536), null, false, false, new DateTime(2024, 6, 30, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5538), false, null, null, null, null, null, false, "b49adf16-28d3-4343-ab82-aa77efc318da", false, "Prince Ferdinand" },
                    { "123", 0, "ea13d12f-48d7-4702-a2a3-e1bfba33aee7", new DateTime(2024, 6, 22, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5514), null, false, true, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5515), false, null, null, null, null, null, false, "9c30f54a-e995-4cd3-b79b-8f9bf97ea9a3", false, "Michael Caine" }
                });

            migrationBuilder.InsertData(
                table: "CharityDonations",
                columns: new[] { "CharityDonationId", "CreatedOn", "CurrentlyRaisedDonations", "DonationGoal", "IsDeleted", "LastEdited" },
                values: new object[,]
                {
                    { "1231b7fa-514e-4e23-9f25-2187dedf7bc6", new DateTime(2024, 3, 12, 8, 40, 56, 0, DateTimeKind.Unspecified), 4396m, 6000m, false, new DateTime(2024, 6, 25, 20, 24, 7, 0, DateTimeKind.Unspecified) },
                    { "2dc40d6f-801e-4f8e-83ff-0c573022e9be", new DateTime(2024, 6, 6, 14, 20, 37, 0, DateTimeKind.Unspecified), 34m, 6000m, false, new DateTime(2024, 6, 7, 16, 28, 31, 0, DateTimeKind.Unspecified) },
                    { "b1493552-b550-403d-8788-a346a9739d3e", new DateTime(2024, 1, 24, 17, 32, 2, 0, DateTimeKind.Unspecified), 5078m, 5000m, true, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5730) }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Contents", "CreatedOn", "EndDateTime", "IsDeleted", "LastEdited", "StartDateTime", "Title" },
                values: new object[,]
                {
                    { "2ccab0d1-a47d-4caf-adb4-04d70bb839bd", "The class of 2016 is going to have a meeting at the local park. There`s going to be food, but you can bring some.", new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5801), new DateTime(2024, 5, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5803), new DateTime(2024, 5, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2016 class" },
                    { "8b0d26ec-462e-4f50-afdb-1c8dd9ed4428", "The class of 2011 is going to have a meeting at the local beach.", new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5807), new DateTime(2024, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5808), new DateTime(2024, 7, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2011 class" },
                    { "c0a29077-7315-46f3-b80d-edb25d96a00b", "The class of 2009 is going to have a meeting at the local pub.", new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5838), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5839), new DateTime(2024, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2009 class" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "Contents", "CreatedOn", "IsDeleted", "LastEdited", "Title" },
                values: new object[] { "cc8e221f-08de-4cec-9278-c91a20ef6f97", "Test seed", new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5774), false, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5775), "News" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Contents", "CreatedOn", "IsDeleted", "LastEdited", "Title", "UserId" },
                values: new object[,]
                {
                    { "229dd424-c2a3-46c9-a3ee-a7f97819b112", "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!", new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5643), false, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5645), "Test", "1" },
                    { "2968a80b-50f4-4487-8de2-e404735c75b7", "My master is a guy who likes to wear black and fights crime", new DateTime(2024, 6, 24, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5585), false, new DateTime(2024, 6, 24, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5587), "Just a random post", "123" },
                    { "409b3a76-a767-47e6-a307-ed0d967a37c2", "On the 23.08.24 the alumni of Softuni Buditel will gather for a tea party in South park", new DateTime(2024, 6, 25, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5562), false, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5564), "Alumni gathering", "1" },
                    { "8033dea4-adfc-4241-8bbb-e3445d46a050", "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!", new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5626), false, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5627), "Test", "1" },
                    { "9385f943-fe19-4231-8326-cbac47d508bb", "I am prince Ferdinand, the first tzar of the new Bulgaria", new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5608), true, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5610), "Listen to your tzar", "102" },
                    { "953038c8-25c7-461e-9dfd-63b4d99c2b1e", "Hello everyone! I hope you're doing well. I'm thrilled to announce the launch of our new alumni mentorship program.This initiative aims to connect recent graduates with seasoned professionals.It's a fantastic opportunity to share your knowledge, give back to our community, and guide the next generation. I look forward to seeing many of you participate!", new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5663), false, new DateTime(2024, 6, 26, 16, 49, 22, 212, DateTimeKind.Local).AddTicks(5665), "Test", "1" }
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
