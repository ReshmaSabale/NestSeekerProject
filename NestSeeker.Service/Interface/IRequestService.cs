using NestSeeker.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
   public interface IRequestService
    {
        IEnumerable<Requests> GetAllRequests();
        Requests GetById(int id);
        Requests AddRequest(Requests requests);
    }
}
