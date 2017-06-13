using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementProject.Domain.Entities;
using SQLite;

namespace StudentManagementProject.Data.Clients.Database
{
    public class ClassDatabaseCall : GeneralDatabase
    {
        private static ClassDatabaseCall instance = null;

        private ClassDatabaseCall() { }

        public static ClassDatabaseCall getInstance()
        {
            if (instance == null)
            {
                instance = new ClassDatabaseCall();
                instance.createDatabase();
            }
            return instance;
        }

        private void createDatabase()
        {
            // Create database connection using base method.
            base.createDatabase();
            database.CreateTable<Class>();
        }

        public Boolean addClass(Class newClass)
        {
            if (database != null)
            {
                try
                {
                    var result = database.Insert(newClass);
                    if (result == 0)
                    {
                        return false;
                    }
                }
                catch (SQLiteException sqlException)
                {
                    return false;
                }
            }
            return true;
        }

        public List<Class> getClassList()
        {
            if (database != null)
            {
                List<Class> lstOfClass = new List<Class>();

                var value = database.Query<Class>("select * from Class");

                foreach (Class curClass in value)
                {
                    lstOfClass.Add(curClass);
                }

                return lstOfClass;
            }
            return null;
        }

        public Boolean deleteAllClass()
        {
            if (database != null)
            {
                try
                {
                    var result = database.DeleteAll<Class>();
                    if (result == 0)
                    {
                        return false;
                    }
                }
                catch (SQLiteException sqlException)
                {
                    return false;
                }
                catch (NotSupportedException notSupportEx)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
