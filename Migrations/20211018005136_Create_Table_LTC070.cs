using Microsoft.EntityFrameworkCore.Migrations;

namespace LTC1070.Migrations
{
    public partial class Create_Table_LTC070 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LTC070",
                columns: table => new
                {
                    LTCId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LTCName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LTC070", x => x.LTCId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LTC070");
        }
    }
}
