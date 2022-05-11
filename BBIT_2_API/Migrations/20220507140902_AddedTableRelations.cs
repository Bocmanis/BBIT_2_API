using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BBIT_2_API.Migrations
{
    public partial class AddedTableRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApartmentId1",
                table: "Residents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeId1",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Residents_ApartmentId",
                table: "Residents",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_ApartmentId1",
                table: "Residents",
                column: "ApartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_HomeId",
                table: "Apartments",
                column: "HomeId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_HomeId1",
                table: "Apartments",
                column: "HomeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Homes_HomeId",
                table: "Apartments",
                column: "HomeId",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Homes_HomeId1",
                table: "Apartments",
                column: "HomeId1",
                principalTable: "Homes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residents_Apartments_ApartmentId",
                table: "Residents",
                column: "ApartmentId",
                principalTable: "Apartments",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Homes_HomeId",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Homes_HomeId1",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Apartments_ApartmentId",
                table: "Residents");

            migrationBuilder.DropForeignKey(
                name: "FK_Residents_Apartments_ApartmentId1",
                table: "Residents");

            migrationBuilder.DropIndex(
                name: "IX_Residents_ApartmentId",
                table: "Residents");

            migrationBuilder.DropIndex(
                name: "IX_Residents_ApartmentId1",
                table: "Residents");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_HomeId",
                table: "Apartments");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_HomeId1",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "ApartmentId1",
                table: "Residents");

            migrationBuilder.DropColumn(
                name: "HomeId1",
                table: "Apartments");
        }
    }
}
