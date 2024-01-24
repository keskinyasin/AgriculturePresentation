using BussinessLayer.Abstract;
using BussinessLayer.ValidationRules;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;

        }


        public IActionResult Index()
        {
            var teams = _teamService.GetAll();
            return View(teams);
        }
        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            TeamValidator validationRules = new TeamValidator();
            FluentValidation.Results.ValidationResult results = validationRules.Validate(team);
            if (results.IsValid)
            {
                _teamService.Insert(team);
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

        public IActionResult DeleteTeam(int id)
        {
            var team = _teamService.Get(id);
            _teamService.Delete(team);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditTeam(int id)
        {
            var team = _teamService.Get(id);
            return View(team);
        }

        [HttpPost]

        public IActionResult EditTeam(Team team)
        {
            TeamValidator validationRules = new TeamValidator();
            FluentValidation.Results.ValidationResult results = validationRules.Validate(team);
            if (results.IsValid)
            {
                _teamService.Update(team);
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
