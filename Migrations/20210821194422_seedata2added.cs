using Microsoft.EntityFrameworkCore.Migrations;

namespace JNCollection.Website.Migrations
{
    public partial class seedata2added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 1,
                column: "ImageThumbanailUrl",
                value: "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 2,
                column: "ImageThumbanailUrl",
                value: "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 3,
                column: "ImageThumbanailUrl",
                value: "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 1,
                column: "ImageThumbanailUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 2,
                column: "ImageThumbanailUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 3,
                column: "ImageThumbanailUrl",
                value: "");
        }
    }
}
