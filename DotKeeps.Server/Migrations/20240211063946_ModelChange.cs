using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotKeeps.Server.Migrations
{
    /// <inheritdoc />
    public partial class ModelChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastUpdateDate",
                table: "KeepItems",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "KeepItems",
                newName: "CreatedAt");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "KeepItems",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Chapter",
                table: "KeepItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Episode",
                table: "KeepItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Season",
                table: "KeepItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "KeepItems",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Volume",
                table: "KeepItems",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chapter",
                table: "KeepItems");

            migrationBuilder.DropColumn(
                name: "Episode",
                table: "KeepItems");

            migrationBuilder.DropColumn(
                name: "Season",
                table: "KeepItems");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "KeepItems");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "KeepItems");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "KeepItems",
                newName: "LastUpdateDate");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "KeepItems",
                newName: "CreationDate");

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "KeepItems",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
