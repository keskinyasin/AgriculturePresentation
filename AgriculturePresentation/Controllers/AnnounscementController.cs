using BussinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class AnnounscementController : Controller
    {
        private readonly IAnnouncementService _announscementService;

        public AnnounscementController(IAnnouncementService announscementService)
        {
            _announscementService = announscementService;
        }
        public IActionResult Index()
        {
            var announscements = _announscementService.GetAll();
            return View(announscements);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
               return View();
        }

        [HttpPost]

        public IActionResult AddAnnouncement(Announcement announcement)
        {
            announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            announcement.Status = false;
            _announscementService.Insert(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAnnounscement(int id)
        {
            var service = _announscementService.Get(id);
            if (service != null)
            {
                _announscementService.Delete(service);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAnnounscement(int id)
        {
            var service = _announscementService.Get(id);
            return View(service);
        }

        [HttpPost]
        public IActionResult EditAnnounscement(Announcement announcement)
        {
            _announscementService.Update(announcement);
            return RedirectToAction("Index");
        }

        

        public IActionResult ChangeStatus(int id)
        {
            var announcement = _announscementService.Get(id);
            if (announcement == null)
            {
                return NotFound();
            }

            announcement.Status = !announcement.Status;
            _announscementService.Update(announcement);

            return RedirectToAction("Index");
        }

    }
}
