using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class CarService
    {
        private readonly KimTravelDataDataContext db = new KimTravelDataDataContext();

        public IQueryable GetList()
        {
            var kindCar = Constant.getListKindCar();
            IQueryable data = from c in db.Cars
                              from s in db.Staffs.Where(x => (x.Kind == 4 || x.Kind == 5) && x.Status == 1).DefaultIfEmpty()
                              select new
                              {
                                  c.CarID,
                                  c.Code,
                                  c.Max,
                                  Type = c.Type == 1 ? kindCar[0].Name : c.Type == 2 ? kindCar[1].Name : kindCar[2].Name,
                                  c.StaffID,
                                  s.Name
                              };

            return data;
        }

        public Car GetByID(int id)
        {
            Car data = db.Cars.FirstOrDefault(x => x.CarID == id);
            return data;
        }

        public bool Insert(Car obj)
        {
            bool checkName = db.Cars.Count(x => x.Code == obj.Code) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkName)
            {
                db.Cars.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(Car obj)
        {
            bool checkUName = db.Cars.Count(x => x.Code == obj.Code && x.CarID != obj.CarID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (checkUName)
            {
                Car currObject = db.Cars.FirstOrDefault(x => x.CarID == obj.CarID);
                if (currObject != null)
                {
                    currObject.Code = obj.Code;
                    currObject.Type = obj.Type;
                    currObject.Max = obj.Max;
                    currObject.StaffID = obj.StaffID;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Car currObject = db.Cars.FirstOrDefault(x => x.CarID == id);
            if (currObject != null)
            {
                db.Cars.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
