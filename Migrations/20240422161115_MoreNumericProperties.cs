﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllPropertiesApp.Migrations
{
    /// <inheritdoc />
    public partial class MoreNumericProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "BigValue",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Value",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BigValue",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "Users");
        }
    }
}
