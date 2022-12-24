using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace Baham.DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addlocationtownshipstore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreAddress_Stores_storeId",
                table: "StoreAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreAddress_Townships_TownshipId",
                table: "StoreAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreAddress",
                table: "StoreAddress");

            migrationBuilder.RenameTable(
                name: "StoreAddress",
                newName: "StoreAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_StoreAddress_TownshipId",
                table: "StoreAddresses",
                newName: "IX_StoreAddresses_TownshipId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreAddress_storeId",
                table: "StoreAddresses",
                newName: "IX_StoreAddresses_storeId");

            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.AddColumn<Point>(
                name: "Location",
                table: "Townships",
                type: "geometry",
                nullable: true);

            migrationBuilder.AddColumn<Point>(
                name: "Location",
                table: "StoreAddresses",
                type: "geometry",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreAddresses",
                table: "StoreAddresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreAddresses_Stores_storeId",
                table: "StoreAddresses",
                column: "storeId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreAddresses_Townships_TownshipId",
                table: "StoreAddresses",
                column: "TownshipId",
                principalTable: "Townships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StoreAddresses_Stores_storeId",
                table: "StoreAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreAddresses_Townships_TownshipId",
                table: "StoreAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StoreAddresses",
                table: "StoreAddresses");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Townships");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "StoreAddresses");

            migrationBuilder.RenameTable(
                name: "StoreAddresses",
                newName: "StoreAddress");

            migrationBuilder.RenameIndex(
                name: "IX_StoreAddresses_TownshipId",
                table: "StoreAddress",
                newName: "IX_StoreAddress_TownshipId");

            migrationBuilder.RenameIndex(
                name: "IX_StoreAddresses_storeId",
                table: "StoreAddress",
                newName: "IX_StoreAddress_storeId");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StoreAddress",
                table: "StoreAddress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StoreAddress_Stores_storeId",
                table: "StoreAddress",
                column: "storeId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreAddress_Townships_TownshipId",
                table: "StoreAddress",
                column: "TownshipId",
                principalTable: "Townships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
