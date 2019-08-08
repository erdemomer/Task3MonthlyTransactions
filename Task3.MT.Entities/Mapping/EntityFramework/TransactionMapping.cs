using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Task3.MT.Entities.Concrete;

namespace Task3.MT.Entities.Mapping.EntityFramework
{
    public class TransactionMapping{
        public TransactionMapping(EntityTypeBuilder<Transaction> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.HasOne(p => p.Category).WithMany(c => c.Transactions).HasForeignKey(p => p.CategoryId);
        }
    }
    
}
