using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace Service_Client
{
    static class clsDbConnection
    {
        //This code was developed by Dean.Stanleyhunt@live.nmit.ac.nz @ 22/06/2018. As an Assessment Project for SDV701 at NMIT NZ.
        //This software is for educational purposes to display knowledge learned about OOP, Refactoring and Design Patterns .
        private static DbProviderFactory ProviderFactory =
            DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["RentalDatabase"].ProviderName);
        private static string ConnectionStr = 
            ConfigurationManager.ConnectionStrings["RentalDatabase"].ConnectionString;

        public static DataTable GetDataTable(string prSQL)
        {
            using (DataTable lcDataTable = new DataTable("TheTable"))
            using (DbConnection lcDataConnection = ProviderFactory.CreateConnection())
            using (DbCommand lcCommand = lcDataConnection.CreateCommand())
            {
                lcDataConnection.ConnectionString = ConnectionStr;
                lcDataConnection.Open();
                lcCommand.CommandText = prSQL;
                using (DbDataReader lcDataReader = lcCommand.ExecuteReader(CommandBehavior.CloseConnection))
                    lcDataTable.Load(lcDataReader);
                return lcDataTable;
            }
        }

        public static int Execute(string prSQL)
        {
            using (DbConnection lcDataConnection = ProviderFactory.CreateConnection())
            using (DbCommand lcCommand = lcDataConnection.CreateCommand())
            {
                lcDataConnection.ConnectionString = ConnectionStr;
                lcDataConnection.Open();
                lcCommand.CommandText = prSQL;
                return lcCommand.ExecuteNonQuery();
            }
        }

    }
}
