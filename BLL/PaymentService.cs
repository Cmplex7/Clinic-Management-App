using DAL;
using Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BLL.Implements
{
    public class PaymentService
    {
        private ClinicDbContext _context = new ClinicDbContext();

        public dynamic GetPaymentWaitingList()
        {
            var list = _context.MedicalRecords
                .Include(m => m.Patient)
                .Where(m => m.Status == "Finished")
                .Select(m => new
                {
                    m.RecordID,
                    m.Patient.FullName,
                    m.Patient.Phone,
                    m.Diagnosis,
                    m.DateCreated
                })
                .ToList();
            return list;
        }


        public dynamic GetPrescriptionDetails(int recordID)
        {
            return _context.PrescriptionDetails
                .Include(d => d.Medicine)
                .Where(d => d.RecordID == recordID)
                .Select(d => new
                {
                    ItemName = d.Medicine.MedicineName,
                    SL = d.Quantity,
                    DonGia = d.UnitPrice,
                    ThanhTien = d.Quantity * d.UnitPrice
                })
                .ToList();
        }


        public dynamic GetServiceDetails(int recordID)
        {
            return _context.RecordServices
                .Include(s => s.Service)
                .Where(s => s.RecordID == recordID)
                .Select(s => new
                {
                    ItemName = s.Service.ServiceName,
                    SL = s.Quantity,
                    DonGia = s.Price,
                    ThanhTien = s.Quantity * s.Price
                })
                .ToList();
        }


        public void ConfirmPayment(int recordID, decimal finalTotalAmount)
        {
            var record = _context.MedicalRecords.Find(recordID);
            if(record != null)
            {
                record.Status = "Paid";
                record.TotalAmount = finalTotalAmount;
                _context.SaveChanges();
            }
        }
    }
}
