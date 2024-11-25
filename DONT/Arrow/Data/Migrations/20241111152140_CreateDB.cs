using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arrow.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name1",
                table: "Genre",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GenreList1",
                table: "Author",
                newName: "GenreList");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genre",
                newName: "Name1");

            migrationBuilder.RenameColumn(
                name: "GenreList",
                table: "Author",
                newName: "GenreList1");
        }
    }
}
