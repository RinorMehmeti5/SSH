using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cunsult.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class AddingTables : Migration
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
                        .Annotation("SqlServer:Identity", "1, 1")
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
                    Lname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
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
                    KonsultimId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Attending = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonsultimAttend", x => x.KAid);
                    table.ForeignKey(
                        name: "FK_KonsultimAttend_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonsultimAttend_Konsultimet_KonsultimId",
                        column: x => x.KonsultimId,
                        principalTable: "Konsultimet",
                        principalColumn: "Kid",
                        onDelete: ReferentialAction.Cascade);
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
                column: "Vid",
                values: new object[]
                {
                    1,
                    2,
                    3
                });

            migrationBuilder.InsertData(
                table: "Lendet",
                columns: new[] { "Lid", "DepartamentId", "Lname", "UserId", "VitiID" },
                values: new object[,]
                {
                    { 100, 10, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 101, 10, "Fizika 1", null, null },
                    { 102, 10, "Bazat e inxhinierise elektrike 1", null, 1 },
                    { 103, 10, "Bazat e Programimit", null, 1 },
                    { 104, 10, "Anglishtja teknike", null, 1 },
                    { 105, 10, "Shkathtësi komunikuese", null, 1 },
                    { 106, 10, "Gjuhe gjermane", null, 1 },
                    { 107, 10, "Praktikum në matematikë", null, 1 },
                    { 108, 10, "Kalkulus 2", null, 1 },
                    { 109, 10, "Fizika 2", null, 1 },
                    { 110, 10, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 111, 10, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 112, 10, "Qarqet digjitale", null, 1 },
                    { 113, 10, "Matematika diskrete dhe probabiliteti", null, 2 },
                    { 114, 10, "Bazat e të dhënave", null, 2 },
                    { 115, 10, "Programimi i orientuar në objekte", null, 2 },
                    { 116, 10, "Arkitektura e kompjuterëve", null, 2 },
                    { 117, 10, "Elektronika", null, 2 },
                    { 118, 10, "Programimi në ueb I", null, 2 },
                    { 119, 10, "Sistemet operative", null, 2 },
                    { 120, 10, "Inxhinieria softuerike", null, 2 },
                    { 121, 10, "Siguria e të dhënave", null, 2 },
                    { 122, 10, "Komunikimi njeri-kompjuter", null, 2 },
                    { 123, 10, "Programimi në ueb II", null, 2 },
                    { 124, 10, "Çeshtjet legale, etike dhe sociale ne TIK", null, 2 },
                    { 125, 10, "Buxheti dhe analiza e shpenzimeve", null, 2 },
                    { 126, 10, "Mikroprocesorët dhe mikrokontrollerët", null, 3 },
                    { 127, 10, "Dizajni dhe analiza e algoritmeve", null, 3 },
                    { 128, 10, "Rrjetat kompjuterike", null, 3 },
                    { 129, 10, "Programimi per pajisje mobile", null, 3 },
                    { 130, 10, "Inxhinierimi i të dhënave", null, 3 },
                    { 131, 10, "Siguria në kompjuter", null, 3 },
                    { 132, 10, "Testimi i softuerit", null, 3 },
                    { 133, 10, "Concurrent Computing", null, 3 },
                    { 134, 10, "Ndërmarresi dhe inovacion", null, 3 },
                    { 135, 10, "Menaxhimi i projekteve në TI", null, 3 },
                    { 137, 10, "Sistemet e shpërndara", null, 3 },
                    { 138, 10, "Gërmimi i të dhënave", null, 3 },
                    { 139, 10, "Siguria në internet", null, 3 },
                    { 140, 10, "Big data", null, 3 },
                    { 141, 10, "Nxjerrja e informatave", null, 3 },
                    { 142, 10, "Visual computing", null, 3 },
                    { 143, 10, "Cloud computing", null, 3 },
                    { 144, 10, "Parallel computing", null, 3 },
                    { 145, 10, "Komunikimi i të dhënave", null, 3 },
                    { 146, 10, "Biomedical Engineering", null, 3 },
                    { 147, 10, "Biometrics & Forensics", null, 3 },
                    { 148, 10, "Praktika profesionale", null, 3 },
                    { 149, 10, "Punimi i diplomës", null, 3 },
                    { 150, 11, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 151, 11, "Fizika 1", null, 1 },
                    { 152, 11, "Bazat e inxhinierisë elektrike 1", null, 1 },
                    { 153, 11, "Bazat e Programimit", null, 1 },
                    { 154, 11, "Anglishtja teknike", null, 1 },
                    { 155, 11, "Shkathtësi komunikuese", null, 1 },
                    { 156, 11, "Gjuhe gjermane", null, 1 },
                    { 157, 11, "Praktikum në matematikë", null, 1 },
                    { 158, 11, "Kalkulus 2", null, 1 },
                    { 159, 11, "Fizika 2", null, 1 },
                    { 160, 11, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 161, 11, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 162, 11, "Qarqet digjitale", null, 1 },
                    { 163, 11, "Mikroprocesorët dhe mikrokontrollerët", null, 2 },
                    { 164, 11, "Kalkulus 3E", null, 2 },
                    { 165, 11, "Sinjale dhe sisteme", null, 2 },
                    { 166, 11, "Automatika", null, 2 },
                    { 167, 11, "Elektronika", null, 2 },
                    { 168, 11, "Matjet elektronike", null, 2 },
                    { 169, 11, "Interneti i gjërave", null, 2 },
                    { 170, 11, "Elektroenergjetika", null, 2 },
                    { 171, 11, "Fushat dhe valët elektromagnetike", null, 2 },
                    { 172, 11, "Sinjalet diskrete dhe pёrpunimi digjital", null, 2 },
                    { 173, 11, "Arkitektura e kompjuterёve", null, 2 },
                    { 174, 11, "Inovacioni dhe biznesi", null, 2 },
                    { 175, 11, "Menaxhimi i projekteve", null, 2 },
                    { 176, 11, "Komponentët elektronike", null, 3 },
                    { 177, 11, "Elektronika digjitale", null, 3 },
                    { 178, 11, "Elektronika energjetike", null, 3 },
                    { 179, 11, "Optoelektronika", null, 3 },
                    { 180, 11, "Sensorët dhe aktuatorët", null, 3 },
                    { 181, 11, "Komunikimet elektronike", null, 3 },
                    { 182, 11, "Instrumentacioni matës dhe DAQ", null, 3 },
                    { 183, 11, "Bazat e mekatronikës", null, 3 },
                    { 184, 11, "Sinjalet biomedicinale", null, 3 },
                    { 185, 11, "Ndёrmarrёsia", null, 3 },
                    { 186, 11, "Mikroekonomia", null, 3 },
                    { 187, 11, "Mikroelektronika", null, 3 },
                    { 188, 11, "Elektronika analoge", null, 3 },
                    { 189, 11, "Bazat e multimedias", null, 3 },
                    { 190, 11, "Bazat e robotikës", null, 3 },
                    { 191, 11, "Teknologjia e komunikimeve optike", null, 3 },
                    { 192, 11, "Sistemet e ndërthurura ", null, 3 },
                    { 193, 11, "Projektimi i sistemeve elektronike me", null, 3 },
                    { 194, 11, "Instrumentacioni biomedicinale", null, 3 },
                    { 195, 11, "Praktika profesionale", null, 3 },
                    { 196, 11, "Tema e diplomës bachelor", null, 3 },
                    { 197, 11, "Sistemet e rregullimit automatik", null, 3 },
                    { 198, 11, "Bazat e robotikës", null, 3 },
                    { 199, 11, "Dirigjuesit e programueshëm logjik ", null, 3 },
                    { 200, 11, "Aktuatorët e mençur dhe ngasjet", null, 3 },
                    { 201, 11, "Sensorët e mençur", null, 3 },
                    { 202, 11, "Komunikimet në automatikë", null, 3 },
                    { 203, 11, "Metodat e elementeve tё fundme", null, 3 },
                    { 204, 11, "Sistemet operative", null, 3 },
                    { 205, 11, "Modelimi dhe simulimi", null, 3 },
                    { 206, 11, "Sistemet digjitale tё rregullimit", null, 3 },
                    { 207, 11, "Sistemet jolineare të rregullimit", null, 3 },
                    { 208, 11, "Rregullimi i proceseve kimike", null, 3 },
                    { 209, 11, "Proceset e vazhduara dhe grupore", null, 3 },
                    { 210, 11, "Rregullimi në kohë reale", null, 3 },
                    { 211, 11, "Grumbullimi kompjuterik i të dhënave", null, 3 },
                    { 212, 11, "Automatizimi i objekteve të banimit", null, 3 },
                    { 213, 11, "Praktika profesionale", null, 3 },
                    { 214, 11, "Tema e diplomës bachelor", null, 3 },
                    { 215, 12, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 216, 12, "Fizika 1", null, 1 },
                    { 217, 12, "Bazat e inxhinierisë elektrike 1 ", null, 1 },
                    { 218, 12, "Bazat e Programimit", null, 1 },
                    { 219, 12, "Anglishtja teknike", null, 1 },
                    { 220, 12, "Shkathtësi komunikuese", null, 1 },
                    { 221, 12, "Gjuhe gjermane", null, 1 },
                    { 222, 12, "Praktikum në matematikë", null, 1 },
                    { 223, 12, "Kalkulus 2", null, 1 },
                    { 224, 12, "Fizika 2", null, 1 },
                    { 225, 12, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 226, 12, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 227, 12, "Qarqet digjitale", null, 1 },
                    { 228, 12, "Kalkulus 3 dhe probabilitet", null, 2 },
                    { 229, 12, "Sinjalet dhe Informacionet", null, 2 },
                    { 230, 12, "Elektronikë", null, 2 },
                    { 231, 12, "Teknologjitë e Internetit", null, 2 },
                    { 232, 12, "Praktikum në Matlab", null, 2 },
                    { 233, 12, "Praktikum në Labview", null, 2 },
                    { 234, 12, "Komunikimet digjitale", null, 2 },
                    { 235, 12, "Valët elektromagnetike", null, 2 },
                    { 236, 12, "Transmetimi i të dhënave", null, 2 },
                    { 237, 12, "Menaxhimi i projekteve ne TIK", null, 2 },
                    { 238, 12, "Ekonomia per Inxhinieri", null, 2 },
                    { 239, 12, "Arkitektura e kompjutereve dhe pajisjeve", null, 2 },
                    { 240, 12, "Zhvillimi i aplikacioneve ne C++", null, 2 },
                    { 241, 12, "Zhvillimi i Web aplikacioneve/www", null, 2 },
                    { 242, 12, "Rrjetet komunikuese I", null, 3 },
                    { 243, 12, "Sistemet operative për TIK", null, 3 },
                    { 244, 12, "Programimi i orientuar ne objekte", null, 3 },
                    { 245, 12, "Teknologjitë dhe sistemet multimediale", null, 3 },
                    { 246, 12, "Python", null, 3 },
                    { 247, 12, "Zhvillimi aplikacioneve per Android dhe IOS", null, 3 },
                    { 248, 12, "Zhvillim i lojerave kompjuterike", null, 3 },
                    { 249, 12, "Praktikum në Matlab", null, 3 },
                    { 250, 12, "Praktikum në Labview", null, 3 },
                    { 251, 12, "Inxhinieria e RF dhe Mikrovalëve", null, 3 },
                    { 252, 12, "Komunikimet mobile", null, 3 },
                    { 253, 12, "Programimi i distribuar", null, 3 },
                    { 254, 12, "Rrjetet komunikuese II", null, 3 },
                    { 255, 12, "Projekti përfundimtar (Praktika profesionale dhe prezantimi)", null, 3 },
                    { 256, 12, "Komunikimet optike", null, 3 },
                    { 257, 12, "Bioelektromagnetika", null, 3 },
                    { 258, 12, "Protokolet komunikuese", null, 3 },
                    { 259, 12, "Animimi dhe VR", null, 3 },
                    { 260, 13, "Algjebra lineare dhe kalkulus 1", null, 1 },
                    { 261, 13, "Fizika 1", null, 1 },
                    { 262, 13, "Bazat e inxhinierisë elektrike 1", null, 1 },
                    { 263, 13, "Bazat e Programimit", null, 1 },
                    { 264, 13, "Anglishtja teknike", null, 1 },
                    { 265, 13, "Shkathtësi komunikuese", null, 1 },
                    { 266, 13, "Gjuhe gjermane", null, 1 },
                    { 267, 13, "Praktikum në matematikë", null, 1 },
                    { 268, 13, "Kalkulus 2", null, 1 },
                    { 269, 13, "Fizika 2", null, 1 },
                    { 270, 13, "Bazat e inxhinierisë elektrike 2", null, 1 },
                    { 271, 13, "Algoritmet dhe strukturat e të dhënave", null, 1 },
                    { 272, 13, "Qarqet digjitale", null, 1 },
                    { 273, 13, "Kalkulus 3 dhe probabilitet", null, 2 },
                    { 274, 13, "Materialet elektrike", null, 2 },
                    { 275, 13, "Matjet Elektrike", null, 2 },
                    { 276, 13, "Bazat e Elektroenergjetikës", null, 2 },
                    { 277, 13, "Elektronika", null, 2 },
                    { 278, 13, "Bazat e automatikës", null, 2 },
                    { 279, 13, "Sinjalet dhe sistemet", null, 2 },
                    { 280, 13, "Programimi i orientuar në objekte", null, 2 },
                    { 281, 13, "Aplikacionet softwerike në elektroenergjetikë", null, 2 },
                    { 282, 13, "Makinat elektrike dhe transformatorët", null, 2 },
                    { 283, 13, "Energjia dhe mjedisi", null, 2 },
                    { 284, 13, "Centralet elektrike", null, 2 },
                    { 285, 13, "Fushat dhe valët elektromagnetike", null, 2 },
                    { 286, 13, "Menaxhimi i energjisë dhe auditimi i efiçiencës", null, 2 },
                    { 287, 13, "Instrumentacioni matës në elektroenergjetikë", null, 2 },
                    { 288, 13, "Teknika e sigurimit në impiantet elektrike", null, 2 },
                    { 289, 13, "Transmetimi i të dhënave", null, 2 },
                    { 290, 13, "Tregu i energjisë elektrike", null, 3 },
                    { 291, 13, "Bartja dhe shpërndarja e energjisë elektrike", null, 3 },
                    { 292, 13, "Stabilimentet elektroenergjetike", null, 3 },
                    { 293, 13, "Instalimet elektrike dhe rrjetat e tensionit", null, 3 },
                    { 294, 13, "Burimet e ripërtëritshme të energjisë", null, 3 },
                    { 295, 13, "Energjia diellore dhe fotovoltaikët", null, 3 },
                    { 296, 13, "Elektronika energjetike", null, 3 },
                    { 297, 13, "Makinat elektrike speciale", null, 3 },
                    { 298, 13, "Rrjetat elektrike të fuqisë", null, 3 },
                    { 299, 13, "Energjia diellore dhe fotovoltaikët", null, 3 },
                    { 300, 13, "Ngasjet elektrike", null, 3 },
                    { 301, 13, "Mbrojtja e sistemeve elektroenergjetike", null, 3 },
                    { 302, 13, "Praktika profesionale", null, 3 },
                    { 303, 13, "Punimi i Diplomës", null, 3 },
                    { 304, 13, "Kualiteti i fuqisë në sistemet elektroenergjetike", null, 3 },
                    { 305, 13, "Energjia e erës", null, 3 },
                    { 306, 13, "Bazat e rrjetave të mençura", null, 3 },
                    { 307, 13, "Vlerësimi ekonomik i investimeve", null, 3 },
                    { 308, 13, "Menaxhimi i projekteve dhe etika", null, 3 },
                    { 309, 13, "Ndërmarrësia", null, 3 }
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
                name: "IX_KonsultimAttend_KonsultimId",
                table: "KonsultimAttend",
                column: "KonsultimId");

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
