using System.Web.Mvc;
using CleanArchitecture.Core.Contracts;

namespace CleanArchitecture.UI.Controllers
{
    public class HomeController : Controller
    {
        public IWidgetRepository Repo { get; }

        public HomeController(IWidgetRepository repo)
        {
            Repo = repo;
        }
        public ActionResult Index()
        {
            var x = Repo.GetById(1);
            return View(x);
        }
    }
}