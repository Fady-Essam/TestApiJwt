using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApiJwt.Migrations;
public partial class SeedData : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
            table: "AspNetRoles",
            columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
            values: new Object[] { Guid.NewGuid().ToString(), "Admin", "ADMIN", Guid.NewGuid().ToString() }
        );
        migrationBuilder.InsertData(
            table: "AspNetRoles",
            columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
            values: new Object[] { Guid.NewGuid().ToString(), "User", "USER", Guid.NewGuid().ToString() }
        );
    }
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELETE FROM [AspNetRoles]");
    }
}