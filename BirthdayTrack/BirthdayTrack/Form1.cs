using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayTrack
{
    public partial class FrmBirthdayTrack : Form
    {
        //this is a birthday object 
        Birthdays birthdays;
        public FrmBirthdayTrack()
        {
            InitializeComponent();
        }

        private void FrmBirthdayTrack_Load(object sender, EventArgs e)
        {
            //create a birthdayas object
            birthdays = new Birthdays();
            AddPeople();

            // now we are ready to show the data on the form
            DisplayPerson();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            birthdays.StepToNextPerson();
            //and update the display
            DisplayPerson();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            birthdays.StepToPreviousPerson();
            //this is to update the display
            DisplayPerson();
        }

        public void AddPeople()
        {
            birthdays.AddPerson("Peter", "Cook", 2, 11, 2000);
            birthdays.AddPerson("Jordy", "ALI", 31, 12, 1999);
            birthdays.AddPerson("Annie", "BROWN", 11, 11, 2005);
            // test values here.
            birthdays.AddPerson("Yesterday", "Noname", 26, 10, 2001);
            birthdays.AddPerson("Today", "Noaame", 27, 10, 2001);
            birthdays.AddPerson("Tomorrow", "Noname", 28, 10, 2001);
        }

        public void DisplayPerson()
        {
            txtFirstName.Text = birthdays.GetPersonFirstName();
            txtLastName.Text = birthdays.GetPersonLastName();
            txtDateOfBirth.Text = birthdays.GetPersonDateOfBirth();

            // add this
            txtDaysToBirthday.Text = string.Format("{0} Days", birthdays.GetPersonDaysTillNextBirthday());
            txtAgeInYears.Text = string.Format("{0} Years old", birthdays.GetPersonAgeInYears());
        }

     
    
    }
}
