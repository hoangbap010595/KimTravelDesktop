using KimTravel.DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL.Services
{
    public class GroupTourService
    {
        private readonly KimTravelDataContext db = new KimTravelDataContext();

        public IQueryable GetList()
        {
            IQueryable data = from g in db.GroupTours
                              orderby g.Name
                              select new
                              {
                                  g.GroupID,
                                  g.Name,
                                  g.DateCreate,
                                  g.MinPax,
                                  g.MaxPax,
                                  g.Enable,
                                  g.Note
                              };
            return data;
        }

        public IEnumerable<GroupTour> GetListCombobox()
        {
            IEnumerable<GroupTour> data = db.GroupTours.Where(x=>x.Enable == true).OrderBy(x => x.Name).ToList();
            return data;
        }

        public GroupTour GetByID(int id)
        {
            GroupTour data = db.GroupTours.FirstOrDefault(x => x.GroupID == id);

            return data;
        }

        public bool Insert(GroupTour gTour)
        {
            bool checkName = db.GroupTours.Count(x => x.Name == gTour.Name) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkName)
            {
                db.GroupTours.InsertOnSubmit(gTour);
                db.SubmitChanges();
                return true;
            }
            else
                return false;
        }

        public bool Update(GroupTour gTour)
        {
            bool checkUName = db.GroupTours.Count(x => x.Name == gTour.Name && x.GroupID != gTour.GroupID) > 0 ? true : false;
            //bool check = db.ApplicationUsers.Count(x => x.Username == user.Username) > 0 ? true : false;
            if (!checkUName)
            {
                GroupTour currObject = db.GroupTours.FirstOrDefault(x => x.GroupID == gTour.GroupID);
                if (currObject != null)
                {
                    currObject.Name = gTour.Name;
                    currObject.MaxPax = gTour.MaxPax;
                    currObject.Enable = gTour.Enable;
                    currObject.Note = gTour.Note;
                    db.SubmitChanges();
                }
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            GroupTour currObject = db.GroupTours.FirstOrDefault(x => x.GroupID == id);
            if (currObject != null)
            {
                db.GroupTours.DeleteOnSubmit(currObject);
                db.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
