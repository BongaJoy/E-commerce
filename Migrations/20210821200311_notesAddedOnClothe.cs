using Microsoft.EntityFrameworkCore.Migrations;

namespace JNCollection.Website.Migrations
{
    public partial class notesAddedOnClothe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Clothes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Clothes");
        }
    }
}
