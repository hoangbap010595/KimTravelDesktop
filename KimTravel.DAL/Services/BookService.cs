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

        public IQueryable GetList(bool isCancel = false)
        {
            IQueryable data = from b in db.Books
                              join t in db.Tours on b.TourID equals t.TourID
                              join g in db.GroupTours on t.GroupID equals g.GroupID
                              from p in db.Partners.Where(x => x.PartnerID == b.PartnerID)
                              where b.IsCancel == isCancel
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
                                  b.Total
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
                              select new
                              {
                                  b.ID,
                                  TourName = t.Name,
                                  b.CustomName,
                                  b.PickUp,
                                  b.Room,
                                  b.Pax
                              };

            return data;
        }
        public IQueryable GetListBooked(int gID, int tourID, string dateS, bool isCancel = false)
        {
            DateTime date = DateTime.Parse(dateS);
            IQueryable data = from b in db.Books
                              join t in db.Tours on b.TourID equals t.TourID
                              join g in db.GroupTours on t.GroupID equals g.GroupID
                              from p in db.Partners.Where(x => x.PartnerID == b.PartnerID)
                              where t.GroupID == gID && b.TourID == tourID
                                    && b.StartDate.Value == date
                                    && b.IsCancel == isCancel
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
                                  b.Total
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
                        where b.TourID == tourID && b.StartDate.Value == date1 && b.IsCancel == false
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
