using Microsoft.EntityFrameworkCore.Migrations;

namespace stockInfoASPClient.Data.Migrations
{
    public partial class a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "occurence",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_occurence", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "seekFor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seekFor", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "60561504-8a61-4629-846a-615158c863a7", "8ecf4737-d09f-4441-8ff4-1a961d3a020c", "Oglądacz", "OGLĄDACZ" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed8453d2-6741-4ca1-9ea0-24ac57616609", "01fe8b6e-7c40-4c2c-be73-03d9b69acc33", "Użytkownik", "UŻYTKOWNIK" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "af984781-2599-40ad-865a-657a3973f296", "3d0116e0-0c4e-4bde-b43a-5fdc29a8ccee", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "occurence");

            migrationBuilder.DropTable(
                name: "seekFor");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60561504-8a61-4629-846a-615158c863a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af984781-2599-40ad-865a-657a3973f296");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed8453d2-6741-4ca1-9ea0-24ac57616609");
        }
    }
}
