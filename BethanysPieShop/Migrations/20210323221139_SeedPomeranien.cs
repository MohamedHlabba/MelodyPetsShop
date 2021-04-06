using Microsoft.EntityFrameworkCore.Migrations;

namespace MelodysZooShop.Migrations
{
    public partial class SeedPomeranien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/0/04/Puppy_and_kitten_shop_%286969733332%29.jpg");

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsDogOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { 4, "", 2, "https://upload.wikimedia.org/wikipedia/commons/2/25/Pomeranian-tb2.jpg", "https://upload.wikimedia.org/wikipedia/commons/2/25/Pomeranian-tb2.jpg", true, false, "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.", "Pomeranien Dog", 15.95m, "A summer classic!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1,
                column: "ImageThumbnailUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/0/04/Puppy_and_kitten_shop_%286969733332%29.jp");
        }
    }
}
