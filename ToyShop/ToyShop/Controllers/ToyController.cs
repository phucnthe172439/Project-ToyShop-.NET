using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToyShop.Models;

namespace ToyShop.Controllers
{
    public class ToyController : Controller
    {
        ToyShopDBContext db = new ToyShopDBContext();
        public IActionResult Index()
        {
            ViewBag.categories = db.Categories.ToList();
            List<Toy> data = db.Toys.ToList();
            return View(data);
        }
        [HttpPost]
        public IActionResult Index(int cateid)
        {
            ViewBag.categories = db.Categories.ToList();
            ViewBag.cateidselected = cateid;
            List<Toy> data = db.Toys.ToList();
            if (cateid != 0)
            {
                data = db.Toys
                    .Where(p => p.Categoryid == cateid)
                    .ToList();
            }
            return View(data);
        }
        public IActionResult Add()
        {
            ViewBag.categories = db.Categories.ToList();
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(Toy toy, int cateid)
        {
            ViewBag.categories = db.Categories.ToList();
            ViewBag.cateidselected = cateid;
            if (cateid != null)
            {
                var addToy = new Toy()
                {
                    Name = toy.Name,
                    Description = toy.Description,
                    Image = toy.Image,
                    Price = toy.Price,
                    Quantity = toy.Quantity,
                    Categoryid = cateid,
                };
               
                    db.Toys.Add(addToy);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Toy");
                
            }
            return RedirectToAction("Index","Home");

        }
    }
}
