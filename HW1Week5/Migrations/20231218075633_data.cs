using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW1Week5.Migrations
{
    /// <inheritdoc />
    public partial class data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "spaces",
                columns: table => new
                {
                    SpaceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    AvaliableSpace = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spaces", x => x.SpaceID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDeatails = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BookingDate = table.Column<int>(type: "int", nullable: false),
                    BookingTime = table.Column<int>(type: "int", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpaceID = table.Column<int>(type: "int", nullable: true),
                    username1 = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Bookings_spaces_SpaceID",
                        column: x => x.SpaceID,
                        principalTable: "spaces",
                        principalColumn: "SpaceID");
                    table.ForeignKey(
                        name: "FK_Bookings_users_username1",
                        column: x => x.username1,
                        principalTable: "users",
                        principalColumn: "username");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SpaceID",
                table: "Bookings",
                column: "SpaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_username1",
                table: "Bookings",
                column: "username1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "spaces");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
