using System;
using System.Collections.Generic;
using System.Text;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.Business.Abstract
{
    public interface ITransactionService
    {
        List<Transaction> GetAll();
        List<Transaction> GetListByCategoryId(int CategoryId);
        Transaction GetByTransactionId(int transactionId);
        bool Add(Transaction transaction);
        bool Update(Transaction transaction);
        bool Delete(Transaction transaction);
    }
}
