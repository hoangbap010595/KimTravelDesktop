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
        private readonly KimTravelDataContext db = new KimTravelDataContext(AppConfig.getStringConnection());

        public IQueryable GetList()
        {
            IQueryable data = from c in db.Cars
                              join t in db.CarTypes on c.Type equals t.ID
                              join s in db.Staffs on c.StaffID equals s.ID
                              select new
                              {
                                  c.CarID,
                                  c.Code,
                                  c.Max,
                                  Type = t.TypeName,
                                  c.StaffID,
                                  s.Name,
                                  c.Note
                              };

            return data;
        }

        public Car GetByID(int id)
        {
            Car data = db.Cars.FirstOrDefault(x => x.CarID == id);
            return data;
        }
        public string GetCode(int staffId)
        {
            Car data = db.Cars.FirstOrDefault(x => x.StaffID == staffId);
            if (data == null)
                return "";
            return data.Code;
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
            if (!checkUName)
            {
                Car currObject = db.Cars.FirstOrDefault(x => x.CarID == obj.CarID);
                if (currObject != null)
                {
                    currObject.Code = obj.Code;
                    currObject.Type = obj.Type;
                    currObject.Max = obj.Max;
                    currObject.StaffID = obj.StaffID;
                    currObject.Note = obj.Note;
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
