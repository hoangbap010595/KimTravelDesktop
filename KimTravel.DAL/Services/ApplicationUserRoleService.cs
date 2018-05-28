using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class ApplicationUserRoleService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext(AppConfig.getStringConnection());

        public string GetListRoles(string username)
        {
            string data = "0";
            if (username == "")
                return data;
            int userID = db.ApplicationUsers.FirstOrDefault(x => x.Username == username).ID;
            IEnumerable<ApplicationUserRole> listRoles = db.ApplicationUserRoles.Where(x => x.UserID == userID).ToList();
            foreach (ApplicationUserRole item in listRoles)
            {
                data += "," + item.RoleID;
            }
            return data;
        }

        public bool Update(string username, string roleID)
        {
            try
            {
                int userID = db.ApplicationUsers.FirstOrDefault(x => x.Username == username).ID;
                Delete(userID);
                string[] roles = roleID.Split(',');
                foreach (string item in roles)
                {
                    int rID = int.Parse(item);
                    ApplicationUserRole hir = new ApplicationUserRole();
                    hir.UserID = userID;
                    hir.RoleID = rID;
                    db.ApplicationUserRoles.InsertOnSubmit(hir);
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            IEnumerable<ApplicationUserRole> data = db.ApplicationUserRoles.Where(x => x.UserID == id);
            if (data.Count() > 0)
            {
                db.ApplicationUserRoles.DeleteAllOnSubmit(data);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
