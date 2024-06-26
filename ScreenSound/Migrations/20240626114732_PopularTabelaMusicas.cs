using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "Id", "AnoLancamento" }, new object[] { "É sal", 1, 2020});
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "Id", "AnoLancamento" }, new object[] { "Reflections", 2, 2018});
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "Id", "AnoLancamento" }, new object[] { "Borderline", 3, 2020});
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "Id", "AnoLancamento" }, new object[] { "One Of The Girls", 4, 2023});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MUSICAS");
        }
    }
}
