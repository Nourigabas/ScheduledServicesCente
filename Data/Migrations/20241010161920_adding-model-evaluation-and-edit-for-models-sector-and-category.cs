using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addingmodelevaluationandeditformodelssectorandcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "Services");

            migrationBuilder.AddColumn<Guid>(
                name: "EvaluationId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsOwner",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerServiceId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlSectorIcon",
                table: "Sectors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "EvaluationAverage",
                table: "OwnerServices",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "OwnerServices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "CategoryServices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UrlCategoryserviceIcon",
                table: "CategoryServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Evaluation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EvaluationValue = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evaluation_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("e99f4b48-f6c5-4c0b-91a5-a2d6f7e7c392"),
                column: "UrlSectorIcon",
                value: "www");

            migrationBuilder.CreateIndex(
                name: "IX_Users_EvaluationId",
                table: "Users",
                column: "EvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerServices_UserId",
                table: "OwnerServices",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_ServiceId",
                table: "Evaluation",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerServices_Users_UserId",
                table: "OwnerServices",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Evaluation_EvaluationId",
                table: "Users",
                column: "EvaluationId",
                principalTable: "Evaluation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerServices_Users_UserId",
                table: "OwnerServices");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Evaluation_EvaluationId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Evaluation");

            migrationBuilder.DropIndex(
                name: "IX_Users_EvaluationId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_OwnerServices_UserId",
                table: "OwnerServices");

            migrationBuilder.DropColumn(
                name: "EvaluationId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsOwner",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OwnerServiceId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UrlSectorIcon",
                table: "Sectors");

            migrationBuilder.DropColumn(
                name: "EvaluationAverage",
                table: "OwnerServices");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OwnerServices");

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "CategoryServices");

            migrationBuilder.DropColumn(
                name: "UrlCategoryserviceIcon",
                table: "CategoryServices");

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "Services",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
