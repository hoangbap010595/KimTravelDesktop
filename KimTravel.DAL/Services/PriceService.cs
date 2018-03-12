using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class PriceService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext();

        public IQueryable GetList()
        {
            var data = from p in db.Prices
                       from g in db.GroupPartners.Where(x => x.GroupPartnerID == p.GroupID).DefaultIfEmpty()
                       from t in db.Tours.Where(x => x.TourID == p.TourID).DefaultIfEmpty()
                       orderby t.Name
                       orderby p.GroupID
                       select new
                       {
                           p.Key,
                           p.GroupID,
                           p.TourID,
                           p.PriceRe,
                           g.GroupName,
                           t.Name
                       };
            return data;
        }
        public Price GetByID(int id)
        {
            Price data = db.Prices.FirstOrDefault(x => x.Key == id);
            return data;
        }
        public string GetPriceForPartner(int partnerID, int tourID)
        {
            int rs = 0;
            try
            {
                int gID = db.Partners.FirstOrDefault(x => x.PartnerID == partnerID).GroupID.Value;
                rs = db.Prices.FirstOrDefault(x => x.GroupID == gID && x.TourID == tourID).PriceRe.Value;
            }
            catch
            {
                rs = 0;
            }
            return rs.ToString();
        }
        public bool Insert(Price obj)
        {
            bool checkName = db.Prices.Count(x => x.GroupID == obj.GroupID && x.TourID == obj.TourID) > 0 ? true : false;
            if (!checkName)
            {
                db.Prices.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(Price obj)
        {
            bool checkUName = db.Prices.Count(x => x.GroupID == obj.GroupID && x.TourID == obj.TourID && x.Key != obj.Key) > 0 ? true : false;
            if (!checkUName)
            {
                Price currObject = db.Prices.FirstOrDefault(x => x.Key == obj.Key);
                if (currObject != null)
                {
                    currObject.GroupID = obj.GroupID;
                    currObject.TourID = obj.TourID;
                    currObject.PriceRe = obj.PriceRe;
                    // currObject.GroupID = obj.GroupID;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Price currObject = db.Prices.FirstOrDefault(x => x.Key == id);
            if (currObject != null)
            {
                db.Prices.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
