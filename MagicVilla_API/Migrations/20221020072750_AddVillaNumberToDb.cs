using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations;

public partial class AddVillaNumberToDb : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "VillaNumbers",
            columns: table => new
            {
                VillaNo = table.Column<int>(type: "int", nullable: false),
                SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
            });

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 20, 9, 27, 49, 995, DateTimeKind.Local).AddTicks(4336));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 20, 9, 27, 49, 995, DateTimeKind.Local).AddTicks(4372));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 20, 9, 27, 49, 995, DateTimeKind.Local).AddTicks(4375));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 20, 9, 27, 49, 995, DateTimeKind.Local).AddTicks(4377));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 20, 9, 27, 49, 995, DateTimeKind.Local).AddTicks(4380));
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "VillaNumbers");

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 17, 14, 46, 15, 868, DateTimeKind.Local).AddTicks(2293));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 17, 14, 46, 15, 868, DateTimeKind.Local).AddTicks(2327));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 17, 14, 46, 15, 868, DateTimeKind.Local).AddTicks(2329));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 17, 14, 46, 15, 868, DateTimeKind.Local).AddTicks(2332));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 17, 14, 46, 15, 868, DateTimeKind.Local).AddTicks(2334));
    }
}
