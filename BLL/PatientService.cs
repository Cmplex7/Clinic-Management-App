using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL;

public class PatientService
{
    private ClinicDbContext _context = new ClinicDbContext();


    //Lấy danh sách bệnh nhân
    public List<Patient> GetPatient()
    {
        return _context.Patients.OrderByDescending(p => p.PatientID).ToList();
    }


    //Tìm kiếm bệnh nhân theo tên & SĐT
    public List<Patient> SearchPatient(string keyword)
    {
        return _context.Patients
                       .Where(p => p.FullName.Contains(keyword) || p.Phone.Contains(keyword))
                       .ToList();
    }


    //Thêm bệnh nhân
    public void AddPatient(Patient p)
    {
        if(_context.Patients.Any(x => x.Phone == p.Phone))
        {
            throw new Exception("Số điện thoại đã tồn tại !");
        }
        _context.Patients.Add(p);
        _context.SaveChanges();
    }


    //Cập nhật thông tin bệnh nhân
    public void UpdatePatient(Patient p)
    {
        var existing = _context.Patients.Find(p.PatientID);
        if(existing != null)
        {
            existing.FullName = p.FullName;
            existing.Phone = p.Phone;
            existing.Address = p.Address;
            existing.BirthYear = p.BirthYear;
            _context.SaveChanges();
        }
    }


    //Xóa bệnh nhân
    public void DeletePatient(int id)
    {
        var p = _context.Patients.Find(id);
        if(p != null)
        {
            _context.Patients.Remove(p);
            _context.SaveChanges();
        }
    }


    //Chức năng đăng ký khám 
    public void RegisterExam(int patientId, int doctorId, string symptoms, int serviceId)
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                var record = new MedicalRecord
                {
                    PatientID = patientId,
                    DoctorID = doctorId,
                    Symptoms = symptoms,
                    DateCreated = DateTime.Now,
                    Status = "Waiting",
                    Diagnosis = "",
                    TotalAmount = 0
                };
                _context.MedicalRecords.Add(record);
                _context.SaveChanges();

                if (serviceId > 0)
                {
                    var servcice = _context.Services.Find(serviceId);
                    if (servcice != null)
                    {
                        var recordService = new RecordService
                        {
                            RecordID = record.RecordID,
                            ServiceID = serviceId,
                            Quantity = 1,
                            Price = servcice.Price
                        };
                        _context.RecordServices.Add(recordService);
                        _context.SaveChanges();
                    }
                }
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                // Tìm đến tận cùng cái lỗi gốc
                var loiCanXem = ex;
                while (loiCanXem.InnerException != null)
                {
                    loiCanXem = loiCanXem.InnerException;
                }

                // Ném ra cái message của lỗi gốc (ví dụ: Duplicate key...)
                throw new Exception("Đăng ký không thành công: " + loiCanXem.Message);
            }
        }
    }
}
