using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Infoeduka.Model
{
    public class Person
    {
        private const char DEL = '|';
              

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; } 
        public string Password { get; set; } 

        public bool IsAdmin { get; set; } = false;
        public Person()
        {

        }
        public Person(string firstName, string lastName, string email, string password, bool isAdmin)
        {
            Id = Utility.GenerateRandomId();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }

        


        public override string ToString() => $"{Id}, {FirstName} {LastName}, {Email}, {Password}, {(IsAdmin ? "Administrator" : "Predavač")}";

        public string FormatForFile()
        => $"{Id}{DEL}{FirstName}{DEL}{LastName}{DEL}{Email}{DEL}{Password}{DEL}{IsAdmin}";


        public static Person ParseFromFile(string line)
        {
            string[] details = line.Split(DEL);
                       
            return new Person
            {
                Id = int.Parse(details[0]),
                FirstName = details[1],
                LastName = details[2],
                Email = details[3],
                Password = details[4],
                IsAdmin = bool.Parse(details[5])
            };
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Id == person.Id &&
                   FirstName == person.FirstName &&
                   LastName == person.LastName &&
                   Email == person.Email &&
                   Password == person.Password &&
                   IsAdmin == person.IsAdmin;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, FirstName, LastName, Email, Password, IsAdmin);
        }
    }
}
