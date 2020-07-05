using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetProject.Migrations
{
    public partial class AddedBiosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Phone = table.Column<string>(maxLength: 50, nullable: true),
                    Logo = table.Column<string>(maxLength: 100, nullable: false),
                    Facebook = table.Column<string>(maxLength: 100, nullable: true),
                    Pinterest = table.Column<string>(maxLength: 100, nullable: true),
                    Vimeo = table.Column<string>(maxLength: 100, nullable: true),
                    Twitter = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bios");
        }
    }
}
