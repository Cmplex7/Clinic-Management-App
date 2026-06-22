using DAL;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Implements
{
    public class CategoryService
    {
        private ClinicDbContext _context = new ClinicDbContext();
        
        public List<MedicineCategory> GetMedicineCategories()
        {
            return _context.MedicineCategories.ToList();
        }
    }
}
