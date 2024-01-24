using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrate;
using System;
using System.Linq;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementsDal
    {
        private readonly AgricultureContext _context;

        public EfAnnouncementDal(AgricultureContext context) : base(context)
        {
            _context = context;
        }



        public Announcement? Get(Func<Announcement, bool> predicate)
        {

            return _context.Announcements?.FirstOrDefault(predicate);

        }

        public Announcement GetByTitle(string title)
        {
            return _context.Announcements.FirstOrDefault(a => a.Title == title);
        }
    }
}
