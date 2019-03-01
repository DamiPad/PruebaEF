using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaEF.Migrations
{
    public partial class RelacionProdCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriaID",
                table: "Producto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_CategoriaID",
                table: "Producto",
                column: "CategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categoria_CategoriaID",
                table: "Producto",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "CategoriaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categoria_CategoriaID",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_CategoriaID",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "CategoriaID",
                table: "Producto");
        }
    }
}
