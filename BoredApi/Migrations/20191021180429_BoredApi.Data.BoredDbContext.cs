using Microsoft.EntityFrameworkCore.Migrations;

namespace BoredApi.Migrations
{
    public partial class BoredApiDataBoredDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity = table.Column<string>(nullable: true),
                    Accessibility = table.Column<float>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Participants = table.Column<int>(nullable: false),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
