using System;
using System.Collections.Generic;
using System.Text;
using Task3.MT.Business.Abstract;
using Task3.MT.DataAccess.Abstract;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;       
        }
        public bool Add(Category category) => _categoryDal.Add(category);

        public bool Delete(Category category) => _categoryDal.Delete(category);

        public List<Category> GetAll() => _categoryDal.GetList();

        public Category GetByCategoryId(int CategoryId) => _categoryDal.Get(x=>x.Id== CategoryId);

        public bool Update(Category category) => _categoryDal.Update(category);

    }
}
