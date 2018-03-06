using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class StaffService
    {
        private readonly KimTravelDataDataContext db = new KimTravelDataDataContext();

        public IQueryable GetList()
        {
            var kindStaff = Constant.getListKindStaff();
            var statusStaff = Constant.getListStatusStaff();
            IQueryable data = from s in db.Staffs
                              from p in db.Partners.Where(x => x.PartnerID == s.PartnerID).DefaultIfEmpty()
                              select new
                              {
                                  s.ID,
                                  s.Name,
                                  s.Address,
                                  s.Phone,
                                  s.PartnerID,
                                  PName = p.Name,
                                  Status = s.Status == 1 ? statusStaff[0].Name : s.Status == 2 ? statusStaff[0].Name : statusStaff[0].Name,
                                  Kind = s.Kind == 1 ? kindStaff[4].Name : s.Kind == 2 ? kindStaff[0].Name : s.Kind == 3 ? kindStaff[1].Name : s.Kind == 4 ? kindStaff[2].Name : kindStaff[3].Name,
                                  s.Note,
                                  s.PSID
                              };

            return data;
        }

        public Staff GetByID(int id)
        {
            Staff data = db.Staffs.FirstOrDefault(x => x.ID == id);

            return data;
        }

        public IQueryable GetStaffTaiXe()
        {
            IQueryable data = from s in db.Staffs
                              where s.Status == 1 && (s.Kind == 4 || s.Kind == 5)
                              select new
                              {
                                  s.ID,
                                  s.Name,
                              };

            return data;
        }

        public bool Insert(Staff obj)
        {
            bool checkName = db.Staffs.Count(x => x.PSID == obj.PSID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkName)
            {
                if (obj.PartnerID == -1)
                    obj.PartnerID = null;
                db.Staffs.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(Staff obj)
        {
            bool checkUName = db.Staffs.Count(x => x.PSID == obj.PSID && x.ID != obj.ID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkUName)
            {
                Staff currObject = db.Staffs.FirstOrDefault(x => x.ID == obj.ID);
                if (currObject != null)
                {
                    if (obj.PartnerID == -1)
                        currObject.PartnerID = null;
                    else
                        currObject.PartnerID = obj.PartnerID;
                    currObject.Name = obj.Name;
                    currObject.Address = obj.Address;
                    currObject.Phone = obj.Phone;
                    currObject.Status = obj.Status;
                    currObject.Kind = obj.Kind;
                    currObject.Note = obj.Note;
                    currObject.PSID = obj.PSID;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            Staff currObject = db.Staffs.FirstOrDefault(x => x.ID == id);
            if (currObject != null)
            {
                db.Staffs.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
