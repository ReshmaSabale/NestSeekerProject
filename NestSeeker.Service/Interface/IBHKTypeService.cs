using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
    public interface IBHKTypeService
    {
        IEnumerable<BHKType> GetAllBHKTypes();
        BHKType GetById(int id);
        BHKType AddBHKType(BHKType bhkType);
    }
}
