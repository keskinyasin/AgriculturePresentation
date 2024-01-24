using BussinessLayer.Abstract;
using BussinessLayer.ValidationRules;
using EntityLayer.Concrate;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;
        public ImageController(IImageService imageService) 
        {
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            var images = _imageService.GetAll();
            return View(images);
        }

        [HttpGet]
        public IActionResult AddImage() { return View(); }
        [HttpPost]
        public IActionResult AddImage(Image image)
        {
            ImageValidator validationRules = new ImageValidator();
            FluentValidation.Results.ValidationResult results = validationRules.Validate(image);
            if (results.IsValid)
            {
                _imageService.Insert(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteImage(int id)
        {
            var images = _imageService.Get(id);
            _imageService.Delete(images);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditImage(int id)
        {
            var images = _imageService.Get(id);
            return View(images);
        }

        [HttpPost]

        public IActionResult EditImage(Image image)
        {
            ImageValidator validationRules = new ImageValidator();
            FluentValidation.Results.ValidationResult results = validationRules.Validate(image);
            if (results.IsValid)
            {
                _imageService.Update(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}

