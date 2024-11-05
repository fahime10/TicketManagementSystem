using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussions_Tickets_TicketIt",
                table: "Discussions");

            migrationBuilder.RenameColumn(
                name: "TicketIt",
                table: "Discussions",
                newName: "TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_Discussions_TicketIt",
                table: "Discussions",
                newName: "IX_Discussions_TicketId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7348c28-0ddb-4992-9aa7-7110f936036c", "AQAAAAIAAYagAAAAEJQiaaGGJbEz0Onr8U4ld/aGVU9tOZNJEhYCDkc5668jPeldJCe1vOTG34evQSzdUg==", "59a36ac7-db8d-4f97-b9c8-88c652e1a26c" });

            migrationBuilder.AddForeignKey(
                name: "FK_Discussions_Tickets_TicketId",
                table: "Discussions",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Discussions_Tickets_TicketId",
                table: "Discussions");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Discussions",
                newName: "TicketIt");

            migrationBuilder.RenameIndex(
                name: "IX_Discussions_TicketId",
                table: "Discussions",
                newName: "IX_Discussions_TicketIt");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62f94fe7-0580-42df-969c-50d4165d63b9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da32f05b-e6a1-483d-8290-c4c9f0a476f1", "AQAAAAIAAYagAAAAEEurNfZ1Dppf39hdWOpOOUqDHIEl5hkXZBG9wqb/8MgPJH19mRmAfZaxrmxnCCP+YA==", "9be17a62-db13-4609-9c58-e8d82ced9d5d" });

            migrationBuilder.AddForeignKey(
                name: "FK_Discussions_Tickets_TicketIt",
                table: "Discussions",
                column: "TicketIt",
                principalTable: "Tickets",
                principalColumn: "TicketId");
        }
    }
}
