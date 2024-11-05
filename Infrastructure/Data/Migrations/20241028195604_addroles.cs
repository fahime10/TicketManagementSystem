using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class addroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7bcd8450-397d-479c-a05e-248ef54ca893", null, "User", "USER" },
                    { "f651ea93-3919-4786-9adc-ed5ca6851b78", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "IsDeleted", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da32f05b-e6a1-483d-8290-c4c9f0a476f1", false, "AQAAAAIAAYagAAAAEEurNfZ1Dppf39hdWOpOOUqDHIEl5hkXZBG9wqb/8MgPJH19mRmAfZaxrmxnCCP+YA==", "9be17a62-db13-4609-9c58-e8d82ced9d5d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f651ea93-3919-4786-9adc-ed5ca6851b78", "62f94fe7-0580-42df-969c-50d4165d63b9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bcd8450-397d-479c-a05e-248ef54ca893");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f651ea93-3919-4786-9adc-ed5ca6851b78", "62f94fe7-0580-42df-969c-50d4165d63b9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f651ea93-3919-4786-9adc-ed5ca6851b78");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13f9834d-e741-45ea-9831-bc458776b644", "AQAAAAIAAYagAAAAEKZqCf/q8tMQMz/oz9mT1GT6v7YoQSzT7wP+Okog9DHEWqauyF9fujg9cveKMRbRcg==", "bfe2296a-efcd-41a9-9548-aef6088938d6" });
        }
    }
}
