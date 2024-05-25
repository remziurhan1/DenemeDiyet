using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenemeDiyetDAL.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    OgunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.OgunID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuvenlikSorusu = table.Column<int>(type: "int", nullable: true),
                    GuvenlikSorusuCevap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Boy = table.Column<double>(type: "float", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "YemekKategorileri",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekKategorileri", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "YemekCesitleri",
                columns: table => new
                {
                    YemekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekAdlari = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekCesitleri", x => x.YemekID);
                    table.ForeignKey(
                        name: "FK_YemekCesitleri_Ogunler_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogunler",
                        principalColumn: "OgunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekCesidiKategori",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    YemekID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekCesidiKategori", x => new { x.KategoriID, x.YemekID });
                    table.ForeignKey(
                        name: "FK_YemekCesidiKategori_YemekCesitleri_YemekID",
                        column: x => x.YemekID,
                        principalTable: "YemekCesitleri",
                        principalColumn: "YemekID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekCesidiKategori_YemekKategorileri_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "YemekKategorileri",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YemekCesidiKategori_YemekID",
                table: "YemekCesidiKategori",
                column: "YemekID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekCesitleri_OgunID",
                table: "YemekCesitleri",
                column: "OgunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "YemekCesidiKategori");

            migrationBuilder.DropTable(
                name: "YemekCesitleri");

            migrationBuilder.DropTable(
                name: "YemekKategorileri");

            migrationBuilder.DropTable(
                name: "Ogunler");
        }
    }
}
