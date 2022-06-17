using Silownia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Register;


namespace Register.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(RegisterC obj)

        {
            if (ModelState.IsValid)
            {
                RegisterEntities db = new RegisterEntities();
                db.RegisterCs.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}