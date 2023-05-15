using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Infoeduka.Model
{
    public class Notification
    {
        private const char DEL = '$';
        private const string DATEFORMAT = "dd.MM.yyyy. hh:mm";
        public Notification(string name, string description, string course, Person creator, DateTime expirationDate)
        {
            Id = Utility.GenerateRandomId();
            Name = name;
            Description = description;
            Course = course;
            Creator = creator;
            ExpirationDate = expirationDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Course { get; set; }
        public Person Creator { get; set; }
        public DateTime DateOfCreation { get; private set; } = DateTime.Now;

        private DateTime _dateOfChange = DateTime.Now;

        public DateTime DateOfChange
        {
            get { return _dateOfChange; }
            set
            {
                if ( value != DateOfCreation)
                {
                    _dateOfChange = value;
                }
                else
                {
                    _dateOfChange = DateOfCreation;
                }
            }
        }
        public DateTime ExpirationDate { get; set; }


        public string FormatForFile() => $"{Id}{DEL}{Name}{DEL}{Description}{DEL}{Course}{DEL}{Creator.FormatForFile()}{DEL}{DateOfCreation.ToString(DATEFORMAT)}{DEL}{DateOfChange.ToString(DATEFORMAT)}{DEL}{ExpirationDate.ToString(DATEFORMAT)}";




        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nCourse: {Course}\nCreator: {Creator}\nDate of Creation: {DateOfCreation.ToString(DATEFORMAT)}\nDate of Change: {DateOfChange.ToString(DATEFORMAT)}\nExpiration Date: {ExpirationDate.ToString(DATEFORMAT)}";
        }

        public static Notification ParseFromFile(string line)
        {
            string[] fields = line.Split(DEL);

            int id = int.Parse(fields[0]);
            string name = fields[1];
            string description = fields[2];
            string course = fields[3];
            Person creator = Person.ParseFromFile(fields[4]);
            DateTime dateOfCreation = DateTime.ParseExact(fields[5], DATEFORMAT, null);
            DateTime dateOfChange = DateTime.ParseExact(fields[6], DATEFORMAT, null);
            DateTime expirationDate = DateTime.ParseExact(fields[7], DATEFORMAT, null);

            Notification notification = new Notification(name, description, course, creator, expirationDate);
            notification.Id = id;
            notification.DateOfCreation = dateOfCreation;
            notification.DateOfChange = dateOfChange;

            return notification;
        }

        public override bool Equals(object obj)
        {
            return obj is Notification notification &&
                   Id == notification.Id &&
                   Name == notification.Name &&
                   Description == notification.Description &&
                   Course == notification.Course &&
                   EqualityComparer<Person>.Default.Equals(Creator, notification.Creator) &&
                   DateOfCreation == notification.DateOfCreation &&
                   _dateOfChange == notification._dateOfChange &&
                   DateOfChange == notification.DateOfChange &&
                   ExpirationDate == notification.ExpirationDate;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Name);
            hash.Add(Description);
            hash.Add(Course);
            hash.Add(Creator);
            hash.Add(DateOfCreation);
            hash.Add(_dateOfChange);
            hash.Add(DateOfChange);
            hash.Add(ExpirationDate);
            return hash.ToHashCode();
        }
    }
}

