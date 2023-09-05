using Lession1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lession1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1, 
                    Name = "Test",
                    Email = "Test",
                    Phone= "Test",
                    Address = "Test",
                    Avatar = Url.Content("~/Avatar/Group.png"),
                    Bio="Test",
                    Birthday= new DateTime(1998,7,15)
                },
                 new Account()
                {
                    Id = 2,
                    Name = "Test",
                    Email = "Test",
                    Phone= "Test",
                    Address = "Test",
                    Avatar = Url.Content("~/Avatar/Group.png"),
                    Bio="Test",
                    Birthday= new DateTime(1998,7,15)
                },
                  new Account()
                {
                    Id = 3,
                    Name = "Test",
                    Email = "Test",
                    Phone= "Test",
                    Address = "Test",
                    Avatar = Url.Content("~/Avatar/Group.png"),
                    Bio="Test",
                    Birthday= new DateTime(1998,7,15)
                },
                   new Account()
                {
                    Id = 4,
                    Name = "Test",
                    Email = "Test",
                    Phone= "Test",
                    Address = "Test",
                    Avatar = Url.Content("~/Avatar/Group.png"),
                    Bio="Test",
                    Birthday= new DateTime(1998,7,15)
                },
            };
            ViewBag.Accounts = accounts;
            return View();
        }


        [Route("ho-so", Name ="profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Test",
                    Email = "Test",
                    Phone= "Test",
                    Address = "Test",
                    Avatar = Url.Content("~/Avatar/Group.png"),
                    Bio="Test",
                    Birthday= new DateTime(1998,7,15)
                },
                 new Account()
                {
                    Id = 2,
                    Name = "Test",
                    Email = "Test",
                    Phone= "Test",
                    Address = "Test",
                    Avatar = Url.Content("~/Avatar/Group.png"),
                    Bio="Test",
                    Birthday= new DateTime(1998,7,15)
                },
                  new Account()
                {
                    Id = 3,
                    Name = "Test",
                    Email = "Test",
                    Phone= "Test",
                    Address = "Test",
                    Avatar = Url.Content("~/Avatar/Group.png"),
                    Bio="Test",
                    Birthday= new DateTime(1998,7,15)
                },
                   new Account()
                {
                    Id = 4,
                    Name = "Test",
                    Email = "Test",
                    Phone= "Test",
                    Address = "Test",
                    Avatar = Url.Content("~/Avatar/Group.png"),
                    Bio="Test",
                    Birthday= new DateTime(1998,7,15)
                },
            };            //
            Account a = accounts.FirstOrDefault(a => a.Id == id);

            ViewBag.a = a;
            return View();
        }



    }
}
