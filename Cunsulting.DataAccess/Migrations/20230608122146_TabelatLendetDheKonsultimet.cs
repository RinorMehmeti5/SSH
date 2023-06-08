using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cunsult.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class TabelatLendetDheKonsultimet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Konsultimet",
                columns: table => new
                {
                    Kid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ktitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KkohaEFillimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KkohaEMbarimit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kpershkrimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KLid = table.Column<int>(type: "int", nullable: false),
                    KPid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konsultimet", x => x.Kid);
                });

            migrationBuilder.CreateTable(
                name: "Lendet",
                columns: table => new
                {
                    Lid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Ldescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LPid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lendet", x => x.Lid);
                });

            migrationBuilder.InsertData(
                table: "Konsultimet",
                columns: new[] { "Kid", "KLid", "KPid", "KkohaEFillimit", "KkohaEMbarimit", "Kpershkrimi", "Ktitle" },
                values: new object[,]
                {
                    { 1, 0, 0, new DateTime(2023, 6, 8, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 8, 16, 30, 0, 0, DateTimeKind.Unspecified), "Konsultime nga lenda e Fizikës", "Konsultimi 1" },
                    { 2, 0, 0, new DateTime(2023, 6, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 8, 17, 30, 0, 0, DateTimeKind.Unspecified), "Konsultime nga lenda e Siguris", "Konsultimi 2" },
                    { 3, 0, 0, new DateTime(2023, 6, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 9, 16, 30, 0, 0, DateTimeKind.Unspecified), "Konsultime nga lenda e Matematikes", "Konsultimi 3" },
                    { 4, 0, 0, new DateTime(2023, 6, 10, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 10, 16, 30, 0, 0, DateTimeKind.Unspecified), "Konsultime nga lenda e Sinjaleve", "Konsultimi 4" }
                });

            migrationBuilder.InsertData(
                table: "Lendet",
                columns: new[] { "Lid", "LPid", "Ldescription", "Lname" },
                values: new object[,]
                {
                    { 100, 0, "Kjo lende ka 7 kredi", "Algjebra lineare dhe kalkulus 1" },
                    { 101, 0, "Kjo lende ka 6 kredi", "Fizika 1" },
                    { 103, 0, "Kjo lende ka 7 kredi", "Bazat e inxhinierise elektrike 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Konsultimet");

            migrationBuilder.DropTable(
                name: "Lendet");
        }
    }
}
