using DAL;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Implements
{
    public class HistoryService
    {
        private ClinicDbContext _context = new ClinicDbContext();

        public List<History> GetHistoryList(string keyword)
        {
            var query = _context.MedicalRecords
                .Include(m => m.Patient)
                .Include(m => m.Doctor)
                .AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(m => m.Patient.FullName.Contains(keyword) || m.Patient.Phone.Contains(keyword));
            }

            var list = query.OrderByDescending(m => m.DateCreated)
                .Select(m => new History
                {
                    RecordID = m.RecordID,
                    NgayKham = m.DateCreated,
                    TenBenhNhan = m.Patient.FullName,
                    SDT = m.Patient.Phone,
                    BacSiKham = m.Doctor.FullName,
                    ChanDoan = m.Diagnosis,
                    TongTien = m.TotalAmount,
                    TrangThai = m.Status
                })
                .ToList();

            return list;
        }


        public dynamic GetPrescriptionDetail(int recordID)
        {
            return _context.PrescriptionDetails
                .Include(d => d.Medicine)
                .Where(d => d.RecordID == recordID)
                .Select(d => new
                {
                    TenThuoc = d.Medicine.MedicineName,
                    SoLuong = d.Quantity,
                    DonVi = d.Medicine.Unit,
                    CachDung = d.Usage,
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
                    TenDichVu = s.Service.ServiceName,
                    SoLuong = s.Quantity,
                    DonGia = s.Price,
                    ThanhTien = s.Quantity * s.Price
                }).ToList();
        }
    }
}
