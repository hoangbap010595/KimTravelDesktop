using KimTravel.DAL.BindModels;
using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class BookService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext();
        private readonly ApplicationUserService uService = new ApplicationUserService();
        public IEnumerable<PartnerBookTourModel> GetListBookedDoneReportPartner(int partnerID, int month, int year, bool isBooked = true)
        {
            var test = uService.GetPartnerViewReport(Constant.CurrentSessionUser);
            var temp = test.Split(',');
            List<int> lsPartner = new List<int>();
            foreach (var item in temp)
            {
                if (item != "")
                    lsPartner.Add(int.Parse(item));
            }
            IEnumerable<PartnerBookTourModel> data = from b in db.Books
                                                     join p in db.Partners on b.PartnerID equals p.PartnerID
                                                     join t in db.Tours on b.TourID equals t.TourID
                                                     join g in db.GroupTours on t.GroupID equals g.GroupID
                                                     where lsPartner.Contains((int)b.PartnerID) && b.IsBooked == isBooked && b.PartnerID == partnerID
                                                           && b.StartDate.Value.Month == month && b.StartDate.Value.Year == year
                                                     orderby p.Address, p.Line
                                                     select new PartnerBookTourModel
                                                     {
                                                         ID = b.ID,
                                                         GroupName = g.Name,
                                                         TourName = t.Name,
                                                         StartDate = b.StartDate,
                                                         Pax = b.Pax,
                                                         Room = b.Room,
                                                         Price = b.PriceReceive,
                                                         SaleBook = b.StaffID,
                                                         Note = b.Note,
                                                         Total = b.Total
                                                     };

            return data;
        }
        /// <summary>
        /// Báo cáo xem theo đối tác
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="isBooked"></param>
        /// <returns></returns>
        public IQueryable GetListBookedDoneReportPartner(int month, int year, bool isBooked = true)
        {
            var test = uService.GetPartnerViewReport(Constant.CurrentSessionUser);
            var temp = test.Split(',');
            List<int> lsPartner = new List<int>();
            foreach (var item in temp)
            {
                if (item != "")
                    lsPartner.Add(int.Parse(item));
            }
            IQueryable data = ((from b in db.Books
                                join p in db.Partners on b.PartnerID equals p.PartnerID
                                join t in db.Tours on b.TourID equals t.TourID
                                join g in db.GroupTours on t.GroupID equals g.GroupID
                                where lsPartner.Contains((int)b.PartnerID) && b.IsBooked == isBooked && b.StartDate.Value.Month == month && b.StartDate.Value.Year == year
                                orderby p.Address, p.Line
                                select new
                                {
                                    b.ID,
                                    b.PartnerID,
                                    b.Total,
                                    b.Pax,
                                    Payment = b.IsPayment == true ? b.Total : 0,
                                    NotPayment = b.IsPayment == false ? b.Total : 0,
                                    p.Name
                                }).GroupBy(x => x.PartnerID).Select(o => new { ID = o.Key, CountPax = o.Sum(x => x.Pax), Payment = o.Sum(x => x.Payment), NotPayment = o.Sum(x => x.NotPayment) })).Join(db.Partners, O1 => O1.ID, O2 => O2.PartnerID, (O1, O2) => new { ID = O1.ID, PartnerName = O2.Name, CountPax = O1.CountPax, Payment = O1.Payment, NotPayment = O1.NotPayment });

            return data;
        }
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
        public IEnumerable<BookTourModel> GetListBookedDoneReport(int partnerID, int month, int year, bool? isPayment = true, bool isBooked = true)
        {
            IEnumerable<BookTourModel> data = null;
            if (isPayment == null)
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsBooked == isBooked && b.PartnerID == partnerID
                             && b.StartDate.Value.Month == month && b.StartDate.Value.Year == year
                       orderby b.StartDate
                       select new BookTourModel
                       {
                           ID = b.ID,
                           TourName = t.Name,
                           StartDate = b.StartDate,
                           Pax = b.Pax,
                           Room = b.Room,
                           Price = b.PriceReceive,
                           SaleBook = b.StaffID,
                           Note = b.Note,
                           Total = b.Total
                       };
            }
            else
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsPayment == isPayment && b.IsBooked == isBooked && b.PartnerID == partnerID
                             && b.StartDate.Value.Month == month && b.StartDate.Value.Year == year
                       orderby b.StartDate
                       select new BookTourModel
                       {
                           ID = b.ID,
                           TourName = t.Name,
                           StartDate = b.StartDate,
                           Pax = b.Pax,
                           Room = b.Room,
                           Price = b.PriceReceive,
                           SaleBook = b.StaffID,
                           Note = b.Note,
                           Total = b.Total
                       };
            }
            return data;
        }
        public IQueryable GetListBookedDone(int partnerID, int month, int year, bool? isPayment = true, bool isBooked = true)
        {
            IQueryable data = null;
            if (isPayment == null)
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsBooked == isBooked && b.PartnerID == partnerID
                             && b.StartDate.Value.Month == month && b.StartDate.Value.Year == year
                       orderby b.StartDate
                       select new
                       {
                           b.ID,
                           t.TourID,
                           TourName = t.Name,
                           ParnerID = p.PartnerID,
                           PartnerName = p.Name,
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
                           b.IsPayment,
                           b.DatePayment,
                           b.ServiceName,
                           b.IsCancel
                       };
            }
            else
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsPayment == isPayment && b.IsBooked == isBooked && b.PartnerID == partnerID
                             && b.StartDate.Value.Month == month && b.StartDate.Value.Year == year
                       orderby b.StartDate
                       select new
                       {
                           b.ID,
                           t.TourID,
                           TourName = t.Name,
                           ParnerID = p.PartnerID,
                           PartnerName = p.Name,
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
                           b.IsPayment,
                           b.DatePayment,
                           b.ServiceName,
                           b.IsCancel
                       };
            }
            return data;
        }
        public IQueryable GetListBookedDoneAllParnert(int month, int year, bool? isPayment = true, bool isBooked = true)
        {
            IQueryable data = null;
            if (isPayment == null)
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsBooked == isBooked
                             && b.StartDate.Value.Month == month && b.StartDate.Value.Year == year
                       orderby b.StartDate
                       select new
                       {
                           b.ID,
                           t.TourID,
                           TourName = t.Name,
                           ParnerID = p.PartnerID,
                           PartnerName = p.Name,
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
                           b.IsPayment,
                           b.DatePayment,
                           b.ServiceName,
                           b.IsCancel
                       };
            }
            else
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsPayment == isPayment && b.IsBooked == isBooked
                             && b.StartDate.Value.Month == month && b.StartDate.Value.Year == year
                       orderby b.StartDate
                       select new
                       {
                           b.ID,
                           t.TourID,
                           TourName = t.Name,
                           ParnerID = p.PartnerID,
                           PartnerName = p.Name,
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
                           b.IsPayment,
                           b.DatePayment,
                           b.ServiceName
                       };
            }
            return data;
        }
        public IQueryable GetList(bool isCancel = false)
        {
            IQueryable data = from b in db.Books
                              join t in db.Tours on b.TourID equals t.TourID
                              join g in db.GroupTours on t.GroupID equals g.GroupID
                              from p in db.Partners.Where(x => x.PartnerID == b.PartnerID)
                              where b.IsCancel == isCancel && b.IsBooked == true
                              orderby b.StartDate, p.Address, p.Line
                              select new
                              {
                                  b.ID,
                                  t.TourID,
                                  TourName = t.Name,
                                  g.GroupID,
                                  GroupName = g.Name,
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
                                  b.ServiceName
                              };

            return data;
        }
        public IQueryable GetList(int partnerID, string dateS, bool isCancel = false)
        {
            DateTime date = DateTime.Parse(dateS);
            IQueryable data = from b in db.Books
                              join t in db.Tours on b.TourID equals t.TourID
                              join g in db.GroupTours on t.GroupID equals g.GroupID
                              from p in db.Partners.Where(x => x.PartnerID == b.PartnerID)
                              where b.PartnerID == partnerID && b.StartDate.Value == date
                                    && b.IsCancel == isCancel
                                    && b.IsBooked == true
                              orderby p.Address, p.Line
                              select new
                              {
                                  b.ID,
                                  TourName = t.Name,
                                  b.CustomName,
                                  b.PickUp,
                                  b.Room,
                                  b.Pax,
                                  b.PartnerPrice,
                                  PartnerName = p.Name,
                                  SaleBook = b.StaffID,
                                  b.ServiceName
                              };

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
                                  t.TourID,
                                  TourName = t.Name,
                                  ParnerID = p.PartnerID,
                                  PartName = p.Name,
                                  BookID = b.ID,
                                  b.StartDate,
                                  b.EndDate,
                                  b.Pax,
                                  b.PaxChild,
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
                                  b.ServiceName
                              };

            return data;
        }
        /// <summary>
        /// Lây tất cả danh sách đã book ko theo tour
        /// Lọc theo ngày tạo
        /// </summary>
        /// <param name="dateS"></param>
        /// <param name="isCancel"></param>
        /// <returns></returns>
        public IQueryable GetListBooked(string dateS, bool isCancel = false)
        {
            DateTime date = DateTime.Parse(dateS);
            DateTime date2 = DateTime.Parse(dateS).AddDays(1);
            IQueryable data = from b in db.Books
                              join t in db.Tours on b.TourID equals t.TourID
                              from p in db.Partners.Where(x => x.PartnerID == b.PartnerID)
                              where b.DateCreate.Value >= date && b.DateCreate.Value < date2
                                    && b.IsCancel == isCancel
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
                                  b.DoneBy
                              };

            return data;
        }
        public Dictionary<string, object> getInfoBooked(int tourID, string SDate)
        {
            var date1 = DateTime.Parse(SDate);
            Dictionary<string, object> dataResult = new Dictionary<string, object>();
            var data = (from b in db.Books
                        join t in db.Tours on b.TourID equals t.TourID
                        where b.TourID == tourID && b.StartDate.Value == date1 && b.IsCancel == false && b.IsBooked == true
                        select new
                        {
                            b
                        }).Sum(x => x.b.Pax);
            var paxPickup = data == null ? 0 : data;
            Tour tour = db.Tours.FirstOrDefault(x => x.TourID == tourID);
            var minPax = tour.MinPax == null ? 0 : tour.MinPax;
            var maxPax = tour.MaxPax == null ? 0 : tour.MaxPax;
            var allowPick = maxPax - paxPickup;

            dataResult.Add("MinPax", minPax);
            dataResult.Add("MaxPax", maxPax);
            dataResult.Add("AllowPick", allowPick);
            dataResult.Add("CurrentTotal", paxPickup);

            return dataResult;
        }
        public Book GetByID(int id)
        {
            Book data = db.Books.FirstOrDefault(x => x.ID == id);

            return data;
        }
        public bool Insert(Book obj)
        {
            try
            {
                if (obj.IsBooked == true)
                    obj.FinishDate = DateTime.Now;
                obj.DateCreate = DateTime.Now;
                db.Books.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateBookPayment(int id, bool isPayment)
        {
            Book currObject = db.Books.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                currObject.IsPayment = isPayment;
                if (isPayment)
                    currObject.DatePayment = DateTime.Now;
                else
                    currObject.DatePayment = null;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateBookCancel(int id, bool isCancel)
        {
            Book currObject = db.Books.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                currObject.IsCancel = isCancel;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool UpdateBooked(int id, bool isBooked)
        {
            Book currObject = db.Books.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                currObject.IsBooked = isBooked;
                if (isBooked)
                    currObject.FinishDate = DateTime.Now;
                else
                    currObject.FinishDate = null;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool UpdateDone(int id, bool isDone, string doneBy)
        {
            Book currObject = db.Books.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                currObject.IsDone = isDone;
                currObject.DoneBy = doneBy;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool Update(Book obj)
        {
            Book currObject = db.Books.FirstOrDefault(x => x.ID == obj.ID);
            if (currObject != null)
            {
                currObject.TourID = obj.TourID;
                currObject.PartnerID = obj.PartnerID;
                currObject.StartDate = obj.StartDate;
                currObject.Pax = obj.Pax;
                currObject.StaffID = obj.StaffID;

                //Cus
                currObject.CustomName = obj.CustomName;
                currObject.Room = obj.Room;
                currObject.PickUp = obj.PickUp;

                //Tre Em
                currObject.PaxChild = obj.PaxChild;
                currObject.PriceReChild = obj.PriceReChild;

                //Service
                currObject.PartnerPrice = obj.PartnerPrice;
                currObject.PriceReceive = obj.PriceReceive;
                currObject.PriceSale = obj.PriceSale;
                currObject.PriceVTQ = obj.PriceVTQ;
                currObject.Note = obj.Note;

                currObject.ServiceType = obj.ServiceType;
                currObject.ServiceName = obj.ServiceName;
                currObject.PromotionMoney = obj.PromotionMoney;
                currObject.PromotionPercent = obj.PromotionPercent;
                currObject.Total = obj.Total;
                currObject.LastUpdate = obj.LastUpdate;
                currObject.UpdateBy = obj.UpdateBy;

                currObject.IsBooked = obj.IsBooked;
                currObject.IsPayment = obj.IsPayment;
                if (obj.IsPayment == true)
                    currObject.DatePayment = DateTime.Now;

                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            Book currObject = db.Books.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                db.Books.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
