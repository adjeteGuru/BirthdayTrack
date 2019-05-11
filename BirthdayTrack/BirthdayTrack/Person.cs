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

  
    }
}
