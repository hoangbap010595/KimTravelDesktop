using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class ApplicationUserService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext(AppConfig.getStringConnection());

        public IQueryable GetList()
        {
            var statusUser = Constant.getListStatusUser();
            IQueryable data = from u in db.ApplicationUsers
                              select new
                              {
                                  u.ID,
                                  u.Email,
                                  u.Phone,
                                  u.DateCreate,
                                  u.LockDate,
                                  Status = u.Status == 1 ? statusUser[0].Name : statusUser[1].Name,
                                  u.LastUpdate,
                                  u.Locked,
                                  u.UpdateBy,
                                  u.Username
                              };

            return data;
        }
        public ApplicationUser GetByID(int id)
        {
            ApplicationUser data = db.ApplicationUsers.FirstOrDefault(x => x.ID == id);

            return data;
        }
        public string GetPartnerViewReport(string username)
        {
            ApplicationUser data = db.ApplicationUsers.FirstOrDefault(x => x.Username == username);
            if (data == null)
                return "";
            return data.Email;
        }
        public bool checkExistsUsername(string username)
        {
            return db.ApplicationUsers.Count(x => x.Username == username) > 0 ? true : false;
        }
        public int CheckLogin(string username, string password)
        {
            string hashPass = HashText.GetSHA1HashData(password);
            ApplicationUser currUser = db.ApplicationUsers.FirstOrDefault(x => x.Username == username && x.Password == hashPass);
            if (currUser != null)
            {
                if (currUser.Locked == true)
                    return 2;
                if (currUser.Status == 1)
                    return 1;
                else
                    return 0;
            }
            return -1;
        }
        public bool Insert(ApplicationUser user)
        {
            bool checkUName = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkUName)
            {
                user.Password = HashText.GetSHA1HashData(user.Password);
                user.DateCreate = DateTime.Now;
                user.Status = 1;
                //Status:
                //    0: Bình thường
                //    1: Ngưng hoạt động
                db.ApplicationUsers.InsertOnSubmit(user);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool UpdateRoleViewReport(int id, string partnerID)
        {
            ApplicationUser currUser = db.ApplicationUsers.FirstOrDefault(x => x.ID == id);
            if (currUser != null)
            {
                currUser.Email = partnerID;
                db.SubmitChanges();
                return true;
            }
            return false;
        }
        public bool Update(ApplicationUser user)
        {
            bool checkUName = db.ApplicationUsers.Count(x => x.Username == user.Username && x.ID != user.ID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkUName)
            {
                ApplicationUser currUser = db.ApplicationUsers.FirstOrDefault(x => x.ID == user.ID);
                if (currUser != null)
                {
                    currUser.Phone = user.Phone;
                    currUser.Status = user.Status;
                    currUser.Username = user.Username;
                    currUser.LastUpdate = DateTime.Now;
                    currUser.UpdateBy = Constant.CurrentSessionUser;
                    if (user.Locked == true)
                    {
                        currUser.Locked = true;
                        currUser.LockDate = DateTime.Now;
                        currUser.Status = 2;
                    }
                    else
                    {
                        currUser.Locked = false;
                        currUser.LockDate = null;
                    }
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }
        public bool UpdatePassword(ApplicationUser user, string newPass)
        {
            bool checkUName = db.ApplicationUsers.Count(x => x.Username == user.Username && x.ID != user.ID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkUName)
            {
                ApplicationUser currUser = db.ApplicationUsers.FirstOrDefault(x => x.ID == user.ID);
                if (currUser != null)
                {
                    user.Password = HashText.GetSHA1HashData(newPass);
                    currUser.LastUpdate = DateTime.Now;
                    currUser.UpdateBy = Constant.CurrentSessionUser;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            ApplicationUser currUser = db.ApplicationUsers.FirstOrDefault(x => x.ID == id);
            if (currUser != null)
            {
                db.ApplicationUsers.DeleteOnSubmit(currUser);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
