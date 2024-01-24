using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.EntityFramework;
using DataAccessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class DefaultController : Controller
    {
        

        
        private readonly IServiceDal _serviceDal;
        private readonly ServiceManager _serviceManager;


        public DefaultController(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
            _serviceManager = new ServiceManager(_serviceDal);

        }


        public IActionResult Index()
        {
            var values = _serviceManager.GetAll();
            return View(values);
        }
    }
}
