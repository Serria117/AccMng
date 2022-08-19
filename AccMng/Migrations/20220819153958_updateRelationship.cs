using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccMng.Migrations
{
    public partial class updateRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Customers_TaxAuthorityId",
                table: "Customers",
                column: "TaxAuthorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_TaxAuthorities_TaxAuthorityId",
                table: "Customers",
                column: "TaxAuthorityId",
                principalTable: "TaxAuthorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_TaxAuthorities_TaxAuthorityId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_TaxAuthorityId",
                table: "Customers");
        }
    }
}
