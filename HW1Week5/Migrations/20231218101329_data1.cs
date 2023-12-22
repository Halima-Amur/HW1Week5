using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW1Week5.Migrations
{
    /// <inheritdoc />
    public partial class data1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_users_username1",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_username1",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "spaces");

            migrationBuilder.DropColumn(
                name: "username",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "username1",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "spaces",
                newName: "SpaceDay");

            migrationBuilder.RenameColumn(
                name: "ReservationDeatails",
                table: "Bookings",
                newName: "Name");

            migrationBuilder.AddColumn<DateOnly>(
                name: "SpaceDate",
                table: "spaces",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "SpaceTime",
                table: "spaces",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpaceDate",
                table: "spaces");

            migrationBuilder.DropColumn(
                name: "SpaceTime",
                table: "spaces");

            migrationBuilder.RenameColumn(
                name: "SpaceDay",
                table: "spaces",
                newName: "location");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Bookings",
                newName: "ReservationDeatails");

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "spaces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "username1",
                table: "Bookings",
                type: "nvarchar(15)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.username);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_username1",
                table: "Bookings",
                column: "username1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_users_username1",
                table: "Bookings",
                column: "username1",
                principalTable: "users",
                principalColumn: "username");
        }
    }
}
