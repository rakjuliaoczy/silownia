using Silownia.Models;
using Silownia.Models.DbModels;
using Silownia.Models.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Silownia.Controllers
{
    public class ClientController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        // GET: Client
        public ActionResult Index()
        {
            var clients = db.Clients.Include(c => c.Gym);
            return View(clients.ToList());
        }

        public ActionResult Details()
        {
            return RedirectToAction("Index", "Classes");
        }

        public ActionResult DetailsSchedule()
        {
            return RedirectToAction("Index", "Schedules");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.GymId = new SelectList(db.Gyms, "GymId", "Adress");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                using (DatabaseContext db = new DatabaseContext())
                {
                    db.Clients.Add(client);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            ViewBag.GymId = new SelectList(db.Gyms, "GymId", "GymName");
            return View(client);
        }
        [HttpGet]
        public ActionResult ViewAll()
        {
            List<Client> clients;
            using (DatabaseContext db = new DatabaseContext())
                clients = db.Clients.ToList();
            ViewBag.GymId = new SelectList(db.Gyms, "GymId", "GymName");
            return View(clients);
        }
        [HttpGet]
        /*
        public ActionResult ViewAll()
        {
            List<GymClient> clients;
            using (DatabaseContext db = new DatabaseContext())
            {
                clients = db.Clients.
                    Join(db.Gyms,
                    client => client.ClientId,
                    gym => gym.GymId,
                    (client, gym) => new
                    {
                        ClientId = client.ClientId,
                        Name = client.Name,
                        Surname = client.Surname,
                        PhoneNumber = client.PhoneNumber,
                        Adress = gym.Adress
                    })
                    .Select(x => new GymClient() { Name = x.Name, Surname = x.Surname, PhoneNumber = x.PhoneNumber, Adress = x.Adress }).ToList();
            }
            return View(clients);
        }
        */
        public ActionResult View(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            ViewBag.GymId = new SelectList(db.Gyms, "GymId", "GymName", client.ClientId);
            return View(client);
        }


        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (!ModelState.IsValid)
            {
                db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GymId = new SelectList(db.Gyms, "GymId", "GymName", client.GymId);
            return View(client);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Client client = db.Clients.Find(id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }


        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            Client client = db.Clients.Find(id);
            db.Clients.Remove(client);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}