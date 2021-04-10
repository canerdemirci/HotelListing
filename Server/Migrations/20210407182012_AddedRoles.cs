using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Server.Migrations
{
    public partial class AddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b244df9c-25e6-4d2a-8059-a881b269e03f", "84665381-2984-4e4f-8407-d5d7eb12ee68", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7158a750-da1e-4aaa-9a11-7e7166e013df", "81d44863-ca39-4b38-a7f0-b0e38b8c612b", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7158a750-da1e-4aaa-9a11-7e7166e013df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b244df9c-25e6-4d2a-8059-a881b269e03f");
        }
    }
}
