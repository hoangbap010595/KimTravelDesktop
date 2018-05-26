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
        public ActionResult Index()
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
        #endregion
    }
}