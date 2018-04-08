using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class TourService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext();

        public IQueryable GetList()
        {
            IQueryable data = from t in db.Tours
                              join g in db.GroupTours on t.GroupID equals g.GroupID
                              orderby t.Name
                              select new
                              {
                                  t.TourID,
                                  t.Name,
                                  //t.PriceReceive,
                                  t.PriceSale,
                                  t.PriceSaleChild,
                                  t.PriceVTQ,
                                  t.Enable,
                                  t.DateCreate,
                                  GName = g.Name
                              };

            return data;
        }
        public IQueryable GetList(int gID)
        {
            IQueryable data = from t in db.Tours
                              join g in db.GroupTours on t.GroupID equals g.GroupID
                              where g.GroupID == gID
                              orderby t.Name
                              select new
                              {
                                  t.TourID,
                                  t.Name,
                                  //t.PriceReceive,
                                  t.PriceSale,
                                  t.PriceSaleChild,
                                  t.PriceVTQ,
                                  t.Enable,
                                  t.DateCreate,
                                  GName = g.Name
                              };

            return data;
        }
        public IEnumerable<Tour> GetListCobobox()
        {
            IEnumerable<Tour> data = db.Tours.Where(x => x.Enable == true).OrderBy(x => x.Name).OrderBy(x => x.GroupID);
            return data;
        }

        public IQueryable GetListForGroup(int GroupID)
        {
            IQueryable data = from t in db.Tours
                              join g in db.GroupTours on t.GroupID equals g.GroupID
                              where t.GroupID == GroupID && t.Enable == true
                              orderby t.Name
                              select new
                              {
                                  t.TourID,
                                  t.Name
                              };

            return data;
        }

        public Tour GetByID(int id)
        {
            Tour data = db.Tours.FirstOrDefault(x => x.TourID == id);
            return data;
        }

        public bool Insert(Tour gTour)
        {
            bool checkName = db.Tours.Count(x => x.Name == gTour.Name && x.GroupID != gTour.GroupID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkName)
            {
                gTour.DateCreate = DateTime.Now;
                db.Tours.InsertOnSubmit(gTour);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(Tour gTour)
        {
            bool checkUName = db.Tours.Count(x => x.Name == gTour.Name && x.GroupID == gTour.GroupID && x.TourID != gTour.TourID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkUName)
            {
                Tour currObject = db.Tours.FirstOrDefault(x => x.TourID == gTour.TourID);
                if (currObject != null)
                {
                    currObject.Name = gTour.Name;
                    currObject.GroupID = gTour.GroupID;
                    currObject.Enable = gTour.Enable;
                    currObject.PriceSale = gTour.PriceSale;
                    currObject.PriceVTQ = gTour.PriceVTQ;
                    currObject.PriceSaleChild = gTour.PriceSaleChild;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Tour currObject = db.Tours.FirstOrDefault(x => x.TourID == id);
            if (currObject != null)
            {
                db.Tours.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
