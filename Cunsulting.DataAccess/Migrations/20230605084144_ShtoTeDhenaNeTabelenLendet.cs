using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Consult.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class ShtoTeDhenaNeTabelenLendet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ldescription",
                table: "Lendet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Lendet",
                columns: new[] { "Lid", "Ldescription", "Lname" },
                values: new object[,]
                {
                    { 100, "Kjo lende ka 7 kredi", "Algjebra lineare dhe kalkulus 1" },
                    { 101, "Kjo lende ka 6 kredi", "Fizika 1" },
                    { 103, "Kjo lende ka 7 kredi", "Bazat e inxhinierise elektrike 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Lendet",
                keyColumn: "Lid",
                keyValue: 103);

            migrationBuilder.AlterColumn<int>(
                name: "Ldescription",
                table: "Lendet",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
