using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KimTravel.Service.Models;

namespace KimTravel.Service.Controllers
{
    public class BooksController : Controller
    {
        private KimTravelModel db = new KimTravelModel();
        // GET: Books
        public ActionResult BookDetail()
        {
            return View();
        }

        #region API
        [HttpPost]
        public JsonResult Travel_BookTour(Book book)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();

            try
            {
                book.EndDate = book.StartDate;
                book.CustomName = "";
                book.DateCreate = DateTime.Now;
                book.IsCancel = false;
                book.IsBooked = true;
                book.IsPayment = false;
                book.IsDone = false;
                book.PromotionPercent = 0;
                
                db.Books.Add(book);
                db.SaveChanges();
                result.Add("status", 0);
                result.Add("success", "Book tour thành công!");
            }
            catch (Exception ex)
            {
                result.Add("status", -1);
                result.Add("error", ex.Message);
            }

            var json = Json(result, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }

        public JsonResult GetListBooked(string dateS)
        {
            DateTime date = DateTime.Parse(dateS);
            DateTime date2 = DateTime.Parse(dateS).AddDays(1);
            IQueryable result = from b in db.Books
                              join t in db.Tours on b.TourID equals t.TourID
                              from p in db.Partners.Where(x => x.PartnerID == b.PartnerID)
                              where b.DateCreate.Value >= date && b.DateCreate.Value < date2
                                    && b.IsBooked == true
                              orderby b.DateCreate
                              select new
                              {
                                  b.ID,
                                  t.TourID,
                                  TourName = t.Name,
                                  ParnerID = p.PartnerID,
                                  PartName = p.Name,
                                  BookID = b.ID,
                                  b.StartDate,
                                  b.EndDate,
                                  b.Pax,
                                  b.PickUp,
                                  b.Room,
                                  b.CustomName,
                                  b.PartnerPrice,
                                  b.PriceReceive,
                                  b.PriceSale,
                                  b.PriceVTQ,
                                  b.PromotionMoney,
                                  b.PromotionPercent,
                                  b.StaffID,
                                  b.DateCreate,
                                  b.Note,
                                  b.ServiceType,
                                  b.Total,
                                  b.ServiceName,
                                  b.IsDone,
                                  b.DoneBy,
                                  b.IsCancel
                              };

            var json = Json(result, JsonRequestBehavior.AllowGet);
            json.MaxJsonLength = int.MaxValue;
            return json;
        }
        #endregion
    }
}