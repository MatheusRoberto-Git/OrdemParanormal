﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OP_RPG.Migrations
{
    /// <inheritdoc />
    public partial class HabClasseDesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HabilidadeClasseDesc",
                table: "Classes",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HabilidadeClasseDesc",
                table: "Classes");
        }
    }
}
