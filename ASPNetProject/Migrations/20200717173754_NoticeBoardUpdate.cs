using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetProject.Migrations
{
    public partial class NoticeBoardUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostedBy",
                table: "NoticeBoards",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostedBy",
                table: "NoticeBoards");
        }
    }
}
