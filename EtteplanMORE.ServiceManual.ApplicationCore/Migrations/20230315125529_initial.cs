using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EtteplanMORE.ServiceManual.ApplicationCore.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FactoryDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceYear = table.Column<int>(type: "int", nullable: false),
                    DeviceType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegisteredTimeTask = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscriptionTask = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeverityTask = table.Column<int>(type: "int", nullable: false),
                    StatusTask = table.Column<int>(type: "int", nullable: false),
                    FactoryDeviceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaintenanceTasks_FactoryDevices_FactoryDeviceId",
                        column: x => x.FactoryDeviceId,
                        principalTable: "FactoryDevices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceTasks_FactoryDeviceId",
                table: "MaintenanceTasks",
                column: "FactoryDeviceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaintenanceTasks");

            migrationBuilder.DropTable(
                name: "FactoryDevices");
        }
    }
}
