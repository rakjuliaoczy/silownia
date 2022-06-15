using Silownia.Models;
using Silownia.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Silownia.Controllers
{
    public class GymsController : Controller
    {
        // GET: Gyms
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Gym());
        }
        [HttpPost]
        public ActionResult Create(Gym gym)
        {
            if(ModelState.IsValid)
            {
                using(DatabaseContext db = new DatabaseContext())
                {
                    db.Gyms.Add(gym);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(new Gym());
        }

        [HttpGet]
        public ActionResult ViewAll()
        {
            List<Gym> gyms;
            using (DatabaseContext db = new DatabaseContext())
                gyms = db.Gyms.ToList();
            return View(gyms);
        }

        public ActionResult View(int id)
        {
            Gym gym;
            using (DatabaseContext db = new DatabaseContext())
                gym = db.Gyms.FirstOrDefault(x => x.GymId == id);

            return View(gym);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Gym gym;
            using (DatabaseContext db = new DatabaseContext())
                gym = db.Gyms.FirstOrDefault(x => x.GymId == id);
            return View(gym);
        }


        [HttpPost]
        public ActionResult Edit(Gym gym)
        {
            if (!ModelState.IsValid)
                return View(gym);

            using (DatabaseContext db = new DatabaseContext())
            {
                db.Entry(gym).State = EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("ViewAll");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            Gym gym;
            using (DatabaseContext db = new DatabaseContext())
            {
                gym = db.Gyms.FirstOrDefault(x => x.GymId == id);
            }
            return View(gym);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int? id)
        {
            Gym gym;
            using (DatabaseContext db = new DatabaseContext())
            {
                gym = db.Gyms.FirstOrDefault(x => x.GymId == id);
                db.Gyms.Remove(gym);
                db.SaveChanges();
            }

            return RedirectToAction("ViewAll");
        }
    }
}