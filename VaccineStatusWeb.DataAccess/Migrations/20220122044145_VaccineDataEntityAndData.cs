using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class VaccineDataEntityAndData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "MedicalInstitutes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VaccineDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccineBatch = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaccineCentre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineDatas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "VaccineDataId" },
                values: new object[] { "PumbahinnaHospital - DB", 1 });

            migrationBuilder.InsertData(
                table: "MedicalInstitutes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "Description", "IsActive", "IsDelete", "LastModifiedBy", "LastModifiedOn", "Name", "OfficialContactNumber", "OfficialContactPerson", "Status", "UserId", "UserName", "VaccineDataId" },
                values: new object[,]
                {
                    { 2, "Doily", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "LocatedInAnuradhapura", false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AnuradhapuraHospital", 0, null, null, 0, null, 1 },
                    { 3, "John", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "LocatedInBadulla", false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BadullaHospital", 0, null, null, 0, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "VaccineDatas",
                columns: new[] { "Id", "Date", "UserId", "UserName", "VaccineBatch", "VaccineCentre" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Dorin", 0, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Shara", 0, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Tom", 0, null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Sana", 0, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VaccineDatas");

            migrationBuilder.DeleteData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "MedicalInstitutes");

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "VaccineDataId" },
                values: new object[] { "PumbahinnaHospital -DB", 0 });
        }
    }
}
