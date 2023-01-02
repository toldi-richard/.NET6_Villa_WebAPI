using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations;

public partial class AddForeignKeyToVillaTable : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "VillaID",
            table: "VillaNumbers",
            type: "int",
            nullable: false,
            defaultValue: 0);

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

        migrationBuilder.CreateIndex(
            name: "IX_VillaNumbers_VillaID",
            table: "VillaNumbers",
            column: "VillaID");

        migrationBuilder.AddForeignKey(
            name: "FK_VillaNumbers_Villas_VillaID",
            table: "VillaNumbers",
            column: "VillaID",
            principalTable: "Villas",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_VillaNumbers_Villas_VillaID",
            table: "VillaNumbers");

        migrationBuilder.DropIndex(
            name: "IX_VillaNumbers_VillaID",
            table: "VillaNumbers");

        migrationBuilder.DropColumn(
            name: "VillaID",
            table: "VillaNumbers");

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
}
