using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class addingusernameandpasswordtomodelOwnerservice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "OwnerServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "OwnerServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "Description", "IsDeleted" },
                values: new object[] { new Guid("e99f4b48-f6c5-4c0b-91a5-a2d6f7e7c392"), "Politics news in Syria", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sectors",
                keyColumn: "Id",
                keyValue: new Guid("e99f4b48-f6c5-4c0b-91a5-a2d6f7e7c392"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "OwnerServices");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "OwnerServices");
        }
    }
}