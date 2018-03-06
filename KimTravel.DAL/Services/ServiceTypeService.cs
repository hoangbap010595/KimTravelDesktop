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
        private readonly KimTravelDataDataContext db = new KimTravelDataDataContext();

        public IEnumerable<ServiceType> GetList()
        {
            IEnumerable<ServiceType> data = db.ServiceTypes.ToList();

            return data;
        }

        public bool Insert(ServiceType obj)
        {
            bool checkName = db.ServiceTypes.Count(x => x.Name == obj.Name) > 0 ? true : false;
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
            bool checkUName = db.ServiceTypes.Count(x => x.Name == obj.Name && x.ID != obj.ID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (checkUName)
            {
                ServiceType currObject = db.ServiceTypes.FirstOrDefault(x => x.ID == obj.ID);
                if (currObject != null)
                {
                    currObject.ID = obj.ID;
                    currObject.Price = obj.Price;
                    currObject.HotelID = obj.HotelID;
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
