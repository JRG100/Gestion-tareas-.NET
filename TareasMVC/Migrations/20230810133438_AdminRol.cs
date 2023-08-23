using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
IF NOT EXISTS(Select Id from AspNetRoles where Id = 'e943e1da-8c4b-4540-aa8c-15cdfb2e6383')
BEGIN
INSERT AspNetRoles (Id, [Name], [NormalizedName])
VALUES ('e943e1da-8c4b-4540-aa8c-15cdfb2e6383', 'admin', 'ADMIN')
END
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id = 'e943e1da-8c4b-4540-aa8c-15cdfb2e6383'");
        }
    }
}
