using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Message.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alıcı",
                table: "MessageBoxes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gonderen",
                table: "MessageBoxes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alıcı",
                table: "MessageBoxes");

            migrationBuilder.DropColumn(
                name: "Gonderen",
                table: "MessageBoxes");
        }
    }
}
