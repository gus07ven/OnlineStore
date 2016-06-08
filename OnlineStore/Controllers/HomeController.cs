using OnlineStore.Models;
using System.Web.Mvc;
using System.Linq;
using Microsoft;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller  
    {
        // GET: /Home
        // Note: Had to change from IActionResult
        // to ActionResult for code to work
        // http://docs.asp.net/projects/mvc/en/latest/getting-started/first-mvc-app/adding-view.html

        public ActionResult Index()
        {
            using (var db = new ProductContext())
            {
                return View(db.Product.ToList());
            }
        }


        // GET: /Home/ShoppingCart 

        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}