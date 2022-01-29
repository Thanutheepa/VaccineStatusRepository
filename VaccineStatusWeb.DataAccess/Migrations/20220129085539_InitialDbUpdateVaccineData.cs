using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDbUpdateVaccineData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VaccineCentre",
                table: "VaccineDatas");

            migrationBuilder.RenameColumn(
                name: "VaccineBatch",
                table: "VaccineDatas",
                newName: "VaccineCentreId");

            migrationBuilder.AddColumn<int>(
                name: "VaccineBatchId",
                table: "VaccineDatas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4380), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4379), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4382), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4396), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4395), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4399), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4403), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4402), new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "VaccineBatchId", "VaccineCentreId" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4270), 123, 12434 });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "VaccineBatchId", "VaccineCentreId" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4281), 466, 98765 });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "VaccineBatchId", "VaccineCentreId" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4282), 789, 98765 });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "VaccineBatchId", "VaccineCentreId" },
                values: new object[] { new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4283), 152, 98762 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VaccineBatchId",
                table: "VaccineDatas");

            migrationBuilder.RenameColumn(
                name: "VaccineCentreId",
                table: "VaccineDatas",
                newName: "VaccineBatch");

            migrationBuilder.AddColumn<string>(
                name: "VaccineCentre",
                table: "VaccineDatas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(919), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(917), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(920) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(930), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(929), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(934), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(933), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(951), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(949), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(955), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(954), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(958), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(958), new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "VaccineBatch", "VaccineCentre" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(781), 123, "SUSL-MC" });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "VaccineBatch", "VaccineCentre" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(792), 466, "Pambahinna" });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "VaccineBatch", "VaccineCentre" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(793), 789, "Balangoda" });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "VaccineBatch", "VaccineCentre" },
                values: new object[] { new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(794), 152, "Ratnapura" });
        }
    }
}
