using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuisineTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ExternalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuisineTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DishTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ExternalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ExternalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DishTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    ExternalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dishes_DishTypes_DishTypeId",
                        column: x => x.DishTypeId,
                        principalTable: "DishTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dishes_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantCuisineTypes",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    CuisineTypeId = table.Column<int>(type: "int", nullable: false),
                    CuisineTypeEntityId = table.Column<int>(type: "int", nullable: true),
                    RestaurantEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantCuisineTypes", x => new { x.RestaurantId, x.CuisineTypeId });
                    table.ForeignKey(
                        name: "FK_RestaurantCuisineTypes_CuisineTypes_CuisineTypeEntityId",
                        column: x => x.CuisineTypeEntityId,
                        principalTable: "CuisineTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RestaurantCuisineTypes_Restaurants_RestaurantEntityId",
                        column: x => x.RestaurantEntityId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CuisineTypes",
                columns: new[] { "Id", "DateCreated", "ExternalId", "LastDateModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("faa62a6c-4359-49cc-86ac-db63003c0e01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polish" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffa5ccd3-b9a8-435a-9ea9-5512a7fb2944"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indian" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6463af4a-a7c7-4f8d-ba9c-9a571368a2bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d65e672e-10c3-45d1-b59a-aa03cf8914fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thai" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cbabaadc-530d-40a9-8773-171ff916f976"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Turkish" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7be6888e-7436-4e22-aec4-556170a7895d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Georgian" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5d1369e9-ff12-4591-b656-21ec9bcfdc03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Czech" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("26ce796a-2824-4c3c-8725-3081385424fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "French" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6df47f57-7dcd-4053-98ad-9b123fe7d569"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mexican" }
                });

            migrationBuilder.InsertData(
                table: "DishTypes",
                columns: new[] { "Id", "DateCreated", "ExternalId", "LastDateModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8d310a2-44c5-4aa6-baf6-fe9934f17e35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kebab" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5559f3b0-b1b3-445e-8e96-e36b8e2e22a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pizza" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantCuisineTypes",
                columns: new[] { "CuisineTypeId", "RestaurantId", "CuisineTypeEntityId", "RestaurantEntityId" },
                values: new object[] { 2, 1, null, null });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "City", "DateCreated", "Description", "ExternalId", "HouseNumber", "LastDateModified", "Name", "PostalCode", "Province", "Street" },
                values: new object[] { 1, "Warszawa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", new Guid("60eac82b-3eee-4f11-b755-0a1678c80db8"), "22", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super Pizzeria", "00-006", "mazowieckie", "Piękna" });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "DateCreated", "Description", "DishTypeId", "ExternalId", "LastDateModified", "Name", "Price", "RestaurantId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Description", 2, new Guid("86eca508-742b-4139-af72-ea21a2f9050d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Big Pepperoni", 40.9m, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_CuisineTypes_Name",
                table: "CuisineTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_DishTypeId",
                table: "Dishes",
                column: "DishTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_RestaurantId",
                table: "Dishes",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_DishTypes_Name",
                table: "DishTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCuisineTypes_CuisineTypeEntityId",
                table: "RestaurantCuisineTypes",
                column: "CuisineTypeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantCuisineTypes_RestaurantEntityId",
                table: "RestaurantCuisineTypes",
                column: "RestaurantEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "RestaurantCuisineTypes");

            migrationBuilder.DropTable(
                name: "DishTypes");

            migrationBuilder.DropTable(
                name: "CuisineTypes");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
