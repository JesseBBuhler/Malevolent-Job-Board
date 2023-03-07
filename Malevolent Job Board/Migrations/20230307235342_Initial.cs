using Microsoft.EntityFrameworkCore.Migrations;

namespace Malevolent_Job_Board.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PositionTypes",
                columns: table => new
                {
                    PositionTypeID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PositionTypeDesc = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionTypes", x => x.PositionTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PositionTitle = table.Column<string>(nullable: false),
                    Company = table.Column<string>(nullable: false),
                    PositionTypeID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Posts_PositionTypes_PositionTypeID",
                        column: x => x.PositionTypeID,
                        principalTable: "PositionTypes",
                        principalColumn: "PositionTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PostID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Resume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_Applications_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PositionTypes",
                columns: new[] { "PositionTypeID", "PositionTypeDesc" },
                values: new object[] { 1, "Full Time" });

            migrationBuilder.InsertData(
                table: "PositionTypes",
                columns: new[] { "PositionTypeID", "PositionTypeDesc" },
                values: new object[] { 2, "Part Time" });

            migrationBuilder.InsertData(
                table: "PositionTypes",
                columns: new[] { "PositionTypeID", "PositionTypeDesc" },
                values: new object[] { 3, "Internship" });

            migrationBuilder.InsertData(
                table: "PositionTypes",
                columns: new[] { "PositionTypeID", "PositionTypeDesc" },
                values: new object[] { 4, "Contract" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostID", "Company", "Description", "PositionTitle", "PositionTypeID", "Salary" },
                values: new object[] { 1, "Mordor", "Sauron is in need of a right hand man to send after the plucky band of adventurers so that he doesn't have to go himself and blow the powerscale way out of balance.  It is imperative that a successful applicant have a tragic backstory that will make them sympathetic to the audience before their inevitable redemption arc.", "Treacherous Second In Command", 1, 150000 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostID", "Company", "Description", "PositionTitle", "PositionTypeID", "Salary" },
                values: new object[] { 3, "The Unspeakable Void", "The Great Old One is looking for an intern to summon him from the beyond, perform ritual sacrifices, torment the local moody doctor, and other tasks that he just can't be bothered to do himself.  This is an unpaid internship but applicants will be given the opportunity to learn dark secrets not fit for the mind of man.", "Cthulhu's gopher", 3, 0 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostID", "Company", "Description", "PositionTitle", "PositionTypeID", "Salary" },
                values: new object[] { 2, "The Galactic Empire", "I need someone to find and kill Luke before the Emperor finds out that he may or may not actually be dead.", "Bounty Hunter", 4, 50000 });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_PostID",
                table: "Applications",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PositionTypeID",
                table: "Posts",
                column: "PositionTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "PositionTypes");
        }
    }
}
