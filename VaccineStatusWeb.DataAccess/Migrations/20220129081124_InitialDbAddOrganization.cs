using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    public partial class InitialDbAddOrganization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MedicalInstitutes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Organizations",
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
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Address", "ContactPerson", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "IsActive", "IsDelete", "LastModifiedBy", "LastModifiedOn", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "BaselStreet,Balangoda,Ratnapura", "Dr.Silva", "Adhil", new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(951), "none", new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(949), "Not deleted", true, false, "Not modified", new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(951), "Boston", 123456781 },
                    { 2, "LiyanegeStreet,Badulla", "Dr.Isuru", "Perera", new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(955), "none", new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(954), "Not deleted", true, false, "Not modified", new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(956), "Kiva", 123456754 },
                    { 3, "NamalStreet,Colombo", "Dr.Kaliyawansa", "Munasinghe", new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(958), "none", new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(958), "Not deleted", true, false, "Not modified", new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(959), "Goodwill", 123456783 }
                });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 29, 13, 41, 23, 701, DateTimeKind.Local).AddTicks(794));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MedicalInstitutes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5938), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5935), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5942), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5942), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "MedicalInstitutes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5946), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5945), new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5946) });

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "VaccineDatas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5833));
        }
    }
}
