using System;
using System.Collections.Generic;
using System.Text;
using Task3.Core.Entities;

namespace Task3.MT.Entities.Concrete
{
    public class Category: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}
