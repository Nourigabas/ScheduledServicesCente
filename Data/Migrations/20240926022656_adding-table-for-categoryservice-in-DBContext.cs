using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addingtableforcategoryserviceinDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryService_Sectors_SectorId",
                table: "CategoryService");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_CategoryService_CategoryServiceId",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryService",
                table: "CategoryService");

            migrationBuilder.RenameTable(
                name: "CategoryService",
                newName: "CategoryServices");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryService_SectorId",
                table: "CategoryServices",
                newName: "IX_CategoryServices_SectorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryServices",
                table: "CategoryServices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryServices_Sectors_SectorId",
                table: "CategoryServices",
                column: "SectorId",
                principalTable: "Sectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_CategoryServices_CategoryServiceId",
                table: "Services",
                column: "CategoryServiceId",
                principalTable: "CategoryServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryServices_Sectors_SectorId",
                table: "CategoryServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_CategoryServices_CategoryServiceId",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryServices",
                table: "CategoryServices");

            migrationBuilder.RenameTable(
                name: "CategoryServices",
                newName: "CategoryService");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryServices_SectorId",
                table: "CategoryService",
                newName: "IX_CategoryService_SectorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryService",
                table: "CategoryService",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryService_Sectors_SectorId",
                table: "CategoryService",
                column: "SectorId",
                principalTable: "Sectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_CategoryService_CategoryServiceId",
                table: "Services",
                column: "CategoryServiceId",
                principalTable: "CategoryService",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}