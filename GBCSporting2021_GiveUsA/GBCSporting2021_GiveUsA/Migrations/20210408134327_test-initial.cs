using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021_GiveUsA.Migrations
{
    public partial class testinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 4, 8, 9, 43, 27, 500, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 4, 8, 9, 43, 27, 500, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "IncidentId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2021, 4, 8, 9, 43, 27, 500, DateTimeKind.Local).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 8, 9, 43, 27, 498, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 8, 9, 43, 27, 500, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 4, 8, 9, 43, 27, 500, DateTimeKind.Local).AddTicks(4203));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
