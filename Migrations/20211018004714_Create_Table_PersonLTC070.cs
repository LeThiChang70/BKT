using Microsoft.EntityFrameworkCore.Migrations;

namespace LTC1070.Migrations
{
    public partial class Create_Table_PersonLTC070 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
