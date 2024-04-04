using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangedColumnsAndAddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Kittens");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Kittens",
                newName: "Breed");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Kittens",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Kittens");

            migrationBuilder.RenameColumn(
                name: "Breed",
                table: "Kittens",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Kittens",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
