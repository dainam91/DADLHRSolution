using Microsoft.EntityFrameworkCore.Migrations;

namespace DADLHRSolution.Data.Migrations
{
    public partial class Migration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Tests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Tests");
        }
    }
}
