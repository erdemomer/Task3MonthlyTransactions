using System;
using System.Collections.Generic;
using System.Text;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetByCategoryId(int CategoryId);
        bool Add(Category category);
        bool Update(Category category);
        bool Delete(Category category);
    }
}
