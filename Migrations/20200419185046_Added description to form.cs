using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject_StephenBrimer.Migrations
{
    public partial class Addeddescriptiontoform : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AddNote",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddNote",
                table: "Orders");
        }
    }
}
