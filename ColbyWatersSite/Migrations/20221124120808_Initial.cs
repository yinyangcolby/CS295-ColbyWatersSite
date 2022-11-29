using Microsoft.EntityFrameworkCore.Migrations;

namespace ColbyWatersSite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Rating = table.Column<int>(maxLength: 2, nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "Comment", "Date", "Name", "Rating" },
                values: new object[] { 1, "testing testing...", "11/11/2022", "anonymous", 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
