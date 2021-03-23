using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GBCSporting2021_GiveUsA.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    TechnicianId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.TechnicianId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Province = table.Column<string>(nullable: false),
                    Postalcode = table.Column<string>(nullable: false),
                    CountryId = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    IncidentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    DateOpened = table.Column<DateTime>(nullable: false),
                    DateClosed = table.Column<DateTime>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    TechnicianId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.IncidentId);
                    table.ForeignKey(
                        name: "FK_Incidents_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Technicians_TechnicianId",
                        column: x => x.TechnicianId,
                        principalTable: "Technicians",
                        principalColumn: "TechnicianId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    RegistrationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.RegistrationId);
                    table.ForeignKey(
                        name: "FK_Registrations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Registrations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { "CAD", "Canada" },
                    { "USA", "United States of America" },
                    { "KOR", "Korea" },
                    { "OTHER", "Other" },
                    { "AUS", "Australia" },
                    { "MEX", "Mexico" },
                    { "UK", "United Kingdom" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Code", "Name", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "MAC-AIR-M1", "Macbook Air M1", 1200.0, new DateTime(2021, 3, 22, 15, 51, 7, 932, DateTimeKind.Local).AddTicks(2997) },
                    { 2, "BLK-COF", "Black Coffee", 2.5, new DateTime(2021, 3, 22, 15, 51, 7, 933, DateTimeKind.Local).AddTicks(9675) },
                    { 3, "yoga-mat", "Yoga Mat", 10.0, new DateTime(2021, 3, 22, 15, 51, 7, 933, DateTimeKind.Local).AddTicks(9703) }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Yoon@email.com", "Alex Yoon", "647-347-3345" },
                    { 2, "doe@hotmail.com", "John Doe", "416-774-5412" },
                    { 3, "janster@gmail.com", "Jane Doe", "122-458-4775" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "City", "CountryId", "Email", "Firstname", "Lastname", "Phone", "Postalcode", "Province" },
                values: new object[,]
                {
                    { 1, "123 Home Drive", "Toronto", "CAD", "jack.robinson@gmail.com", "Jack", "Robinson", "123-456-7899", "M4B 1G5", "Ontario" },
                    { 8, "Bloor 87", "Toronto", "CAD", "afafa82@gmail.com", "Bruce", "Wayne", "416-123-4567", "M4A Y2Y", "Ontario" },
                    { 13, "Bont 81", "New York City", "USA", "payne12@gmail.com", "Payne", "Crue", "416-697-2145", "K9K H3M", "New York" },
                    { 15, "Sariro 52", "Seoul", "KOR", "afafa1234@gmail.com", "Youngil", "Kim", "647-689-5682", "213566", "Seoul" },
                    { 5, "Bont 81", "Tokyo", "OTHER", "kelly82@gmail.com", "Kelly", "Doll", "416-265-1478", "215368", "Tokyo-to" },
                    { 3, "123 Home Drive", "Toronto", "AUS", "jack.robinson@gmail.com", "Young-il", "Kim", "123-456-7899", "M4B 1G5", "Ontario" },
                    { 2, "123 Home Drive", "Toronto", "MEX", "fatih@gmail.com", "Fatih", "Com", "123-456-7899", "M4B 1G5", "Ontario" },
                    { 10, "Query 58", "Mexico City", "MEX", "hana25@gmail.com", "Haley", "Lee", "263-589-1254", "H3E Y2H", "State of Mexico" }
                });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "CustomerId", "DateClosed", "DateOpened", "Description", "ProductId", "TechnicianId", "Title" },
                values: new object[] { 1, 1, null, new DateTime(2021, 3, 22, 15, 51, 7, 934, DateTimeKind.Local).AddTicks(2842), "Alex smashed by macbook because he was too jealous", 1, 1, "Macbook broke" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "CustomerId", "DateClosed", "DateOpened", "Description", "ProductId", "TechnicianId", "Title" },
                values: new object[] { 3, 3, null, new DateTime(2021, 3, 22, 15, 51, 7, 934, DateTimeKind.Local).AddTicks(4033), "Wrong yoga mat was delivered to me", 3, 3, "Yoga mat is wrong colour" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "CustomerId", "DateClosed", "DateOpened", "Description", "ProductId", "TechnicianId", "Title" },
                values: new object[] { 2, 2, null, new DateTime(2021, 3, 22, 15, 51, 7, 934, DateTimeKind.Local).AddTicks(4001), "Coffee spilled all over me", 2, 3, "Coffe spill" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CountryId",
                table: "Customers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CustomerId",
                table: "Incidents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductId",
                table: "Incidents",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_TechnicianId",
                table: "Incidents",
                column: "TechnicianId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CustomerId",
                table: "Registrations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ProductId",
                table: "Registrations",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Registrations");

            migrationBuilder.DropTable(
                name: "Technicians");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
