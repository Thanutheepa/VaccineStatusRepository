using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDbAddVaccine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vaccines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccines", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Vaccines",
                columns: new[] { "Id", "Country", "Type", "VaccineName" },
                values: new object[,]
                {
                    { 1, "China", "Inactivated", "Sinopharm BIBP" },
                    { 2, "Singapore", "TozinameranVaccineInjection", "Pfizer–BioNTech" },
                    { 3, "America", "mRNA", "Moderna" },
                    { 4, "Russia", "Viral vector", "Sputnik V" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vaccines");

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
                column: "Date",
                value: new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4270));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 29, 14, 25, 39, 499, DateTimeKind.Local).AddTicks(4283));
        }
    }
}
