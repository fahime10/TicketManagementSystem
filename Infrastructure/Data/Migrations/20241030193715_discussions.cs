using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class discussions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb00fe2c-04d6-4020-98f5-c5500be85c88", "AQAAAAIAAYagAAAAEBvbeb7OXOYHTfdztHmdgy1cVcTA42q5wOppZkDRUqEbYttrlFKkdJEkPMMRXQNqGg==", "05b1a3f0-7067-4b63-a13d-f04c9ab0fe97" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7348c28-0ddb-4992-9aa7-7110f936036c", "AQAAAAIAAYagAAAAEJQiaaGGJbEz0Onr8U4ld/aGVU9tOZNJEhYCDkc5668jPeldJCe1vOTG34evQSzdUg==", "59a36ac7-db8d-4f97-b9c8-88c652e1a26c" });
        }
    }
}
