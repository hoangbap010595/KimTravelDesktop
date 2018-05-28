using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class ApplicationRoleService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext(AppConfig.getStringConnection());

        public IEnumerable<ApplicationRole> GetList()
        {
            IEnumerable<ApplicationRole> data = db.ApplicationRoles.ToList();

            return data;
        }

        public bool Insert(ApplicationRole role)
        {
            bool checkUName = db.ApplicationRoles.Count(x => x.Name == role.Name) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkUName)
            {
                db.ApplicationRoles.InsertOnSubmit(role);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(ApplicationRole role)
        {
            bool checkUName = db.ApplicationRoles.Count(x => x.Name == role.Name && x.ID != role.ID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (checkUName)
            {
                ApplicationRole currRole = db.ApplicationRoles.FirstOrDefault(x => x.ID == role.ID);
                if (currRole != null)
                {
                    currRole.Name = role.Name;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            ApplicationRole currRole = db.ApplicationRoles.FirstOrDefault(x => x.ID == id);
            if (currRole != null)
            {
                db.ApplicationRoles.DeleteOnSubmit(currRole);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
