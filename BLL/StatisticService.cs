using DAL;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;

namespace BLL.Implements
{
    public class StatisticService
    {
        private ClinicDbContext _context = new ClinicDbContext();

        public List<Statistics> GetStatistics(DateTime fromDate, DateTime toDate)
        {
            var rawData = _context.MedicalRecords
                .Where(m => m.DateCreated >= fromDate.Date
                         && m.DateCreated < toDate.Date.AddDays(1)
                         && m.Status == "Paid")
                .Select(m => new {m.DateCreated, m.TotalAmount })
                .ToList();

            var result = rawData
                .GroupBy(x => x.DateCreated.Date)
                .Select(g => new Statistics
                {
                    Ngay = g.Key,
                    SoLuotKham = g.Count(),
                    DoanhThu = g.Sum(x => x.TotalAmount)
                })
                .OrderBy(x => x.Ngay)
                .ToList();
            return result;
        }
    }
}
