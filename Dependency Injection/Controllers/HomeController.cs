using Dependency_Injection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;
        private ProductSum _productSum;
        public HomeController(IRepository repository, ProductSum productSum)
        {
            _repository = repository;
            _productSum = productSum;
        }
        public IActionResult Index([FromServices] ProductSum productSum)
        {
            ViewBag.Total = _productSum.Total;
            ViewBag.HomeControllerGuid = _repository.ToString();
            ViewBag.ProductGuid = _productSum._repository.ToString();
            return View(_repository.Products);
        }
    }
}