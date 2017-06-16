using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using Windows.Storage;

namespace StudentManagementProject.Data.Clients.Database
{
    public class GeneralDatabase
    {

        public static string DB_PATH = Path.Combine(Path.Combine(ApplicationData.Current.LocalFolder.Path, "manager_student.sqlite"));
        public SQLiteConnection database;

        protected void createDatabase()
        {
            if (database == null)
            {
                database = new SQLiteConnection(DB_PATH);
            }
        }

    }
}
