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
            var products = new List<Product>
            {
                new Product { Id = 1,
                              Name = "Adidas Soccer Shoes",
                              Price = 99.99m,
                              picture ="http://www.bayareakicks.com/wp-content/uploads/2011/03/adidas-soccer-cleats-shoes-5.jpg",
                              },
                new Product { Id = 2,
                              Name = "Venezuela Soccer Shirt",
                              Price = 69.99m,
                              picture ="http://image-load-balancer.worldsportshops.com/Images/watermarked_thumbnail.aspx?photoNum=1&t=I&catalog=Soccer&img=71781"
                              },
                new Product { Id = 3,
                              Name = "Soccer Shin Guards",
                              Price = 19.99m,
                              picture ="http://assets.academy.com/mgen/00/10269800.jpg"
                              },
                new Product { Id = 4,
                              Name = "Adidas Soccer Ball",
                              Price = 19.99m,
                              picture ="http://image-load-balancer.worldsportshops.com/Datafeeds/Graphics/Products/ImageCache/600x600/71662.jpg"
                              },
                new Product { Id = 5,
                              Name = "USA Soccer Shirt",
                              Price = 69.99m,
                              picture ="http://worldsoccertalk.com/wp-content/uploads/2014/04/usmnt-world-cup-away-shirt1.jpg"
                              },
                new Product { Id = 6,
                              Name = "Soccer Socks",
                              Price = 9.99m,
                              picture ="http://www.yomister.com/image/large/iPZ8kLwDTalalGc9iaVD6=VtkvVwjaIC6=gB/images/liverpool-gk-away-socks-2012-13.jpg"
                              },
                new Product { Id = 7 ,
                              Name = "Shorts",
                              Price = 12.99m,
                              picture = "http://www.soccergarage.com/images/T/squadra%2013%20short%20navy-01.jpg"
                              },
                new Product { Id = 8 ,
                              Name = "Videos",
                              Price = 29.99m,
                              picture = "http://www.soccermylife.com/wp-content/uploads/2015/02/How-To-Play-Soccer-For-Index-Page.jpg"
                              },
                new Product { Id = 9 ,
                              Name = "Cones",
                              Price = 29.99m,
                              picture = "http://ecx.images-amazon.com/images/I/31OfL%2BOywnL._SY300_.jpg"
                              },
                new Product { Id = 10 ,
                              Name = "Brazil shirt",
                              Price = 69.99m,
                              picture = "http://www.gogoalshop.hk/images/Brazil/2014-World-Cup-Brazil-Yellow-Soccer-Jersey.jpg"
                              },
                new Product { Id = 11 ,
                              Name = "Netherlands shirt",
                              Price = 69.99m,
                              picture = "http://ecx.images-amazon.com/images/I/615Pi3dqOgL._UL1500_.jpg"
                              },
                new Product { Id = 12 ,
                              Name = "Germany shirt",
                              Price = 69.99m,
                              picture = "http://cdn3.volusion.com/goz35.avhz4/v/vspfiles/photos/TTYADM35023-2.jpg?1456231556"
                              },
            };
            using (var db = new ProductContext())
            {
               foreach(Product p in products)
                {
                    db.Product.Add(p);
                    db.SaveChanges();
                }
            }
            
            return View(products);
        }

        // GET: /Home/Welcome 

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}