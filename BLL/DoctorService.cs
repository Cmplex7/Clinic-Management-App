using DAL;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BLL.Implements
{
    public class DoctorService
    {
        private ClinicDbContext _context = new ClinicDbContext();

        public dynamic GetWaitingList()
        {
            var list = _context.MedicalRecords
                .Include(m => m.Patient)
                .Where(m => m.Status == "Waiting" || m.Status == "Đang chờ khám")
                .Select(m => new
                {
                    m.RecordID,
                    m.Patient.FullName,
                    m.Patient.Phone,
                    m.Symptoms,
                })
                .ToList();
            return list;
        }

        public List<Medicine> GetMedicines()
        {
            return _context.Medicines.ToList();
        }


        
        //Khám hoàn tất
        public void FinishExamination(int recordId, string diagnosis, List<PrescriptionDetail> listDonThuoc)
        {
            using(var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var record = _context.MedicalRecords.FirstOrDefault(x => x.RecordID == recordId);
                    if (record != null)
                    {
                        record.Diagnosis = diagnosis;
                        record.Status = "Finished";
                    }

                    decimal totalDrugPrice = 0;

                    foreach(var item in listDonThuoc)
                    {
                        item.RecordID = recordId;

                        var medicine = _context.Medicines.Find(item.MedicineID);
                        if(medicine != null)
                        {
                            if(medicine.StockQuantity < item.Quantity)
                            {
                                throw new Exception($"Thuốc '{medicine.MedicineName}' không còn đủ tồn kho ! Số lượng còn lại: {medicine.StockQuantity}");
                            }
                            medicine.StockQuantity -= item.Quantity;
                            item.UnitPrice = medicine.SellPrice;
                        }
                        totalDrugPrice += (item.UnitPrice * item.Quantity);
                        _context.PrescriptionDetails.Add(item);
                    }
                    record.TotalAmount = totalDrugPrice;

                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
