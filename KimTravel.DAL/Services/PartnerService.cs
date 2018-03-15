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
        private KimTravelDataContext db = new KimTravelDataContext();

        public IQueryable GetList()
        {
            IQueryable data = from p in db.Partners
                              from g in db.GroupPartners.Where(x => x.GroupPartnerID == p.GroupID).DefaultIfEmpty()
                              orderby p.Name
                              select new
                              {
                                  p.PartnerID,
                                  p.PartnerCode,
                                  p.Name,
                                  p.Address,
                                  p.Phone,
                                  p.Note,
                                  p.GroupID,
                                  g.GroupName,
                                  Status = p.Status == 1 ? "Bình thường" : "Ngưng hợp tác"
                              };
            return data;
        }

        public IQueryable GetListFind(string content)
        {
            IQueryable data = from p in db.Partners
                              where p.Address.Contains(content) && p.Status == 1
                              orderby p.Address
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
        public IEnumerable<Partner> GetListCobobox()
        {
            IEnumerable<Partner> data = db.Partners.Where(x => x.Status == 1).OrderBy(x => x.Address).ToList();
            return data;
        }
        public string GetPartnerCode()
        {
            var data = db.Partners.OrderByDescending(x => x.PartnerCode).FirstOrDefault().PartnerCode;
            var no = data == null ? "0" : data.Remove(0, 2);
            int newCode = int.Parse(no) + 1;
            return "DT" + string.Format("{0:000000}", newCode);
        }
        public Partner GetByID(int id)
        {
            Partner data = db.Partners.FirstOrDefault(x => x.PartnerID == id);

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
