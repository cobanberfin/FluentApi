using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentApiTabloOluşturma.Migrations
{
    public partial class ekletablo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Firma",
                columns: table => new
                {
                    Anahtar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaUnvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNumarası = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAdres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Firma", x => x.Anahtar);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Personel",
                columns: table => new
                {
                    Anahtar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAdres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonNumarası = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Personel", x => x.Anahtar);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Firma");

            migrationBuilder.DropTable(
                name: "Tbl_Personel");
        }
    }
}
