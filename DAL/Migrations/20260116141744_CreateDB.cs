using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "tblMedicineCategories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMedicineCategories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "tblPatients",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPatients", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "tblRoles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "tblMedicines",
                columns: table => new
                {
                    MedicineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImportPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMedicines", x => x.MedicineID);
                    table.ForeignKey(
                        name: "FK_tblMedicines_tblMedicineCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "tblMedicineCategories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_tblUsers_tblRoles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "tblRoles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblMedicalRecords",
                columns: table => new
                {
                    RecordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    Symptoms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblMedicalRecords", x => x.RecordID);
                    table.ForeignKey(
                        name: "FK_tblMedicalRecords_tblPatients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "tblPatients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblMedicalRecords_tblUsers_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "tblUsers",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblPrescriptionDetails",
                columns: table => new
                {
                    DetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordID = table.Column<int>(type: "int", nullable: false),
                    MedicineID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Usage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicalRecordRecordID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPrescriptionDetails", x => x.DetailID);
                    table.ForeignKey(
                        name: "FK_tblPrescriptionDetails_tblMedicalRecords_MedicalRecordRecordID",
                        column: x => x.MedicalRecordRecordID,
                        principalTable: "tblMedicalRecords",
                        principalColumn: "RecordID");
                    table.ForeignKey(
                        name: "FK_tblPrescriptionDetails_tblMedicalRecords_RecordID",
                        column: x => x.RecordID,
                        principalTable: "tblMedicalRecords",
                        principalColumn: "RecordID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPrescriptionDetails_tblMedicines_MedicineID",
                        column: x => x.MedicineID,
                        principalTable: "tblMedicines",
                        principalColumn: "MedicineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblRecordService",
                columns: table => new
                {
                    RecordServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordID = table.Column<int>(type: "int", nullable: false),
                    ServiceID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRecordService", x => x.RecordServiceID);
                    table.ForeignKey(
                        name: "FK_tblRecordService_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ServiceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblRecordService_tblMedicalRecords_RecordID",
                        column: x => x.RecordID,
                        principalTable: "tblMedicalRecords",
                        principalColumn: "RecordID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceID", "Price", "ServiceName" },
                values: new object[,]
                {
                    { 1, 100000m, "Khám thường" },
                    { 2, 300000m, "Khám VIP" },
                    { 3, 150000m, "Siêu âm" }
                });

            migrationBuilder.InsertData(
                table: "tblMedicineCategories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Kháng sinh" },
                    { 2, "Giảm đau & Hạ sốt" },
                    { 3, "Vitamin & Khoáng chất" },
                    { 4, "Tim mạch & Huyết áp" }
                });

            migrationBuilder.InsertData(
                table: "tblPatients",
                columns: new[] { "PatientID", "Address", "BirthYear", "FullName", "Gender", "Phone" },
                values: new object[,]
                {
                    { 1, "Hà Nội", 1990, "Nguyễn Văn A", "Nam", "0987654321" },
                    { 2, "Đà Nẵng", 1995, "Trần Thị B", "Nữ", "0123456789" },
                    { 3, "TP.HCM", 1985, "Lê Văn C", "Nam", "0999888777" }
                });

            migrationBuilder.InsertData(
                table: "tblRoles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Bác sĩ" },
                    { 3, "Nhân viên" }
                });

            migrationBuilder.InsertData(
                table: "tblMedicines",
                columns: new[] { "MedicineID", "CategoryID", "ExpiryDate", "ImportPrice", "MedicineName", "SellPrice", "StockQuantity", "Unit" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2026, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m, "Panadol Extra", 2500m, 500, "Viên" },
                    { 2, 1, new DateTime(2025, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, "Amoxicillin 500mg", 25000m, 100, "Vỉ" },
                    { 3, 3, new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 45000m, "Vitamin C 1000mg", 60000m, 50, "Hộp" },
                    { 4, 1, new DateTime(2027, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000m, "Berberin", 18000m, 200, "Lọ" }
                });

            migrationBuilder.InsertData(
                table: "tblUsers",
                columns: new[] { "UserID", "FullName", "IsActive", "Password", "RoleID", "UserName" },
                values: new object[,]
                {
                    { 1, "Quản Trị Viên", true, "123", 1, "admin" },
                    { 2, "Bác sĩ CK1", true, "123", 2, "bacsi" }
                });

            migrationBuilder.InsertData(
                table: "tblMedicalRecords",
                columns: new[] { "RecordID", "DateCreated", "Diagnosis", "DoctorID", "PatientID", "Status", "Symptoms", "TotalAmount" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 20, 8, 30, 0, 0, DateTimeKind.Unspecified), "", 2, 1, "Waiting", "Đau bụng dữ dội, buồn nôn", 0m },
                    { 2, new DateTime(2025, 12, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), "Viêm họng cấp", 2, 2, "Finished", "Ho khan, sốt nhẹ", 0m },
                    { 3, new DateTime(2025, 12, 19, 14, 0, 0, 0, DateTimeKind.Unspecified), "Viêm da cơ địa", 2, 3, "Paid", "Dị ứng da", 150000m }
                });

            migrationBuilder.InsertData(
                table: "tblRecordService",
                columns: new[] { "RecordServiceID", "Price", "Quantity", "RecordID", "ServiceID" },
                values: new object[] { 1, 100000m, 1, 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_tblMedicalRecords_DoctorID",
                table: "tblMedicalRecords",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMedicalRecords_PatientID",
                table: "tblMedicalRecords",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_tblMedicines_CategoryID",
                table: "tblMedicines",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPrescriptionDetails_MedicalRecordRecordID",
                table: "tblPrescriptionDetails",
                column: "MedicalRecordRecordID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPrescriptionDetails_MedicineID",
                table: "tblPrescriptionDetails",
                column: "MedicineID");

            migrationBuilder.CreateIndex(
                name: "IX_tblPrescriptionDetails_RecordID",
                table: "tblPrescriptionDetails",
                column: "RecordID");

            migrationBuilder.CreateIndex(
                name: "IX_tblRecordService_RecordID",
                table: "tblRecordService",
                column: "RecordID");

            migrationBuilder.CreateIndex(
                name: "IX_tblRecordService_ServiceID",
                table: "tblRecordService",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_tblUsers_RoleID",
                table: "tblUsers",
                column: "RoleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPrescriptionDetails");

            migrationBuilder.DropTable(
                name: "tblRecordService");

            migrationBuilder.DropTable(
                name: "tblMedicines");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "tblMedicalRecords");

            migrationBuilder.DropTable(
                name: "tblMedicineCategories");

            migrationBuilder.DropTable(
                name: "tblPatients");

            migrationBuilder.DropTable(
                name: "tblUsers");

            migrationBuilder.DropTable(
                name: "tblRoles");
        }
    }
}
