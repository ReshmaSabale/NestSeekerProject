using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
   public interface IDirectionService
    {
        IEnumerable<Direction> GetAllUser();
        Direction GetById(int id);
        Direction AddDirection(Direction direction);
    }
}
