using StudentManagementProject.Data.Clients.Database;
using StudentManagementProject.Domain.Entities;
using StudentManagementProject.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementProject.Data.Managers
{
    class RegisterRepositoryImp : UserRepository
    {
        public User process(User user)
        {
            return LoginRegisterDatabaseCall.getInstance().addUser(user);
        }
    }
}
