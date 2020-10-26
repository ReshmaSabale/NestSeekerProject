using NestSeeker.Data.Model;
using NestSeeker.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace NestSeeker.Service.Interface
{
    public interface ITransactionTypeService
    {
        IEnumerable<TransactionType> GetAlltransactiontypes();

        TransactionType GetById(int id);
        TransactionType AddTransactionType(TransactionType transactionType);

    }
}
