using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cunsult.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyForKonsultimeLendetRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Konsultimet",
                keyColumn: "Kid",
                keyValue: 1,
                column: "KLid",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Konsultimet",
                keyColumn: "Kid",
                keyValue: 2,
                column: "KLid",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Konsultimet",
                keyColumn: "Kid",
                keyValue: 3,
                column: "KLid",
                value: 103);

            migrationBuilder.UpdateData(
                table: "Konsultimet",
                keyColumn: "Kid",
                keyValue: 4,
                column: "KLid",
                value: 103);

            migrationBuilder.CreateIndex(
                name: "IX_Konsultimet_KLid",
                table: "Konsultimet",
                column: "KLid");

            migrationBuilder.AddForeignKey(
                name: "FK_Konsultimet_Lendet_KLid",
                table: "Konsultimet",
                column: "KLid",
                principalTable: "Lendet",
                principalColumn: "Lid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Konsultimet_Lendet_KLid",
                table: "Konsultimet");

            migrationBuilder.DropIndex(
                name: "IX_Konsultimet_KLid",
                table: "Konsultimet");

            migrationBuilder.UpdateData(
                table: "Konsultimet",
                keyColumn: "Kid",
                keyValue: 1,
                column: "KLid",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Konsultimet",
                keyColumn: "Kid",
                keyValue: 2,
                column: "KLid",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Konsultimet",
                keyColumn: "Kid",
                keyValue: 3,
                column: "KLid",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Konsultimet",
                keyColumn: "Kid",
                keyValue: 4,
                column: "KLid",
                value: 0);
        }
    }
}
