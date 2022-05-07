using Microsoft.EntityFrameworkCore.Migrations;

namespace zemzem.Migrations
{
    public partial class categoryChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryDescription",
                table: "TbCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryImage",
                table: "TbCategory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryTitle",
                table: "TbCategory",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryDescription",
                table: "TbCategory");

            migrationBuilder.DropColumn(
                name: "CategoryImage",
                table: "TbCategory");

            migrationBuilder.DropColumn(
                name: "CategoryTitle",
                table: "TbCategory");
        }
    }
}
