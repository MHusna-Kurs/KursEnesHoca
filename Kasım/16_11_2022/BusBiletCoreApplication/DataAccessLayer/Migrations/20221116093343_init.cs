using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "firmalar",
                columns: table => new
                {
                    firmaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firmaAd = table.Column<string>(maxLength: 50, nullable: true),
                    iletisim = table.Column<string>(maxLength: 300, nullable: true),
                    logoUrl = table.Column<string>(maxLength: 100, nullable: true),
                    silindi = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_firmalar", x => x.firmaId);
                });

            migrationBuilder.CreateTable(
                name: "guzergahlar",
                columns: table => new
                {
                    guzergahId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kalkisYeri = table.Column<string>(maxLength: 20, nullable: true),
                    varisYeri = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guzergahlar", x => x.guzergahId);
                });

            migrationBuilder.CreateTable(
                name: "kullanicilar",
                columns: table => new
                {
                    kullaniciId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciAd = table.Column<string>(maxLength: 50, nullable: true),
                    kullaniciSifre = table.Column<string>(maxLength: 50, nullable: true),
                    ad = table.Column<string>(maxLength: 50, nullable: true),
                    soyad = table.Column<string>(maxLength: 50, nullable: true),
                    dogumTarihi = table.Column<DateTime>(nullable: false),
                    tc = table.Column<string>(maxLength: 11, nullable: true),
                    mail = table.Column<string>(maxLength: 50, nullable: true),
                    cinsiyet = table.Column<bool>(nullable: false),
                    tel = table.Column<string>(maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kullanicilar", x => x.kullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "otobusler",
                columns: table => new
                {
                    otobusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    koltukSayisi = table.Column<int>(nullable: false),
                    wifi = table.Column<bool>(nullable: false),
                    tv = table.Column<bool>(nullable: false),
                    plaka = table.Column<string>(maxLength: 11, nullable: true),
                    marka = table.Column<string>(maxLength: 50, nullable: true),
                    model = table.Column<string>(maxLength: 50, nullable: true),
                    firmaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_otobusler", x => x.otobusId);
                    table.ForeignKey(
                        name: "FK_otobusler_firmalar_firmaId",
                        column: x => x.firmaId,
                        principalTable: "firmalar",
                        principalColumn: "firmaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "guzergahOtobusler",
                columns: table => new
                {
                    seferId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sure = table.Column<int>(nullable: false),
                    kalkisSaat = table.Column<string>(maxLength: 5, nullable: true),
                    tarih = table.Column<DateTime>(nullable: false),
                    biletFiyat = table.Column<double>(nullable: false),
                    guzergahId = table.Column<int>(nullable: false),
                    otobusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guzergahOtobusler", x => x.seferId);
                    table.ForeignKey(
                        name: "FK_guzergahOtobusler_guzergahlar_guzergahId",
                        column: x => x.guzergahId,
                        principalTable: "guzergahlar",
                        principalColumn: "guzergahId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_guzergahOtobusler_otobusler_otobusId",
                        column: x => x.otobusId,
                        principalTable: "otobusler",
                        principalColumn: "otobusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "guzergahOtobusKullanicilar",
                columns: table => new
                {
                    biletId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seriNo = table.Column<string>(maxLength: 50, nullable: true),
                    odemeTipi = table.Column<bool>(nullable: false),
                    koltukNo = table.Column<int>(nullable: false),
                    biletKesimTarihi = table.Column<DateTime>(nullable: false),
                    yolcuAd = table.Column<string>(maxLength: 25, nullable: true),
                    yolcuSoyad = table.Column<string>(maxLength: 25, nullable: true),
                    yolcuTc = table.Column<string>(maxLength: 11, nullable: true),
                    yolcuCinsiyet = table.Column<bool>(nullable: false),
                    guzergahOtobusId = table.Column<int>(nullable: false),
                    kullaniciId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guzergahOtobusKullanicilar", x => x.biletId);
                    table.ForeignKey(
                        name: "FK_guzergahOtobusKullanicilar_guzergahOtobusler_guzergahOtobusId",
                        column: x => x.guzergahOtobusId,
                        principalTable: "guzergahOtobusler",
                        principalColumn: "seferId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_guzergahOtobusKullanicilar_kullanicilar_kullaniciId",
                        column: x => x.kullaniciId,
                        principalTable: "kullanicilar",
                        principalColumn: "kullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_guzergahOtobusKullanicilar_guzergahOtobusId",
                table: "guzergahOtobusKullanicilar",
                column: "guzergahOtobusId");

            migrationBuilder.CreateIndex(
                name: "IX_guzergahOtobusKullanicilar_kullaniciId",
                table: "guzergahOtobusKullanicilar",
                column: "kullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_guzergahOtobusler_guzergahId",
                table: "guzergahOtobusler",
                column: "guzergahId");

            migrationBuilder.CreateIndex(
                name: "IX_guzergahOtobusler_otobusId",
                table: "guzergahOtobusler",
                column: "otobusId");

            migrationBuilder.CreateIndex(
                name: "IX_otobusler_firmaId",
                table: "otobusler",
                column: "firmaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "guzergahOtobusKullanicilar");

            migrationBuilder.DropTable(
                name: "guzergahOtobusler");

            migrationBuilder.DropTable(
                name: "kullanicilar");

            migrationBuilder.DropTable(
                name: "guzergahlar");

            migrationBuilder.DropTable(
                name: "otobusler");

            migrationBuilder.DropTable(
                name: "firmalar");
        }
    }
}
