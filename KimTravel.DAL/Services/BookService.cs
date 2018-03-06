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
        private readonly KimTravelDataDataContext db = new KimTravelDataDataContext();

        public IQueryable GetList()
        {
            IQueryable data = from b in db.Books
                              join t in db.Tours on b.TourID equals t.TourID
                              join g in db.GroupTours on t.GroupID equals g.GroupID
                              from p in db.Partners.Where(x=>x.PartnerID == b.PartnerID)
                              select new
                              {
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
                                  b.Room,b.CustomName,
                                  b.PartnerPrice,
                                  b.PriceReceive,b.PriceSale,b.PriceVTQ,
                                  b.PromotionMoney,b.PromotionPercent,
                                  b.StaffID,
                                  b.DateCreate,
                                  b.Note,
                                  b.ServiceType,b.Total
                              };

            return data;
        }
        public IQueryable GetList(int gID, int tID, string dateS, string dateE)
        {
            IQueryable data = from b in db.Books 
                              join t in db.Tours on b.TourID equals t.TourID
                              join g in db.GroupTours on t.GroupID equals g.GroupID
                              from p in db.Partners.Where(x => x.PartnerID == b.PartnerID)
                              where t.GroupID == gID && b.TourID == tID 
                                    && b.StartDate.Value.ToString("MM-dd-yyyy") == dateS
                                    && b.EndDate.Value.ToString("MM-dd-yyyy") == dateE
                              select new
                              {
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
        public Dictionary<string, object> getInfoBooked(int groupID, int tourID, string SDate, string EDate)
        {
            var date1 = DateTime.Parse(SDate);
            var date2 = DateTime.Parse(EDate);
            Dictionary<string, object> dataResult = new Dictionary<string, object>();
            var data = (from b in db.Books
                        join t in db.Tours on b.TourID equals t.TourID
                        join g in db.GroupTours on t.GroupID equals g.GroupID
                        where b.TourID == tourID && b.StartDate.Value == date2 && b.EndDate.Value == date2
                        select new
                        {
                            b,
                            t,
                            g
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

        public bool Update(Book obj)
        {
            Book currObject = db.Books.FirstOrDefault(x => x.ID == obj.ID);
            if (currObject != null)
            {

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
