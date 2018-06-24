using System;

namespace Car_Rentals
{
    //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
    //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
    sealed class clsErrorHandler
    {
        public static readonly clsErrorHandler Instance = new clsErrorHandler();

        private clsErrorHandler() { }

        public int ErrorCheckTextLength(string theText,int maxlength)
        {
            if (theText.Length >= maxlength)
                return 1;
            return 0;
        }

        public int ErrorCheckTextYear(string theText, int maxlength)
        {
            try {
                if (theText == "")
                    return 0;
                if (theText.Length > maxlength)
                    return 1;
                int theYear = Convert.ToInt32(theText);
                if (theYear > DateTime.Now.Year)
                    return 2;
                if (theText.Contains(" ") == true)
                    return 3;
                return 0;
            }
            catch (Exception)
            {
                return 3;
            }
        }

        public int ErrorCheckTextCurrency(string theText)
        {
            try
            {
                if (theText == "")
                    return 0;
                decimal theYear = Convert.ToDecimal(theText);
                if (theText.Contains(" ") == true)
                    return 3;
                return 0;
            }
            catch (Exception)
            {
                return 3;
            }
        }

        public string ErrorMessage(int ErrNum)
        {
            switch (ErrNum)
            {
                case 1:
                    return "Error: Maximum Input Length Reached!";
                case 2:
                    return "Error: Year cant exceed " + DateTime.Today.Year;
                case 3:
                    return "Error: Invalid Textbox Input!";
                case 4:
                    return "Error: Minimum Year Is 1950!";
                case 5:
                    return "Error: All Feilds Are Compulsory!";
                case 6:
                    return "Error: Rego already exist in System!";
                case 7:
                    return "Error: Sorry No Match Found For That Rego!";
                case 8:
                    return "Error: Return Date cant be earlier than Start Date!";
                default:
                    return "Unknown Error!";
            }
        }

    }
}
