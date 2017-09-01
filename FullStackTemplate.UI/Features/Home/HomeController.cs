using System.Diagnostics;
using FullStackTemplate.Facade.FeatureFacades;
using FullStackTemplate.Facade.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FullStackTemplate.UI.Features.Home
{
    public class HomeController : Controller
    {
        private readonly IHomeFacade _homeFacade;
        
        public HomeController(IHomeFacade homeFacade)
        {
            // TODO Dependency Inject all required facades
            _homeFacade = homeFacade;
        }

        public IActionResult Index()
        {
            _homeFacade.Index();
            return View();
        }

        public IActionResult About()
        {
            _homeFacade.About();
            
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            _homeFacade.Contact();
            
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Error()
        {
            var errorViewModel = _homeFacade.Error(Activity.Current?.Id, HttpContext.TraceIdentifier);
            return View(errorViewModel);
        }
    }
}