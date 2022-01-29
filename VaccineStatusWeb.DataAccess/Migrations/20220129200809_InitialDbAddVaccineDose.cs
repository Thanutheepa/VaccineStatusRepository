using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDbAddVaccineDose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VaccineDoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineId = table.Column<int>(type: "int", nullable: false),
                    RequiredCount = table.Column<int>(type: "int", nullable: false),
                    VaccinatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HealthWorker = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineDoses", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "VaccineDoses",
                columns: new[] { "Id", "HealthWorker", "RequiredCount", "VaccinatedDate", "VaccineId" },
                values: new object[,]
                {
                    { 1, "Designated vaccinator by MOH approved vaccination site", 0, new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5929), 1 },
                    { 2, "Designated vaccinator by MOH approved vaccination site", 1, new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5931), 2 },
                    { 3, "Designated vaccinator by MOH approved vaccination site", 2, new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5933), 3 },
                    { 4, "Designated vaccinator by MOH approved vaccination site", 3, new DateTime(2022, 1, 30, 1, 38, 8, 670, DateTimeKind.Local).AddTicks(5934), 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VaccineDoses");

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
    }
}
