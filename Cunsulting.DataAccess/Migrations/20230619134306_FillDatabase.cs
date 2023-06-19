using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cunsult.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class FillDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Viti",
                columns: table => new
                {
                    Vid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VitiName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viti", x => x.Vid);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FKID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartamentID = table.Column<int>(type: "int", nullable: true),
                    VitiID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departament_DepartamentID",
                        column: x => x.DepartamentID,
                        principalTable: "Departament",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Viti_VitiID",
                        column: x => x.VitiID,
                        principalTable: "Viti",
                        principalColumn: "Vid");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lendet",
                columns: table => new
                {
                    Lid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lname = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DepartamentId = table.Column<int>(type: "int", nullable: false),
                    VitiID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lendet", x => x.Lid);
                    table.ForeignKey(
                        name: "FK_Lendet_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lendet_Departament_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lendet_Viti_VitiID",
                        column: x => x.VitiID,
                        principalTable: "Viti",
                        principalColumn: "Vid");
                });

            migrationBuilder.CreateTable(
                name: "Konsultimet",
                columns: table => new
                {
                    Kid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ktitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KkohaEFillimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KkohaEMbarimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kpershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KLid = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konsultimet", x => x.Kid);
                    table.ForeignKey(
                        name: "FK_Konsultimet_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Konsultimet_Lendet_KLid",
                        column: x => x.KLid,
                        principalTable: "Lendet",
                        principalColumn: "Lid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KonsultimAttend",
                columns: table => new
                {
                    KAid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kid = table.Column<int>(type: "int", nullable: false),
                    Attending = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonsultimAttend", x => x.KAid);
                    table.ForeignKey(
                        name: "FK_KonsultimAttend_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KonsultimAttend_Konsultimet_Kid",
                        column: x => x.Kid,
                        principalTable: "Konsultimet",
                        principalColumn: "Kid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Departament",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Inxhinieri Kompjuterike dhe Softuerike" },
                    { 11, "Elektronikë, Automatikë dhe Robotikë" },
                    { 12, "Teknologjite e Informacionit dhe Komunikimit" },
                    { 13, "Elektroenergjetike" }
                });

            migrationBuilder.InsertData(
                table: "Viti",
                columns: new[] { "Vid", "VitiName" },
                values: new object[,]
                {
                    { 1, "Viti i parë" },
                    { 2, "Viti i dytë" },
                    { 3, "Viti i tretë" }
                });

            migrationBuilder.InsertData(
                table: "Lendet",
                columns: new[] { "Lid", "DepartamentId", "Lname", "UserId", "VitiID" },
                values: new object[,]
                {
                    { 1, 10, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 2, 10, "Fizika 1", null, 1 },
                    { 3, 10, "Bazat e inxhinierise elektrike 1", null, 1 },
                    { 4, 10, "Bazat e Programimit", null, 1 },
                    { 5, 10, "Anglishtja teknike", null, 1 },
                    { 6, 10, "Shkathtësi komunikuese", null, 1 },
                    { 7, 10, "Gjuhe gjermane", null, 1 },
                    { 8, 10, "Praktikum në matematikë", null, 1 },
                    { 9, 10, "Kalkulus 2", null, 1 },
                    { 10, 10, "Fizika 2", null, 1 },
                    { 11, 10, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 12, 10, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 13, 10, "Qarqet digjitale", null, 1 },
                    { 14, 10, "Matematika diskrete dhe probabiliteti", null, 2 },
                    { 15, 10, "Bazat e të dhënave", null, 2 },
                    { 16, 10, "Programimi i orientuar në objekte", null, 2 },
                    { 17, 10, "Arkitektura e kompjuterëve", null, 2 },
                    { 18, 10, "Elektronika", null, 2 },
                    { 19, 10, "Programimi në ueb I", null, 2 },
                    { 20, 10, "Sistemet operative", null, 2 },
                    { 21, 10, "Inxhinieria softuerike", null, 2 },
                    { 22, 10, "Siguria e të dhënave", null, 2 },
                    { 23, 10, "Komunikimi njeri-kompjuter", null, 2 },
                    { 24, 10, "Programimi në ueb II", null, 2 },
                    { 25, 10, "Çeshtjet legale, etike dhe sociale ne TIK", null, 2 },
                    { 26, 10, "Buxheti dhe analiza e shpenzimeve", null, 2 },
                    { 27, 10, "Mikroprocesorët dhe mikrokontrollerët", null, 3 },
                    { 28, 10, "Dizajni dhe analiza e algoritmeve", null, 3 },
                    { 29, 10, "Rrjetat kompjuterike", null, 3 },
                    { 30, 10, "Programimi per pajisje mobile", null, 3 },
                    { 31, 10, "Inxhinierimi i të dhënave", null, 3 },
                    { 32, 10, "Siguria në kompjuter", null, 3 },
                    { 33, 10, "Testimi i softuerit", null, 3 },
                    { 34, 10, "Concurrent Computing", null, 3 },
                    { 35, 10, "Ndërmarresi dhe inovacion", null, 3 },
                    { 36, 10, "Menaxhimi i projekteve në TI", null, 3 },
                    { 37, 10, "Sistemet e shpërndara", null, 3 },
                    { 38, 10, "Gërmimi i të dhënave", null, 3 },
                    { 39, 10, "Siguria në internet", null, 3 },
                    { 40, 10, "Big data", null, 3 },
                    { 41, 10, "Nxjerrja e informatave", null, 3 },
                    { 42, 10, "Visual computing", null, 3 },
                    { 43, 10, "Cloud computing", null, 3 },
                    { 44, 10, "Parallel computing", null, 3 },
                    { 45, 10, "Komunikimi i të dhënave", null, 3 },
                    { 46, 10, "Biomedical Engineering", null, 3 },
                    { 47, 10, "Biometrics & Forensics", null, 3 },
                    { 48, 10, "Praktika profesionale", null, 3 },
                    { 49, 10, "Punimi i diplomës", null, 3 },
                    { 50, 11, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 51, 11, "Fizika 1", null, 1 },
                    { 52, 11, "Bazat e inxhinierisë elektrike 1", null, 1 },
                    { 53, 11, "Bazat e Programimit", null, 1 },
                    { 54, 11, "Anglishtja teknike", null, 1 },
                    { 55, 11, "Shkathtësi komunikuese", null, 1 },
                    { 56, 11, "Gjuhe gjermane", null, 1 },
                    { 57, 11, "Praktikum në matematikë", null, 1 },
                    { 58, 11, "Kalkulus 2", null, 1 },
                    { 59, 11, "Fizika 2", null, 1 },
                    { 60, 11, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 61, 11, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 62, 11, "Qarqet digjitale", null, 1 },
                    { 63, 11, "Mikroprocesorët dhe mikrokontrollerët", null, 2 },
                    { 64, 11, "Kalkulus 3E", null, 2 },
                    { 65, 11, "Sinjale dhe sisteme", null, 2 },
                    { 66, 11, "Automatika", null, 2 },
                    { 67, 11, "Elektronika", null, 2 },
                    { 68, 11, "Matjet elektronike", null, 2 },
                    { 69, 11, "Interneti i gjërave", null, 2 },
                    { 70, 11, "Elektroenergjetika", null, 2 },
                    { 71, 11, "Fushat dhe valët elektromagnetike", null, 2 },
                    { 72, 11, "Sinjalet diskrete dhe pёrpunimi digjital", null, 2 },
                    { 73, 11, "Arkitektura e kompjuterёve", null, 2 },
                    { 74, 11, "Inovacioni dhe biznesi", null, 2 },
                    { 75, 11, "Menaxhimi i projekteve", null, 2 },
                    { 76, 11, "Komponentët elektronike", null, 3 },
                    { 77, 11, "Elektronika digjitale", null, 3 },
                    { 78, 11, "Elektronika energjetike", null, 3 },
                    { 79, 11, "Optoelektronika", null, 3 },
                    { 80, 11, "Sensorët dhe aktuatorët", null, 3 },
                    { 81, 11, "Komunikimet elektronike", null, 3 },
                    { 82, 11, "Instrumentacioni matës dhe DAQ", null, 3 },
                    { 83, 11, "Bazat e mekatronikës", null, 3 },
                    { 84, 11, "Sinjalet biomedicinale", null, 3 },
                    { 85, 11, "Ndёrmarrёsia", null, 3 },
                    { 86, 11, "Mikroekonomia", null, 3 },
                    { 87, 11, "Mikroelektronika", null, 3 },
                    { 88, 11, "Elektronika analoge", null, 3 },
                    { 89, 11, "Bazat e multimedias", null, 3 },
                    { 90, 11, "Bazat e robotikës", null, 3 },
                    { 91, 11, "Teknologjia e komunikimeve optike", null, 3 },
                    { 92, 11, "Sistemet e ndërthurura ", null, 3 },
                    { 93, 11, "Projektimi i sistemeve elektronike me", null, 3 },
                    { 94, 11, "Instrumentacioni biomedicinale", null, 3 },
                    { 95, 11, "Praktika profesionale", null, 3 },
                    { 96, 11, "Tema e diplomës bachelor", null, 3 },
                    { 97, 11, "Sistemet e rregullimit automatik", null, 3 },
                    { 98, 11, "Bazat e robotikës", null, 3 },
                    { 99, 11, "Dirigjuesit e programueshëm logjik ", null, 3 },
                    { 100, 11, "Aktuatorët e mençur dhe ngasjet", null, 3 },
                    { 101, 11, "Sensorët e mençur", null, 3 },
                    { 102, 11, "Komunikimet në automatikë", null, 3 },
                    { 103, 11, "Metodat e elementeve tё fundme", null, 3 },
                    { 104, 11, "Sistemet operative", null, 3 },
                    { 105, 11, "Modelimi dhe simulimi", null, 3 },
                    { 106, 11, "Sistemet digjitale tё rregullimit", null, 3 },
                    { 107, 11, "Sistemet jolineare të rregullimit", null, 3 },
                    { 108, 11, "Rregullimi i proceseve kimike", null, 3 },
                    { 109, 11, "Proceset e vazhduara dhe grupore", null, 3 },
                    { 110, 11, "Rregullimi në kohë reale", null, 3 },
                    { 111, 11, "Grumbullimi kompjuterik i të dhënave", null, 3 },
                    { 112, 11, "Automatizimi i objekteve të banimit", null, 3 },
                    { 113, 11, "Praktika profesionale", null, 3 },
                    { 114, 11, "Tema e diplomës bachelor", null, 3 },
                    { 115, 12, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 116, 12, "Fizika 1", null, 1 },
                    { 117, 12, "Bazat e inxhinierisë elektrike 1 ", null, 1 },
                    { 118, 12, "Bazat e Programimit", null, 1 },
                    { 119, 12, "Anglishtja teknike", null, 1 },
                    { 120, 12, "Shkathtësi komunikuese", null, 1 },
                    { 121, 12, "Gjuhe gjermane", null, 1 },
                    { 122, 12, "Praktikum në matematikë", null, 1 },
                    { 123, 12, "Kalkulus 2", null, 1 },
                    { 124, 12, "Fizika 2", null, 1 },
                    { 125, 12, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 126, 12, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 127, 12, "Qarqet digjitale", null, 1 },
                    { 128, 12, "Kalkulus 3 dhe probabilitet", null, 2 },
                    { 129, 12, "Sinjalet dhe Informacionet", null, 2 },
                    { 130, 12, "Elektronikë", null, 2 },
                    { 131, 12, "Teknologjitë e Internetit", null, 2 },
                    { 132, 12, "Praktikum në Matlab", null, 2 },
                    { 133, 12, "Praktikum në Labview", null, 2 },
                    { 134, 12, "Komunikimet digjitale", null, 2 },
                    { 135, 12, "Valët elektromagnetike", null, 2 },
                    { 136, 12, "Transmetimi i të dhënave", null, 2 },
                    { 137, 12, "Menaxhimi i projekteve ne TIK", null, 2 },
                    { 138, 12, "Ekonomia per Inxhinieri", null, 2 },
                    { 139, 12, "Arkitektura e kompjutereve dhe pajisjeve", null, 2 },
                    { 140, 12, "Zhvillimi i aplikacioneve ne C++", null, 2 },
                    { 141, 12, "Zhvillimi i Web aplikacioneve/www", null, 2 },
                    { 142, 12, "Rrjetet komunikuese I", null, 3 },
                    { 143, 12, "Sistemet operative për TIK", null, 3 },
                    { 144, 12, "Programimi i orientuar ne objekte", null, 3 },
                    { 145, 12, "Teknologjitë dhe sistemet multimediale", null, 3 },
                    { 146, 12, "Python", null, 3 },
                    { 147, 12, "Zhvillimi aplikacioneve per Android dhe IOS", null, 3 },
                    { 148, 12, "Zhvillim i lojerave kompjuterike", null, 3 },
                    { 149, 12, "Praktikum në Matlab", null, 3 },
                    { 150, 12, "Praktikum në Labview", null, 3 },
                    { 151, 12, "Inxhinieria e RF dhe Mikrovalëve", null, 3 },
                    { 152, 12, "Komunikimet mobile", null, 3 },
                    { 153, 12, "Programimi i distribuar", null, 3 },
                    { 154, 12, "Rrjetet komunikuese II", null, 3 },
                    { 155, 12, "Projekti përfundimtar (Praktika profesionale dhe prezantimi)", null, 3 },
                    { 156, 12, "Komunikimet optike", null, 3 },
                    { 157, 12, "Bioelektromagnetika", null, 3 },
                    { 158, 12, "Protokolet komunikuese", null, 3 },
                    { 159, 12, "Animimi dhe VR", null, 3 },
                    { 160, 13, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 161, 13, "Fizika 1", null, 1 },
                    { 162, 13, "Bazat e inxhinierisë elektrike 1", null, 1 },
                    { 163, 13, "Bazat e Programimit", null, 1 },
                    { 164, 13, "Anglishtja teknike", null, 1 },
                    { 165, 13, "Shkathtësi komunikuese", null, 1 },
                    { 166, 13, "Gjuhe gjermane", null, 1 },
                    { 167, 13, "Praktikum në matematikë", null, 1 },
                    { 168, 13, "Kalkulus 2", null, 1 },
                    { 169, 13, "Fizika 2", null, 1 },
                    { 170, 13, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 171, 13, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 172, 13, "Qarqet digjitale", null, 1 },
                    { 173, 13, "Kalkulus 3 dhe probabilitet", null, 2 },
                    { 174, 13, "Materialet elektrike", null, 2 },
                    { 175, 13, "Matjet Elektrike", null, 2 },
                    { 176, 13, "Bazat e Elektroenergjetikës", null, 2 },
                    { 177, 13, "Elektronika", null, 2 },
                    { 178, 13, "Bazat e automatikës", null, 2 },
                    { 179, 13, "Sinjalet dhe sistemet", null, 2 },
                    { 180, 13, "Programimi i orientuar në objekte", null, 2 },
                    { 181, 13, "Aplikacionet softwerike në elektroenergjetikë", null, 2 },
                    { 182, 13, "Makinat elektrike dhe transformatorët", null, 2 },
                    { 183, 13, "Energjia dhe mjedisi", null, 2 },
                    { 184, 13, "Centralet elektrike", null, 2 },
                    { 185, 13, "Fushat dhe valët elektromagnetike", null, 2 },
                    { 186, 13, "Menaxhimi i energjisë dhe auditimi i efiçiencës", null, 2 },
                    { 187, 13, "Instrumentacioni matës në elektroenergjetikë", null, 2 },
                    { 188, 13, "Teknika e sigurimit në impiantet elektrike", null, 2 },
                    { 189, 13, "Transmetimi i të dhënave", null, 2 },
                    { 190, 13, "Tregu i energjisë elektrike", null, 3 },
                    { 191, 13, "Bartja dhe shpërndarja e energjisë elektrike", null, 3 },
                    { 192, 13, "Stabilimentet elektroenergjetike", null, 3 },
                    { 193, 13, "Instalimet elektrike dhe rrjetat e tensionit", null, 3 },
                    { 194, 13, "Burimet e ripërtëritshme të energjisë", null, 3 },
                    { 195, 13, "Energjia diellore dhe fotovoltaikët", null, 3 },
                    { 196, 13, "Elektronika energjetike", null, 3 },
                    { 197, 13, "Makinat elektrike speciale", null, 3 },
                    { 198, 13, "Rrjetat elektrike të fuqisë", null, 3 },
                    { 199, 13, "Energjia diellore dhe fotovoltaikët", null, 3 },
                    { 200, 13, "Ngasjet elektrike", null, 3 },
                    { 201, 13, "Mbrojtja e sistemeve elektroenergjetike", null, 3 },
                    { 202, 13, "Praktika profesionale", null, 3 },
                    { 203, 13, "Punimi i Diplomës", null, 3 },
                    { 204, 13, "Kualiteti i fuqisë në sistemet elektroenergjetike", null, 3 },
                    { 205, 13, "Energjia e erës", null, 3 },
                    { 206, 13, "Bazat e rrjetave të mençura", null, 3 },
                    { 207, 13, "Vlerësimi ekonomik i investimeve", null, 3 },
                    { 208, 13, "Menaxhimi i projekteve dhe etika", null, 3 },
                    { 209, 13, "Ndërmarrësia", null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartamentID",
                table: "AspNetUsers",
                column: "DepartamentID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_VitiID",
                table: "AspNetUsers",
                column: "VitiID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KonsultimAttend_Kid",
                table: "KonsultimAttend",
                column: "Kid");

            migrationBuilder.CreateIndex(
                name: "IX_KonsultimAttend_UserId",
                table: "KonsultimAttend",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Konsultimet_KLid",
                table: "Konsultimet",
                column: "KLid");

            migrationBuilder.CreateIndex(
                name: "IX_Konsultimet_UserId",
                table: "Konsultimet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lendet_DepartamentId",
                table: "Lendet",
                column: "DepartamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lendet_UserId",
                table: "Lendet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lendet_VitiID",
                table: "Lendet",
                column: "VitiID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "KonsultimAttend");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Konsultimet");

            migrationBuilder.DropTable(
                name: "Lendet");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Departament");

            migrationBuilder.DropTable(
                name: "Viti");
        }
    }
}
