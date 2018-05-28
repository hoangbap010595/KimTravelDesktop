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
        private readonly KimTravelDataContext db = new KimTravelDataContext(AppConfig.getStringConnection());
        private ApplicationUserService userService = new ApplicationUserService();
        public IQueryable GetList()
        {
            var kindStaff = Constant.getListKindStaff();
            var statusStaff = Constant.getListStatusStaff();
            var data = from s in db.Staffs
                       from p in db.Partners.Where(x => x.PartnerID == s.PartnerID).DefaultIfEmpty()
                       orderby s.PSID
                       orderby s.Name
                       orderby s.Kind
                       select new
                       {
                           s.ID,
                           s.Name,
                           s.Address,
                           s.Phone,
                           s.PartnerID,
                           PName = p.Name,
                           Status = s.Status == 1 ? statusStaff[0].Name : s.Status == 2 ? statusStaff[0].Name : statusStaff[0].Name,
                           Kind = s.Kind == 1 ? kindStaff[0].Name : s.Kind == 2 ? kindStaff[1].Name : s.Kind == 3 ? kindStaff[2].Name : s.Kind == 4 ? kindStaff[3].Name : kindStaff[4].Name,
                           s.Note,
                           s.PSID
                       };

            return data;
        }
        public IQueryable GetListFind(string content)
        {
            var kindStaff = Constant.getListKindStaff();
            var statusStaff = Constant.getListStatusStaff();
            IQueryable data = from s in db.Staffs
                              from p in db.Partners.Where(x => x.PartnerID == s.PartnerID).DefaultIfEmpty()
                              where s.Name.Contains(content)
                              orderby s.PSID
                              orderby s.Name
                              orderby s.Kind
                              select new
                              {
                                  s.ID,
                                  s.Name,
                                  s.Address,
                                  s.Phone,
                                  s.PartnerID,
                                  PName = p.Name,
                                  Status = s.Status == 1 ? statusStaff[0].Name : s.Status == 2 ? statusStaff[0].Name : statusStaff[0].Name,
                                  Kind = s.Kind == 1 ? kindStaff[0].Name : s.Kind == 2 ? kindStaff[1].Name : s.Kind == 3 ? kindStaff[2].Name : s.Kind == 4 ? kindStaff[3].Name : kindStaff[4].Name,
                                  s.Note,
                                  s.PSID
                              };
            return data;
        }
        public string GetPSID()
        {
            var data = db.Staffs.OrderByDescending(x => x.PSID).FirstOrDefault().PSID;
            var no = data == null ? "0" : data.Remove(0, 2);
            int newPSID = int.Parse(no) + 1;
            return "NV" + string.Format("{0:000000}", newPSID);
        }
        public Staff GetByID(int id)
        {
            Staff data = db.Staffs.FirstOrDefault(x => x.ID == id);

            return data;
        }
        public IQueryable GetStaffOfPartner(int partnerID)
        {
            IQueryable data = from s in db.Staffs
                              where s.Status == 1 && s.Kind == 1 && s.PartnerID == partnerID
                              select new
                              {
                                  s.ID,
                                  s.Name,
                              };

            return data;
        }
        public IQueryable GetStaffHDV()
        {
            IQueryable data = from s in db.Staffs
                              where s.Status == 1 && (s.Kind == 1 || s.Kind == 3)
                              orderby s.Name
                              select new
                              {
                                  s.ID,
                                  s.Name,
                              };

            return data;
        }
        public IQueryable GetStaffTaiXe()
        {
            IQueryable data = from s in db.Staffs
                              where s.Status == 1 && (s.Kind == 2 || s.Kind == 4)
                              orderby s.Name
                              select new
                              {
                                  s.ID,
                                  s.Name,
                              };

            return data;
        }

        public bool Insert(Staff obj,Dictionary<string,object> objAccount)
        {
            bool checkName = db.Staffs.Count(x => x.PSID == obj.PSID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkName)
            {
                if (obj.PartnerID == -1)
                    obj.PartnerID = null;
                db.Staffs.InsertOnSubmit(obj);

                if (objAccount != null)
                {
                    var staffID = obj.ID;
                    ApplicationUser user = new ApplicationUser();
                    user.Username = objAccount["Username"].ToString();
                    user.Password = HashText.GetSHA1HashData(objAccount["Password"].ToString());
                    user.Phone = obj.Phone;
                    user.Status = 1;
                    user.Locked = false;
                    user.DateCreate = DateTime.Now;
                    //user.StaffID = staffID;
                    db.ApplicationUsers.InsertOnSubmit(user);
                }
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
