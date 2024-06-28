using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Alumni.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedOn", "Email", "EmailConfirmed", "IsDeleted", "LastEdited", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("30913bf8-4000-4809-801e-764de3136c0e"), 0, "bbb8a124-ff9f-4146-b1ff-c1a1848f9300", new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, true, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, null, null, false, null, false, "Michael Caine" },
                    { new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"), 0, "1114fb0c-d3f2-4994-aebc-707f84e270e0", new DateTime(2024, 7, 11, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8325), null, false, true, new DateTime(2024, 7, 12, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8327), false, null, null, null, null, null, false, null, false, "gazelle trueman" },
                    { new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"), 0, "24826760-fd68-4811-ac0d-4c49f1ff0726", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, null, null, false, null, false, "Prince Ferdinand" },
                    { new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"), 0, "3365c379-ae79-4841-93bb-9ede0e6c750b", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, null, null, null, false, null, false, "Vasko Bilkata" },
                    { new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"), 0, "b07f1e43-7bd6-4c88-98a7-2baf55cd25bc", new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8275), null, false, false, new DateTime(2024, 7, 5, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8317), false, null, null, null, null, null, false, null, false, "Burxh califchar" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Contents", "CreatedOn", "EndDateTime", "IsDeleted", "LastEdited", "StartDateTime", "Title" },
                values: new object[,]
                {
                    { new Guid("257cb7ad-df19-4cac-a009-f68eeb305afa"), "The class of 2009 is going to have a meeting at the local pub.", new DateTime(2023, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2009 class" },
                    { new Guid("541e7f5d-4016-474e-acd2-2f30ecd9a446"), "The class of 2011 is going to have a meeting at the local beach.", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2011 class" },
                    { new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"), "The class of 2009 is going to have a meeting at the local pub.", new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8920), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8922), new DateTime(2010, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2009 class" },
                    { new Guid("832388e9-e1d9-4878-9299-273129c9f247"), "The class of 2003 is going to have a meeting at the local pub.", new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8914), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8917), new DateTime(2024, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2003 class" },
                    { new Guid("87c281f4-5052-47a5-a6f4-75c9741663ef"), "The class of 2016 is going to have a meeting at the local park. There`s going to be food, but you can bring some.", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2016 class" },
                    { new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"), "The class of 2009 is going to have a meeting at the local pub.", new DateTime(2025, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8926), new DateTime(2024, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2009 class" },
                    { new Guid("9a1172e2-e2e5-44fd-92e6-285c1154e8dc"), "The class of 2009 is going to have a meeting at the local pub.", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Meeting - 2009 class" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "Contents", "CreatedOn", "IsDeleted", "LastEdited", "Title" },
                values: new object[,]
                {
                    { new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"), "f k y u d b j g d", new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8602), false, new DateTime(2024, 6, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8604), "News" },
                    { new Guid("85183070-d0af-41a1-9b3b-95d0073995eb"), "Test seed", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "News" },
                    { new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"), "funny haha get shmucked", new DateTime(2024, 5, 28, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8594), true, new DateTime(2024, 9, 11, 12, 14, 51, 560, DateTimeKind.Local).AddTicks(8598), "file" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "Contents", "CreatedOn", "IsDeleted", "LastEdited", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("22a984ee-76a2-4c73-b0bf-7ac5e30ccc1b"), "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") },
                    { new Guid("2fae760d-6a45-45ed-ae78-e4451ebf47f8"), "Hello everyone! I hope this message finds you well. I’m excited to announce the launch of our new alumni mentorship program, designed to connect recent graduates with experienced professionals. It's a great way to share your expertise, give back to our community, and help guide the next generation. Looking forward to seeing many of you get involved!", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") },
                    { new Guid("62c9dd2b-1ad2-4089-a157-c358c0422884"), "Hello everyone! I hope you're doing well. I'm thrilled to announce the launch of our new alumni mentorship program.This initiative aims to connect recent graduates with seasoned professionals.It's a fantastic opportunity to share your knowledge, give back to our community, and guide the next generation. I look forward to seeing many of you participate!", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") },
                    { new Guid("7463e718-280e-47b6-93b3-f6d629e26a9d"), "My master is a guy who likes to wear black and fights crime", new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Just a random post", new Guid("30913bf8-4000-4809-801e-764de3136c0e") },
                    { new Guid("ecfccb98-75a2-49ee-910d-e5a5ec44ae5b"), "On the 23.08.24 the alumni of Softuni Buditel will gather for a tea party in South park", new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alumni gathering", new Guid("7388ce0f-df30-4686-9e49-46daac4e0292") },
                    { new Guid("ee03701f-f3c6-4872-8dc8-800a99947a9d"), "I am prince Ferdinand, the first tzar of the new Bulgaria", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Listen to your tzar", new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6609e8af-abbe-4472-a1ff-ab5fdfb92f80"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6a98fd4-b8db-4566-ad8c-d7c49f3bd2db"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("257cb7ad-df19-4cac-a009-f68eeb305afa"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("541e7f5d-4016-474e-acd2-2f30ecd9a446"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("74a8ad71-9425-4115-8b44-55cc94b13a89"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("832388e9-e1d9-4878-9299-273129c9f247"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("87c281f4-5052-47a5-a6f4-75c9741663ef"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("8f0a57e7-afe3-4648-8efa-9a977602bee0"));

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: new Guid("9a1172e2-e2e5-44fd-92e6-285c1154e8dc"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("31dedd8d-0dc7-455a-955a-14d7d5e9320f"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("85183070-d0af-41a1-9b3b-95d0073995eb"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "NewsId",
                keyValue: new Guid("fb8f1f7a-8853-4bed-8008-a17ae2a3be3f"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("22a984ee-76a2-4c73-b0bf-7ac5e30ccc1b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("2fae760d-6a45-45ed-ae78-e4451ebf47f8"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("62c9dd2b-1ad2-4089-a157-c358c0422884"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("7463e718-280e-47b6-93b3-f6d629e26a9d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("ecfccb98-75a2-49ee-910d-e5a5ec44ae5b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: new Guid("ee03701f-f3c6-4872-8dc8-800a99947a9d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30913bf8-4000-4809-801e-764de3136c0e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7388ce0f-df30-4686-9e49-46daac4e0292"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d7ed0e0-1804-4283-aa5b-802033b2c918"));
        }
    }
}
