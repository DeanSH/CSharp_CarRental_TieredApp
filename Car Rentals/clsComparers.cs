using System.Collections.Generic;

namespace Car_Rentals
{
    sealed class clsDateComparer : IComparer<clsActivity>
    {
        //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
        //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
        public static readonly clsDateComparer Instance = new clsDateComparer();

        private clsDateComparer() { }

        public int Compare(clsActivity prActivityX, clsActivity prActivityY)
        {
            int lcResult = prActivityX.Date.CompareTo(prActivityY.Date);
            if (lcResult < 0 | lcResult > 0)
            {
                return lcResult;
            }
            else
            {
                return prActivityX.Name.CompareTo(prActivityY.Name);
            }
        }
    }

    sealed class clsNameComparer : IComparer<clsActivity>
    {
        public static readonly clsNameComparer Instance = new clsNameComparer();

        private clsNameComparer() { }

        public int Compare(clsActivity prActivityX, clsActivity prActivityY)
        {
            int lcResult = prActivityX.Name.CompareTo(prActivityY.Name);
            if (lcResult < 0 | lcResult > 0)
            {
                return lcResult;
            }
            else
            {
                return prActivityX.Date.CompareTo(prActivityY.Date);
            }
        }
    }
}
