using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
   public interface IStatusService
    {
        IEnumerable<Status> GetAllStatus();
        
        Status GetById(int id);
        Status AddStatus(Status status);
       
    }
}
