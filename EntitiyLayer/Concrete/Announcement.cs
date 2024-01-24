using System;
using System.Linq;

namespace EntityLayer.Concrate
{
    public class Announcement
    {
        public int AnnouncementID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }


    }

    public class AnnouncementTest
    {
        public void Test()
        {
            Announcement myAnnouncement = new Announcement();
            int id = myAnnouncement.AnnouncementID;
        }
    }
}
