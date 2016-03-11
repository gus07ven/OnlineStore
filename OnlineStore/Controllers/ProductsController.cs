using OnlineStore.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace OnlineStore.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
    }
}