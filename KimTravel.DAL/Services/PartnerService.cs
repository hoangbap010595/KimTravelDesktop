using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Entity;
using System.Linq;
using KimTravel.DAL.Models;

namespace KimTravel.DAL.Services
{
    public class PartnerService
    {
        private KimTravelDataDataContext db = new KimTravelDataDataContext();

        public IQueryable GetList()
        {
            IQueryable data = from p in db.Partners
                              select new
                              {
                                  p.PartnerID,
                                  p.PartnerCode,
                                  p.Name,
                                  p.Address,
                                  p.Phone,
                                  p.Note,
                                  Status = p.Status == 1 ? "Bình thường" : "Ngưng hợp tác"
                              };
            return data;
        }
        public Partner GetByID(int id)
        {
            Partner data = db.Partners.FirstOrDefault(x=>x.PartnerID == id);

            return data;
        }

        public bool Insert(Partner obj)
        {
            bool checkName = db.Partners.Count(x => x.Name == obj.Name) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkName)
            {
                db.Partners.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(Partner obj)
        {
            bool checkUName = db.Partners.Count(x => x.Name == obj.Name && x.PartnerID != obj.PartnerID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkUName)
            {
                Partner currObject = db.Partners.FirstOrDefault(x => x.PartnerID == obj.PartnerID);
                if (currObject != null)
                {
                    currObject.Name = obj.Name;
                    currObject.PartnerCode = obj.PartnerCode;
                    currObject.Address = obj.Address;
                    currObject.Phone = obj.Phone;
                    currObject.Status = obj.Status;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Partner currObject = db.Partners.FirstOrDefault(x => x.PartnerID == id);
            if (currObject != null)
            {
                db.Partners.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
