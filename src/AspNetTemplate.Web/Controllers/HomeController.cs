using Microsoft.AspNetCore.Mvc;

namespace AspNetTemplate.Web.Controllers
{
    public class HomeController : AspNetTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}