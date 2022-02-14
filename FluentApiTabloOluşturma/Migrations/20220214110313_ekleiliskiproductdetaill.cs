using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiTabloOluşturma.Migrations
{
    public partial class ekleiliskiproductdetaill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductDEtails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prtID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDEtails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductDEtails_Products_prtID",
                        column: x => x.prtID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDEtails_prtID",
                table: "ProductDEtails",
                column: "prtID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDEtails");
        }
    }
}
