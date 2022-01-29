using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDbAddVaccineDose1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4328), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4335), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4334), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4337), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4337), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4353), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4352), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4357), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4356), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4362), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4361), new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 1,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 2,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 3,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 4,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4440));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5828), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5825), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5837), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5836), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5841), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5859), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5858), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5866), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5864), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5871), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 1,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 2,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 3,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 4,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5934));
        }
    }
}
