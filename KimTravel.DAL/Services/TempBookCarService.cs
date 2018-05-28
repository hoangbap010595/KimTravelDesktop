using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class TempBookCarService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext(AppConfig.getStringConnection());

        /// <summary>
        /// Lấy danh sách đã book chưa được sắp xe
        /// </summary>
        /// <param name="groupID"></param>
        /// <param name="dateStart"></param>
        /// <param name="isBooked"></param>
        /// <returns></returns>
        public IQueryable GetListBookedNotInCar(int groupID, string dateStart, bool isBooked = true, bool isCancel = false)
        {
            var date = DateTime.Parse(dateStart);
            IQueryable data = ((from b in db.Books
                                join tb in db.TempBookCars on b.ID equals tb.BookID
                                join p in db.Partners on b.PartnerID equals p.PartnerID
                                join t in db.Tours on b.TourID equals t.TourID
                                join g in db.GroupTours on t.GroupID equals g.GroupID
                                where b.IsBooked == isBooked && b.IsCancel == isCancel && g.GroupID == groupID && b.StartDate == date
                                orderby p.Address, p.Line
                                select new
                                {
                                    TourID = t.TourID,
                                    b.Pax,
                                    b.PaxChild
                                }).GroupBy(x => x.TourID)
                                .Select(o => new { ID = o.Key, Total = o.Sum(x => x.Pax), TotalChild = o.Sum(x => x.PaxChild) }))
                                .Join(db.Tours, O1 => O1.ID, O2 => O2.TourID, (O1, O2) => new { TourID = O1.ID, TourName = O2.Name, O2.MaxPax, Pax = O1.Total, PaxChild = O1.TotalChild });
            return data;
        }


        /// <summary>
        /// Lấy tất cả danh sách đã book có theo tour
        /// </summary>
        /// <param name="tourID"></param>
        /// <param name="dateS"></param>
        /// <param name="isCancel"></param>
        /// <returns></returns>
        public IQueryable GetListBooked(int tourID, string dateS, bool isCancel = false)
        {
            DateTime date = DateTime.Parse(dateS);
            IQueryable data = from b in db.Books
                              join tb in db.TempBookCars on b.ID equals tb.BookID
                              join t in db.Tours on b.TourID equals t.TourID
                              from p in db.Partners.Where(x => x.PartnerID == b.PartnerID)
                              where b.TourID == tourID
                                    && b.StartDate.Value == date
                                    && b.IsCancel == isCancel
                                    && b.IsBooked == true
                              orderby p.Address, p.Line
                              select new
                              {
                                  b.ID,
                                  b.StartDate,
                                  b.Pax,
                                  b.PaxChild,
                                  b.PickUp,
                                  b.Room,
                                  b.PartnerPrice,
                                  b.Note,
                                  b.ServiceType,
                                  b.ServiceName,
                                  tb.Added,
                                  tb.Car1,
                                  tb.Car2,
                                  tb.Car3,
                                  tb.Car4,
                                  tb.Car5,
                                  tb.Car6,
                                  tb.Car7,
                                  tb.Car8,
                                  tb.Car9,
                                  tb.Car10
                              };

            return data;
        }


        public void AddBookFromOtherTour(string startDate, int bookID)
        {
            TempBookCar t = db.TempBookCars.FirstOrDefault(x => x.BookID == bookID);
            if (t == null)
            {
                t = new TempBookCar();
                t.StartDate = DateTime.Parse(startDate);
                t.Added = true;
                db.TempBookCars.InsertOnSubmit(t);
                db.SubmitChanges();
            }
        }


        public bool RemoveBookCarAdded(int bookID)
        {
            TempBookCar t = db.TempBookCars.FirstOrDefault(x => x.BookID == bookID);
            if (t != null)
            {
                if(t.Added == true)
                {
                    t.Added = false;
                    t.Car1 = false;
                    t.Car2 = false;
                    t.Car3 = false;
                    t.Car4 = false;
                    t.Car5 = false;
                    t.Car6 = false;
                    t.Car7 = false;
                    t.Car8 = false;
                    t.Car9 = false;
                    t.Car10 = false;
                    db.SubmitChanges();
                    return true;
                }
            }
            return false;
        }

        public void UpdateBookSelectedCar(int bookID, string car)
        {
            TempBookCar t = db.TempBookCars.FirstOrDefault(x => x.BookID == bookID);
            if (t != null)
            {
                t.Car1 = false;
                t.Car2 = false;
                t.Car3 = false;
                t.Car4 = false;
                t.Car5 = false;
                t.Car6 = false;
                t.Car7 = false;
                t.Car8 = false;
                t.Car9 = false;
                t.Car10 = false;
                switch (car)
                {
                    case "colCar1":
                        t.Car1 = true;
                        break;
                    case "colCar2":
                        t.Car2 = true;
                        break;
                    case "colCar3":
                        t.Car3 = true;
                        break;
                    case "colCar4":
                        t.Car4 = true;
                        break;
                    case "colCar5":
                        t.Car5 = true;
                        break;
                    case "colCar6":
                        t.Car6 = true;
                        break;
                    case "colCar7":
                        t.Car7 = true;
                        break;
                    case "colCar8":
                        t.Car8 = true;
                        break;
                    case "colCar9":
                        t.Car9 = true;
                        break;
                    case "colCar10":
                        t.Car10 = true;
                        break;
                }

                db.SubmitChanges();
            }
        }
    }
}
