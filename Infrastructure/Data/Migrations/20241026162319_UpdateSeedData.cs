using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0251d6b3-f9af-49c1-9192-f1d8101a2779", "AQAAAAIAAYagAAAAEFbXHK2WopeKkcucFwoA0xAhG0cEa2hYkycaHh3VfMD/TE82z+FT38H4o7+DGVvjng==", "49f4848f-9b34-41ab-a6c4-2529f7c23c16" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { "62f94fe7-0580-42df-969c-50d4165d63b9", new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24b21f95-8b83-4370-9ade-6793ed710181", "AQAAAAIAAYagAAAAEPtaNVJ8G1Ru9RRx+Q0GeQVKBIodm3eCmPb+GFoN5w9iG6nqAlVmH2vk+xPthCtXrg==", "f9696faf-62c7-4e1d-b4b2-2b6881029f30" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 8,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 11,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 14,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 17,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 20,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 21,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 22,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 23,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 24,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 25,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 26,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 27,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 28,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 29,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 30,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 31,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 32,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 33,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 34,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 35,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 36,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 37,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 38,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 39,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 40,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 41,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 42,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 43,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 44,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 45,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 46,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 47,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 48,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 49,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 50,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 51,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 52,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 53,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 54,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 55,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 56,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 57,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 58,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 59,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 60,
                columns: new[] { "ClosedBy", "ClosedDate" },
                values: new object[] { null, null });
        }
    }
}
