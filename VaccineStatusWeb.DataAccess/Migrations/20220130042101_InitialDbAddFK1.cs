using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDbAddFK1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "VaccineBatches",
                keyColumn: "Id",
                keyValue: 3,
                column: "VaccineId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "VaccineBatches",
                keyColumn: "Id",
                keyValue: 4,
                column: "VaccineId",
                value: 3);

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
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 9, 51, 0, 782, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.CreateIndex(
                name: "IX_VaccineBatches_VaccineId",
                table: "VaccineBatches",
                column: "VaccineId");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineBatches_Vaccines_VaccineId",
                table: "VaccineBatches",
                column: "VaccineId",
                principalTable: "Vaccines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaccineBatches_Vaccines_VaccineId",
                table: "VaccineBatches");

            migrationBuilder.DropIndex(
                name: "IX_VaccineBatches_VaccineId",
                table: "VaccineBatches");

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
                table: "VaccineBatches",
                keyColumn: "Id",
                keyValue: 3,
                column: "VaccineId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "VaccineBatches",
                keyColumn: "Id",
                keyValue: 4,
                column: "VaccineId",
                value: 4);

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
    }
}
