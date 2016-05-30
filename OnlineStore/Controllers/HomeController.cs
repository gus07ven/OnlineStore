using OnlineStore.Models;
using OnlineStore;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.Data.Entity;


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
             
                var query = from b in db.Product
                            orderby b.Name
                            select b;

                foreach (var item in query)
                {
                    return View(item);
                }
            }
        }

        // GET: /Home/Welcome 

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}