using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllPropertiesApp.Migrations
{
    /// <inheritdoc />
    public partial class MoreProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GenderChar",
                table: "Users",
                type: "char(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "EnergyConsumption",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<byte>(
                name: "HeightInCentimeters",
                table: "Users",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<float>(
                name: "HeightInMeters",
                table: "Users",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "TimeOfBirth",
                table: "Users",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<int>(
                name: "Years",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnergyConsumption",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HeightInCentimeters",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HeightInMeters",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TimeOfBirth",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Years",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "GenderChar",
                table: "Users",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(1)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)");
        }
    }
}
