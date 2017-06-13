using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using StudentManagementProject.Domain.Entities;


namespace StudentManagementProject.Data.Clients.Database
{
    public class LoginRegisterDatabaseCall : GeneralDatabase
    {
        private static LoginRegisterDatabaseCall instance = null;

        private LoginRegisterDatabaseCall() { }

        public static LoginRegisterDatabaseCall getInstance()
        {
            if (instance == null)
            {
                instance = new LoginRegisterDatabaseCall();
                instance.createDatabase();
            }
            return instance;
        }

        private void createDatabase()
        {
            // Create database connection using base method.
            base.createDatabase();
            database.CreateTable<User>();
        }

        public Boolean addUser(User newUser)
        {
            if (database != null)
            {
                try
                {
                    var result = database.Insert(newUser);
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

        public Boolean checkUser(User validatedUser)
        {
            if (database != null)
            {
                var value = database.Query<User>("select Password from User where Email = ?", validatedUser.Email);

                foreach (User user in value)
                {
                    if (user.Password == validatedUser.Password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Boolean deleteAllUser()
        {
            if (database != null)
            {
                try
                {
                    var result = database.DeleteAll<User>();
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
