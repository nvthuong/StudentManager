using StudentManagementProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Domain.Repositories
{
    public interface StudentRepository
    {
        Task<List<Student>> performSearch();
        Task<List<Student>> performSearch(String name);
    }
}
