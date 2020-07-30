using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleComent.Data.Migrations
{
    public partial class includedUserInComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Comments");
        }
    }
}
