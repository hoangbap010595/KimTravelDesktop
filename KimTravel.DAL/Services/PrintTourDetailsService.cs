using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class PrintTourDetailsService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext();

        public IQueryable GetList(int parentID)
        {
            var data = from d in db.DetailPrintTours
                       join b in db.Books on d.BookID equals b.ID
                       join p in db.Partners on b.PartnerID equals p.PartnerID
                       where d.PrintID == parentID
                       orderby p.Address, p.Line
                       select new
                       {
                           DetailID = d.ID,
                           BookID = b.ID,
                           b.Pax,
                           b.PickUp,
                           b.Room,
                           b.PartnerPrice,
                           b.Note
                       };
            return data;
        }

        public DetailPrintTour GetByID(int id)
        {
            DetailPrintTour data = db.DetailPrintTours.FirstOrDefault(x => x.ID == id);
            return data;
        }

        public bool Insert(DetailPrintTour obj)
        {
            db.DetailPrintTours.InsertOnSubmit(obj);
            db.SubmitChanges();
            return true;
        }

        public bool DeletePrintParent(int parentID)
        {
            IEnumerable<DetailPrintTour> currObject = db.DetailPrintTours.Where(x => x.PrintID == parentID);
            if (currObject != null)
            {
                db.DetailPrintTours.DeleteAllOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            DetailPrintTour currObject = db.DetailPrintTours.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                db.DetailPrintTours.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
