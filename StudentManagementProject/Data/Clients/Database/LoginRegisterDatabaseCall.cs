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

        public User addUser(User newUser)
        {
            if (database != null)
            {
                try
                {
                    var result = database.Insert(newUser);
                    if (result == 0)
                    {
                        return null;
                    }
                    else
                    {
                        return newUser;
                    }
                }
                catch (SQLiteException sqlException)
                {
                    return null;
                }
            }
            return null;
        }

        public User checkUser(User validatedUser)
        {
            if (database != null)
            {
                var value = database.Query<User>("select * from User where Email = ?", validatedUser.Email);

                foreach (User user in value)
                {
                    if (user.Password == validatedUser.Password)
                    {
                        return user;
                    }
                }
            }
            return null;
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
