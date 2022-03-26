using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceMVC.Data.Migrations
{
    public partial class colorSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_ImageGalleries_ImageGalleryId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "ImageGalleries");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "ImageGalleryId",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "ProductVariants");

            migrationBuilder.RenameColumn(
                name: "ImageGalleryId",
                table: "Images",
                newName: "ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ImageGalleryId",
                table: "Images",
                newName: "IX_Images_ProductVariantId");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ProductVariants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "ProductVariants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hexVal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    decimalVal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ColorId",
                table: "ProductVariants",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_SizeId",
                table: "ProductVariants",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ProductVariants_ProductVariantId",
                table: "Images",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "ProductVariantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Colors_ColorId",
                table: "ProductVariants",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Sizes_SizeId",
                table: "ProductVariants",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "SizeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_ProductVariants_ProductVariantId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Colors_ColorId",
                table: "ProductVariants");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Sizes_SizeId",
                table: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariants_ColorId",
                table: "ProductVariants");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariants_SizeId",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "ProductVariants");

            migrationBuilder.RenameColumn(
                name: "ProductVariantId",
                table: "Images",
                newName: "ImageGalleryId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ProductVariantId",
                table: "Images",
                newName: "IX_Images_ImageGalleryId");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "ProductVariants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageGalleryId",
                table: "ProductVariants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "ProductVariants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ImageGalleries",
                columns: table => new
                {
                    ImageGalleryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGalleries", x => x.ImageGalleryId);
                    table.ForeignKey(
                        name: "FK_ImageGalleries_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "ProductVariantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageGalleries_ProductVariantId",
                table: "ImageGalleries",
                column: "ProductVariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ImageGalleries_ImageGalleryId",
                table: "Images",
                column: "ImageGalleryId",
                principalTable: "ImageGalleries",
                principalColumn: "ImageGalleryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
