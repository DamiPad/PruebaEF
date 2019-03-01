using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaEF.Migrations
{
    public partial class AgregaPrecio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Descontinuado",
                table: "Producto",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Existencia",
                table: "Producto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "Producto",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descontinuado",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Existencia",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Producto");
        }
    }
}
