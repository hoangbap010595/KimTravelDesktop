using KimTravel.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class GroupPartnerService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext(AppConfig.getStringConnection());

        public IEnumerable<GroupPartner> GetList()
        {
            IEnumerable<GroupPartner> data = db.GroupPartners.ToList();

            return data;
        }
        public GroupPartner GetByID(int id)
        {
            GroupPartner data = db.GroupPartners.FirstOrDefault(x => x.GroupPartnerID == id);

            return data;
        }

        public bool Insert(GroupPartner obj)
        {
            bool checkName = db.GroupPartners.Count(x => x.GroupName == obj.GroupName) > 0 ? true : false;
            if (!checkName)
            {
                db.GroupPartners.InsertOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(GroupPartner obj)
        {
            bool checkUName = db.GroupPartners.Count(x => x.GroupName == obj.GroupName && x.GroupPartnerID != obj.GroupPartnerID) > 0 ? true : false;
            if (!checkUName)
            {
                GroupPartner currObject = db.GroupPartners.FirstOrDefault(x => x.GroupPartnerID == obj.GroupPartnerID);
                if (currObject != null)
                {
                    currObject.GroupName = obj.GroupName;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            GroupPartner currObject = db.GroupPartners.FirstOrDefault(x => x.GroupPartnerID == id);
            if (currObject != null)
            {
                db.GroupPartners.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
