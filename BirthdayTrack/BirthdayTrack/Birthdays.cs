using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayTrack
{// birthdays class to hold information about people
 public class Birthdays
    {
        //declare and reference a member person
        int currenPerson = 0;

        //this is object people to hold list of people
        List<Person> people = new List<Person>();

        //access a person data
        public string GetPersonFirstName()
        {
          return people[currenPerson].FirstName;
        }

        //access a person data
        public string GetPersonLastName()
        {
            return people[currenPerson].LastName;
        }

        //access a person data
        public string GetPersonDateOfBirth()
        {
            return people[currenPerson].DateOfBirth();
        }
    }
}
