using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backendTODO.Migrations
{
    /// <inheritdoc />
    public partial class updatenamecollunmnamedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "data_created",
                table: "tb_todo",
                newName: "created_at");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "tb_todo",
                newName: "data_created");
        }
    }
}
