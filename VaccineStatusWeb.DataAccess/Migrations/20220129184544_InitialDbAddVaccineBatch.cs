using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDbAddVaccineBatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VaccineBatches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaccineId = table.Column<int>(type: "int", nullable: false),
                    BatchNumber = table.Column<int>(type: "int", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineBatches", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7604), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7600), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7612), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7616), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7631), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7629), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7637), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7636), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.InsertData(
                table: "VaccineBatches",
                columns: new[] { "Id", "BatchNumber", "Manufacturer", "Name", "VaccineId" },
                values: new object[,]
                {
                    { 1, 456789, "Gamaleya Research", "FirstBatch", 1 },
                    { 2, 456733, "Charles Research", "SecondBatch", 2 },
                    { 3, 456789, " BIONTECH", "ThirdBatch", 3 },
                    { 4, 456321, "Beijing Institute", "ForthBatch", 4 }
                });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 30, 0, 15, 44, 344, DateTimeKind.Local).AddTicks(7505));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VaccineBatches");

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9133), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9130), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9138), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9138), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9141), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9141), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9157), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9156), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9161), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9050));
        }
    }
}
