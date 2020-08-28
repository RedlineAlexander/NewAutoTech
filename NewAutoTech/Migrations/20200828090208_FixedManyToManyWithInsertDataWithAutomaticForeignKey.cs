using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewAutoTech.Migrations
{
    public partial class FixedManyToManyWithInsertDataWithAutomaticForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autos",
                columns: new[] { "AutoID", "AutoColor", "AutoName", "YearFromPipeline" },
                values: new object[] { 1, "Red", "Mazda", new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "OwnerID", "BirthDate", "FatherName", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified), "Oleksiovic", "Tyxy", "Oleks" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autos",
                keyColumn: "AutoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "OwnerID",
                keyValue: 1);
        }
    }
}
