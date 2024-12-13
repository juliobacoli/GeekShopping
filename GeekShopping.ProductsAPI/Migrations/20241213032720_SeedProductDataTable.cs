using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductsAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Id", "catergory_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 4L, "Smartphone", "Smartphone Description", "http://www.abc.com.br/image.jpg", "Smartphone", 1000m },
                    { 5L, "Smartphone", "Smartphone Description 2", "http://www.abc.com.br/image2.jpg", "Smartphone 2", 10.36m },
                    { 6L, "Smartphone", "Smartphone Description 3", "http://www.abc.com.br/image3.jpg", "Smartphone 3", 10.36m },
                    { 7L, "Smartphone", "Smartphone Description 4", "http://www.abc.com.br/image4.jpg", "Smartphone 4", 10.36m },
                    { 8L, "Smartphone", "Smartphone Description 5", "http://www.abc.com.br/image5.jpg", "Smartphone 5", 10.36m },
                    { 9L, "Smartphone", "Smartphone Description 6", "http://www.abc.com.br/image6.jpg", "Smartphone 6", 10.36m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 9L);
        }
    }
}
