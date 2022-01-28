using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5938), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5935), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5942), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5942), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5946), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5945), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5833));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(254), new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(252), new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(260), new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(259), new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(263), new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(263), new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(20));
        }
    }
}
