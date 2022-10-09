using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class skyapp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Customer = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brand = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Model = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorOrInch = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PackageType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WashType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductDate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Deadline = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhotoPath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    s28 = table.Column<int>(type: "int", nullable: false),
                    s30 = table.Column<int>(type: "int", nullable: false),
                    s32 = table.Column<int>(type: "int", nullable: false),
                    s34 = table.Column<int>(type: "int", nullable: false),
                    s36 = table.Column<int>(type: "int", nullable: false),
                    s38 = table.Column<int>(type: "int", nullable: false),
                    s40 = table.Column<int>(type: "int", nullable: false),
                    s42 = table.Column<int>(type: "int", nullable: false),
                    s44 = table.Column<int>(type: "int", nullable: false),
                    s46 = table.Column<int>(type: "int", nullable: false),
                    s48 = table.Column<int>(type: "int", nullable: false),
                    s50 = table.Column<int>(type: "int", nullable: false),
                    sCount = table.Column<int>(type: "int", nullable: true),
                    k28 = table.Column<int>(type: "int", nullable: false),
                    k30 = table.Column<int>(type: "int", nullable: false),
                    k32 = table.Column<int>(type: "int", nullable: false),
                    k34 = table.Column<int>(type: "int", nullable: false),
                    k36 = table.Column<int>(type: "int", nullable: false),
                    k38 = table.Column<int>(type: "int", nullable: false),
                    k40 = table.Column<int>(type: "int", nullable: false),
                    k42 = table.Column<int>(type: "int", nullable: false),
                    k44 = table.Column<int>(type: "int", nullable: false),
                    k46 = table.Column<int>(type: "int", nullable: false),
                    k48 = table.Column<int>(type: "int", nullable: false),
                    k50 = table.Column<int>(type: "int", nullable: false),
                    kCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");
        }
    }
}
