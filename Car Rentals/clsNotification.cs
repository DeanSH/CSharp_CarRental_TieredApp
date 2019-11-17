namespace Car_Rentals
{
    //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
    class clsNotification
    {
        private string _Description;
        private int _Id;
        private string _Rego;

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

        public override string ToString()
        {
            return Rego + "\t" + Description;
        }
    }
}
