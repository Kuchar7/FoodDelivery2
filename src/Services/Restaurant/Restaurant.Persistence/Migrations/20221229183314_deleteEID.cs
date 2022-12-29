using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Persistence.Migrations
{
    public partial class deleteEID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "DishTypes");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "CuisineTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ExternalId",
                table: "Restaurants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ExternalId",
                table: "DishTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ExternalId",
                table: "Dishes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ExternalId",
                table: "CuisineTypes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "CuisineTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExternalId",
                value: new Guid("faa62a6c-4359-49cc-86ac-db63003c0e01"));

            migrationBuilder.UpdateData(
                table: "CuisineTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExternalId",
                value: new Guid("ffa5ccd3-b9a8-435a-9ea9-5512a7fb2944"));

            migrationBuilder.UpdateData(
                table: "CuisineTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExternalId",
                value: new Guid("6463af4a-a7c7-4f8d-ba9c-9a571368a2bf"));

            migrationBuilder.UpdateData(
                table: "CuisineTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExternalId",
                value: new Guid("d65e672e-10c3-45d1-b59a-aa03cf8914fd"));

            migrationBuilder.UpdateData(
                table: "CuisineTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "ExternalId",
                value: new Guid("cbabaadc-530d-40a9-8773-171ff916f976"));

            migrationBuilder.UpdateData(
                table: "CuisineTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "ExternalId",
                value: new Guid("7be6888e-7436-4e22-aec4-556170a7895d"));

            migrationBuilder.UpdateData(
                table: "CuisineTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "ExternalId",
                value: new Guid("5d1369e9-ff12-4591-b656-21ec9bcfdc03"));

            migrationBuilder.UpdateData(
                table: "CuisineTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "ExternalId",
                value: new Guid("26ce796a-2824-4c3c-8725-3081385424fb"));

            migrationBuilder.UpdateData(
                table: "CuisineTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ExternalId",
                value: new Guid("6df47f57-7dcd-4053-98ad-9b123fe7d569"));

            migrationBuilder.UpdateData(
                table: "DishTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExternalId",
                value: new Guid("b8d310a2-44c5-4aa6-baf6-fe9934f17e35"));

            migrationBuilder.UpdateData(
                table: "DishTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExternalId",
                value: new Guid("5559f3b0-b1b3-445e-8e96-e36b8e2e22a0"));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExternalId",
                value: new Guid("86eca508-742b-4139-af72-ea21a2f9050d"));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExternalId",
                value: new Guid("60eac82b-3eee-4f11-b755-0a1678c80db8"));
        }
    }
}
