using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementProject.Domain.Entities;
using SQLite;

namespace StudentManagementProject.Data.Clients.Database
{
    public class StudentDatabaseCall : GeneralDatabase
    {
        private static StudentDatabaseCall instance = null;
        private int start = 0;
        private int range = 10;

        public int Start
        {
            get
            {
                return start;
            }
            set
            {
                start = value;
            }
        }

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        private StudentDatabaseCall() { }

        public static StudentDatabaseCall getInstance()
        {
            if (instance == null)
            {
                instance = new StudentDatabaseCall();
                instance.createDatabase();
            }
            return instance;
        }

        private void createDatabase()
        {
            // Create database connection using base method.
            base.createDatabase();
            database.CreateTable<Student>();
        }

        public Boolean addStudent(Student student)
        {
            if (database != null)
            {
                try
                {
                    var result = database.Insert(student);
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

        public Boolean addAllStudent(List<Student> student)
        {
            if (database != null)
            {
                try
                {
                    var result = database.InsertAll(student);
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

        public Boolean modifyStudent(Student student)
        {
            if (database != null)
            {
                try
                {
                    var result = database.Update(student);
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

        public Boolean deleteStudent(Student student)
        {
            if (database != null)
            {
                try
                {
                    var result = database.Delete(student);
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

        public Boolean deleteAllStudent()
        {
            if (database != null)
            {
                try
                {
                    var result = database.DeleteAll<Student>();
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

        public List<Student> getStudentList()
        {
            if (database != null)
            {
                List<Student> lstOfStudent = new List<Student>();

                var value = database.Query<Student>("select * from Student limit ?, ?", start, range);

                foreach (Student curStudent in value)
                {
                    lstOfStudent.Add(curStudent);
                }

                return lstOfStudent;
            }
            return null;
        }

        public List<Student> getStudentListByName(String name)
        {
            if (database != null)
            {
                List<Student> lstOfStudent = new List<Student>();

                var value = database.Query<Student>("select * from Student where Name like '%" + name + "%'");

                foreach (Student curStudent in value)
                {
                    lstOfStudent.Add(curStudent);
                }

                return lstOfStudent;
            }
            return null;
        }

        public List<Student> getStudentListByClassName(String className)
        {
            if (database != null)
            {
                List<Student> lstOfStudent = new List<Student>();

                var value = database.Query<Student>("select * from Student where ClassName = ?", className);

                foreach (Student curStudent in value)
                {
                    lstOfStudent.Add(curStudent);
                }

                return lstOfStudent;
            }
            return null;
        }
    }
}
