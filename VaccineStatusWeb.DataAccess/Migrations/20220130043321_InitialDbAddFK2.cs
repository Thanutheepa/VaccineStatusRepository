using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDbAddFK2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1195), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1192), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1201), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1204), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1203), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1218), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1217), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1222), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1221), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1224), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1224), new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 1,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 2,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 3,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "VaccinatedDate", "VaccineId" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1274), 3 });

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDoses_VaccineId",
                table: "VaccineDoses",
                column: "VaccineId");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDoses_Vaccines_VaccineId",
                table: "VaccineDoses",
                column: "VaccineId",
                principalTable: "Vaccines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDoses_Vaccines_VaccineId",
                table: "VaccineDoses");

            migrationBuilder.DropIndex(
                name: "IX_VaccineDoses_VaccineId",
                table: "VaccineDoses");

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7209), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7205), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7213), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7212), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7216), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7215), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7231), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7234), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7233), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7237), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7236), new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 1,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 2,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 3,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "VaccinatedDate", "VaccineId" },
                values: new object[] { new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7281), 4 });
        }
    }
}
