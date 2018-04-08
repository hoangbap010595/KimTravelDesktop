using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class ServiceTypeService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext();

        public IEnumerable<ServiceType> GetList(int tourID)
        {
            IEnumerable<ServiceType> data = db.ServiceTypes.Where(x=>x.TourID == tourID).ToList();

            return data;
        }
        public ServiceType GetByID(int id)
        {
            ServiceType data = db.ServiceTypes.FirstOrDefault(x=>x.ID == id);

            return data;
        }
        public IQueryable GetListFind(string content, int TourID)
        {
            IQueryable data = from p in db.ServiceTypes
                              where p.Name.Contains(content) && p.TourID == TourID
                              select new
                              {
                                 p.ID,p.Name,p.Price,p.TourID
                              };
            return data;
        }
        public bool Insert(ServiceType obj)
        {
            bool checkName = db.ServiceTypes.Count(x => x.Name == obj.Name && x.TourID == obj.TourID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkName)
            {
                db.ServiceTypes.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(ServiceType obj)
        {
            bool checkUName = db.ServiceTypes.Count(x => x.Name == obj.Name && x.TourID == obj.TourID && x.ID != obj.ID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkUName)
            {
                ServiceType currObject = db.ServiceTypes.FirstOrDefault(x => x.ID == obj.ID);
                if (currObject != null)
                {
                    currObject.ID = obj.ID;
                    currObject.Price = obj.Price;
                    currObject.TourID = obj.TourID;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            ServiceType currObject = db.ServiceTypes.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                db.ServiceTypes.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
