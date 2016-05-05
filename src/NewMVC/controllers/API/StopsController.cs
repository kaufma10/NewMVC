using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NewMVC.models;
using AutoMapper;
using NewMVC.models.viewmodel;
using YourAppName.Services;
using Microsoft.AspNet.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NewMVC.controllers.Web
{
    public class StopsController : Controller
    {
        private TripsRepository SCDB;
        TripsRepository db = new TripsRepository();
        CoordinateService cr = new CoordinateService();
        public StopsController(TripsRepository db)
        {
            SCDB = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var stops = SCDB.GetAllStops();
            var results = AutoMapper.Mapper.Map<IEnumerable<StopViewModel>>(stops);
            return Json(results);
        }
        [Route("api/[controller]/{tripName}")]
        public JsonResult Stop(int? id)
        {
            var oneStop = SCDB.GetStop(id);
            return Json(oneStop);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Post(StopViewModel stop)
        {
            if (ModelState.IsValid)
            {
                var newStop = Mapper.Map<Stop>(stop);
                var longlat = await cr.Lookup(newStop.Name);
            }
            var results = AutoMapper.Mapper.Map<IEnumerable<StopViewModel>>(stop);
            return Json(results);
        }
    }
}
