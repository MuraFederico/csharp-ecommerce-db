using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_ecommerce_db.Migrations
{
    public partial class Pivot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_order_OrdersForProductId",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_product_OrderedProductsId",
                table: "OrderProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_OrdersForProductId",
                table: "OrderProduct");

            migrationBuilder.RenameColumn(
                name: "OrdersForProductId",
                table: "OrderProduct",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "OrderedProductsId",
                table: "OrderProduct",
                newName: "ProductId");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "OrderProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "order",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct",
                columns: new[] { "OrderId", "ProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_order_OrderId",
                table: "OrderProduct",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_product_ProductId",
                table: "OrderProduct",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_order_OrderId",
                table: "OrderProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_product_ProductId",
                table: "OrderProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct");

            migrationBuilder.DropIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderProduct");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderProduct",
                newName: "OrdersForProductId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderProduct",
                newName: "OrderedProductsId");

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "order",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProduct",
                table: "OrderProduct",
                columns: new[] { "OrderedProductsId", "OrdersForProductId" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrdersForProductId",
                table: "OrderProduct",
                column: "OrdersForProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_order_OrdersForProductId",
                table: "OrderProduct",
                column: "OrdersForProductId",
                principalTable: "order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_product_OrderedProductsId",
                table: "OrderProduct",
                column: "OrderedProductsId",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
