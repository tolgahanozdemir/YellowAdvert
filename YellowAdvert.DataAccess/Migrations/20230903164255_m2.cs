using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YellowAdvert.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProductAttributesId",
                table: "CategoryAttributeValues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryAttributeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryAttributeValueId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomCategoryAttributeValue = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    LastUpdateUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdateDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAttributeValues_CategoryAttributeId",
                table: "CategoryAttributeValues",
                column: "CategoryAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAttributeValues_ProductAttributesId",
                table: "CategoryAttributeValues",
                column: "ProductAttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAttributes_CategoryId",
                table: "CategoryAttributes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductId",
                table: "ProductAttributes",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributes_Categories_CategoryId",
                table: "CategoryAttributes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributeValues_CategoryAttributes_CategoryAttributeId",
                table: "CategoryAttributeValues",
                column: "CategoryAttributeId",
                principalTable: "CategoryAttributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAttributeValues_ProductAttributes_ProductAttributesId",
                table: "CategoryAttributeValues",
                column: "ProductAttributesId",
                principalTable: "ProductAttributes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributes_Categories_CategoryId",
                table: "CategoryAttributes");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributeValues_CategoryAttributes_CategoryAttributeId",
                table: "CategoryAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAttributeValues_ProductAttributes_ProductAttributesId",
                table: "CategoryAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAttributeValues_CategoryAttributeId",
                table: "CategoryAttributeValues");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAttributeValues_ProductAttributesId",
                table: "CategoryAttributeValues");

            migrationBuilder.DropIndex(
                name: "IX_CategoryAttributes_CategoryId",
                table: "CategoryAttributes");

            migrationBuilder.DropColumn(
                name: "ProductAttributesId",
                table: "CategoryAttributeValues");
        }
    }
}
