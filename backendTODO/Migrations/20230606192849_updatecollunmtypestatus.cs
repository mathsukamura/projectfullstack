using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backendTODO.Migrations
{
    /// <inheritdoc />
    public partial class updatecollunmtypestatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "tb_todo",
                type: "varchar(24)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "tb_todo",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(24)");
        }
    }
}
