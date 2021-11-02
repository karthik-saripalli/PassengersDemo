using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlightsDAL;
using FlightsBAL;
using FlightManagement.Models;
namespace FlightManagement.Controllers
{
    public class PassengersController : Controller
    {
        // GET: Passengers
        public ActionResult Index()
        {
            return View();
        }
       

        // GET: Passengers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Passengers/Create
        public ActionResult BookTicket()
        {
            return View();
        }

        // POST: Passengers/Create
        [HttpPost]
        public ActionResult BookTicket(Passengers p)
        {
                DALFlights d = new DALFlights();
                PassengerBAL b = new PassengerBAL();
                b.FlightId = p.FlightId;
                b.PassId = p.PassId;
                b.PassName = p.PassName;
                b.PassAge = p.PassAge;
               int t= d.BookTicket(b);
                // TODO: Add insert logic here
            return Content("Your ticket booking reference =" + t);
        }
        public ActionResult CancelTicket()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CancelTicket(Models.CancelTicket a)
        {
            DALFlights f = new DALFlights();
            CancelTicket t = new CancelTicket();
            t.PassId = a.PassId;
            f.CancelTicket(t.PassId);
            return Content("ticket of passenger "+t.PassId+" cancelled");
        }
        // GET: Passengers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Passengers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Passengers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Passengers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
