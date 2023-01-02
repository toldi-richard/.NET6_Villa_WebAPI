using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations;

public partial class addUsersToDB : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "LocalUsers",
            columns: table => new
            {
                Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_LocalUsers", x => x.Id);
            });

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 22, 8, 17, 49, 691, DateTimeKind.Local).AddTicks(9852));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 22, 8, 17, 49, 691, DateTimeKind.Local).AddTicks(9886));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 22, 8, 17, 49, 691, DateTimeKind.Local).AddTicks(9889));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 22, 8, 17, 49, 691, DateTimeKind.Local).AddTicks(9891));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 22, 8, 17, 49, 691, DateTimeKind.Local).AddTicks(9893));
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "LocalUsers");

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 1,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 21, 11, 36, 22, 683, DateTimeKind.Local).AddTicks(8501));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 2,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 21, 11, 36, 22, 683, DateTimeKind.Local).AddTicks(8546));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 3,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 21, 11, 36, 22, 683, DateTimeKind.Local).AddTicks(8548));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 4,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 21, 11, 36, 22, 683, DateTimeKind.Local).AddTicks(8550));

        migrationBuilder.UpdateData(
            table: "Villas",
            keyColumn: "Id",
            keyValue: 5,
            column: "CreatedDate",
            value: new DateTime(2022, 10, 21, 11, 36, 22, 683, DateTimeKind.Local).AddTicks(8553));
    }
}
