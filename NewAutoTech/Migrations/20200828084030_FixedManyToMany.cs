using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewAutoTech.Migrations
{
    public partial class FixedManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autos",
                columns: table => new
                {
                    AutoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoName = table.Column<string>(nullable: true),
                    AutoColor = table.Column<string>(nullable: true),
                    YearFromPipeline = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autos", x => x.AutoID);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    OwnerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.OwnerID);
                });

            migrationBuilder.CreateTable(
                name: "AutosAndOwners",
                columns: table => new
                {
                    Autoid = table.Column<int>(nullable: false),
                    Ownerid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutosAndOwners", x => new { x.Autoid, x.Ownerid });
                    table.ForeignKey(
                        name: "FK_AutosAndOwners_Autos_Autoid",
                        column: x => x.Autoid,
                        principalTable: "Autos",
                        principalColumn: "AutoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutosAndOwners_Owners_Ownerid",
                        column: x => x.Ownerid,
                        principalTable: "Owners",
                        principalColumn: "OwnerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutosAndOwners_Ownerid",
                table: "AutosAndOwners",
                column: "Ownerid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutosAndOwners");

            migrationBuilder.DropTable(
                name: "Autos");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
