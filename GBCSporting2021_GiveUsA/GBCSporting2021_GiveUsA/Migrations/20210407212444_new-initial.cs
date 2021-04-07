using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021_GiveUsA.Migrations
{
    public partial class newinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "Incidents",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 4, 7, 17, 24, 43, 702, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 4, 7, 17, 24, 43, 702, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2021, 4, 7, 17, 24, 43, 702, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 7, 17, 24, 43, 697, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 7, 17, 24, 43, 701, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 7, 17, 24, 43, 701, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "TechnicianId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "Incidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 3, 22, 15, 51, 7, 934, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 3, 22, 15, 51, 7, 934, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2021, 3, 22, 15, 51, 7, 934, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 22, 15, 51, 7, 932, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 22, 15, 51, 7, 933, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 3, 22, 15, 51, 7, 933, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "TechnicianId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
