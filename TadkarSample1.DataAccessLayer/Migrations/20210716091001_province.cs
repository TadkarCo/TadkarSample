using Microsoft.EntityFrameworkCore.Migrations;

namespace TadkarSample1.DataAccessLayer.Migrations
{
    public partial class province : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnel_Province_ProvinceId",
                table: "Personnel");

            migrationBuilder.DropIndex(
                name: "IX_Personnel_ProvinceId",
                table: "Personnel");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Personnel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Personnel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_ProvinceId",
                table: "Personnel",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnel_Province_ProvinceId",
                table: "Personnel",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
