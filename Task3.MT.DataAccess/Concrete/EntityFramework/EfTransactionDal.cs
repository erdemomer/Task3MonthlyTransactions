using System;
using System.Collections.Generic;
using System.Text;
using Task3.Core.DataAccess.EntityFramework;
using Task3.MT.DataAccess.Abstract;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.DataAccess.Concrete.EntityFramework
{
    public class EfTransactionDal: EfEntityRepositoryBase<Transaction,MTContext>,ITransactionDal
    {
    }
}
