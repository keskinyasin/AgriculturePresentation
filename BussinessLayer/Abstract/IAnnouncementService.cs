using EntityLayer.Concrate;
using System;
using System.Linq;

namespace BussinessLayer.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        Announcement Get(Func<Announcement, bool> predicate);

    }
}
