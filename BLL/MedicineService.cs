using DAL;
using Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BLL.Implements
{
    public class MedicineService
    {
        private ClinicDbContext _context = new ClinicDbContext();

        public List<Medicine> GetMedicines()
        {
            return _context.Medicines
                .Include(m => m.Category)
                .OrderBy(m => m.MedicineName)
                .ToList();
        }

        public List<Medicine> SearchMedicine(string keyword)
        {
            return _context.Medicines
                .Include(m => m.Category)
                .Where(m => m.MedicineName.Contains(keyword))
                .ToList();
        }

        public void AddMedicine(Medicine m)
        {
            if (_context.Medicines.Any(x => x.MedicineName == m.MedicineName))
            {
                throw new Exception("Thuốc đã tồn tại trong kho !");
            }
            _context.Medicines.Add(m);
            _context.SaveChanges();
        }

        public void UpdateMedicine(Medicine m)
        {
            var existing = _context.Medicines.Find(m.MedicineID);
            if(existing != null)
            {
                existing.MedicineName = m.MedicineName;
                existing.Unit = m.Unit;
                existing.ImportPrice = m.ImportPrice;
                existing.SellPrice = m.SellPrice;
                existing.StockQuantity = m.StockQuantity;
                existing.ExpiryDate = m.ExpiryDate;
                existing.CategoryID = m.CategoryID;

                _context.SaveChanges();
            }
        }

        public void DeleteMedicine(int id)
        {
            var item = _context.Medicines.Find(id);
            if (item != null)
            {
                _context.Medicines.Remove(item);
                _context.SaveChanges();
            }
        }

        public List<Medicine> GetByCategory(int categoryID)
        {
            return _context.Medicines
                .Include(m => m.Category)
                .Where(m => m.CategoryID == categoryID)
                .OrderBy(m => m.MedicineName)
                .ToList();
        }
    }
}
