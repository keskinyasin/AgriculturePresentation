using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Linq;

namespace BussinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementsDal _announcementDal;

        public AnnouncementManager(IAnnouncementsDal announcementDal)
        {
            _announcementDal = announcementDal;
        }



        public void Delete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public Announcement Get(int id)
        {
            return _announcementDal.Get(x => x.AnnouncementID == id);
        }

        public Announcement Get(Func<Announcement, bool> predicate)
        {
            return _announcementDal.Get(predicate);
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.GetAll();
        }

        public void Insert(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public void Update(Announcement t)
        {
            _announcementDal.Update(t);
        }
    }
}
