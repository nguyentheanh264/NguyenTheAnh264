using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenTheAnh264.Migrations
{
    public partial class NTA0264 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTA0264",
                columns: table => new
                {
                    NTAId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NTAName = table.Column<string>(type: "TEXT", nullable: true),
                    NTAGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTA0264", x => x.NTAId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTA0264");
        }
    }
}
