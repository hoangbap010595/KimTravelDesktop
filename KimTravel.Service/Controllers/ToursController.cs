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
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetLishTour()
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            var groupTours = db.GroupTours.Where(x => x.Enable == true).OrderBy(x=>x.Name).ToList();
            foreach (GroupTour item in groupTours)
            {
                Dictionary<string, object> objGroup = new Dictionary<string, object>();
                objGroup.Add("GroupID", item.GroupID);
                objGroup.Add("GroupName", item.Name);

                var tours = db.Tours.Where(x => x.Enable == true && x.GroupID == item.GroupID).OrderBy(x=>x.Name).ToList();
                List<Dictionary<string, object>> listTour = new List<Dictionary<string, object>>();
                foreach (Tour tour in tours)
                {
                    Dictionary<string, object> objTour = new Dictionary<string, object>();
                    objTour.Add("TourID", tour.TourID);
                    objTour.Add("TourName", tour.Name);
                    objTour.Add("MaxPax", tour.MaxPax);
                    listTour.Add(objTour);
                }
                objGroup.Add("Tours", listTour);
                result.Add(objGroup);
            }

            var json = Json(result, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }
    }
}