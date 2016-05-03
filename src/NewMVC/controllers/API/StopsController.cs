using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NewMVC.models;
using AutoMapper;
using NewMVC.models.viewmodel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NewMVC.controllers.Web
{
    public class StopsController : Controller
    {
        private TripsRepository SCDB;
        TripsRepository db = new TripsRepository();
        public StopsController(TripsRepository SCDB)
        {
            SCDB = new TripsRepository();
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Json(null);
        }
        public JsonResult Stop(int? id)
        {
            var oneStop = SCDB.GetStop(id);
            return Json(oneStop);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Post(StopViewModel trip)
        {
            if (ModelState.IsValid)
            {
                var newStop = Mapper.Map<Stop>(trip);
                return RedirectToAction("Index");
            }
            var results = AutoMapper.Mapper.Map<IEnumerable<StopViewModel>>(trip);
            return Json(results);
        }
    }
}
