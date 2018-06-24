using System;

namespace Car_Rentals_App
{
    //This code was developed by Dean Stanley-Hunt @ 10/06/2017. As an Assessment Project for SDV601 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP. Dean.Stanleyhunt@live.nmit.ac.nz
    class clsActivityService : clsActivity
    {
        private string _Description;

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        public override string typeOfActivity()
        {
            return "Service";
        }
    }
}
