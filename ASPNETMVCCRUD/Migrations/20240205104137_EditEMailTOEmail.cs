using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNETMVCCRUD.Migrations
{
    /// <inheritdoc />
    public partial class EditEMailTOEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EMail",
                table: "Employees",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Employees",
                newName: "EMail");
        }
    }
}
