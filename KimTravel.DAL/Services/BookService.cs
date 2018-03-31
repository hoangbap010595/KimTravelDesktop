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
                                    p.Name
                                }).GroupBy(x => x.PartnerID).Select(o => new { ID = o.Key, Count = o.Count(), Total = o.Sum(x => x.Total) })).Join(db.Partners, O1 => O1.ID, O2 => O2.PartnerID, (O1, O2) => new { ID = O1.ID, PartnerName = O2.Name, Count = O1.Count, Total = O1.Total });

            return data;
        }
        /// <summary>
        /// Lấy danh sách đã book chưa được sắp xe
        /// </summary>
        /// <param name="groupID"></param>
        /// <param name="dateStart"></param>
        /// <param name="isBooked"></param>
        /// <returns></returns>
        public IQueryable GetListBookedNotInCar(int groupID, string dateStart, bool isBooked = false, bool isCancel = false)
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
                                    b.Pax
                                }).GroupBy(x => x.TourID)
                                .Select(o => new { ID = o.Key, Total = o.Sum(x => x.Pax) }))
                                .Join(db.Tours, O1 => O1.ID, O2 => O2.TourID, (O1, O2) => new { TourID = O1.ID, TourName = O2.Name, Pax = O1.Total });

            return data;
        }
        public IEnumerable<BookTourModel> GetListBookedDoneReport(int partnerID, int groupID, int month, int year, bool? isPayment = true, bool isBooked = true)
        {
            IEnumerable<BookTourModel> data = null;
            if (isPayment == null)
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsBooked == isBooked && b.PartnerID == partnerID && g.GroupID == groupID
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
                       where b.IsPayment == isPayment && b.IsBooked == isBooked && b.PartnerID == partnerID && g.GroupID == groupID
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
        public IQueryable GetListBookedDone(int partnerID, int groupID, int month, int year, bool? isPayment = true, bool isBooked = true)
        {
            IQueryable data = null;
            if (isPayment == null)
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsBooked == isBooked && b.PartnerID == partnerID && g.GroupID == groupID
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
            else
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsPayment == isPayment && b.IsBooked == isBooked && b.PartnerID == partnerID && g.GroupID == groupID
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
        public IQueryable GetListBookedDoneAllParnert(int groupID, int month, int year, bool? isPayment = true, bool isBooked = true)
        {
            IQueryable data = null;
            if (isPayment == null)
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsBooked == isBooked && g.GroupID == groupID
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
            else
            {
                data = from b in db.Books
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       join t in db.Tours on b.TourID equals t.TourID
                       join g in db.GroupTours on t.GroupID equals g.GroupID
                       where b.IsPayment == isPayment && b.IsBooked == isBooked && g.GroupID == groupID
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
                              where b.IsCancel == isCancel && b.IsBooked != true
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
                                    && b.IsBooked != true
                              orderby p.Address, p.Line
                              select new
                              {
                                  b.ID,
                                  TourName = t.Name,
                                  b.CustomName,
                                  b.PickUp,
                                  b.Room,
                                  b.Pax,
                                  PartnerName = p.Name,
                                  SaleBook = b.StaffID,
                                  b.ServiceName
                              };

            return data;
        }
        public IQueryable GetListBooked(int tourID, string dateS, bool isCancel = false)
        {
            DateTime date = DateTime.Parse(dateS);
            IQueryable data = from b in db.Books
                              join t in db.Tours on b.TourID equals t.TourID
                              from p in db.Partners.Where(x => x.PartnerID == b.PartnerID)
                              where b.TourID == tourID
                                    && b.StartDate.Value == date
                                    && b.IsCancel == isCancel
                                    && b.IsBooked != true
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
        public Dictionary<string, object> getInfoBooked(int groupID, int tourID, string SDate)
        {
            var date1 = DateTime.Parse(SDate);
            Dictionary<string, object> dataResult = new Dictionary<string, object>();
            var data = (from b in db.Books
                        join t in db.Tours on b.TourID equals t.TourID
                        join g in db.GroupTours on t.GroupID equals g.GroupID
                        where b.TourID == tourID && b.StartDate.Value == date1 && b.IsCancel == false && b.IsBooked != true
                        select new
                        {
                            b
                        }).Sum(x => x.b.Pax);

            var maxG = db.GroupTours.FirstOrDefault(x => x.GroupID == groupID).MaxPax;

            dataResult.Add("MaxPax", maxG == null ? 0 : maxG);
            dataResult.Add("CurrentTotal", data == null ? 0 : data);

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
                obj.DateCreate = DateTime.Now;
                db.Books.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            catch
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
