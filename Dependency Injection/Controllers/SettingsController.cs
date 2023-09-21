using Dependency_Injection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Dependency_Injection.Controllers
{
    public class SettingsController : Controller
    {
        private readonly MyJson _settings;

        public SettingsController(IOptions<MyJson> settingsOptions)
        {
            _settings = settingsOptions.Value;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = _settings.Title;
            ViewData["Version"] = _settings.Version;
            return View();
        }

        public IActionResult Show()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
