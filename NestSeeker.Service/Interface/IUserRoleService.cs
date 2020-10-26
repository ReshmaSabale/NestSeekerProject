using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
    public interface IUserRoleService
    {
        IEnumerable<UserRole> GetAllUserRole();

        UserRole GetById(int id);
    }
}
