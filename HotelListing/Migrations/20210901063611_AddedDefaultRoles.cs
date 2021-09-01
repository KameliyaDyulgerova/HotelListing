using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e61a2e5-8168-4aa6-b0cc-8105ce3c043a", "633d6d4b-e4fc-4de9-bc4b-7f80bbc14b2a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce9b6df4-7e2c-433b-8d88-840d2e0a3072", "70fc8ef8-864d-4253-93ba-7bdb3e9c79dd", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e61a2e5-8168-4aa6-b0cc-8105ce3c043a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce9b6df4-7e2c-433b-8d88-840d2e0a3072");
        }
    }
}
