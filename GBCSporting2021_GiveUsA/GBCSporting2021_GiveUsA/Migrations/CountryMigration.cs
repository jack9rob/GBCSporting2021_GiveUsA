using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Migrations
{
    public class Country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryId",
                table: "Countries",
                nullable: false,
                defaultValue: ""
                );

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.CountryId);
                }
            );
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                   {"CAD", "Canada" },
                   {"USA", "United States of America" },
                   {"KOR", "Korea" },
                   {"Other", "Other"},
                   {"AUS", "Australia"},
                   {"MEX", "MEX"},
                   {"UK", "United Kingdom"}
                }
            );
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "CountryId",
                value: "CAD"
            );
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "CountryId",
                value: "KOR"
            );
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "CountryId",
                value: "MAX"
            );
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "CountryId",
                value: "OTHER"
            );
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "CountryId",
                value: "USA"
            );
            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Countries_CountryId",
                table: "Customers",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade
            );
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Countries_CountryId",
                table: "Countries"
            );
            migrationBuilder.DropTable(
                name: "Countries"
            );
            migrationBuilder.DropIndex(
                name: "IX_Customers_CountryId",
                table: "Customers"
            );
            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Countries"
            );
        }
        
    }
}
