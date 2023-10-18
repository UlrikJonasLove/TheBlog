using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Created", "Description", "Image", "LastEdited", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 1", "image1.jpg", new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "Post 1" },
                    { 2, new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 2", "image2.jpg", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Post 2" },
                    { 3, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 3", "image3.jpg", new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Post 3" },
                    { 4, new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 4", "image4.jpg", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Post 4" },
                    { 5, new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 5", "image5.jpg", new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Local), "Post 5" },
                    { 6, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 6", "image6.jpg", new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Local), "Post 6" },
                    { 7, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 7", "image7.jpg", new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Local), "Post 7" },
                    { 8, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 8", "image8.jpg", new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), "Post 8" },
                    { 9, new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 9", "image9.jpg", new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Post 9" },
                    { 10, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 10", "image10.jpg", new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Post 10" },
                    { 11, new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 11", "image11.jpg", new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Post 11" },
                    { 12, new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 12", "image12.jpg", new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Local), "Post 12" },
                    { 13, new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 13", "image13.jpg", new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), "Post 13" },
                    { 14, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 14", "image14.jpg", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Local), "Post 14" },
                    { 15, new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Local), "Beskrivning för post 15", "image15.jpg", new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Local), "Post 15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
