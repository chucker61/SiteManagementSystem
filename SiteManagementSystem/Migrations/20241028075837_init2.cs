using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SiteManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "200e3214-1b1d-4d6a-ac1f-c4d3afe5b195");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32d36322-2512-42f9-9817-e22065c018f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a8fbb6e-c5e1-4280-8bfa-8d7057aacb0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "943d6d89-d877-4a9d-beb1-20cc0236abb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed14d28a-ecde-4134-bc6a-cd6092e58864");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "23f1bd92-b9b0-4cf1-990a-336aa9cc0278", null, "Admin", "ADMIN" },
                    { "3e15fe66-a497-4b68-90c5-773dab83e1e6", null, "Visitor", "VISITOR" },
                    { "7e0936ef-8d72-45f0-b671-0e88c4870d9d", null, "User", "USER" },
                    { "b38cbe0a-ebb8-4a2b-821f-1c433ff2cb3a", null, "ApartmentManager", "APARTMENTMANAGER" },
                    { "db7de4af-f6eb-4ca8-9cd4-643a11fb5945", null, "SiteManager", "SITEMANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Free", 0m });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Bronz", 50m });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Silver", 75m });

            migrationBuilder.InsertData(
                table: "Memberships",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 4, "Gold", 100m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "23f1bd92-b9b0-4cf1-990a-336aa9cc0278");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e15fe66-a497-4b68-90c5-773dab83e1e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e0936ef-8d72-45f0-b671-0e88c4870d9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b38cbe0a-ebb8-4a2b-821f-1c433ff2cb3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db7de4af-f6eb-4ca8-9cd4-643a11fb5945");

            migrationBuilder.DeleteData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "200e3214-1b1d-4d6a-ac1f-c4d3afe5b195", null, "ApartmentManager", "APARTMENTMANAGER" },
                    { "32d36322-2512-42f9-9817-e22065c018f3", null, "Visitor", "VISITOR" },
                    { "7a8fbb6e-c5e1-4280-8bfa-8d7057aacb0f", null, "Admin", "ADMIN" },
                    { "943d6d89-d877-4a9d-beb1-20cc0236abb1", null, "SiteManager", "SITEMANAGER" },
                    { "ed14d28a-ecde-4134-bc6a-cd6092e58864", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Bronz", 50m });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Silver", 75m });

            migrationBuilder.UpdateData(
                table: "Memberships",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Gold", 100m });
        }
    }
}
