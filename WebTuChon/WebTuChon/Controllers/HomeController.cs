using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using WebTuChon.Models;

namespace WebTuChon.Controllers
{
    public class HomeController : Controller
    {
        private List<User> _users
        {
            get
            {
                if (Session["User"] == null)
                {
                    Session["User"] = new List<User>()
                    {
                        new User{Id = 1, FullName = "Nguyen Van A",Country = "VietNam", BirthDay = new DateTime(), Subject = new List<string>{" CNTT ", " C# " } }
                    };
                }
                return (List<User>)Session["User"];
            }
            set
            {
                Session["User"] = value;
            }
        }
        public ActionResult Index()
        {
            return View(_users);
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                _users.Add(user);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}