using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace my_app.Migrations
{
    public partial class sindikata_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sindikatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Emaili = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Themelimi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sindikatas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sindikatas");
        }
    }
}
