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
    public class StudentSearchByNameRepoImp : StudentSearchRepoImp
    {
        public override Task<List<Student>> performSearch(String name)
        {
            return Task.Run(() =>
            {
                return StudentDatabaseCall.getInstance().getStudentListByName(name);
            });
        }
    }
}
