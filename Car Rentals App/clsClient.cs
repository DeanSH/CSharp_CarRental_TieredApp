using System;
using System.Collections.Generic;
using System.IO;

namespace Car_Rentals_App
{
    //This code was developed by Dean Stanley-Hunt @ 10/06/2017. As an Assessment Project for SDV601 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP. Dean.Stanleyhunt@live.nmit.ac.nz
    sealed class clsClient
    {
        public static readonly clsClient Instance = new clsClient();

        private clsClient() { }
        private Boolean _Servicing = false;
        private clsVehicle _Vehicle = new clsVehicle();
        private clsActivity _Activity;

        public bool Servicing { get => _Servicing; set => _Servicing = value; }
        public clsVehicle Vehicle { get => _Vehicle; set => _Vehicle = value; }
        public clsActivity Activity { get => _Activity; set => _Activity = value; }
    }
}
