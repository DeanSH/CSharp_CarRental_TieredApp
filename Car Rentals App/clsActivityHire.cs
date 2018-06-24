using System;

namespace Car_Rentals_App
{
    //This code was developed by Dean Stanley-Hunt @ 10/06/2017. As an Assessment Project for SDV601 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP. Dean.Stanleyhunt@live.nmit.ac.nz
    class clsActivityHire : clsActivity
    {
        private string _EndDate = DateTime.Today.ToString();
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

        public int countDays(DateTime StartDate, DateTime EndDate)
        {
            return new TimeSpan(EndDate.Date.Ticks - StartDate.Date.Ticks).Days;
        }
    }
}
