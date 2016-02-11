using System.Web;
using System.Web.Mvc;


namespace OnlineStore.Controllers
{
    public class HomeController: Controller  
    {
        // GET: /Home
        // Note: Had to change from IActionResult
        // to ActionResult for code to work
        // http://docs.asp.net/projects/mvc/en/latest/getting-started/first-mvc-app/adding-view.html

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/Welcom 

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}