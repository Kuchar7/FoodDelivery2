using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Persistence.Migrations
{
    public partial class fix_RestaurantCuisineType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantCuisineTypes_CuisineTypes_CuisineTypeEntityId",
                table: "RestaurantCuisineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantCuisineTypes_Restaurants_RestaurantEntityId",
                table: "RestaurantCuisineTypes");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantCuisineTypes_CuisineTypeEntityId",
                table: "RestaurantCuisineTypes");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantCuisineTypes_RestaurantEntityId",
                table: "RestaurantCuisineTypes");

            migrationBuilder.DropColumn(
                name: "CuisineTypeEntityId",
                table: "RestaurantCuisineTypes");

            migrationBuilder.DropColumn(
                name: "RestaurantEntityId",
                table: "RestaurantCuisineTypes");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCuisineTypes_CuisineTypeId",
                table: "RestaurantCuisineTypes",
                column: "CuisineTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantCuisineTypes_CuisineTypes_CuisineTypeId",
                table: "RestaurantCuisineTypes",
                column: "CuisineTypeId",
                principalTable: "CuisineTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantCuisineTypes_Restaurants_RestaurantId",
                table: "RestaurantCuisineTypes",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantCuisineTypes_CuisineTypes_CuisineTypeId",
                table: "RestaurantCuisineTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantCuisineTypes_Restaurants_RestaurantId",
                table: "RestaurantCuisineTypes");

            migrationBuilder.DropIndex(
                name: "IX_RestaurantCuisineTypes_CuisineTypeId",
                table: "RestaurantCuisineTypes");

            migrationBuilder.AddColumn<int>(
                name: "CuisineTypeEntityId",
                table: "RestaurantCuisineTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantEntityId",
                table: "RestaurantCuisineTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCuisineTypes_CuisineTypeEntityId",
                table: "RestaurantCuisineTypes",
                column: "CuisineTypeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCuisineTypes_RestaurantEntityId",
                table: "RestaurantCuisineTypes",
                column: "RestaurantEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantCuisineTypes_CuisineTypes_CuisineTypeEntityId",
                table: "RestaurantCuisineTypes",
                column: "CuisineTypeEntityId",
                principalTable: "CuisineTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantCuisineTypes_Restaurants_RestaurantEntityId",
                table: "RestaurantCuisineTypes",
                column: "RestaurantEntityId",
                principalTable: "Restaurants",
                principalColumn: "Id");
        }
    }
}
