using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cunsult.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class addDepartamentToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartamentID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartamentID",
                table: "AspNetUsers",
                column: "DepartamentID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departamentet_DepartamentID",
                table: "AspNetUsers",
                column: "DepartamentID",
                principalTable: "Departamentet",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departamentet_DepartamentID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DepartamentID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DepartamentID",
                table: "AspNetUsers");
        }
    }
}
