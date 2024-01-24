using AgriculturePresentation.Models;
using BussinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View(new ServiceAddViewModel());
        }

        [HttpPost]
        public IActionResult AddService(ServiceAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool imageValue;

                if (model.Image == "1")
                {
                    imageValue = true;
                }
                else if (model.Image == "0")
                {
                    imageValue = false;
                }
                else
                {
                    imageValue = bool.Parse(model.Image); // Bu, yalnızca 'true' veya 'false' için çalışacaktır
                }

                _serviceService.Insert(new Service()
                {
                    Title = model.Title,
                    Image = imageValue,
                    Description = model.Description,
                    ServiceName = model.ServiceName
                });
                return RedirectToAction("Index");
            }

            return View(model);
        }


        public IActionResult DeleteService(int id)
        {
            var service = _serviceService.Get(id);
            _serviceService.Delete(service);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var service = _serviceService.Get(id);
            return View(service);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            _serviceService.Update(service);
            return RedirectToAction("Index");
        }

        public IActionResult Deneme(int id)
        {
            
            return View();
        }
    }
}
