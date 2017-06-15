﻿using StudentManagementProject.Data.Clients.Database;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Data.Managers
{
    public abstract class StudentSearchRepoImp : StudentRepository
    {
        public Task<List<Student>> performSearch()
        {
            return Task.Run(() =>
            {
                return StudentDatabaseCall.getInstance().getStudentList();
            });
        }

        public abstract Task<List<Student>> performSearch(String name);
    }
}
