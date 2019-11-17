using System;

namespace Car_Rentals
{
    //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
    class clsActivityHire : clsActivity
    {
        private string _EndDate = DateTime.Today.ToShortDateString();
        private int _Paid = 0;

        public string EndDate
        {
            get
            {
                return _EndDate;
            }

            set
            {
                _EndDate = value;
            }
        }

        public int Paid
        {
            get
            {
                return _Paid;
            }

            set
            {
                _Paid = value;
            }
        }

        public override string typeOfActivity()
        {
            return "Hire";
        }

        public string countDays(DateTime StartDate, DateTime EndDate)
        {
            return new TimeSpan(EndDate.Date.Ticks - StartDate.Date.Ticks).Days.ToString();
        }
    }
}
