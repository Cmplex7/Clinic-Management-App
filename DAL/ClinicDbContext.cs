using Entities;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ClinicDbContext : DbContext
    {
        // --- 1. KHAI BÁO CÁC BẢNG (DBSETS) ---
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<Medicine> Medicines { get; set; }

        public DbSet<MedicineCategory> MedicineCategories { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        public DbSet<RecordService> RecordServices { get; set; }





        public ClinicDbContext() { }
        public ClinicDbContext(DbContextOptions<ClinicDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ClinicContext"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --- A. CẤU HÌNH QUAN HỆ (FLUENT API) ---

            // 1. Cấu hình MedicalRecord - Doctor (User)
            modelBuilder.Entity<MedicalRecord>()
                .HasOne(m => m.Doctor)
                .WithMany()
                .HasForeignKey(m => m.DoctorID)
                .OnDelete(DeleteBehavior.Restrict);

            // 2. Cấu hình MedicalRecord - Patient
            // Mục đích: Một bệnh nhân có nhiều phiếu khám
            modelBuilder.Entity<MedicalRecord>()
                .HasOne(m => m.Patient)
                .WithMany(p => p.MedicalRecords)
                .HasForeignKey(m => m.PatientID);

            // 3. Cấu hình PrescriptionDetail - MedicalRecord
            modelBuilder.Entity<PrescriptionDetail>()
                .HasOne(pd => pd.MedicalRecord)
                .WithMany()
                .HasForeignKey(pd => pd.RecordID)
                .OnDelete(DeleteBehavior.Cascade);

            // 4. Cấu hình User - Role
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleID);

            // 5. Cấu hình RecordService - MedicalRecord
            modelBuilder.Entity<MedicalRecord>()
                .Property(m => m.TotalAmount)
                .HasColumnType("decimal(18,2)");

            // 6. Cấu hình PrescriptionDetail - Medicine
            modelBuilder.Entity<PrescriptionDetail>()
                .Property(p => p.UnitPrice)
                .HasColumnType("decimal(18,2)");

            // 7. Cấu hình RecordService - Service
            modelBuilder.Entity<Service>()
                .Property(s => s.Price)
                .HasColumnType("decimal(18,2)");

            // 8. Cấu hình Medicine - MedicineCategory
            modelBuilder.Entity<Medicine>()
                .Property(m => m.ImportPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Medicine>()
                .Property(m => m.SellPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Medicine>()
                .HasOne(m => m.Category)
                .WithMany(c => c.Medicines)
                .HasForeignKey(m => m.CategoryID);

            //Cấu hình RecordService - MedicalRecord
            modelBuilder.Entity<RecordService>()
                .HasOne(rs => rs.MedicalRecord)
                .WithMany(m => m.RecordServices)
                .HasForeignKey(rs => rs.RecordID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RecordService>()
                .Property(rs => rs.Price)
                .HasColumnType("decimal(18,2)");






            // --- B. DỮ LIỆU MẪU (SEED DATA) ---


            // Tạo sẵn các vai trò
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, RoleName = "Admin" },
                new Role { RoleID = 2, RoleName = "Bác sĩ" },
                new Role { RoleID = 3, RoleName = "Nhân viên" }
            );

            // Tạo sẵn tài khoản (Pass: 123)
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID = 1,
                    FullName = "Quản Trị Viên",
                    UserName = "admin",
                    Password = "123",
                    RoleID = 1,
                    IsActive = true
                },
                new User
                {
                    UserID = 2,
                    FullName = "Bác sĩ CK1",
                    UserName = "bacsi",
                    Password = "123",
                    RoleID = 2,
                    IsActive = true
                }
            );

            // --- TẠO DỮ LIỆU MẪU: DỊCH VỤ KHÁM ---
            modelBuilder.Entity<Service>().HasData(
                new Service { ServiceID = 1, ServiceName = "Khám thường", Price = 100000 },
                new Service { ServiceID = 2, ServiceName = "Khám VIP", Price = 300000 },
                new Service { ServiceID = 3, ServiceName = "Siêu âm", Price = 150000 }
            );


            // --- 1. TẠO DỮ LIỆU MẪU: DANH MỤC THUỐC ---
            modelBuilder.Entity<MedicineCategory>().HasData(
                new MedicineCategory { CategoryID = 1, CategoryName = "Kháng sinh" },
                new MedicineCategory { CategoryID = 2, CategoryName = "Giảm đau & Hạ sốt" },
                new MedicineCategory { CategoryID = 3, CategoryName = "Vitamin & Khoáng chất" },
                new MedicineCategory { CategoryID = 4, CategoryName = "Tim mạch & Huyết áp" }
            );

            // --- 2. TẠO DỮ LIỆU MẪU: THUỐC ---
            modelBuilder.Entity<Medicine>().HasData(
                new Medicine
                {
                    MedicineID = 1,
                    MedicineName = "Panadol Extra",
                    Unit = "Viên",
                    ImportPrice = 1000m,
                    SellPrice = 2500m,
                    StockQuantity = 500,
                    CategoryID = 2,        // Thuộc nhóm Giảm đau
                    ExpiryDate = new DateTime(2026, 12, 31)
                },
                new Medicine
                {
                    MedicineID = 2,
                    MedicineName = "Amoxicillin 500mg",
                    Unit = "Vỉ",
                    ImportPrice = 15000m,
                    SellPrice = 25000m,
                    StockQuantity = 100,
                    CategoryID = 1,        // Thuộc nhóm Kháng sinh
                    ExpiryDate = new DateTime(2025, 10, 20)
                },
                new Medicine
                {
                    MedicineID = 3,
                    MedicineName = "Vitamin C 1000mg",
                    Unit = "Hộp",
                    ImportPrice = 45000m,
                    SellPrice = 60000m,
                    StockQuantity = 50,
                    CategoryID = 3,        // Thuộc nhóm Vitamin
                    ExpiryDate = new DateTime(2026, 5, 15)
                },
                new Medicine
                {
                    MedicineID = 4,
                    MedicineName = "Berberin",
                    Unit = "Lọ",
                    ImportPrice = 10000m,
                    SellPrice = 18000m,
                    StockQuantity = 200,
                    CategoryID = 1, // Tạm cho vào nhóm 1 hoặc tạo nhóm Tiêu hóa sau
                    ExpiryDate = new DateTime(2027, 1, 1)
                }
            );

            // --- 3. TẠO DỮ LIỆU MẪU: BỆNH NHÂN ---
            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {
                    PatientID = 1,
                    FullName = "Nguyễn Văn A",
                    Gender = "Nam",
                    BirthYear = 1990,
                    Phone = "0987654321",
                    Address = "Hà Nội"
                },
                new Patient
                {
                    PatientID = 2,
                    FullName = "Trần Thị B",
                    Gender = "Nữ",
                    BirthYear = 1995,
                    Phone = "0123456789",
                    Address = "Đà Nẵng"
                },
                new Patient
                {
                    PatientID = 3,
                    FullName = "Lê Văn C",
                    Gender = "Nam",
                    BirthYear = 1985,
                    Phone = "0999888777",
                    Address = "TP.HCM"
                }
            );

            modelBuilder.Entity<MedicalRecord>().HasData(
                // Ca 1: Đang CHỜ KHÁM
                new MedicalRecord
                {
                    RecordID = 1,
                    PatientID = 1,
                    DoctorID = 2,
                    DateCreated = new DateTime(2025, 12, 20, 8, 30, 0),
                    Symptoms = "Đau bụng dữ dội, buồn nôn",
                    Status = "Waiting",
                    TotalAmount = 0,
                    Diagnosis = ""
                },

                // Ca 2: Đã KHÁM XONG
                new MedicalRecord
                {
                    RecordID = 2,
                    PatientID = 2,
                    DoctorID = 2,
                    DateCreated = new DateTime(2025, 12, 20, 9, 0, 0),
                    Symptoms = "Ho khan, sốt nhẹ",
                    Status = "Finished",
                    TotalAmount = 0,
                    Diagnosis = "Viêm họng cấp"
                },

                // Ca 3: Đã TRẢ TIỀN
                new MedicalRecord
                {
                    RecordID = 3,
                    PatientID = 3,
                    DoctorID = 2,
                    DateCreated = new DateTime(2025, 12, 19, 14, 0, 0),
                    Symptoms = "Dị ứng da",
                    Status = "Paid",
                    TotalAmount = 150000m,
                    Diagnosis = "Viêm da cơ địa"
                }
            );


            modelBuilder.Entity<RecordService>().HasData(
                    new RecordService { RecordServiceID = 1, RecordID = 2, ServiceID = 1, Quantity = 1, Price = 100000m }
                );
        }
    }
}