using System;
using System.Collections.Generic;

namespace Car_Rentals_App
{
    public class clsVehicle
    {
        private string _Rego;
        private string _Make;
        private string _Model;
        private int _Year;
        private string _Trans = "Automatic";
        private decimal _Rate;
        private string _VehicleType = "Sedan";

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
            return VehicleType + " \t" + Make + " \t" + Model;
        }

        public string QuickViewHire()
        {
            return "Vehicle Details!\nRego: " + Rego.ToString() + "\nMake: " + Make + "\nModel: " + Model + "\nYear: " + Year.ToString() + "\nTrans: " + Trans + "\nType: " + VehicleType + "\nRate: " + Rate.ToString();
        }

        public string QuickViewService()
        {
            return "Vehicle Details!\nRego: " + Rego.ToString() + "\nMake: " + Make + "\nModel: " + Model + "\nYear: " + Year.ToString() + "\nTrans: " + Trans + "\nType: " + VehicleType;
        }
    }
}
