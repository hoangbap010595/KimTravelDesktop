using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class CarTypeService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext(AppConfig.getStringConnection());

        public IQueryable GetList()
        {
            IQueryable data = from c in db.CarTypes                       
                              select new
                              {
                                  c.ID,c.Enable,c.TypeName
                              };

            return data;
        }
        public IQueryable GetListCobobox()
        {
            IQueryable data = from c in db.CarTypes
                              where c.Enable == true
                              select new
                              {
                                  c.ID,
                                  c.Enable,
                                  c.TypeName
                              };

            return data;
        }
        public CarType GetByID(int id)
        {
            CarType data = db.CarTypes.FirstOrDefault(x => x.ID == id);
            return data;
        }

        public bool Insert(CarType obj)
        {
            bool checkName = db.CarTypes.Count(x => x.TypeName == obj.TypeName) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkName)
            {
                db.CarTypes.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(CarType obj)
        {
            bool checkUName = db.CarTypes.Count(x => x.TypeName == obj.TypeName && x.ID != obj.ID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (checkUName)
            {
                CarType currObject = db.CarTypes.FirstOrDefault(x => x.ID == obj.ID);
                if (currObject != null)
                {
                    currObject.TypeName = obj.TypeName;
                    currObject.Enable = obj.Enable;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            CarType currObject = db.CarTypes.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                db.CarTypes.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
