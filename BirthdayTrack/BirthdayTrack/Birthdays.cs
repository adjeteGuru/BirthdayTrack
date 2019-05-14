using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayTrack
{// birthdays class to hold information about people
 public class Birthdays
    {
        
        //this is object people to hold list of people
        List<Person> people = new List<Person>();

        //declare and reference a member person
        int currenPerson = 0;

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

        public int GetPersonDaysTillNextBirthday()
        {
            return people[currenPerson].HowManyDaysTillBirthday();
        }

        public int GetPersonAgeInYears()
        {
            return people[currenPerson].GetAgeInYears();
        }

        public bool IsNextPerson()
        {
            return (currenPerson < (people.Count -1));
        }

        public bool IsPreviousPerson()
        {
            return (currenPerson > 0);
        }

        public void StepToNextPerson()
        {
            if (IsNextPerson())
            {
                currenPerson++;
            }

        }

        public void StepToPreviousPerson()
        {
            if (IsPreviousPerson())
            {
                currenPerson--;
            }
        }

        public void AddPerson(string fristName, string lastName, int dayBorn, int monthBorn, int yearBorn)
        {// create a new person object
            Person person = new Person();

            // copy in the details
            person.FirstName = fristName;
            person.LastName = lastName;
            person.DayBorn = dayBorn;
            person.MonthBorn = monthBorn;
            person.YearBorn = yearBorn;

            // add to the list of people
            people.Add(person);
        }
    }
}
