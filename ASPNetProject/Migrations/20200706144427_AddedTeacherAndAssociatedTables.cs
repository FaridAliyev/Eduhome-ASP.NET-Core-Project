using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNetProject.Migrations
{
    public partial class AddedTeacherAndAssociatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Bios",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degrees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Language = table.Column<int>(nullable: false),
                    TeamLeader = table.Column<int>(nullable: false),
                    Development = table.Column<int>(nullable: false),
                    Design = table.Column<int>(nullable: false),
                    Innovation = table.Column<int>(nullable: false),
                    Communication = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fullname = table.Column<string>(maxLength: 200, nullable: false),
                    Image = table.Column<string>(maxLength: 300, nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    FacultyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teachers_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherDegrees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeacherId = table.Column<int>(nullable: false),
                    DegreeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDegrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherDegrees_Degrees_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degrees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherDegrees_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherHobbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeacherId = table.Column<int>(nullable: false),
                    HobbieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherHobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherHobbies_Hobbies_HobbieId",
                        column: x => x.HobbieId,
                        principalTable: "Hobbies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherHobbies_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Qualification = table.Column<string>(maxLength: 200, nullable: false),
                    About = table.Column<string>(maxLength: 800, nullable: false),
                    ExperienceYear = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Phone = table.Column<string>(maxLength: 200, nullable: false),
                    Skype = table.Column<string>(maxLength: 200, nullable: true),
                    Facebook = table.Column<string>(maxLength: 200, nullable: true),
                    Pinterest = table.Column<string>(maxLength: 200, nullable: true),
                    Vimeo = table.Column<string>(maxLength: 200, nullable: true),
                    Twitter = table.Column<string>(maxLength: 200, nullable: true),
                    TeacherId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherInfos_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDegrees_DegreeId",
                table: "TeacherDegrees",
                column: "DegreeId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDegrees_TeacherId",
                table: "TeacherDegrees",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherHobbies_HobbieId",
                table: "TeacherHobbies",
                column: "HobbieId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherHobbies_TeacherId",
                table: "TeacherHobbies",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherInfos_TeacherId",
                table: "TeacherInfos",
                column: "TeacherId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_FacultyId",
                table: "Teachers",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SkillId",
                table: "Teachers",
                column: "SkillId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherDegrees");

            migrationBuilder.DropTable(
                name: "TeacherHobbies");

            migrationBuilder.DropTable(
                name: "TeacherInfos");

            migrationBuilder.DropTable(
                name: "Degrees");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Faculties");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Bios");
        }
    }
}
