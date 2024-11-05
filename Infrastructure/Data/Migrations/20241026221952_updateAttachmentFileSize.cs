using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateAttachmentFileSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "Attachments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13f9834d-e741-45ea-9831-bc458776b644", "AQAAAAIAAYagAAAAEKZqCf/q8tMQMz/oz9mT1GT6v7YoQSzT7wP+Okog9DHEWqauyF9fujg9cveKMRbRcg==", "bfe2296a-efcd-41a9-9548-aef6088938d6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "Attachments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0251d6b3-f9af-49c1-9192-f1d8101a2779", "AQAAAAIAAYagAAAAEFbXHK2WopeKkcucFwoA0xAhG0cEa2hYkycaHh3VfMD/TE82z+FT38H4o7+DGVvjng==", "49f4848f-9b34-41ab-a6c4-2529f7c23c16" });
        }
    }
}
