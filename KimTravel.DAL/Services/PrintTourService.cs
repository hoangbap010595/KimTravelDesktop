using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class PrintTourService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext(AppConfig.getStringConnection());

        public IQueryable GetList()
        {
            var data = from p in db.PrintTours
                       join t in db.Tours on p.TourID equals t.TourID
                       from s1 in db.Staffs.Where(x => x.ID == p.Guide1).DefaultIfEmpty()
                       from s2 in db.Staffs.Where(x => x.ID == p.Driver1).DefaultIfEmpty()
                       orderby p.DateStart
                       select new
                       {
                           p.ID,
                           p.OrganizationID,
                           p.TourID,
                           t.Name,
                           p.DateStart,
                           Guide1 = s1.Name,
                           p.Guide2,
                           Driver1 = s2.Name,
                           p.Driver2,
                           p.CarCode,
                           p.DatePrint,
                           p.TotalPax
                       };
            return data;
        }
        public IQueryable GetList(int tID)
        {
            var data = from p in db.PrintTours
                       join t in db.Tours on p.TourID equals t.TourID
                       from s1 in db.Staffs.Where(x => x.ID == p.Guide1).DefaultIfEmpty()
                       from s2 in db.Staffs.Where(x => x.ID == p.Driver1).DefaultIfEmpty()
                       where t.TourID == tID
                       orderby p.DateStart
                       select new
                       {
                           p.ID,
                           p.OrganizationID,
                           p.TourID,
                           t.Name,
                           p.DateStart,
                           Guide1 = s1.ID,
                           GuideName1 = s1.Name,
                           p.Guide2,
                           Driver1 = s2.ID,
                           DriverName1 = s2.Name,
                           p.Driver2,
                           p.CarCode,
                           p.DatePrint,
                           p.TotalPax
                       };
            return data;
        }
        public IQueryable GetList(string dateStart)
        {
            DateTime date = DateTime.Parse(dateStart);
            var data = from p in db.PrintTours
                       join t in db.Tours on p.TourID equals t.TourID
                       from s1 in db.Staffs.Where(x => x.ID == p.Guide1).DefaultIfEmpty()
                       from s2 in db.Staffs.Where(x => x.ID == p.Driver1).DefaultIfEmpty()
                       where p.DateStart == date
                       orderby p.DateStart
                       select new
                       {
                           p.ID,
                           //p.OrganizationID,
                           p.TourID,
                           t.Name,
                           p.DateStart,
                           Guide1 = p.Guide1 == 0 ? 0 : s1.ID,
                           GuideName1 = p.Guide1 == 0 ? "" : s1.Name,
                           p.Guide2,
                           Driver1 = p.Driver1 == 0 ? 0 : s2.ID,
                           DriverName1 = p.Driver1 == 0 ? "" : s2.Name,
                           p.Driver2,
                           p.CarCode,
                           p.DatePrint,
                           p.TotalPax
                       };
            return data;
        }
        public IQueryable GetList(int tID, string dateStart)
        {
            DateTime date = DateTime.Parse(dateStart);
            var data = from p in db.PrintTours
                       join t in db.Tours on p.TourID equals t.TourID
                       from s1 in db.Staffs.Where(x => x.ID == p.Guide1).DefaultIfEmpty()
                       from s2 in db.Staffs.Where(x => x.ID == p.Driver1).DefaultIfEmpty()
                       where t.TourID == tID && p.DateStart == date
                       orderby p.DateStart
                       select new
                       {
                           p.ID,
                           p.OrganizationID,
                           p.TourID,
                           t.Name,
                           p.DateStart,
                           Guide1 = s1.ID,
                           GuideName1 = s1.Name,
                           p.Guide2,
                           Driver1 = s2.ID,
                           DriverName1 = s2.Name,
                           p.Driver2,
                           p.CarCode,
                           p.DatePrint,
                           p.TotalPax
                       };
            return data;
        }
        public PrintTour GetByID(int id)
        {
            PrintTour data = db.PrintTours.FirstOrDefault(x => x.ID == id);
            return data;
        }

        public int Insert(PrintTour obj)
        {
            db.PrintTours.InsertOnSubmit(obj);
            db.SubmitChanges();
            return obj.ID;
        }

        public bool Update(PrintTour obj)
        {
            PrintTour currObject = db.PrintTours.FirstOrDefault(x => x.ID == obj.ID);
            if (currObject != null)
            {
                currObject.OrganizationID = obj.OrganizationID;
                currObject.TourID = obj.TourID;
                currObject.DateStart = obj.DateStart;
                currObject.Guide1 = obj.Guide1;
                currObject.Guide2 = obj.Guide2;
                currObject.Driver1 = obj.Driver1;
                currObject.Driver2 = obj.Driver2;
                currObject.CarCode = obj.CarCode;
                currObject.DatePrint = obj.DatePrint;
                currObject.TotalPax = obj.TotalPax;

                db.SubmitChanges();
            }
            return true;
        }

        public bool Delete(int id)
        {
            PrintTour currObject = db.PrintTours.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                db.PrintTours.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
