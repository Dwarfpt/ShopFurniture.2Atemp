using ShopFurniture_2_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopFurniture_2_Web.Controllers
{
    public class HomeController : Controller
    {


        // GET: Home
        public ActionResult Index()
        {
            UserData u = new UserData();
            u.UserName = "Customer";
            u.Products = new List<Product>
    {
        new Product { Name = "Nordic Chair", Price = "$50.00" },
        new Product { Name = "Kruzo Aero Chair", Price = "$78.00" },
        new Product { Name = "Ergonomic Chair", Price = "$43.00" }
    };

            return View(u);
        }

        public ActionResult AboutUs()
        {
            var teamMembers = new List<TeamMember>
        {
            new TeamMember { Name = "Lawson Arnold", Position = "CEO, Founder, Atty.", Description = "Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.", ImageUrl = "~/PackFurni/images/person_1.jpg" },
            new TeamMember { Name = "Jeremy Walker", Position = "CEO, Founder, Atty.", Description = "Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.", ImageUrl = "~/PackFurni/images/person_2.jpg" },
            new TeamMember { Name = "Patrik White", Position = "CEO, Founder, Atty.", Description = "Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.", ImageUrl = "~/PackFurni/images/person_3.jpg" },
            new TeamMember { Name = "Kathryn Ryan", Position = "CEO, Founder, Atty.", Description = "Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.", ImageUrl = "~/PackFurni/images/person_4.jpg" }
        };

            return View(teamMembers);
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Shop()
        {
            return View();
        }
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}