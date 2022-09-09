using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DadJokes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Setup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Punchline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadJokes", x => x.Id);
                });

            //Seed some initial data. This not necessarily how you would want to do this, but we need something in the database to start.
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline", "Rating" }, new object[] { "What do you call a factory that makes okay products?", "A satisfactory.", 2 });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline" }, new[] { "Have you heard about the chocolate record player?", "It sounds pretty sweet." });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline" }, new[] { "What did the ocean say to the beach?", "Nothing, it just waved." });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline", "Rating" }, new object[] { "Why do seagulls fly over the ocean?", "Because if they flew over the bay, we'd call them bagels.", 5 });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline" }, new[] { "How does the moon cut his hair?", "Eclipse it." });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline" }, new[] { "What did the zero say to the eight?", "That belt looks good on you." });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline" }, new[] { "What did Baby Corn say to Mama Corn?", "Where's Pop Corn?" });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline", "Rating" }, new object[] { "What's the best thing about Switzerland?", "I don't know, but the flag is a big plus.", 4});
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline" }, new[] { "Where do you learn to make a banana split?", "Sundae school." });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline" }, new[] { "What do you call a poor Santa Claus?", "St. Nickel-less." });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline" }, new[] { "What do you call someone with no body and no nose?", "Nobody knows." });
            migrationBuilder.InsertData("DadJokes", new[] { "Setup", "Punchline" }, new[] { "What did one hat say to the other?", "Stay here! I'm going on ahead." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadJokes");
        }
    }
}
