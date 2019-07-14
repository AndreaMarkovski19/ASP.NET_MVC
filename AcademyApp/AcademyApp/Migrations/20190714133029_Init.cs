using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AcademyApp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Academy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    EstimatedTime = table.Column<int>(nullable: false),
                    TimeSpent = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Academy", "Age", "FirstName", "LastName" },
                values: new object[] { 1, 1, 35, "Andrea", "Markovski" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Academy", "Age", "FirstName", "LastName" },
                values: new object[] { 2, 3, 22, "Martin", "Vitanov" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "EstimatedTime", "StudentId", "TimeSpent", "Title" },
                values: new object[,]
                {
                    { 1, 10, 1, 20, "Project_01" },
                    { 2, 8, 1, 4, "Project_02" },
                    { 3, 4, 1, 3, "Project_03" },
                    { 4, 4, 2, 3, "Project_04" },
                    { 5, 7, 2, 3, "Project_05" },
                    { 6, 54, 2, 12, "Project_06" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_StudentId",
                table: "Projects",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
