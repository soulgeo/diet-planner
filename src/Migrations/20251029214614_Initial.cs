using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DietPlanner.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    food_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Calories = table.Column<double>(type: "REAL", nullable: false),
                    Protein = table.Column<double>(type: "REAL", nullable: false),
                    Carbs = table.Column<double>(type: "REAL", nullable: false),
                    Fat = table.Column<double>(type: "REAL", nullable: false),
                    Allergen = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.food_id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    meal_id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    meal_type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.meal_id);
                });

            migrationBuilder.CreateTable(
                name: "Meal_Foods",
                columns: table => new
                {
                    meal_id = table.Column<int>(type: "INTEGER", nullable: false),
                    food_id = table.Column<int>(type: "INTEGER", nullable: false),
                    quantity_grams = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal_Foods", x => new { x.meal_id, x.food_id });
                    table.ForeignKey(
                        name: "FK_Meal_Foods_Foods_food_id",
                        column: x => x.food_id,
                        principalTable: "Foods",
                        principalColumn: "food_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meal_Foods_Meals_meal_id",
                        column: x => x.meal_id,
                        principalTable: "Meals",
                        principalColumn: "meal_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "food_id", "Allergen", "Calories", "Carbs", "Fat", "Name", "Protein" },
                values: new object[,]
                {
                    { 1, "None", 52.0, 14.0, 0.20000000000000001, "Μήλο", 0.29999999999999999 },
                    { 2, "None", 89.0, 23.0, 0.29999999999999999, "Μπανάνα", 1.1000000000000001 },
                    { 3, "None", 165.0, 0.0, 3.6000000000000001, "Στήθος Κοτόπουλο", 31.0 },
                    { 4, "Fish", 208.0, 0.0, 13.0, "Σολομός", 20.0 },
                    { 5, "None", 55.0, 11.0, 0.59999999999999998, "Μπρόκολο", 3.7000000000000002 },
                    { 6, "None", 111.0, 23.0, 0.90000000000000002, "Ρύζι καστανό", 2.6000000000000001 },
                    { 7, "Nuts", 579.0, 22.0, 49.0, "Αμύγδαλα", 21.0 },
                    { 8, "Dairy", 73.0, 3.6000000000000001, 2.0, "Γιαούρτι Στραγγιστό 2%", 10.0 },
                    { 9, "Egg", 155.0, 1.1000000000000001, 11.0, "Αυγό", 13.0 },
                    { 10, "None", 23.0, 3.6000000000000001, 0.40000000000000002, "Σπανάκι", 2.8999999999999999 },
                    { 11, "None", 86.0, 20.0, 0.10000000000000001, "Γλυκοπατάτα", 1.6000000000000001 },
                    { 12, "None", 884.0, 0.0, 100.0, "Ελαιόλαδο", 0.0 },
                    { 13, "Gluten", 389.0, 66.299999999999997, 6.9000000000000004, "Βρώμη", 16.899999999999999 },
                    { 14, "None", 116.0, 20.0, 0.40000000000000002, "Φακές", 9.0 },
                    { 15, "Fish", 132.0, 0.0, 1.3, "Τόνος σε νερό", 28.0 },
                    { 16, "None", 15.0, 3.6000000000000001, 0.10000000000000001, "Αγγούρι", 0.69999999999999996 },
                    { 17, "None", 18.0, 3.8999999999999999, 0.20000000000000001, "Ντομάτα", 0.90000000000000002 },
                    { 18, "None", 217.0, 0.0, 15.0, "Μοσχαρίσιος Κιμάς (90/10)", 19.0 },
                    { 19, "None", 120.0, 21.0, 1.8999999999999999, "Κινόα", 4.4000000000000004 },
                    { 20, "None", 32.0, 7.7000000000000002, 0.29999999999999999, "Φράουλες", 0.69999999999999996 },
                    { 21, "None", 160.0, 9.0, 15.0, "Αβοκάντο", 2.0 },
                    { 22, "Dairy", 98.0, 3.3999999999999999, 4.2999999999999998, "Τυρί Cottage", 11.0 },
                    { 23, "Gluten", 247.0, 41.0, 3.3999999999999999, "Ψωμί ολικής άλεσης", 13.0 },
                    { 24, "None", 135.0, 0.0, 1.0, "Γαλοπούλα βραστή", 29.0 },
                    { 25, "None", 164.0, 27.0, 2.6000000000000001, "Ρεβύθια", 8.9000000000000004 },
                    { 26, "None", 31.0, 6.0, 0.29999999999999999, "Πιπεριά Κόκκινη", 1.0 },
                    { 27, "None", 304.0, 82.0, 0.0, "Μέλι", 0.29999999999999999 },
                    { 28, "Nuts", 588.0, 20.0, 50.0, "Φυστικοβούτυρο", 25.0 },
                    { 29, "Dairy", 47.0, 5.0, 1.5, "Γάλα 1.5%", 3.3999999999999999 },
                    { 30, "None", 57.0, 14.0, 0.29999999999999999, "Μύρτιλα (Blueberries)", 0.69999999999999996 }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "meal_id", "meal_type", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Πρωινό με Βρώμη & Φρούτα" },
                    { 2, 2, "Μεσημεριανό με Κοτόπουλο & Κινόα" },
                    { 3, 4, "Βραδινό με Σολομό & Γλυκοπατάτα" },
                    { 4, 3, "Γιαούρτι με Μέλι & Ξηρούς Καρπούς" },
                    { 5, 0, "Ομελέτα με Σπανάκι" },
                    { 6, 2, "Σαλάτα με Τόνο" },
                    { 7, 1, "Τοστ με Γαλοπούλα & Αβοκάντο" },
                    { 8, 2, "Κιμάς με Ρύζι" },
                    { 9, 0, "Smoothie Πρωτεΐνης" },
                    { 10, 4, "Σαλάτα με Ρεβύθια" },
                    { 11, 3, "Cottage με Φράουλες" },
                    { 12, 2, "Φακές Σούπα" }
                });

            migrationBuilder.InsertData(
                table: "Meal_Foods",
                columns: new[] { "food_id", "meal_id", "quantity_grams" },
                values: new object[,]
                {
                    { 2, 1, 100.0 },
                    { 7, 1, 15.0 },
                    { 13, 1, 50.0 },
                    { 29, 1, 150.0 },
                    { 3, 2, 150.0 },
                    { 12, 2, 10.0 },
                    { 19, 2, 180.0 },
                    { 26, 2, 100.0 },
                    { 4, 3, 150.0 },
                    { 10, 3, 150.0 },
                    { 11, 3, 200.0 },
                    { 7, 4, 20.0 },
                    { 8, 4, 200.0 },
                    { 27, 4, 15.0 },
                    { 9, 5, 120.0 },
                    { 10, 5, 70.0 },
                    { 12, 5, 5.0 },
                    { 12, 6, 15.0 },
                    { 15, 6, 100.0 },
                    { 16, 6, 100.0 },
                    { 17, 6, 150.0 },
                    { 21, 7, 50.0 },
                    { 23, 7, 70.0 },
                    { 24, 7, 60.0 },
                    { 6, 8, 200.0 },
                    { 17, 8, 100.0 },
                    { 18, 8, 150.0 },
                    { 8, 9, 100.0 },
                    { 20, 9, 50.0 },
                    { 28, 9, 20.0 },
                    { 29, 9, 250.0 },
                    { 12, 10, 20.0 },
                    { 16, 10, 100.0 },
                    { 17, 10, 100.0 },
                    { 25, 10, 150.0 },
                    { 26, 10, 50.0 },
                    { 20, 11, 100.0 },
                    { 22, 11, 150.0 },
                    { 30, 11, 50.0 },
                    { 12, 12, 10.0 },
                    { 14, 12, 250.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meal_Foods_food_id",
                table: "Meal_Foods",
                column: "food_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meal_Foods");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");
        }
    }
}
