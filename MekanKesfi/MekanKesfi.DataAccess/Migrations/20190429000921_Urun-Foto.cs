using Microsoft.EntityFrameworkCore.Migrations;

namespace MekanKesfi.DataAccess.Migrations
{
    public partial class UrunFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrunFoto",
                table: "Urunler",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrunFoto",
                table: "Urunler");
        }
    }
}
