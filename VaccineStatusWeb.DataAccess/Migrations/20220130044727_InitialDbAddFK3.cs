using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDbAddFK3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4787), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4784), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4791), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4790), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4794), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4794), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4808), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4807), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4812), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4811), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4814), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4814), new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "VaccineBatchId" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4670), 1 });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "VaccineBatchId" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4680), 1 });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "VaccineBatchId" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4681), 2 });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "VaccineBatchId" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4682), 3 });

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 1,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 2,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 3,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "VaccineDoses",
                keyColumn: "Id",
                keyValue: 4,
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 10, 17, 26, 558, DateTimeKind.Local).AddTicks(4857));

            migrationBuilder.CreateIndex(
                name: "IX_VaccineDatas_VaccineBatchId",
                table: "VaccineDatas",
                column: "VaccineBatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDatas_VaccineBatches_VaccineBatchId",
                table: "VaccineDatas",
                column: "VaccineBatchId",
                principalTable: "VaccineBatches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDatas_VaccineBatches_VaccineBatchId",
                table: "VaccineDatas");

            migrationBuilder.DropIndex(
                name: "IX_VaccineDatas_VaccineBatchId",
                table: "VaccineDatas");

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
                columns: new[] { "Date", "VaccineBatchId" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1053), 123 });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "VaccineBatchId" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1063), 466 });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "VaccineBatchId" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1065), 789 });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "VaccineBatchId" },
                values: new object[] { new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1095), 152 });

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
                column: "VaccinatedDate",
                value: new DateTime(2022, 1, 30, 10, 3, 20, 606, DateTimeKind.Local).AddTicks(1274));
        }
    }
}
