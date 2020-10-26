using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
    public interface IRoleService
    {
        IEnumerable<Role> GetAllRoles();

        Role GetById(int id);
        Role AddRole(Role role);
    }
}
