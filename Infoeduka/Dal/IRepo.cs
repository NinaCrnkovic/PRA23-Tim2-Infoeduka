using Infoeduka.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoeduka.Dal
{
    public interface IRepo
    {
        public void SavePersonData(IList<Person> persons);
        public void SaveCourseData(IList<Course> courses);

        public void SaveNotificationData(IList<Notification> notifications);

        public IList<Notification> GetNotifications();
        public IList<Person> GetPersons();
        public IList<Course> GetCourses();
    }
}
