using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerServices_Users_UserId",
                table: "OwnerServices");

            migrationBuilder.DropIndex(
                name: "IX_OwnerServices_UserId",
                table: "OwnerServices");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "OwnerServices",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_OwnerServices_UserId",
                table: "OwnerServices",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerServices_Users_UserId",
                table: "OwnerServices",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerServices_Users_UserId",
                table: "OwnerServices");

            migrationBuilder.DropIndex(
                name: "IX_OwnerServices_UserId",
                table: "OwnerServices");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "OwnerServices",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OwnerServices_UserId",
                table: "OwnerServices",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerServices_Users_UserId",
                table: "OwnerServices",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
