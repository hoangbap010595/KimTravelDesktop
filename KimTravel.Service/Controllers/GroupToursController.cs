using KimTravel.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KimTravel.Service.Controllers
{
    public class GroupToursController : Controller
    {
        private KimTravelModel db = new KimTravelModel();

        // GET: Groups
        public ActionResult GroupDetail()
        {
            return View();
        }

        public JsonResult GetListGroup()
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            var groupTours = db.GroupTours.Where(x => x.Enable == true).OrderBy(x => x.Name).ToList();
            foreach (GroupTour item in groupTours)
            {
                Dictionary<string, object> objGroup = new Dictionary<string, object>();
                objGroup.Add("GroupID", item.GroupID);
                objGroup.Add("GroupName", item.Name);
                objGroup.Add("MaxPax", item.MaxPax);
                result.Add(objGroup);
            }
            var json = Json(result, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }
    }
}