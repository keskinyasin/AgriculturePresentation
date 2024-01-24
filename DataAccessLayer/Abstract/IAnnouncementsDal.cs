using EntityLayer.Concrate;
using System;
using System.Linq;

namespace DataAccessLayer.Abstract
{
    public interface IAnnouncementsDal : IGenericDal<Announcement>
    {
        Announcement Get(Func<Announcement, bool> predicate);
        Announcement GetByTitle(string title);


    }
}
