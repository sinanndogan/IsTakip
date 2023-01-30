using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IsTakip.Core.Migrations
{
    public partial class _1001_firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepoRaf",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoRaf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DurusTip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DurusTip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kalinlik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kalinlik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MailParams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmtpPort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSLKullan = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailParams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MalzemeTip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalzemeTip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriSinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriSinif", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UretimSurec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RenkKodu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiraNo = table.Column<int>(type: "int", nullable: false),
                    SurecSayfaGorunumu = table.Column<int>(type: "int", nullable: false),
                    KolonMusteri = table.Column<bool>(type: "bit", nullable: false),
                    KolonProgram = table.Column<bool>(type: "bit", nullable: false),
                    KolonMakine = table.Column<bool>(type: "bit", nullable: false),
                    KolonKalinlik = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimSurec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepoEnvanter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoEnvanter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepoEnvanter_Depo_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepoHareket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepoId = table.Column<int>(type: "int", nullable: false),
                    DepoRafId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepoHareket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepoHareket_Depo_DepoId",
                        column: x => x.DepoId,
                        principalTable: "Depo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DepoHareket_DepoRaf_DepoRafId",
                        column: x => x.DepoRafId,
                        principalTable: "DepoRaf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Uretim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UretimKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false),
                    MalzemeTransferDurum = table.Column<int>(type: "int", nullable: false),
                    UretimBaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UretimBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MakineId = table.Column<int>(type: "int", nullable: true),
                    Not = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UretimDurum = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uretim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uretim_Makine_MakineId",
                        column: x => x.MakineId,
                        principalTable: "Makine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Uretim_MalzemeTip_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "MalzemeTip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MusteriSinifId = table.Column<int>(type: "int", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VergiNumarasi = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteri_MusteriSinif_MusteriSinifId",
                        column: x => x.MusteriSinifId,
                        principalTable: "MusteriSinif",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UretimDepoEnvanter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimId = table.Column<int>(type: "int", nullable: false),
                    DepoEnvanterId = table.Column<int>(type: "int", nullable: false),
                    MalzemeAdedi = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimDepoEnvanter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimDepoEnvanter_DepoEnvanter_DepoEnvanterId",
                        column: x => x.DepoEnvanterId,
                        principalTable: "DepoEnvanter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UretimDepoEnvanter_Uretim_UretimId",
                        column: x => x.UretimId,
                        principalTable: "Uretim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UretimDosya",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimId = table.Column<int>(type: "int", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimDosya", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimDosya_Uretim_UretimId",
                        column: x => x.UretimId,
                        principalTable: "Uretim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UretimDurus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimId = table.Column<int>(type: "int", nullable: false),
                    DurusTipId = table.Column<int>(type: "int", nullable: false),
                    DurusBaslamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurusBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DurusSuresi = table.Column<int>(type: "int", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimDurus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimDurus_DurusTip_DurusTipId",
                        column: x => x.DurusTipId,
                        principalTable: "DurusTip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UretimDurus_Uretim_UretimId",
                        column: x => x.UretimId,
                        principalTable: "Uretim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ajanda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ajanda_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Is",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    Teklifli = table.Column<bool>(type: "bit", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TeklifNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OgledenOnceTeslim = table.Column<bool>(type: "bit", nullable: false),
                    IsBitimindeBildir = table.Column<bool>(type: "bit", nullable: false),
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOnceligi = table.Column<int>(type: "int", nullable: false),
                    MusteriSiparisNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaturaKesildiMi = table.Column<bool>(type: "bit", nullable: false),
                    IslendiMi = table.Column<bool>(type: "bit", nullable: false),
                    MuhasebeNotu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ErturIsNotu = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Is", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Is_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusteriKisitlama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IslemAciklama = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Kisitla = table.Column<bool>(type: "bit", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriKisitlama", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriKisitlama_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusteriTemsilci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MailAdresi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Parola = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TelefonNumarasi = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    MailBildirimiGonder = table.Column<bool>(type: "bit", nullable: false),
                    SmsBildirimiGonder = table.Column<bool>(type: "bit", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriTemsilci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriTemsilci_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IsDosya",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsDosya", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsDosya_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IsMalzeme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    MalzemeTipId = table.Column<int>(type: "int", nullable: false),
                    KalinlikId = table.Column<int>(type: "int", nullable: false),
                    Iscilik = table.Column<bool>(type: "bit", nullable: false),
                    MalzemeNotu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UretimEmriVar = table.Column<bool>(type: "bit", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsMalzeme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsMalzeme_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsMalzeme_Kalinlik_KalinlikId",
                        column: x => x.KalinlikId,
                        principalTable: "Kalinlik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsMalzeme_MalzemeTip_MalzemeTipId",
                        column: x => x.MalzemeTipId,
                        principalTable: "MalzemeTip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IsMusteriTemsilcisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    MusteriTemsilciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsMusteriTemsilcisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsMusteriTemsilcisi_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsMusteriTemsilcisi_MusteriTemsilci_MusteriTemsilciId",
                        column: x => x.MusteriTemsilciId,
                        principalTable: "MusteriTemsilci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IsMalzemeUretimSurec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMalzemeId = table.Column<int>(type: "int", nullable: false),
                    UretimSurecId = table.Column<int>(type: "int", nullable: false),
                    IsId = table.Column<int>(type: "int", nullable: true),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsMalzemeUretimSurec", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsMalzemeUretimSurec_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsMalzemeUretimSurec_IsMalzeme_IsMalzemeId",
                        column: x => x.IsMalzemeId,
                        principalTable: "IsMalzeme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IsMalzemeUretimSurec_UretimSurec_UretimSurecId",
                        column: x => x.UretimSurecId,
                        principalTable: "UretimSurec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UretimIsMalzeme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimId = table.Column<int>(type: "int", nullable: false),
                    IsMalzemeId = table.Column<int>(type: "int", nullable: false),
                    IsId = table.Column<int>(type: "int", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    FaturaKesildi = table.Column<bool>(type: "bit", nullable: false),
                    FaturaIslendi = table.Column<bool>(type: "bit", nullable: false),
                    FaturaTutari = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaturaNot = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimIsMalzeme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimIsMalzeme_Is_IsId",
                        column: x => x.IsId,
                        principalTable: "Is",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UretimIsMalzeme_IsMalzeme_IsMalzemeId",
                        column: x => x.IsMalzemeId,
                        principalTable: "IsMalzeme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UretimIsMalzeme_Musteri_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UretimIsMalzeme_Uretim_UretimId",
                        column: x => x.UretimId,
                        principalTable: "Uretim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UretimUretimSurec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UretimId = table.Column<int>(type: "int", nullable: false),
                    UretimIsMalzemeId = table.Column<int>(type: "int", nullable: false),
                    UretimSurecId = table.Column<int>(type: "int", nullable: false),
                    UretimDurum = table.Column<int>(type: "int", nullable: false),
                    SurecBaslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SurecBitis = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OlusturanKullanciId = table.Column<int>(type: "int", nullable: false),
                    OlusturanKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GuncelleyenKullanciId = table.Column<int>(type: "int", nullable: false),
                    GuncelleyenKullanici = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UretimUretimSurec", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UretimUretimSurec_Uretim_UretimId",
                        column: x => x.UretimId,
                        principalTable: "Uretim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UretimUretimSurec_UretimIsMalzeme_UretimIsMalzemeId",
                        column: x => x.UretimIsMalzemeId,
                        principalTable: "UretimIsMalzeme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UretimUretimSurec_UretimSurec_UretimSurecId",
                        column: x => x.UretimSurecId,
                        principalTable: "UretimSurec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ajanda_MusteriId",
                table: "Ajanda",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoEnvanter_DepoId",
                table: "DepoEnvanter",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoHareket_DepoId",
                table: "DepoHareket",
                column: "DepoId");

            migrationBuilder.CreateIndex(
                name: "IX_DepoHareket_DepoRafId",
                table: "DepoHareket",
                column: "DepoRafId");

            migrationBuilder.CreateIndex(
                name: "IX_Is_MusteriId",
                table: "Is",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_IsDosya_IsId",
                table: "IsDosya",
                column: "IsId");

            migrationBuilder.CreateIndex(
                name: "IX_IsMalzeme_IsId",
                table: "IsMalzeme",
                column: "IsId");

            migrationBuilder.CreateIndex(
                name: "IX_IsMalzeme_KalinlikId",
                table: "IsMalzeme",
                column: "KalinlikId");

            migrationBuilder.CreateIndex(
                name: "IX_IsMalzeme_MalzemeTipId",
                table: "IsMalzeme",
                column: "MalzemeTipId");

            migrationBuilder.CreateIndex(
                name: "IX_IsMalzemeUretimSurec_IsId",
                table: "IsMalzemeUretimSurec",
                column: "IsId");

            migrationBuilder.CreateIndex(
                name: "IX_IsMalzemeUretimSurec_IsMalzemeId",
                table: "IsMalzemeUretimSurec",
                column: "IsMalzemeId");

            migrationBuilder.CreateIndex(
                name: "IX_IsMalzemeUretimSurec_UretimSurecId",
                table: "IsMalzemeUretimSurec",
                column: "UretimSurecId");

            migrationBuilder.CreateIndex(
                name: "IX_IsMusteriTemsilcisi_IsId",
                table: "IsMusteriTemsilcisi",
                column: "IsId");

            migrationBuilder.CreateIndex(
                name: "IX_IsMusteriTemsilcisi_MusteriTemsilciId",
                table: "IsMusteriTemsilcisi",
                column: "MusteriTemsilciId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteri_MusteriSinifId",
                table: "Musteri",
                column: "MusteriSinifId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriKisitlama_MusteriId",
                table: "MusteriKisitlama",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriTemsilci_MusteriId",
                table: "MusteriTemsilci",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Uretim_MakineId",
                table: "Uretim",
                column: "MakineId");

            migrationBuilder.CreateIndex(
                name: "IX_Uretim_MalzemeTipId",
                table: "Uretim",
                column: "MalzemeTipId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDepoEnvanter_DepoEnvanterId",
                table: "UretimDepoEnvanter",
                column: "DepoEnvanterId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDepoEnvanter_UretimId",
                table: "UretimDepoEnvanter",
                column: "UretimId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDosya_UretimId",
                table: "UretimDosya",
                column: "UretimId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDurus_DurusTipId",
                table: "UretimDurus",
                column: "DurusTipId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimDurus_UretimId",
                table: "UretimDurus",
                column: "UretimId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimIsMalzeme_IsId",
                table: "UretimIsMalzeme",
                column: "IsId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimIsMalzeme_IsMalzemeId",
                table: "UretimIsMalzeme",
                column: "IsMalzemeId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimIsMalzeme_MusteriId",
                table: "UretimIsMalzeme",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimIsMalzeme_UretimId",
                table: "UretimIsMalzeme",
                column: "UretimId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimUretimSurec_UretimId",
                table: "UretimUretimSurec",
                column: "UretimId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimUretimSurec_UretimIsMalzemeId",
                table: "UretimUretimSurec",
                column: "UretimIsMalzemeId");

            migrationBuilder.CreateIndex(
                name: "IX_UretimUretimSurec_UretimSurecId",
                table: "UretimUretimSurec",
                column: "UretimSurecId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ajanda");

            migrationBuilder.DropTable(
                name: "DepoHareket");

            migrationBuilder.DropTable(
                name: "IsDosya");

            migrationBuilder.DropTable(
                name: "IsMalzemeUretimSurec");

            migrationBuilder.DropTable(
                name: "IsMusteriTemsilcisi");

            migrationBuilder.DropTable(
                name: "MailParams");

            migrationBuilder.DropTable(
                name: "MusteriKisitlama");

            migrationBuilder.DropTable(
                name: "Tedarikci");

            migrationBuilder.DropTable(
                name: "UretimDepoEnvanter");

            migrationBuilder.DropTable(
                name: "UretimDosya");

            migrationBuilder.DropTable(
                name: "UretimDurus");

            migrationBuilder.DropTable(
                name: "UretimUretimSurec");

            migrationBuilder.DropTable(
                name: "DepoRaf");

            migrationBuilder.DropTable(
                name: "MusteriTemsilci");

            migrationBuilder.DropTable(
                name: "DepoEnvanter");

            migrationBuilder.DropTable(
                name: "DurusTip");

            migrationBuilder.DropTable(
                name: "UretimIsMalzeme");

            migrationBuilder.DropTable(
                name: "UretimSurec");

            migrationBuilder.DropTable(
                name: "Depo");

            migrationBuilder.DropTable(
                name: "IsMalzeme");

            migrationBuilder.DropTable(
                name: "Uretim");

            migrationBuilder.DropTable(
                name: "Is");

            migrationBuilder.DropTable(
                name: "Kalinlik");

            migrationBuilder.DropTable(
                name: "Makine");

            migrationBuilder.DropTable(
                name: "MalzemeTip");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "MusteriSinif");
        }
    }
}
