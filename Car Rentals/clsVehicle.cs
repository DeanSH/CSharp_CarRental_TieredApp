using System;
using System.Collections.Generic;

namespace Car_Rentals
{
    [Serializable]
    public class clsVehicle
    {
        //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
        //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
        private List<clsActivity> _ActivityList = new List<clsActivity>();
        private string _Rego;
        private string _Make;
        private string _Model;
        private int _Year;
        private string _Trans = "Automatic";
        private decimal _Rate;
        private string _VehicleType = "Sedan";

        public List<clsActivity> ActivityList
        {
            get
            {
                return _ActivityList;
            }

            set
            {
                _ActivityList = value;
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

        public string Make
        {
            get
            {
                return _Make;
            }

            set
            {
                _Make = value;
            }
        }

        public string Model
        {
            get
            {
                return _Model;
            }

            set
            {
                _Model = value;
            }
        }

        public int Year
        {
            get
            {
                return _Year;
            }

            set
            {
                _Year = value;
            }
        }

        public string Trans
        {
            get
            {
                return _Trans;
            }

            set
            {
                _Trans = value;
            }
        }

        public string VehicleType
        {
            get
            {
                return _VehicleType;
            }

            set
            {
                _VehicleType = value;
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

        public override string ToString()
        {
            return Rego + "\t" + VehicleType;
        }

        public string QuickView()
        {
            return "Make: " + Make + "\nModel: " + Model + "\nYear: " + Year.ToString() + "\nRate: $" + Rate.ToString() + "\nType: " + VehicleType;
        }
    }
}
