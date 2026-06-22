using DAL;
using Entities;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ServicesService
    {
        private ClinicDbContext _context = new ClinicDbContext();

        public List<Service> GetServices()
        {
            return _context.Services.ToList();
        }
        public decimal GetPrice(int serviceId)
        {
            var s = _context.Services.Find(serviceId);
            return s != null ? s.Price : 0;
        }
    }
}
