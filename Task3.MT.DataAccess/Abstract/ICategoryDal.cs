using System;
using System.Collections.Generic;
using System.Text;
using Task3.Core.DataAccess;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
        //Custom Operations
    }
}
