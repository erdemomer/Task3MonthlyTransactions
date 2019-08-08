using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.Entities.Mapping.EntityFramework
{
    public class CategoryMapping
    {
        public CategoryMapping(EntityTypeBuilder<Category> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            
        }


    }
}
