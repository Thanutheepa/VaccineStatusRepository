using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VaccineDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaccineBatch = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VaccineCentre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicalInstitutes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OfficialContactNumber = table.Column<int>(type: "int", nullable: false),
                    OfficialContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    VaccineDataId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalInstitutes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalInstitutes_VaccineDatas_VaccineDataId",
                        column: x => x.VaccineDataId,
                        principalTable: "VaccineDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "VaccineDatas",
                columns: new[] { "Id", "Date", "UserId", "UserName", "VaccineBatch", "VaccineCentre" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(7), 1, "Dorin", 123, "SUSL-MC" },
                    { 2, new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(18), 2, "Shara", 466, "Pambahinna" },
                    { 3, new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(19), 4, "Tom", 789, "Balangoda" },
                    { 4, new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(20), 5, "Sana", 152, "Ratnapura" }
                });

            migrationBuilder.InsertData(
                table: "MedicalInstitutes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "Description", "IsActive", "IsDelete", "LastModifiedBy", "LastModifiedOn", "Name", "OfficialContactNumber", "OfficialContactPerson", "Status", "UserId", "UserName", "VaccineDataId" },
                values: new object[] { 1, "Adheera", new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(254), "none", new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(252), "Not deleted", "LocatedInRatnapura", true, false, "Not modified", new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(255), "PumbahinnaHospital - DB", 12345678, "Dr.Perera", 0, 0, "Dorin", 1 });

            migrationBuilder.InsertData(
                table: "MedicalInstitutes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "Description", "IsActive", "IsDelete", "LastModifiedBy", "LastModifiedOn", "Name", "OfficialContactNumber", "OfficialContactPerson", "Status", "UserId", "UserName", "VaccineDataId" },
                values: new object[] { 2, "Doily", new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(260), "none", new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(259), "Not deleted", "LocatedInAnuradhapura", true, false, "Not modified", new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(260), "AnuradhapuraHospital", 12345678, "Dr.Perera", 0, 0, "Dorin", 1 });

            migrationBuilder.InsertData(
                table: "MedicalInstitutes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "Description", "IsActive", "IsDelete", "LastModifiedBy", "LastModifiedOn", "Name", "OfficialContactNumber", "OfficialContactPerson", "Status", "UserId", "UserName", "VaccineDataId" },
                values: new object[] { 3, "John", new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(263), "none", new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(263), "Not deleted", "LocatedInBadulla", true, false, "Not modified", new DateTime(2022, 1, 28, 13, 59, 58, 585, DateTimeKind.Local).AddTicks(264), "BadullaHospital", 112258697, "Dr.Saman", 0, 0, "Shara", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalInstitutes_VaccineDataId",
                table: "MedicalInstitutes",
                column: "VaccineDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalInstitutes");

            migrationBuilder.DropTable(
                name: "VaccineDatas");
        }
    }
}
