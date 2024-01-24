using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Delete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service Get(int id)
        {
            return _serviceDal.Get(id);
        }

        public List<Service> GetAll()
        {
            List<Service> services = _serviceDal.GetAll();

            foreach (Service service in services)
            {
                service.Description = service.Description ?? string.Empty;
                // Diğer özellikler için de benzer kontrol yapabilirsiniz
            }

            return services;
        }

        public void Insert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void Update(Service t)
        {
            _serviceDal.Update(t);
        }

        // Add your missing code here

    }
}
