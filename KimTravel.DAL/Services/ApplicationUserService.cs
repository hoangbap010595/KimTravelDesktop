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
        private readonly KimTravelDataDataContext db = new KimTravelDataDataContext();

        public IEnumerable<ApplicationUser> GetList()
        {
            IEnumerable<ApplicationUser> data = db.ApplicationUsers.ToList();

            return data;
        }

        public int CheckLogin(string username, string password)
        {
            string hashPass = HashText.GetSHA1HashData(password);
            ApplicationUser currUser = db.ApplicationUsers.FirstOrDefault(x => x.Username == username && x.Password == hashPass);
            if (currUser != null)
            {
                if (currUser.Status == 0)
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
                user.Status = 0;
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

        public bool Update(ApplicationUser user)
        {
            bool checkUName = db.ApplicationUsers.Count(x => x.Username == user.Username && x.ID != user.ID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (checkUName)
            {
                ApplicationUser currUser = db.ApplicationUsers.FirstOrDefault(x => x.ID == user.ID);
                if (currUser != null)
                {
                    currUser.Username = user.Username;
                    currUser.LastUpdate = DateTime.Now;
                    currUser.UpdateBy = Constant.CurrentSessionUser;
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
            if (checkUName)
            {
                ApplicationUser currUser = db.ApplicationUsers.FirstOrDefault(x => x.ID == user.ID);
                if (currUser != null)
                {
                    user.Password = HashText.GetSHA1HashData(user.Password);
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
