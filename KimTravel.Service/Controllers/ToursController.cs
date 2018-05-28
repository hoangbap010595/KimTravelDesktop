using KimTravel.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KimTravel.Service.Controllers
{
    public class ToursController : Controller
    {
        private KimTravelModel db = new KimTravelModel();
        // GET: Tours
        public ActionResult ListDetail()
        {
            return View();
        }

        public JsonResult GetListTour(int groupID)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            var tours = db.Tours.Where(x => x.Enable == true && x.GroupID == groupID).OrderBy(x => x.Name).ToList();
            foreach (Tour tour in tours)
            {
                Dictionary<string, object> objTour = new Dictionary<string, object>();
                objTour.Add("TourID", tour.TourID);
                objTour.Add("TourName", tour.Name);
                objTour.Add("MaxPax", tour.MaxPax);
                result.Add(objTour);
            }

            var json = Json(result, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }
    }
}