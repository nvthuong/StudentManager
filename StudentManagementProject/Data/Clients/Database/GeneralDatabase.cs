using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace StudentManagementProject.Data.Clients.Database
{
    public class GeneralDatabase
    {
        protected String databasePath = "dtbase";
        protected SQLiteConnection database = null;

        protected void createDatabase()
        {
            if (database == null)
            {
                database = new SQLiteConnection("dtbase");
            }
        }

    }
}
