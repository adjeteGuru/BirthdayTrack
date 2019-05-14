using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayTrack
{
    //class to hold information about a person
   public class Person
    {
        //attributes of the person member of the class person
        private string mFirstName;
        private string mLastName;
        private int mDayBorn;
        private int mMonthBorn;
        private int mYearBorn;
    
  //construction DayOfBirth
  public string DateOfBirth()
        {
            return string.Format("{0}/{1}/{2}", mDayBorn, mMonthBorn, mYearBorn);
        }

    //encapsulation Get Set FirstName to be call upon
    public string FirstName
    {
        get
        {
            return mFirstName;
        }
        set
        {
            value = mFirstName;
        }
    }

        //encapsulation Get Set LastName to be call upon
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                value = mLastName;
            }

        }

        //encapsulation Get Set DayBorn to be call upon
        public int DayBorn
        {
            get
            {
                return mDayBorn;
            }
            set
            {
                value = mDayBorn;
            }

        }

        //encapsulation Get Set MonthBorn to be call upon
        public int MonthBorn
        {
            get
            {
                return mMonthBorn;
            }
            set
            {
                value = mMonthBorn;
            }

        }

        //encapsulation Get Set YearBorn to be call upon
        public int YearBorn
        {
            get
            {
                return mYearBorn;
            }
            set
            {
                value = mYearBorn;
            }
        }

  public bool HadThisYearsBirthday()
        {
            // get todays date
            DateTime today = DateTime.Today;

            // we assume you have not had this years birthday yet
            bool returnValue = false;

            // but if this month is AFTER you birthay month you have
            if (today.Month > MonthBorn)
            {
                returnValue = true;
            }
            // if this is your birthday month we look at the days            
            else if (today.Month == MonthBorn)
            {
                // if today is on or after your birthday then you have
                if (today.Day >= DayBorn)
                {
                    returnValue = true;
                }

            }
            return returnValue;
        }

        public DateTime GetNextBirthday()
        {
            // we calculate the date for your next birthday
            DateTime today = DateTime.Today;
            // assume your birthday is this year
            int birthdayYear = today.Year;
            // if you've already had your birthday then
            // its a year later
            if (HadThisYearsBirthday())
            {
                birthdayYear++;
            }
            // now we create the right dateTime
            DateTime nextBirthday =
                new DateTime(birthdayYear, MonthBorn, DayBorn);
            return nextBirthday;
        }

        public int HowManyDaysTillBirthday()
        {
            // we work out the difference between your next birthday
            // and todays date

            DateTime nextBirthday = GetNextBirthday();
            DateTime today = DateTime.Today;

            TimeSpan difference =
                nextBirthday.Subtract(today);

            // from the timespan object we are only interested in the
            // number of days
            int daysToBirthday = difference.Days;

            return daysToBirthday;
        }

        public int GetAgeInYears()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - YearBorn;

            // but if you haven't had this years birthday
            // you are 1 year younger

            if (!HadThisYearsBirthday())
            {
                age--;
            }
            return age;
        }
    }
}
