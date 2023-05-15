using Infoeduka.CustomDesign;
using Infoeduka.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoeduka.Model
{
    public class DataManager
    {
        private IRepo repo = RepoFactory.GetRepo();
        IDictionary<int, Person> personsDictionary = new Dictionary<int, Person>();
        IDictionary<int, Course> coursesDictionary = new Dictionary<int, Course>();
        IDictionary<int, Notification> notificationDictionary = new Dictionary<int, Notification>();

        //metoda za napuniti osobe u dictionary iz fajle
        public void LoadPersonsToDictionary()
        {

            try
            {
                IList<Person> persons = repo.GetPersons();
                FillPersonsDictionary(persons);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Nije moguće napuniti predavače u riječnik:" +e.Message);
            }
        }


        //metoda za napuniti kolegije u dictionary iz fajle
        public IDictionary<int, Course> LoadCoursesToDictionary()
        {
            try
            {
                IList<Course> courses = repo.GetCourses();
                FillCoursesDictionary(courses);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Nije moguće napuniti kolegije u riječnik:" + e.Message);
            }
            return coursesDictionary;
        }

        public void LoadNotificationsToDictionary()
        {

            try
            {
                IList<Notification> notifications = repo.GetNotifications();
                FillNotificationsDictionary(notifications);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Nije moguće napuniti obavijesti u riječnik: " + e.Message);
            }
        }


        //metoda za dohvati dicitionarya osoba
        public IDictionary<int, Person> GetPersonsDictionary()
        {
            return personsDictionary;
        }
        //metoda za dohvati dicitionarya kolegija
        public IDictionary<int, Course> GetCoursesDictionary()
        {
            return coursesDictionary;
        }
        public IDictionary<int, Notification> GetNotificationDictionary()
        {
            return notificationDictionary;
        }


        //metoda za punjenje dicitonaria iz liste
        private void FillCoursesDictionary(IList<Course> courses)
        {
            foreach (Course course in courses)
            {
                try
                {
                    coursesDictionary.Add(course.Id, course);

                }
                catch (Exception e)
                {
                    MessageBox.Show($"fill courses dic" + e.Message);
                }
            }
        }

        //metoda za punjenje dicitonaria iz liste
        private void FillPersonsDictionary(IList<Person> persons)
        {
            foreach (Person person in persons)
            {
                try
                {
                    personsDictionary.Add(person.Id, person);

                }
                catch (Exception e)
                {
                    MessageBox.Show($"fill person dic" + e.Message);
                }
            }
        }

        private void FillNotificationsDictionary(IList<Notification> notifications)
        {
            foreach (Notification notification in notifications)
            {
                try
                {
                    notificationDictionary.Add(notification.Id, notification);

                }
                catch (Exception e)
                {
                    MessageBox.Show($"fill notification dic" + e.Message);
                }
            }
        }


        //dodavanje osobe u dictyonary
        public void AddNewPersonToDictionary(Person newPerson)
        {
            // dodajte novog Person objekta u dictionary
            personsDictionary.Add(newPerson.Id, newPerson);
        }
        //doavanje kolegija u dictyonary
        public void AddNewCourseToDictionary(Course newCourse)
        {
            // dodajte novog Course objekta u dictionary
            coursesDictionary.Add(newCourse.Id, newCourse);
        }
        public void AddNewNotificationToDictionary(Notification newNotification)
        {
            try
            {
                // dodajte novog Course objekta u dictionary
                notificationDictionary.Add(newNotification.Id, newNotification);
            }
            catch (Exception)
            {

                MessageBox.Show("Add new to puko");
            }
          
        }


        public void DeletePersonFromDictionary(int id)
        {
            var person = personsDictionary[id];
            if (person != null)
            {
                // provjera da li je person predavač na nekom kolegiju
                bool isLecturer = false;
                StringBuilder messageBuilder = new StringBuilder("Nije moguće izbrisati osobu jer je predavač na sljedećim kolegijima:\n");
                foreach (var course in coursesDictionary.Values)
                {
                    if (course.Lecturers.Contains(person))
                    {
                        isLecturer = true;
                        messageBuilder.Append($"{course.Name}\n");
                    }
                }

                // ako osoba nije predavač na nekom kolegiju, obriši je iz dictionaryja
                if (isLecturer)
                {
                    CustomMessageBox.Show(messageBuilder.ToString(), "Upozorenje", MessageBoxButtons.OK);
                }
                else
                {
                    personsDictionary.Remove(id);
                }
            }
        }


        public void DeleteCourseFromDictionary(int id)
        {
            coursesDictionary.Remove(id);
        }

        public void DeleteNotificationFromDictionary(int id)
        {
            notificationDictionary.Remove(id);
        }


        public void UpdatePersonToDictionary(Person updatedPerson)
        {
            //provjeravamo da li osoba postoji u dictionaryu
            if (personsDictionary.ContainsKey(updatedPerson.Id))
            {
                //dohvaćamo osobu
                Person person = personsDictionary[updatedPerson.Id];
                //postavljamo nove vrijednosti
                person.FirstName = updatedPerson.FirstName;
                person.LastName = updatedPerson.LastName;
                person.Email = updatedPerson.Email;
                person.Password = updatedPerson.Password;
                person.IsAdmin = updatedPerson.IsAdmin;

                //update osobe
                personsDictionary[updatedPerson.Id] = person;
            }
            else
            {
                // ako osoba s ID-om ne postoji u rječniku, izbacite iznimku ili 
                // napravite neku drugu vrstu manipulacije podacima
                throw new KeyNotFoundException("Osoba s ID-om " + updatedPerson.Id + " ne postoji u rječniku.");
            }

        }

        public void UpdateCourseToDictionary(Course updatedCourse)
        {
            //provjeravamo da li osoba postoji u dictionaryu
            
            if (coursesDictionary.ContainsKey(updatedCourse.Id))
            {
                //dohvaćamo osobu
                Course course = coursesDictionary[updatedCourse.Id];
                //postavljamo nove vrijednosti
                course.Name = updatedCourse.Name;
                course.Code = updatedCourse.Code;
                course.Ects = updatedCourse.Ects;
                course.Lecturers = updatedCourse.Lecturers;

                //update kolegija
                coursesDictionary[updatedCourse.Id] = course;
            }
            else
            {
                // ako osoba s ID-om ne postoji u rječniku, izbacite iznimku ili 
                // napravite neku drugu vrstu manipulacije podacima
                throw new KeyNotFoundException("Kolegij s ID-om " + updatedCourse.Id + " ne postoji u rječniku.");
            }

        }

        public void UpdateNotificationToDictionary(Notification updatedNotification)
        {
            //provjeravamo da li obavijest postoji u dictionaryu

            if (notificationDictionary.ContainsKey(updatedNotification.Id))
            {
                //dohvaćamo obavijest
                Notification notification = notificationDictionary[updatedNotification.Id];
                //postavljamo nove vrijednosti
                notification.Name = updatedNotification.Name;
                notification.Description = updatedNotification.Description;
                notification.DateOfChange = DateTime.Now;
                notification.ExpirationDate = updatedNotification.ExpirationDate;
                notification.Creator = updatedNotification.Creator;
                notification.Course = updatedNotification.Course;
                //update obavijesti
                notificationDictionary[updatedNotification.Id] = notification;
            }
            else
            {
                // ako osoba s ID-om ne postoji u rječniku, izbacite iznimku ili 
                // napravite neku drugu vrstu manipulacije podacima
                throw new KeyNotFoundException("Obavijest s ID-om " + updatedNotification.Id + " ne postoji u rječniku.");
            }

        }



        public void SaveDataForAllInRepo(IList<Person> persons, IList<Course> courses, IList<Notification> notifications)
        {
            try
            {
                repo.SavePersonData(persons);
                repo.SaveCourseData(courses);
                repo.SaveNotificationData(notifications);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
           
        }


        //metaoda koja sprema sve podatke prije zatvaranja aplikacije
            public void SaveAllDataInFile()
        {
            try
            {
                IList<Person> persons = personsDictionary.Values.ToList();
                IList<Course> courses = coursesDictionary.Values.ToList();
                IList<Notification> notifications = notificationDictionary.Values.ToList();
                SaveDataForAllInRepo(persons, courses, notifications);
            }
            catch (Exception)
            {
                CustomMessageBox.Show($"Nije moguće spremanje podataka u datoteku", "Upozorenje!", MessageBoxButtons.OK);
            }
        }
    }
}

