using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace my_app.Migrations
{
    public partial class departamenti_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departamenti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SindikataId = table.Column<int>(nullable: false),
                    Emri = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Adresa = table.Column<string>(nullable: true),
                    Telefoni = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Emaili = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Themelimi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departamenti_Sindikatas_SindikataId",
                        column: x => x.SindikataId,
                        principalTable: "Sindikatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamenti_SindikataId",
                table: "Departamenti",
                column: "SindikataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departamenti");
        }
    }
}
