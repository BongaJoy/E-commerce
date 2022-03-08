using Microsoft.EntityFrameworkCore.Migrations;

namespace JNCollection.Website.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Man wear", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Women wear", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Children wear", null });

            migrationBuilder.InsertData(
                table: "Clothes",
                columns: new[] { "ClotheId", "CategoryId", "ImageThumbanailUrl", "ImageUrl", "InStock", "IsClotheOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "", "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg", true, true, "Wear it with Love", "White-Tshirt", 12.95m, "Our Lovely T-shirt" },
                    { 4, 1, "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg", "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg", true, true, "Wear it with Love", "White-Tshirt", 12.95m, "Our Lovely T-shirt" },
                    { 2, 2, "", "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg", true, true, "Wear it with Love", "White-Tshirt", 12.95m, "Our Lovely T-shirt" },
                    { 5, 2, "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg", "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg", true, true, "Wear it with Love", "White-Tshirt", 12.95m, "Our Lovely T-shirt" },
                    { 3, 3, "", "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg", true, true, "Wear it with Love", "White-Tshirt", 12.95m, "Our Lovely T-shirt" },
                    { 6, 3, "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg", "https://cdn-images.farfetch-contents.com/14/37/02/55/14370255_23742822_1000.jpg", true, true, "Wear it with Love", "White-Tshirt", 12.95m, "Our Lovely T-shirt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clothes",
                keyColumn: "ClotheId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
