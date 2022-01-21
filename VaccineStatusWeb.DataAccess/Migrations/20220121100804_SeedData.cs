using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MedicalInstitutes",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "Description", "IsActive", "IsDelete", "LastModifiedBy", "LastModifiedOn", "Name", "OfficialContactNumber", "OfficialContactPerson", "Status", "UserId", "VaccineDataId" },
                values: new object[] { 1, "Adheera", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "LocatedInRatnapura", false, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PumbahinnaHospital -DB", 0, null, null, 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
