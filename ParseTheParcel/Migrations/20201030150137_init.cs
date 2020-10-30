using Microsoft.EntityFrameworkCore.Migrations;

namespace ParseTheParcel.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "parseTheParcelRules",
                columns: table => new
                {
                    RuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleOrder = table.Column<int>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Breadth = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    RuleName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parseTheParcelRules", x => x.RuleID);
                });

            migrationBuilder.InsertData(
                table: "parseTheParcelRules",
                columns: new[] { "RuleID", "Breadth", "Height", "Length", "Price", "RuleName", "RuleOrder", "Weight" },
                values: new object[] { 1, 300, 150, 200, 5.0, "Small", 1, 25000 });

            migrationBuilder.InsertData(
                table: "parseTheParcelRules",
                columns: new[] { "RuleID", "Breadth", "Height", "Length", "Price", "RuleName", "RuleOrder", "Weight" },
                values: new object[] { 2, 400, 200, 300, 7.5, "Medium", 2, 25000 });

            migrationBuilder.InsertData(
                table: "parseTheParcelRules",
                columns: new[] { "RuleID", "Breadth", "Height", "Length", "Price", "RuleName", "RuleOrder", "Weight" },
                values: new object[] { 3, 600, 250, 400, 8.5, "Large", 3, 25000 });

            migrationBuilder.CreateIndex(
                name: "IX_parseTheParcelRules_RuleOrder",
                table: "parseTheParcelRules",
                column: "RuleOrder",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "parseTheParcelRules");
        }
    }
}
