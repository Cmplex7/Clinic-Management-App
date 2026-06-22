using DAL;
using Entities;
using System.Collections.Generic;

namespace BLL.Implements
{
    public class ServiceManagement
    {
        private ClinicDbContext _context = new ClinicDbContext();

        public List<Service> GetAllServices()
        {
            return _context.Services.ToList();
        }


        public void AddServices(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
        }

        public void UpdateServices(Service service)
        {
            var item = _context.Services.Find(service.ServiceID);
            if(item != null)
            {
                item.ServiceName = service.ServiceName;
                item.Price = service.Price;
                _context.SaveChanges();
            }
        }

        public void DeleteServices(int id)
        {
            var item = _context.Services.Find(id);
            if(item != null)
            {
                _context.Services.Remove(item);
                _context.SaveChanges();
            }
        }


        public List<Service> SearchServices(string keyword)
        {
            return _context.Services
                .Where(s => s.ServiceName.Contains(keyword))
                .ToList();
        }
    }
}
