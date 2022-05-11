using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBIT_2_API.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Homes_HomeId1",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Apartments_ApartmentId1",
                table: "Residents");

            migrationBuilder.RenameColumn(
                name: "ApartmentId1",
                table: "Residents",
                newName: "ApartmentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Residents_ApartmentId1",
                table: "Residents",
                newName: "IX_Residents_ApartmentsId");

            migrationBuilder.RenameColumn(
                name: "HomeId1",
                table: "Apartments",
                newName: "HomesId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_HomeId1",
                table: "Apartments",
                newName: "IX_Apartments_HomesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Homes_HomesId",
                table: "Apartments",
                column: "HomesId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Apartments_ApartmentsId",
                table: "Residents",
                column: "ApartmentsId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Homes_HomesId",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Apartments_ApartmentsId",
                table: "Residents");

            migrationBuilder.RenameColumn(
                name: "ApartmentsId",
                table: "Residents",
                newName: "ApartmentId1");

            migrationBuilder.RenameIndex(
                name: "IX_Residents_ApartmentsId",
                table: "Residents",
                newName: "IX_Residents_ApartmentId1");

            migrationBuilder.RenameColumn(
                name: "HomesId",
                table: "Apartments",
                newName: "HomeId1");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_HomesId",
                table: "Apartments",
                newName: "IX_Apartments_HomeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Homes_HomeId1",
                table: "Apartments",
                column: "HomeId1",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Apartments_ApartmentId1",
                table: "Residents",
                column: "ApartmentId1",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
