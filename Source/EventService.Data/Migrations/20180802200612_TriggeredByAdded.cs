using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventService.Data.Migrations
{
    public partial class TriggeredByAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TriggeredBy",
                table: "Events",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TriggeredBy",
                table: "Events");
        }
    }
}
