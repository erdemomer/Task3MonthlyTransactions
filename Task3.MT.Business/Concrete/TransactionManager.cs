using System;
using System.Collections.Generic;
using Task3.MT.Business.Abstract;
using Task3.MT.DataAccess.Abstract;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.Business.Concrete
{
    public class TransactionManager : ITransactionService
    {
        private ITransactionDal _transactionDal;
        public TransactionManager(ITransactionDal transactionDal)
        {
            _transactionDal = transactionDal;
        }
        public bool Add(Transaction transaction) => _transactionDal.Add(transaction);

        public bool Delete(Transaction transaction) => _transactionDal.Delete(transaction);

        public List<Transaction> GetAll() => _transactionDal.GetList();

        public Transaction GetByTransactionId(int transactionId) => _transactionDal.Get(x => x.Id == transactionId);

        public List<Transaction> GetListByCategoryId(int CategoryId) => _transactionDal.GetList(x => x.CategoryId == CategoryId);

        public bool Update(Transaction transaction) => _transactionDal.Update(transaction);
    }
}
