using System;

namespace Car_Rentals_App
{
    //This code was developed by Dean Stanley-Hunt @ 10/06/2017. As an Assessment Project for SDV601 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP. Dean.Stanleyhunt@live.nmit.ac.nz
    public abstract class clsActivity
    {
        private int _Id;
        private string _Rego;
        private string _Name;
        private string _Date = DateTime.Today.ToString();
        private decimal _Cost;
        private decimal _Rate;
        private string _ActivityType;
        private int _Notify;

        public static readonly string[] ActivityTypes = { "Hire", "Service" };

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string Rego
        {
            get
            {
                return _Rego;
            }

            set
            {
                _Rego = value;
            }
        }

        public int Notify
        {
            get
            {
                return _Notify;
            }

            set
            {
                _Notify = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return _Cost;
            }

            set
            {
                _Cost = value;
            }
        }

        public decimal Rate
        {
            get
            {
                return _Rate;
            }

            set
            {
                _Rate = value;
            }
        }

        public string ActivityType
        {
            get
            {
                return _ActivityType;
            }

            set
            {
                _ActivityType = value;
            }
        }

        public override string ToString()
        {
            return Name + "\t" + typeOfActivity() + "\t" + Date + "\t" + Convert.ToString(Cost);
        }

        public static clsActivity NewActivity(int prChoice)
        {
            if (prChoice == 0)
                return new clsActivityHire();
            else
                return new clsActivityService();
        }

        public abstract string typeOfActivity();
    }
}