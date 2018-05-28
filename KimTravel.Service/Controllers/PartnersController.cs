using KimTravel.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KimTravel.Service.Controllers
{
    public class PartnersController : Controller
    {
        private KimTravelModel db = new KimTravelModel();
        // GET: Partners
        public ActionResult DetailPartner()
        {
            return View();
        }

        public JsonResult GetListPartner()
        {
            List<Dictionary<string,object>> result = new List<Dictionary<string, object>>();
            var rs = db.Partners.OrderBy(x => x.Name);
            foreach (Partner item in rs)
            {
                Dictionary<string, object> row = new Dictionary<string, object>();
                row.Add("PartnerID", item.PartnerID);
                row.Add("PartnerCode", item.PartnerCode);
                row.Add("Name", item.Name);
                row.Add("Line", item.Line);
                row.Add("Address", item.Address);
                row.Add("Phone", item.Phone);

                result.Add(row);
            }
            var json = Json(result, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public JsonResult GetListPartnerByID(int partnerID)
        {
            Partner result = db.Partners.FirstOrDefault(x => x.PartnerID == partnerID);
            var json = Json(result, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }
    }
}